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
    }
}
