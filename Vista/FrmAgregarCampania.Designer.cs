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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarCampania));
            this.btnCampaniaGuardar = new System.Windows.Forms.Button();
            this.btnCampaniaCancelar = new System.Windows.Forms.Button();
            this.labelNuevaCampania = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.groupBoxFechaHora = new System.Windows.Forms.GroupBox();
            this.comboBoxCampaniaHoraFin = new System.Windows.Forms.ComboBox();
            this.comboBoxCampaniHoraInicio = new System.Windows.Forms.ComboBox();
            this.dateTimePickerCampaniaFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCampaniaFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.labelFechaHoraFin = new System.Windows.Forms.Label();
            this.labelFHInicio = new System.Windows.Forms.Label();
            this.textBoxCampaniaNombre = new System.Windows.Forms.TextBox();
            this.groupBoxImagenes = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewImagenesSeleccionadas = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTodasLasImagenes = new System.Windows.Forms.DataGridView();
            this.pictureBoxVistaPreviaImagenes = new System.Windows.Forms.PictureBox();
            this.buttonConsultarDisponibilidad = new System.Windows.Forms.Button();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxFechaHora.SuspendLayout();
            this.groupBoxImagenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImagenesSeleccionadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodasLasImagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVistaPreviaImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCampaniaGuardar
            // 
            this.btnCampaniaGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCampaniaGuardar.AutoSize = true;
            this.btnCampaniaGuardar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCampaniaGuardar.Location = new System.Drawing.Point(270, 558);
            this.btnCampaniaGuardar.Name = "btnCampaniaGuardar";
            this.btnCampaniaGuardar.Size = new System.Drawing.Size(134, 33);
            this.btnCampaniaGuardar.TabIndex = 16;
            this.btnCampaniaGuardar.Text = "Guardar";
            this.btnCampaniaGuardar.UseVisualStyleBackColor = true;
            this.btnCampaniaGuardar.Click += new System.EventHandler(this.btnCampaniaGuardar_Click);
            // 
            // btnCampaniaCancelar
            // 
            this.btnCampaniaCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCampaniaCancelar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCampaniaCancelar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCampaniaCancelar.Location = new System.Drawing.Point(459, 558);
            this.btnCampaniaCancelar.Name = "btnCampaniaCancelar";
            this.btnCampaniaCancelar.Size = new System.Drawing.Size(134, 33);
            this.btnCampaniaCancelar.TabIndex = 17;
            this.btnCampaniaCancelar.Text = "Cancelar";
            this.btnCampaniaCancelar.UseVisualStyleBackColor = true;
            this.btnCampaniaCancelar.Click += new System.EventHandler(this.btnCampaniaCancelar_Click);
            // 
            // labelNuevaCampania
            // 
            this.labelNuevaCampania.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNuevaCampania.AutoSize = true;
            this.labelNuevaCampania.BackColor = System.Drawing.Color.Transparent;
            this.labelNuevaCampania.Font = new System.Drawing.Font("Lucida Calligraphy", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevaCampania.ForeColor = System.Drawing.Color.SandyBrown;
            this.labelNuevaCampania.Location = new System.Drawing.Point(126, 23);
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
            this.labelNombre.Location = new System.Drawing.Point(43, 92);
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
            this.groupBoxFechaHora.Controls.Add(this.comboBoxCampaniaHoraFin);
            this.groupBoxFechaHora.Controls.Add(this.comboBoxCampaniHoraInicio);
            this.groupBoxFechaHora.Controls.Add(this.dateTimePickerCampaniaFechaFin);
            this.groupBoxFechaHora.Controls.Add(this.dateTimePickerCampaniaFechaInicio);
            this.groupBoxFechaHora.Controls.Add(this.labelFechaHoraFin);
            this.groupBoxFechaHora.Controls.Add(this.labelFHInicio);
            this.groupBoxFechaHora.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFechaHora.ForeColor = System.Drawing.Color.White;
            this.groupBoxFechaHora.Location = new System.Drawing.Point(47, 186);
            this.groupBoxFechaHora.Name = "groupBoxFechaHora";
            this.groupBoxFechaHora.Size = new System.Drawing.Size(434, 135);
            this.groupBoxFechaHora.TabIndex = 20;
            this.groupBoxFechaHora.TabStop = false;
            this.groupBoxFechaHora.Text = "Fecha y Hora";
            // 
            // comboBoxCampaniaHoraFin
            // 
            this.comboBoxCampaniaHoraFin.FormattingEnabled = true;
            this.comboBoxCampaniaHoraFin.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.comboBoxCampaniaHoraFin.Location = new System.Drawing.Point(286, 83);
            this.comboBoxCampaniaHoraFin.Name = "comboBoxCampaniaHoraFin";
            this.comboBoxCampaniaHoraFin.Size = new System.Drawing.Size(81, 27);
            this.comboBoxCampaniaHoraFin.TabIndex = 10;
            // 
            // comboBoxCampaniHoraInicio
            // 
            this.comboBoxCampaniHoraInicio.FormattingEnabled = true;
            this.comboBoxCampaniHoraInicio.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.comboBoxCampaniHoraInicio.Location = new System.Drawing.Point(286, 26);
            this.comboBoxCampaniHoraInicio.Name = "comboBoxCampaniHoraInicio";
            this.comboBoxCampaniHoraInicio.Size = new System.Drawing.Size(81, 27);
            this.comboBoxCampaniHoraInicio.TabIndex = 10;
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
            this.labelFHInicio.Location = new System.Drawing.Point(6, 26);
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
            this.textBoxCampaniaNombre.Location = new System.Drawing.Point(144, 85);
            this.textBoxCampaniaNombre.Name = "textBoxCampaniaNombre";
            this.textBoxCampaniaNombre.Size = new System.Drawing.Size(469, 30);
            this.textBoxCampaniaNombre.TabIndex = 21;
            // 
            // groupBoxImagenes
            // 
            this.groupBoxImagenes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBoxImagenes.AutoSize = true;
            this.groupBoxImagenes.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxImagenes.Controls.Add(this.button2);
            this.groupBoxImagenes.Controls.Add(this.button1);
            this.groupBoxImagenes.Controls.Add(this.dataGridViewImagenesSeleccionadas);
            this.groupBoxImagenes.Controls.Add(this.dataGridViewTodasLasImagenes);
            this.groupBoxImagenes.Controls.Add(this.pictureBoxVistaPreviaImagenes);
            this.groupBoxImagenes.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxImagenes.ForeColor = System.Drawing.Color.White;
            this.groupBoxImagenes.Location = new System.Drawing.Point(47, 337);
            this.groupBoxImagenes.Name = "groupBoxImagenes";
            this.groupBoxImagenes.Size = new System.Drawing.Size(791, 215);
            this.groupBoxImagenes.TabIndex = 20;
            this.groupBoxImagenes.TabStop = false;
            this.groupBoxImagenes.Text = "Imágenes";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(415, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "<- Quitar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonQuitarImagen_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(415, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar ->";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonAgregarImagen_Click);
            // 
            // dataGridViewImagenesSeleccionadas
            // 
            this.dataGridViewImagenesSeleccionadas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewImagenesSeleccionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImagenesSeleccionadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            this.dataGridViewImagenesSeleccionadas.Location = new System.Drawing.Point(545, 40);
            this.dataGridViewImagenesSeleccionadas.Name = "dataGridViewImagenesSeleccionadas";
            this.dataGridViewImagenesSeleccionadas.ReadOnly = true;
            this.dataGridViewImagenesSeleccionadas.Size = new System.Drawing.Size(175, 150);
            this.dataGridViewImagenesSeleccionadas.TabIndex = 1;
            // 
            // Nombre
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle1;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // dataGridViewTodasLasImagenes
            // 
            this.dataGridViewTodasLasImagenes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTodasLasImagenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTodasLasImagenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTodasLasImagenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombres});
            this.dataGridViewTodasLasImagenes.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewTodasLasImagenes.Location = new System.Drawing.Point(189, 40);
            this.dataGridViewTodasLasImagenes.Name = "dataGridViewTodasLasImagenes";
            this.dataGridViewTodasLasImagenes.ReadOnly = true;
            this.dataGridViewTodasLasImagenes.Size = new System.Drawing.Size(178, 150);
            this.dataGridViewTodasLasImagenes.TabIndex = 1;
            this.dataGridViewTodasLasImagenes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTodasLasImagenes_CellClick);
            // 
            // pictureBoxVistaPreviaImagenes
            // 
            this.pictureBoxVistaPreviaImagenes.Location = new System.Drawing.Point(13, 40);
            this.pictureBoxVistaPreviaImagenes.Name = "pictureBoxVistaPreviaImagenes";
            this.pictureBoxVistaPreviaImagenes.Size = new System.Drawing.Size(122, 90);
            this.pictureBoxVistaPreviaImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVistaPreviaImagenes.TabIndex = 0;
            this.pictureBoxVistaPreviaImagenes.TabStop = false;
            // 
            // buttonConsultarDisponibilidad
            // 
            this.buttonConsultarDisponibilidad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonConsultarDisponibilidad.AutoSize = true;
            this.buttonConsultarDisponibilidad.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonConsultarDisponibilidad.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultarDisponibilidad.Location = new System.Drawing.Point(533, 225);
            this.buttonConsultarDisponibilidad.Name = "buttonConsultarDisponibilidad";
            this.buttonConsultarDisponibilidad.Size = new System.Drawing.Size(299, 44);
            this.buttonConsultarDisponibilidad.TabIndex = 22;
            this.buttonConsultarDisponibilidad.Text = "Ver Horarios Disponibles";
            this.buttonConsultarDisponibilidad.UseVisualStyleBackColor = false;
            this.buttonConsultarDisponibilidad.Click += new System.EventHandler(this.buttonConsultarDisponibilidad_Click);
            // 
            // Nombres
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Nombres.DefaultCellStyle = dataGridViewCellStyle3;
            this.Nombres.HeaderText = "Nombre";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            // 
            // FrmAgregarCampania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(887, 612);
            this.Controls.Add(this.buttonConsultarDisponibilidad);
            this.Controls.Add(this.textBoxCampaniaNombre);
            this.Controls.Add(this.groupBoxImagenes);
            this.Controls.Add(this.groupBoxFechaHora);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelNuevaCampania);
            this.Controls.Add(this.btnCampaniaCancelar);
            this.Controls.Add(this.btnCampaniaGuardar);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAgregarCampania";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmAgregarCampania_Load);
            this.groupBoxFechaHora.ResumeLayout(false);
            this.groupBoxFechaHora.PerformLayout();
            this.groupBoxImagenes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImagenesSeleccionadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodasLasImagenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVistaPreviaImagenes)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dateTimePickerCampaniaFechaInicio;
        private System.Windows.Forms.Label labelFechaHoraFin;
        private System.Windows.Forms.Label labelFHInicio;
        private System.Windows.Forms.TextBox textBoxCampaniaNombre;
        private System.Windows.Forms.GroupBox groupBoxImagenes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewImagenesSeleccionadas;
        private System.Windows.Forms.DataGridView dataGridViewTodasLasImagenes;
        private System.Windows.Forms.PictureBox pictureBoxVistaPreviaImagenes;
        private System.Windows.Forms.ComboBox comboBoxCampaniaHoraFin;
        private System.Windows.Forms.ComboBox comboBoxCampaniHoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Button buttonConsultarDisponibilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
    }
}