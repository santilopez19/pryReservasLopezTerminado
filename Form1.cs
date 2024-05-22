using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace pryReservasLopezTerminado
{
    public partial class frmQuaken : Form
    {
        private List<clsFunciones> funcionesTeatro;
        private const int Filas = 10;
        private const int Columnas = 4;
        private const int AnchoAsiento = 30;
        private const int AltoAsiento = 30;
        private Dictionary<string, (string Nombre, string Dni)> reservas;
        private PictureBox pictureBoxSeleccionado;



        public frmQuaken()
        {
            InitializeComponent();
            reservas = new Dictionary<string, (string Nombre, string Dni)>();
            funcionesTeatro = new List<clsFunciones>();
            InicializarAsientos();
            InicializarComboBoxLugaresDisponibles();
            ActualizarComboBoxFunciones();
            frmAdministrarFunciones adminForm = new frmAdministrarFunciones(this);
        }
        int margenHorizontalEscenario = 15;
        int margenVerticalEscenario = 25;
        public void AgregarFuncion(clsFunciones funcion)
        {
            funcionesTeatro.Add(funcion);
            ActualizarComboBoxFunciones();
        }

        // Método para actualizar el ComboBox con las funciones disponibles
        private void ActualizarComboBoxFunciones()
        {
            cmbFunciones.Items.Clear();
            foreach (var funcion in funcionesTeatro)
            {
                cmbFunciones.Items.Add(funcion);
            }
            if (cmbFunciones.Items.Count > 0)
            {
                cmbFunciones.SelectedIndex = 0; // Selecciona el primer elemento por defecto
            }
        }
        private void InicializarAsientos()
        {
            int margenHorizontal = 20; // Margen horizontal
            int margenVertical = 20;   // Margen vertical
            int numeroAsiento = 1;     // Número inicial del asiento

            

            // PictureBox para el escenario
            PictureBox pbEscenario = new PictureBox
            {
                Size = new Size(Columnas * (AnchoAsiento + margenHorizontalEscenario), margenVerticalEscenario),
                Location = new Point(margenHorizontal, margenVertical),
                BackColor = Color.Gray, // Color del escenario
                BorderStyle = BorderStyle.FixedSingle,
                Name = "Escenario"
            };
            // Agregar la palabra "Escenario"
            Label lblEscenario = new Label
            {
                Text = "Escenario",
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 10, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(pbEscenario.Width / 4, pbEscenario.Height / 3)
            };
            pbEscenario.Controls.Add(lblEscenario); // Agregar la etiqueta al PictureBox
            this.Controls.Add(pbEscenario);

            for (int fila = 0; fila < Filas; fila++)
            {
                for (int columna = 0; columna < Columnas; columna++)
                {
                    PictureBox pb = new PictureBox
                    {
                        Size = new Size(AnchoAsiento, AltoAsiento),
                        Location = new Point(margenHorizontal + columna * (AnchoAsiento + margenHorizontal), margenVertical * 2 + pbEscenario.Height + fila * (AltoAsiento + margenVertical)),
                        BackColor = Color.Green,
                        BorderStyle = BorderStyle.FixedSingle,
                        Name = $"{fila}-{columna}"
                    };


                    // Crear un label para mostrar el número del asiento
                    Label lblNumero = new Label
                    {
                        Text = numeroAsiento.ToString(),
                        AutoSize = true,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Arial", 8, FontStyle.Bold),
                        ForeColor = Color.Black,
                        Location = new Point(pb.Width / 2 - 7, pb.Height / 2 - 7) // Centrar el número dentro del PictureBox
                    };
                    pb.Controls.Add(lblNumero); // Agregar el label al PictureBox

                    pb.Click += Asiento_Click;
                    this.Controls.Add(pb);
                    numeroAsiento++;
                }
            }
            // PictureBox para el cuadro azul (asientos del 1 al 20)
            PictureBox pbAzul = new PictureBox
            {
                Size = new Size(Columnas * (AnchoAsiento + margenHorizontal), (Filas / 2) * (AltoAsiento + 21)),
                Location = new Point(10, 25 * 2),
                BackColor = Color.LightSkyBlue,
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(pbAzul);

            // PictureBox para el cuadro verde (asientos del 21 al 40)
            PictureBox pbVerde = new PictureBox
            {
                Size = new Size(Columnas * (AnchoAsiento + margenHorizontal), (Filas / 2) * (AltoAsiento + 23)),
                Location = new Point(10, margenHorizontal * 2 + (Filas / 2) * (AltoAsiento + margenVertical)),
                BackColor = Color.LightGreen,
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(pbVerde);
        }

        private void Asiento_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if (pb == null) return;

            // Establecer el PictureBox seleccionado
            pictureBoxSeleccionado = pb;

            // Verificar si hay una reserva en el lugar seleccionado
            if (reservas.TryGetValue(pb.Name, out var datos))
            {
                // Mostrar los detalles de la reserva y preguntar si se desea cancelar
                var result = MessageBox.Show($"Asiento reservado por:\nNombre: {datos.Nombre}\nDNI: {datos.Dni}\n\n¿Desea cancelar la reserva?", "Reserva", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Cancelar la reserva
                    reservas.Remove(pb.Name);
                    pb.BackColor = Color.Green; // Restaurar el color original del asiento
                    MessageBox.Show("Reserva cancelada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Si no hay reserva, mostrar un mensaje indicando que el lugar está disponible
                MessageBox.Show("Este lugar está disponible.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LimpiarCampos()
        {
            // Limpiar los campos de nombre y DNI
            txtNombre.Clear();
            txtDni.Clear();
        }
        private void InicializarComboBoxLugaresDisponibles()
        {
            for (int i = 1; i <= Filas * Columnas; i++)
            {
                cmbLugar.Items.Add($" {i}");
            }
        }

        private void cmbLugar_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el nombre del lugar seleccionado en el ComboBox
            string lugarSeleccionado = cmbLugar.SelectedItem.ToString();

            // Obtener el número de asiento del lugar seleccionado
            int numeroAsiento = int.Parse(lugarSeleccionado.Split(' ')[1]);

            // Obtener el nombre del PictureBox correspondiente al lugar seleccionado
            string nombrePictureBox = ObtenerNombrePictureBox(numeroAsiento);

            // Buscar el PictureBox correspondiente al lugar seleccionado
            pictureBoxSeleccionado = this.Controls.OfType<PictureBox>().FirstOrDefault(pb => pb.Name == nombrePictureBox);
        }
        private string ObtenerNombrePictureBox(int numeroLugar)
        {
            // Convertir el número del lugar a las coordenadas de fila y columna
            int fila = (numeroLugar - 1) / Columnas;
            int columna = (numeroLugar - 1) % Columnas;
            // Construir el nombre del PictureBox correspondiente a las coordenadas
            return $"{fila}-{columna}";
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un lugar en el PictureBox
            if (pictureBoxSeleccionado != null)
            {
                // Obtener el nombre del lugar (PictureBox)
                string nombreLugar = pictureBoxSeleccionado.Name;

                // Verificar si ya hay una reserva en el lugar seleccionado
                if (reservas.ContainsKey(nombreLugar))
                {
                    MessageBox.Show("Este lugar ya está reservado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Verificar si se han ingresado datos de nombre y DNI
                    if (!string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtDni.Text))
                    {
                        // Realizar la reserva en el lugar seleccionado
                        reservas[nombreLugar] = (txtNombre.Text, txtDni.Text);
                        pictureBoxSeleccionado.BackColor = Color.Red; // Cambiar el color del asiento a rojo
                        pictureBoxSeleccionado.Tag = $"Reservado por: {txtNombre.Text} (DNI: {txtDni.Text})"; // Guardar los datos de la reserva en el Tag del PictureBox
                        LimpiarCampos(); // Limpiar los campos de nombre y DNI
                    }
                    else
                    {
                        MessageBox.Show("Por favor, complete los campos Nombre y DNI.", "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un lugar para realizar la reserva.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
