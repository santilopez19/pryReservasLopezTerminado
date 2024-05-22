using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryReservasLopezTerminado
{
    public partial class frmTeatros : Form
    {
        public frmTeatros()
        {
            InitializeComponent();
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuaken frmQuaken = new frmQuaken();
            frmQuaken.ShowDialog();
        }

        private void reservasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmOnas frmOnas = new frmOnas();
            frmOnas.ShowDialog();
        }

        private void tobasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void reservasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmTobas frmTobas = new frmTobas();
            frmTobas.ShowDialog();
        }

        private void administrarFuncionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Suponiendo que quakenForm es una instancia de frmQuaken
            frmQuaken quakenForm = new frmQuaken();

            frmAdministrarFunciones frmAdministrarFunciones = new frmAdministrarFunciones(quakenForm);
            frmAdministrarFunciones.ShowDialog();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void funcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
