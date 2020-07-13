using Marfrig.Domain;
using Marfrig.Formularios.Cadastro;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace Marfrig.Formularios.Cadastro
{
    public partial class frmCadastro : Form
    {
        #region "                Propriedades                    "
        string URL = "";
        int codigoProduto = 1;
        List<Animal> lstAnimais = new List<Animal>();
        #endregion


        public frmCadastro()
        {
            InitializeComponent();
            GetAllPecuaristas();
            cmbAnimal.SelectedIndexChanged -= cmbAnimal_SelectedIndexChanged;
            GetAllAnimais();
            cmbAnimal.SelectedIndexChanged += cmbAnimal_SelectedIndexChanged;
        }


        private void cmbAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if ((int)cmbAnimal.SelectedValue != 0)
                {
                    int id = (int)cmbAnimal.SelectedValue;
                    txtPreco.Text = lstAnimais.Where(p => p.Id == id).FirstOrDefault().Preco.ToString();
                }
            }
            catch (Exception)
            {

            }
        }

        private void qtdGado_ValueChanged(object sender, EventArgs e)
        {
            int id = (int)cmbAnimal.SelectedValue;
            int quantidade = Convert.ToInt32(Math.Round(qtdGado.Value, 0));
            double total = (lstAnimais.Where(p => p.Id == id).FirstOrDefault().Preco * quantidade);
            txtTotal.Text = total.ToString("C");
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            PostCompraGadoItem();
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

        public async void GetAllAnimais()
        {
            URL = ConfigurationManager.AppSettings["Marfrig"];
            URL += "/Animal";

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URL))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        lstAnimais = JsonConvert.DeserializeObject<Animal[]>(ProdutoJsonString).ToList();

                        cmbAnimal.DataSource = lstAnimais;
                        cmbAnimal.DisplayMember = "Descricao";
                        cmbAnimal.ValueMember = "Id";
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o produto : " + response.StatusCode);
                    }
                }
            }
        }

        private async void PostCompraGadoItem()
        {
            URL = ConfigurationManager.AppSettings["Marfrig"];
            URL += "/CompraGadoItem";

            CompraGadoItem compraGadoItem = new CompraGadoItem();
            compraGadoItem.CompraGado = new CompraGado();

            compraGadoItem.Quantidade = Convert.ToInt32(Math.Round(qtdGado.Value, 0));
            compraGadoItem.AnimalId = (int)cmbAnimal.SelectedValue;
            compraGadoItem.CompraGado.DataEntrega = dtpDataEntrega.Value;
            compraGadoItem.CompraGado.PecuaristaId = (int)cmbPecuarista.SelectedValue;

            using (var client = new HttpClient())
            {
                var serializedProduto = JsonConvert.SerializeObject(compraGadoItem);
                var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URL, content);

                MessageBox.Show("Pedido de compra efetuado");
            }
        }

        
    }
}
