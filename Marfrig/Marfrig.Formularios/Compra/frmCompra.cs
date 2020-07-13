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
            if (dgvConsulta.CurrentRow.Cells[0].Value != null)
            {
                int id = (int)dgvConsulta.CurrentRow.Cells[0].Value;
                GetAllCompraGadoItemById(id);
            }
            
        }

        private void btnIncluirProduto_Click(object sender, EventArgs e)
        {
            frmCadastro frmCadastro = new frmCadastro();
            frmCadastro.Show();
        }

        private void btnAtualizaProduto_Click(object sender, EventArgs e)
        {
            

            if (dgvConsulta.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Pecuarista não possui itens");
            }
            else
            {
                LinhaSelecionada();
            }
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

        public async void GetAllCompraGadoItem()
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

        public async void GetAllCompraGadoItemById(int compraGadoItemId)
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

        public async void GetAllCompraGadoItemByPecuaristaId(int pecuaristaId)
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

        public async void GetAllPecuaristas()
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
                        cmbPecuarista.Update();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o produto : " + response.StatusCode);
                    }
                }
            }
        }



        


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
                //MessageBox.Show("Ops .. problema ao carregar combo");
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
            string value3 = "";
            int value4 = 0;

            foreach (DataGridViewRow row in dgvConsulta.SelectedRows)
            {
                value1 = row.Cells[0].Value.ToString();
                value2 = row.Cells[1].Value.ToString();
                value3 = row.Cells[2].Value.ToString();
                value4 = (int)cmbPecuarista.SelectedValue;
            }

            frmAlterarCompra frmAlterarCompra = new frmAlterarCompra(value1, value2, value3, value4);
            frmAlterarCompra.Show();
        }
        #endregion
    }
}
