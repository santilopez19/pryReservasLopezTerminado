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
    public partial class frmAdministrarFunciones : Form
    {

        private frmQuaken frmQuaken;
        public frmAdministrarFunciones(frmQuaken quakenForm)
        {
            InitializeComponent();
            frmQuaken = quakenForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreFuncion.Text) ||
            string.IsNullOrWhiteSpace(txtHoraFuncion.Text) ||
            cmbTeatroFuncion.SelectedIndex == -1 ||
            !decimal.TryParse(txtCosto.Text, out decimal costo))
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = txtNombreFuncion.Text;
            DateTime fecha = dtFuncion.Value;
            string hora = txtHoraFuncion.Text;
            string teatro = cmbTeatroFuncion.SelectedItem.ToString();

            clsFunciones nuevaFuncion = new clsFunciones(nombre, fecha, hora, teatro, costo);
            frmQuaken.AgregarFuncion(nuevaFuncion);

            MessageBox.Show("Función agregada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombreFuncion.Clear();
            txtHoraFuncion.Clear();
            cmbTeatroFuncion.SelectedIndex = -1;
            txtCosto.Clear();
        }
    }
}
