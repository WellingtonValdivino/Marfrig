using System;
using System.Windows.Forms;
using Marfrig.DAL;

namespace Marfrig.Formularios.Compra
{
    public partial class frmCompra : Form
    {
        public frmCompra()
        {
            InitializeComponent();
        }

        #region "                     Eventos"
        private void btnObterCompraGadoItem_Click(object sender, EventArgs e)
        {
            CompraGadoItemDAL compraGadoItemDAL = new CompraGadoItemDAL();
            string url = "localhost:5000/api/Marfrig";
            this.dgvConsulta.DataSource = compraGadoItemDAL.GetAllCompraGadoItem(url);
        }

        //private void btnProdutosPorId_Click(object sender, EventArgs e)
        //{
        //    InputBox();
        //    if (codigoProduto != -1)
        //    {
        //        GetProdutoById(codigoProduto);
        //    }
        //}

        //private void btnIncluirProduto_Click(object sender, EventArgs e)
        //{
        //    AddProduto();
        //}

        //private void btnAtualizaProduto_Click(object sender, EventArgs e)
        //{
        //    InputBox();
        //    if (codigoProduto != -1)
        //    {
        //        UpdateProduto(codigoProduto);
        //    }
        //}

        //private void btnDeletarProduto_Click(object sender, EventArgs e)
        //{
        //    InputBox();
        //    if (codigoProduto != -1)
        //    {
        //        DeleteProduto(codigoProduto);
        //    }
        //}

        #endregion
    }
}
