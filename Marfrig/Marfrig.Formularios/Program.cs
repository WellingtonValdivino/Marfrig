using Marfrig.Formularios.Compra;
using Marfrig.Formularios.Relatorio;
using System;
using System.Windows.Forms;

namespace Marfrig.Formularios
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmCompra());
        }
    }
}
