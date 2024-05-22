using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryReservasLopezTerminado
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Crear una instancia de frmTeatros si es necesario
            frmTeatros teatrosForm = new frmTeatros(); // Asegúrate de importar el espacio de nombres adecuado

            Application.Run(teatrosForm);
        }
    }
}
