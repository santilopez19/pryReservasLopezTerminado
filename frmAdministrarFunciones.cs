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
        private List<clsFunciones> funciones;
        public frmAdministrarFunciones()
        {
            InitializeComponent();
            funciones = new List<clsFunciones>();

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

            clsFunciones nuevaFuncion = new clsFunciones(
                txtNombreFuncion.Text,
                dtFuncion.Value,
                txtHoraFuncion.Text,
                cmbTeatroFuncion.SelectedItem.ToString(),
                costo
            );

            funciones.Add(nuevaFuncion);

            // Encontrar el formulario del teatro correspondiente y agregar la función
            Form teatroForm = null;
            if (nuevaFuncion.Teatro == "Quenaken")
            {
                teatroForm = Application.OpenForms.OfType<frmQuaken>().FirstOrDefault();
            }
            else if (nuevaFuncion.Teatro == "Onas")
            {
                teatroForm = Application.OpenForms.OfType<frmOnas>().FirstOrDefault();
            }
            else if (nuevaFuncion.Teatro == "Tobas")
            {
                teatroForm = Application.OpenForms.OfType<frmTobas>().FirstOrDefault();
            }

            if (teatroForm != null)
            {
                var method = teatroForm.GetType().GetMethod("AgregarFuncion");
                if (method != null)
                {
                    method.Invoke(teatroForm, new object[] { nuevaFuncion });
                }
            }

            MessageBox.Show("Función creada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
