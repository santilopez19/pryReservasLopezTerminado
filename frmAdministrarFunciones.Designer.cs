namespace pryReservasLopezTerminado
{
    partial class frmAdministrarFunciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreFuncion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTeatroFuncion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoraFuncion = new System.Windows.Forms.TextBox();
            this.dtFuncion = new System.Windows.Forms.DateTimePicker();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombreFuncion
            // 
            this.txtNombreFuncion.Location = new System.Drawing.Point(38, 85);
            this.txtNombreFuncion.Name = "txtNombreFuncion";
            this.txtNombreFuncion.Size = new System.Drawing.Size(100, 22);
            this.txtNombreFuncion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hora";
            // 
            // cmbTeatroFuncion
            // 
            this.cmbTeatroFuncion.FormattingEnabled = true;
            this.cmbTeatroFuncion.Items.AddRange(new object[] {
            "Quenaken",
            "Tobas",
            "Onas"});
            this.cmbTeatroFuncion.Location = new System.Drawing.Point(396, 85);
            this.cmbTeatroFuncion.Name = "cmbTeatroFuncion";
            this.cmbTeatroFuncion.Size = new System.Drawing.Size(121, 24);
            this.cmbTeatroFuncion.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Teatro";
            // 
            // txtHoraFuncion
            // 
            this.txtHoraFuncion.Location = new System.Drawing.Point(167, 136);
            this.txtHoraFuncion.Name = "txtHoraFuncion";
            this.txtHoraFuncion.Size = new System.Drawing.Size(100, 22);
            this.txtHoraFuncion.TabIndex = 7;
            // 
            // dtFuncion
            // 
            this.dtFuncion.Location = new System.Drawing.Point(167, 85);
            this.dtFuncion.Name = "dtFuncion";
            this.dtFuncion.Size = new System.Drawing.Size(200, 22);
            this.dtFuncion.TabIndex = 8;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(538, 87);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 22);
            this.txtCosto.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Costo ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Crear Funciones";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(589, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAdministrarFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 201);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtFuncion);
            this.Controls.Add(this.txtHoraFuncion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTeatroFuncion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreFuncion);
            this.Controls.Add(this.label1);
            this.Name = "frmAdministrarFunciones";
            this.Text = "frmAdministrarFunciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreFuncion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTeatroFuncion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoraFuncion;
        private System.Windows.Forms.DateTimePicker dtFuncion;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}