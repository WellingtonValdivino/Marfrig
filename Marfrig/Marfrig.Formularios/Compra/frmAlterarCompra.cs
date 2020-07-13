using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marfrig.Formularios.Compra
{
    public partial class frmAlterarCompra : Form
    {
        public frmAlterarCompra(string v1, string v2)
        {
            InitializeComponent();
            
            textBox1.Text = v1;
            textBox2.Text = v2;
        }

        
    }
}
