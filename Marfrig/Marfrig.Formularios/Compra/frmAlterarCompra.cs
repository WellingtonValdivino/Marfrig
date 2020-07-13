using Marfrig.Domain;
using System;
using System.Configuration;
using System.Net.Http;
using System.Windows.Forms;

namespace Marfrig.Formularios.Compra
{
    public partial class frmAlterarCompra : Form
    {
        #region "                Propriedades"
        string URL = "";
        int idPecuarista;
        #endregion

        #region "                  Construtor"
        public frmAlterarCompra(string v1, string v2, string v3, int v4)
        {
            InitializeComponent();

            lblCompraGadoID.Text = v1;
            txtPecuarista.Text = v2;
            dtpDataEntrega.Text = v3;

            idPecuarista = v4;
        }
        #endregion

        #region "                     Eventos"
        private void btnCofirmar_Click(object sender, EventArgs e)
        {
            Update();
        }
        #endregion

        private new async void Update()
        {
            URL = ConfigurationManager.AppSettings["Marfrig"];
            URL += "/CompraGado";
            
            CompraGado compraGado = new CompraGado();
            compraGado.Pecuarista = new Pecuarista();

            compraGado.Id = int.Parse(lblCompraGadoID.Text);
            compraGado.DataEntrega = dtpDataEntrega.Value;
            compraGado.Pecuarista.Id = idPecuarista;
            compraGado.Pecuarista.Nome = txtPecuarista.Text;

            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URL + "/" + compraGado.Id, compraGado);
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Produto atualizado");
                    
                    frmCompra frm = new frmCompra();
                    frm.GetAllPecuaristas();
                    
                }
                else
                {
                    MessageBox.Show("Falha ao atualizar o produto : " + responseMessage.StatusCode);
                }
            }
        }
    }
}
