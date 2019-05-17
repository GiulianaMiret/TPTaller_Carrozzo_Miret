namespace Vista
{
    partial class FrmAgregarCampania
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarCampania));
            this.btnCampaniaGuardar = new System.Windows.Forms.Button();
            this.btnCampaniaCancelar = new System.Windows.Forms.Button();
            this.labelNuevaCampania = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.groupBoxFechaHora = new System.Windows.Forms.GroupBox();
            this.dateTimePickerCampaniaFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCampaniaHoraFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCampaniaHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCampaniaFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.labelFechaHoraFin = new System.Windows.Forms.Label();
            this.labelFHInicio = new System.Windows.Forms.Label();
            this.textBoxCampaniaNombre = new System.Windows.Forms.TextBox();
            this.groupBoxFechaHora.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCampaniaGuardar
            // 
            this.btnCampaniaGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCampaniaGuardar.AutoSize = true;
            this.btnCampaniaGuardar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCampaniaGuardar.Location = new System.Drawing.Point(229, 386);
            this.btnCampaniaGuardar.Name = "btnCampaniaGuardar";
            this.btnCampaniaGuardar.Size = new System.Drawing.Size(134, 33);
            this.btnCampaniaGuardar.TabIndex = 16;
            this.btnCampaniaGuardar.Text = "Guardar";
            this.btnCampaniaGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCampaniaCancelar
            // 
            this.btnCampaniaCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCampaniaCancelar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCampaniaCancelar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCampaniaCancelar.Location = new System.Drawing.Point(416, 386);
            this.btnCampaniaCancelar.Name = "btnCampaniaCancelar";
            this.btnCampaniaCancelar.Size = new System.Drawing.Size(134, 33);
            this.btnCampaniaCancelar.TabIndex = 17;
            this.btnCampaniaCancelar.Text = "Cancelar";
            this.btnCampaniaCancelar.UseVisualStyleBackColor = true;
            // 
            // labelNuevaCampania
            // 
            this.labelNuevaCampania.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNuevaCampania.AutoSize = true;
            this.labelNuevaCampania.BackColor = System.Drawing.Color.Transparent;
            this.labelNuevaCampania.Font = new System.Drawing.Font("Lucida Calligraphy", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevaCampania.ForeColor = System.Drawing.Color.SandyBrown;
            this.labelNuevaCampania.Location = new System.Drawing.Point(39, 23);
            this.labelNuevaCampania.Name = "labelNuevaCampania";
            this.labelNuevaCampania.Size = new System.Drawing.Size(336, 45);
            this.labelNuevaCampania.TabIndex = 18;
            this.labelNuevaCampania.Text = "Nueva Campaña";
            this.labelNuevaCampania.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(43, 122);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(77, 19);
            this.labelNombre.TabIndex = 19;
            this.labelNombre.Text = "Nombre";
            // 
            // groupBoxFechaHora
            // 
            this.groupBoxFechaHora.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBoxFechaHora.AutoSize = true;
            this.groupBoxFechaHora.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxFechaHora.Controls.Add(this.dateTimePickerCampaniaFechaFin);
            this.groupBoxFechaHora.Controls.Add(this.dateTimePickerCampaniaHoraFin);
            this.groupBoxFechaHora.Controls.Add(this.dateTimePickerCampaniaHoraInicio);
            this.groupBoxFechaHora.Controls.Add(this.dateTimePickerCampaniaFechaInicio);
            this.groupBoxFechaHora.Controls.Add(this.labelFechaHoraFin);
            this.groupBoxFechaHora.Controls.Add(this.labelFHInicio);
            this.groupBoxFechaHora.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFechaHora.ForeColor = System.Drawing.Color.White;
            this.groupBoxFechaHora.Location = new System.Drawing.Point(47, 198);
            this.groupBoxFechaHora.Name = "groupBoxFechaHora";
            this.groupBoxFechaHora.Size = new System.Drawing.Size(511, 134);
            this.groupBoxFechaHora.TabIndex = 20;
            this.groupBoxFechaHora.TabStop = false;
            this.groupBoxFechaHora.Text = "Fecha y Hora";
            // 
            // dateTimePickerCampaniaFechaFin
            // 
            this.dateTimePickerCampaniaFechaFin.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerCampaniaFechaFin.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerCampaniaFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerCampaniaFechaFin.Location = new System.Drawing.Point(97, 83);
            this.dateTimePickerCampaniaFechaFin.Name = "dateTimePickerCampaniaFechaFin";
            this.dateTimePickerCampaniaFechaFin.Size = new System.Drawing.Size(161, 26);
            this.dateTimePickerCampaniaFechaFin.TabIndex = 9;
            // 
            // dateTimePickerCampaniaHoraFin
            // 
            this.dateTimePickerCampaniaHoraFin.CustomFormat = "hh:mm";
            this.dateTimePickerCampaniaHoraFin.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerCampaniaHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerCampaniaHoraFin.Location = new System.Drawing.Point(340, 83);
            this.dateTimePickerCampaniaHoraFin.Name = "dateTimePickerCampaniaHoraFin";
            this.dateTimePickerCampaniaHoraFin.ShowUpDown = true;
            this.dateTimePickerCampaniaHoraFin.Size = new System.Drawing.Size(96, 26);
            this.dateTimePickerCampaniaHoraFin.TabIndex = 6;
            // 
            // dateTimePickerCampaniaHoraInicio
            // 
            this.dateTimePickerCampaniaHoraInicio.CustomFormat = "hh:mm";
            this.dateTimePickerCampaniaHoraInicio.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerCampaniaHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerCampaniaHoraInicio.Location = new System.Drawing.Point(340, 25);
            this.dateTimePickerCampaniaHoraInicio.Name = "dateTimePickerCampaniaHoraInicio";
            this.dateTimePickerCampaniaHoraInicio.ShowUpDown = true;
            this.dateTimePickerCampaniaHoraInicio.Size = new System.Drawing.Size(96, 26);
            this.dateTimePickerCampaniaHoraInicio.TabIndex = 6;
            // 
            // dateTimePickerCampaniaFechaInicio
            // 
            this.dateTimePickerCampaniaFechaInicio.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerCampaniaFechaInicio.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerCampaniaFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerCampaniaFechaInicio.Location = new System.Drawing.Point(97, 25);
            this.dateTimePickerCampaniaFechaInicio.Name = "dateTimePickerCampaniaFechaInicio";
            this.dateTimePickerCampaniaFechaInicio.Size = new System.Drawing.Size(161, 26);
            this.dateTimePickerCampaniaFechaInicio.TabIndex = 6;
            // 
            // labelFechaHoraFin
            // 
            this.labelFechaHoraFin.AutoSize = true;
            this.labelFechaHoraFin.BackColor = System.Drawing.Color.Transparent;
            this.labelFechaHoraFin.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaHoraFin.ForeColor = System.Drawing.Color.White;
            this.labelFechaHoraFin.Location = new System.Drawing.Point(9, 83);
            this.labelFechaHoraFin.Name = "labelFechaHoraFin";
            this.labelFechaHoraFin.Size = new System.Drawing.Size(31, 22);
            this.labelFechaHoraFin.TabIndex = 5;
            this.labelFechaHoraFin.Text = "Fin";
            // 
            // labelFHInicio
            // 
            this.labelFHInicio.AutoSize = true;
            this.labelFHInicio.BackColor = System.Drawing.Color.Transparent;
            this.labelFHInicio.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFHInicio.ForeColor = System.Drawing.Color.White;
            this.labelFHInicio.Location = new System.Drawing.Point(9, 25);
            this.labelFHInicio.Name = "labelFHInicio";
            this.labelFHInicio.Size = new System.Drawing.Size(49, 22);
            this.labelFHInicio.TabIndex = 5;
            this.labelFHInicio.Text = "Inicio";
            // 
            // textBoxCampaniaNombre
            // 
            this.textBoxCampaniaNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCampaniaNombre.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCampaniaNombre.Location = new System.Drawing.Point(144, 115);
            this.textBoxCampaniaNombre.Name = "textBoxCampaniaNombre";
            this.textBoxCampaniaNombre.Size = new System.Drawing.Size(382, 30);
            this.textBoxCampaniaNombre.TabIndex = 21;
            // 
            // FrmAgregarCampania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxCampaniaNombre);
            this.Controls.Add(this.groupBoxFechaHora);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelNuevaCampania);
            this.Controls.Add(this.btnCampaniaCancelar);
            this.Controls.Add(this.btnCampaniaGuardar);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAgregarCampania";
            this.Text = "Shout News";
            this.groupBoxFechaHora.ResumeLayout(false);
            this.groupBoxFechaHora.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCampaniaGuardar;
        private System.Windows.Forms.Button btnCampaniaCancelar;
        private System.Windows.Forms.Label labelNuevaCampania;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.GroupBox groupBoxFechaHora;
        private System.Windows.Forms.DateTimePicker dateTimePickerCampaniaFechaFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerCampaniaHoraFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerCampaniaHoraInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerCampaniaFechaInicio;
        private System.Windows.Forms.Label labelFechaHoraFin;
        private System.Windows.Forms.Label labelFHInicio;
        private System.Windows.Forms.TextBox textBoxCampaniaNombre;
    }
}