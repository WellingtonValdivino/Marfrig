using Marfrig.Domain;
using Marfrig.Formularios.Cadastro;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Windows.Forms;

namespace Marfrig.Formularios.Compra
{
    public partial class frmCompra : Form
    {
        #region "                Propriedades                    "
        string URL = "";
        int codigoProduto = 1;
        #endregion

        #region "                  Construtor                    "
        public frmCompra()
        {
            InitializeComponent();
            cmbPecuarista.SelectedIndexChanged -= cmbPecuarista_SelectedIndexChanged;
            GetAllPecuaristas();
            cmbPecuarista.SelectedIndexChanged += cmbPecuarista_SelectedIndexChanged;
        }
        #endregion

        #region "                     Eventos                    "        

        private void cmbPecuarista_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtId.Text = "";
            dgvConsulta.Rows.Clear();
            dgvConsulta.Refresh();

            
            Clicar_btnObterCompraGadoItem();
        }

        private void dgvConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvConsulta.CurrentRow.Cells[0].Value;
            GetAllCompraGadoItemById(id);
        }

        private void btnIncluirProduto_Click(object sender, EventArgs e)
        {
            frmCadastro frmCadastro = new frmCadastro();
            frmCadastro.Show();
        }

        private void btnAtualizaProduto_Click(object sender, EventArgs e)
        {
            //InputBox();
            //if (codigoProduto != -1)
            //{
            //    UpdateProduto(codigoProduto);
            //}

            LinhaSelecionada();
        }

        private void btnDeletarProduto_Click(object sender, EventArgs e)
        {
            InputDeletar();
            if (codigoProduto != -1)
            {
                DeleteCompraGadoItem(codigoProduto);
            }
        }        

        #endregion

        #region  "                  Chamadas HTTP                 "
        
        private async void GetAllCompraGadoItem()
        {
            URL = ConfigurationManager.AppSettings["Marfrig"];
            URL += "/CompraGadoItem";

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URL))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        List<CompraGadoItem> lstCompraGadoItem = JsonConvert.DeserializeObject<CompraGadoItem[]>(ProdutoJsonString).ToList();

                        //Preenchendo grid 
                        for (int i = 0; i < lstCompraGadoItem.Count; i++)
                        {
                            DataGridViewRow row = (DataGridViewRow)dgvConsulta.Rows[0].Clone();
                            row.Cells[0].Value = lstCompraGadoItem[i].Id;
                            row.Cells[1].Value = lstCompraGadoItem[i].CompraGado.Pecuarista.Nome;
                            row.Cells[2].Value = lstCompraGadoItem[i].CompraGado.DataEntrega.ToString("dd/MM/yyyy");
                            row.Cells[3].Value = (lstCompraGadoItem[i].Animal.Preco * lstCompraGadoItem[i].Quantidade).ToString("C");

                            dgvConsulta.Rows.Add(row);
                        }                        
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o produto : " + response.StatusCode);
                    }
                }
            }
        }

        private async void GetAllCompraGadoItemById(int compraGadoItemId)
        {
            URL = ConfigurationManager.AppSettings["Marfrig"];
            URL += "/CompraGadoItem";

            using (var client = new HttpClient())
            {
                BindingSource bsDados = new BindingSource();
                URL += "/" + compraGadoItemId.ToString();

                HttpResponseMessage response = await client.GetAsync(URL);
                if (response.IsSuccessStatusCode)
                {
                    var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                    CompraGadoItem compraGadoItem = JsonConvert.DeserializeObject<CompraGadoItem>(ProdutoJsonString);                    

                    txtId.Text = compraGadoItem.CompraGado.Id.ToString();
                }
                else
                {
                    MessageBox.Show("Falha ao obter o produto : " + response.StatusCode);
                }
            }
        }

        private async void GetAllCompraGadoItemByPecuaristaId(int pecuaristaId)
        {
            URL = ConfigurationManager.AppSettings["Marfrig"];
            URL += "/CompraGadoItem/ByPecuarista/" + pecuaristaId.ToString();

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URL))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        List<CompraGadoItem> lstCompraGadoItem = JsonConvert.DeserializeObject<CompraGadoItem[]>(ProdutoJsonString).ToList();

                        //Preenchendo grid 
                        for (int i = 0; i < lstCompraGadoItem.Count; i++)
                        {
                            DataGridViewRow row = (DataGridViewRow)dgvConsulta.Rows[0].Clone();
                            row.Cells[0].Value = lstCompraGadoItem[i].Id;
                            row.Cells[1].Value = lstCompraGadoItem[i].CompraGado.Pecuarista.Nome;
                            row.Cells[2].Value = lstCompraGadoItem[i].CompraGado.DataEntrega.ToString("dd/MM/yyyy");
                            row.Cells[3].Value = (lstCompraGadoItem[i].Animal.Preco * lstCompraGadoItem[i].Quantidade).ToString("C");

                            dgvConsulta.Rows.Add(row);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o produto : " + response.StatusCode);
                    }
                }
            }
        }

        private async void GetAllPecuaristas()
        {
            URL = ConfigurationManager.AppSettings["Marfrig"];
            URL += "/Pecuarista";

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URL))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        List<Pecuarista> lstPecuarista = JsonConvert.DeserializeObject<Pecuarista[]>(ProdutoJsonString).ToList();

                        lstPecuarista.Add(new Pecuarista { Nome = "Todos", Id = 0 });

                        cmbPecuarista.DataSource = lstPecuarista;
                        cmbPecuarista.DisplayMember = "Nome";
                        cmbPecuarista.ValueMember = "Id";
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o produto : " + response.StatusCode);
                    }
                }
            }
        }



        //private async void AddProduto()
        //{
        //    URL = txtURL.Text;
        //    Produto prod = new Produto();
        //    //prod.Id = codProduto;
        //    prod.Nome = "NoteBook Lenovo";
        //    prod.Categoria = "Notebooks";
        //    prod.Preco = 1200.00M;

        //    using (var client = new HttpClient())
        //    {
        //        var serializedProduto = JsonConvert.SerializeObject(prod);
        //        var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
        //        var result = await client.PostAsync(URL, content);
        //    }
        //    GetAllProdutos();
        //}

        //private async void UpdateProduto(int codProduto)
        //{
        //    URL = ConfigurationManager.AppSettings["Marfrig"];
        //    URL += "/CompraGadoItem";           

        //    

        //    using (var client = new HttpClient())
        //    {
        //        HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URL + "/" + prod.Id, prod);
        //        if (responseMessage.IsSuccessStatusCode)
        //        {
        //            MessageBox.Show("Produto atualizado");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Falha ao atualizar o produto : " + responseMessage.StatusCode);
        //        }
        //    }
        //    GetAllProdutos();

        //URL = ConfigurationManager.AppSettings["Marfrig"];
        //URL += "/CompraGadoItem";

        //using (var client = new HttpClient())
        //{
        //    BindingSource bsDados = new BindingSource();
        //    URL += "/" + compraGadoItemId.ToString();

        //    HttpResponseMessage response = await client.GetAsync(URL);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
        //        CompraGadoItem compraGadoItem = JsonConvert.DeserializeObject<CompraGadoItem>(ProdutoJsonString);

        //        DataGridViewRow row = (DataGridViewRow)dgvConsulta.Rows[0].Clone();
        //        row.Cells[0].Value = compraGadoItem.Id;
        //        row.Cells[1].Value = compraGadoItem.CompraGado.Pecuarista.Nome;
        //        row.Cells[2].Value = compraGadoItem.CompraGado.DataEntrega.ToString("dd/MM/yyyy");
        //        row.Cells[3].Value = (compraGadoItem.Animal.Preco * compraGadoItem.Quantidade).ToString("C");

        //        dgvConsulta.Rows.Add(row);
        //        txtId.Text = compraGadoItem.CompraGado.Id.ToString();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Falha ao obter o produto : " + response.StatusCode);
        //    }
        //}
        //}


        private async void DeleteCompraGadoItem(int compraGadoItemId)
        {
            URL = ConfigurationManager.AppSettings["Marfrig"];
            URL += "/CompraGadoItem";

            using (var client = new HttpClient())
            {
                BindingSource bsDados = new BindingSource();
                client.BaseAddress = new Uri(URL);
                HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", URL, compraGadoItemId));
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Produto excluído com sucesso");
                }
                else
                {
                    MessageBox.Show("Falha ao excluir o produto  : " + responseMessage.StatusCode);
                }
            }

            txtId.Text = "";
            dgvConsulta.Rows.Clear();
            dgvConsulta.Refresh();
            GetAllCompraGadoItem();
        }
        #endregion

        #region "                     Metodos                    "
        public void Clicar_btnObterCompraGadoItem()
        {
            try
            {
                if ((int)cmbPecuarista.SelectedValue == 0)
                {
                    GetAllCompraGadoItem();
                }
                else
                {
                    GetAllCompraGadoItemByPecuaristaId((int)cmbPecuarista.SelectedValue);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ops .. problema ao carregar combo");
            }            
        }

        private void InputDeletar()
        {
            /* usando a função VB.Net para exibir um prompt para o usuário informar a senha */
            string Prompt = "Informe o Nº do item da tabela abaixo para exclusão";
            string Titulo = "www.marfrig.com";
            string Resultado = Microsoft.VisualBasic.Interaction.InputBox(Prompt, Titulo, "", 600, 350);
            /* verifica se o resultado é uma string vazia o que indica que foi cancelado. */
            if (Resultado != "")
            {
                codigoProduto = Convert.ToInt32(Resultado);
            }
            else
            {
                codigoProduto = -1;
            }
        }
        

        public void LinhaSelecionada()
        {
            string value1 = "";
            string value2 = "";
            
            foreach (DataGridViewRow row in dgvConsulta.SelectedRows)
            {
                value1 = row.Cells[1].Value.ToString();
                value2 = row.Cells[2].Value.ToString();               
            }

            frmAlterarCompra frmAlterarCompra = new frmAlterarCompra(value1, value2);
            frmAlterarCompra.Show();
            //InputAtualizar(value1, value2);
        }
        #endregion

        
    }
}
