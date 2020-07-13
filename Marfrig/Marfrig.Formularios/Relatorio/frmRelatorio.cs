using Marfrig.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marfrig.Formularios.Relatorio
{
    public partial class frmRelatorio : Form
    {
        List<CompraGadoItem> _lstCompraGadoItem = new List<CompraGadoItem>();

        public frmRelatorio(List<CompraGadoItem> lstCompraGadoItem)
        {
            InitializeComponent();
            _lstCompraGadoItem = lstCompraGadoItem;
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            marfrigDataSetBindingSource.DataSource = _lstCompraGadoItem;
            this.reportViewer1.RefreshReport();
        }
    }
}
