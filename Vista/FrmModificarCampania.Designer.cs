namespace Vista
{
    partial class FrmModificarCampania
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarCampania));
            this.labelModificarCampania = new System.Windows.Forms.Label();
            this.labelNombreModificarCampania = new System.Windows.Forms.Label();
            this.textBoxNombreCampania = new System.Windows.Forms.TextBox();
            this.groupBoxFechaHoraModificarCampaña = new System.Windows.Forms.GroupBox();
            this.comboBoxHoraFinCampania = new System.Windows.Forms.ComboBox();
            this.comboBoxHoraInicioCampania = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFechaFinCampania = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaInicioCampania = new System.Windows.Forms.DateTimePicker();
            this.labelFechaHoraFin = new System.Windows.Forms.Label();
            this.labelFHInicio = new System.Windows.Forms.Label();
            this.btnGuardarCampaniaModificada = new System.Windows.Forms.Button();
            this.btnCancelarCambios = new System.Windows.Forms.Button();
            this.buttonConsultarDisponibilidad = new System.Windows.Forms.Button();
            this.groupBoxImagenes = new System.Windows.Forms.GroupBox();
            this.pictureBoxImagenesActuales = new System.Windows.Forms.PictureBox();
            this.buttonQuitarImagen = new System.Windows.Forms.Button();
            this.buttonAgregarImagen = new System.Windows.Forms.Button();
            this.dataGridViewImagenesSeleccionadas = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTodasLasImagenes = new System.Windows.Forms.DataGridView();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxVistaPreviaImagenes = new System.Windows.Forms.PictureBox();
            this.groupBoxFechaHoraModificarCampaña.SuspendLayout();
            this.groupBoxImagenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenesActuales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImagenesSeleccionadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodasLasImagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVistaPreviaImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelModificarCampania
            // 
            this.labelModificarCampania.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelModificarCampania.AutoSize = true;
            this.labelModificarCampania.BackColor = System.Drawing.Color.Transparent;
            this.labelModificarCampania.Font = new System.Drawing.Font("Lucida Calligraphy", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModificarCampania.ForeColor = System.Drawing.Color.SandyBrown;
            this.labelModificarCampania.Location = new System.Drawing.Point(271, 29);
            this.labelModificarCampania.Name = "labelModificarCampania";
            this.labelModificarCampania.Size = new System.Drawing.Size(395, 45);
            this.labelModificarCampania.TabIndex = 19;
            this.labelModificarCampania.Text = "Modificar Campaña";
            this.labelModificarCampania.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelNombreModificarCampania
            // 
            this.labelNombreModificarCampania.AutoSize = true;
            this.labelNombreModificarCampania.BackColor = System.Drawing.Color.Transparent;
            this.labelNombreModificarCampania.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreModificarCampania.ForeColor = System.Drawing.Color.White;
            this.labelNombreModificarCampania.Location = new System.Drawing.Point(40, 113);
            this.labelNombreModificarCampania.Name = "labelNombreModificarCampania";
            this.labelNombreModificarCampania.Size = new System.Drawing.Size(77, 19);
            this.labelNombreModificarCampania.TabIndex = 20;
            this.labelNombreModificarCampania.Text = "Nombre";
            // 
            // textBoxNombreCampania
            // 
            this.textBoxNombreCampania.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNombreCampania.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreCampania.Location = new System.Drawing.Point(136, 106);
            this.textBoxNombreCampania.Name = "textBoxNombreCampania";
            this.textBoxNombreCampania.Size = new System.Drawing.Size(530, 30);
            this.textBoxNombreCampania.TabIndex = 22;
            // 
            // groupBoxFechaHoraModificarCampaña
            // 
            this.groupBoxFechaHoraModificarCampaña.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBoxFechaHoraModificarCampaña.AutoSize = true;
            this.groupBoxFechaHoraModificarCampaña.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxFechaHoraModificarCampaña.Controls.Add(this.comboBoxHoraFinCampania);
            this.groupBoxFechaHoraModificarCampaña.Controls.Add(this.comboBoxHoraInicioCampania);
            this.groupBoxFechaHoraModificarCampaña.Controls.Add(this.dateTimePickerFechaFinCampania);
            this.groupBoxFechaHoraModificarCampaña.Controls.Add(this.dateTimePickerFechaInicioCampania);
            this.groupBoxFechaHoraModificarCampaña.Controls.Add(this.labelFechaHoraFin);
            this.groupBoxFechaHoraModificarCampaña.Controls.Add(this.labelFHInicio);
            this.groupBoxFechaHoraModificarCampaña.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFechaHoraModificarCampaña.ForeColor = System.Drawing.Color.White;
            this.groupBoxFechaHoraModificarCampaña.Location = new System.Drawing.Point(44, 212);
            this.groupBoxFechaHoraModificarCampaña.Name = "groupBoxFechaHoraModificarCampaña";
            this.groupBoxFechaHoraModificarCampaña.Size = new System.Drawing.Size(434, 135);
            this.groupBoxFechaHoraModificarCampaña.TabIndex = 23;
            this.groupBoxFechaHoraModificarCampaña.TabStop = false;
            this.groupBoxFechaHoraModificarCampaña.Text = "Fecha y Hora";
            // 
            // comboBoxHoraFinCampania
            // 
            this.comboBoxHoraFinCampania.FormattingEnabled = true;
            this.comboBoxHoraFinCampania.Items.AddRange(new object[] {
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
            this.comboBoxHoraFinCampania.Location = new System.Drawing.Point(286, 83);
            this.comboBoxHoraFinCampania.Name = "comboBoxHoraFinCampania";
            this.comboBoxHoraFinCampania.Size = new System.Drawing.Size(81, 27);
            this.comboBoxHoraFinCampania.TabIndex = 10;
            // 
            // comboBoxHoraInicioCampania
            // 
            this.comboBoxHoraInicioCampania.FormattingEnabled = true;
            this.comboBoxHoraInicioCampania.Items.AddRange(new object[] {
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
            this.comboBoxHoraInicioCampania.Location = new System.Drawing.Point(286, 26);
            this.comboBoxHoraInicioCampania.Name = "comboBoxHoraInicioCampania";
            this.comboBoxHoraInicioCampania.Size = new System.Drawing.Size(81, 27);
            this.comboBoxHoraInicioCampania.TabIndex = 10;
            // 
            // dateTimePickerFechaFinCampania
            // 
            this.dateTimePickerFechaFinCampania.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerFechaFinCampania.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaFinCampania.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaFinCampania.Location = new System.Drawing.Point(97, 83);
            this.dateTimePickerFechaFinCampania.Name = "dateTimePickerFechaFinCampania";
            this.dateTimePickerFechaFinCampania.Size = new System.Drawing.Size(161, 26);
            this.dateTimePickerFechaFinCampania.TabIndex = 9;
            // 
            // dateTimePickerFechaInicioCampania
            // 
            this.dateTimePickerFechaInicioCampania.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerFechaInicioCampania.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaInicioCampania.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaInicioCampania.Location = new System.Drawing.Point(97, 25);
            this.dateTimePickerFechaInicioCampania.Name = "dateTimePickerFechaInicioCampania";
            this.dateTimePickerFechaInicioCampania.Size = new System.Drawing.Size(161, 26);
            this.dateTimePickerFechaInicioCampania.TabIndex = 6;
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
            // btnGuardarCampaniaModificada
            // 
            this.btnGuardarCampaniaModificada.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardarCampaniaModificada.AutoSize = true;
            this.btnGuardarCampaniaModificada.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCampaniaModificada.Location = new System.Drawing.Point(218, 590);
            this.btnGuardarCampaniaModificada.Name = "btnGuardarCampaniaModificada";
            this.btnGuardarCampaniaModificada.Size = new System.Drawing.Size(134, 33);
            this.btnGuardarCampaniaModificada.TabIndex = 24;
            this.btnGuardarCampaniaModificada.Text = "Guardar";
            this.btnGuardarCampaniaModificada.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCambios
            // 
            this.btnCancelarCambios.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelarCambios.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCambios.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCancelarCambios.Location = new System.Drawing.Point(397, 590);
            this.btnCancelarCambios.Name = "btnCancelarCambios";
            this.btnCancelarCambios.Size = new System.Drawing.Size(134, 33);
            this.btnCancelarCambios.TabIndex = 25;
            this.btnCancelarCambios.Text = "Cancelar";
            this.btnCancelarCambios.UseVisualStyleBackColor = true;
            this.btnCancelarCambios.Click += new System.EventHandler(this.btnCancelarCambios_Click);
            // 
            // buttonConsultarDisponibilidad
            // 
            this.buttonConsultarDisponibilidad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonConsultarDisponibilidad.AutoSize = true;
            this.buttonConsultarDisponibilidad.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonConsultarDisponibilidad.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultarDisponibilidad.Location = new System.Drawing.Point(527, 268);
            this.buttonConsultarDisponibilidad.Name = "buttonConsultarDisponibilidad";
            this.buttonConsultarDisponibilidad.Size = new System.Drawing.Size(299, 44);
            this.buttonConsultarDisponibilidad.TabIndex = 26;
            this.buttonConsultarDisponibilidad.Text = "Ver Horarios Disponibles";
            this.buttonConsultarDisponibilidad.UseVisualStyleBackColor = false;
            this.buttonConsultarDisponibilidad.Click += new System.EventHandler(this.buttonConsultarDisponibilidad_Click);
            // 
            // groupBoxImagenes
            // 
            this.groupBoxImagenes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBoxImagenes.AutoSize = true;
            this.groupBoxImagenes.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxImagenes.Controls.Add(this.pictureBoxImagenesActuales);
            this.groupBoxImagenes.Controls.Add(this.buttonQuitarImagen);
            this.groupBoxImagenes.Controls.Add(this.buttonAgregarImagen);
            this.groupBoxImagenes.Controls.Add(this.dataGridViewImagenesSeleccionadas);
            this.groupBoxImagenes.Controls.Add(this.dataGridViewTodasLasImagenes);
            this.groupBoxImagenes.Controls.Add(this.pictureBoxVistaPreviaImagenes);
            this.groupBoxImagenes.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxImagenes.ForeColor = System.Drawing.Color.White;
            this.groupBoxImagenes.Location = new System.Drawing.Point(44, 353);
            this.groupBoxImagenes.Name = "groupBoxImagenes";
            this.groupBoxImagenes.Size = new System.Drawing.Size(791, 215);
            this.groupBoxImagenes.TabIndex = 27;
            this.groupBoxImagenes.TabStop = false;
            this.groupBoxImagenes.Text = "Imágenes";
            // 
            // pictureBoxImagenesActuales
            // 
            this.pictureBoxImagenesActuales.InitialImage = null;
            this.pictureBoxImagenesActuales.Location = new System.Drawing.Point(649, 40);
            this.pictureBoxImagenesActuales.Name = "pictureBoxImagenesActuales";
            this.pictureBoxImagenesActuales.Size = new System.Drawing.Size(122, 90);
            this.pictureBoxImagenesActuales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagenesActuales.TabIndex = 3;
            this.pictureBoxImagenesActuales.TabStop = false;
            // 
            // buttonQuitarImagen
            // 
            this.buttonQuitarImagen.BackColor = System.Drawing.Color.DarkGray;
            this.buttonQuitarImagen.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.buttonQuitarImagen.ForeColor = System.Drawing.Color.Black;
            this.buttonQuitarImagen.Location = new System.Drawing.Point(344, 108);
            this.buttonQuitarImagen.Name = "buttonQuitarImagen";
            this.buttonQuitarImagen.Size = new System.Drawing.Size(99, 33);
            this.buttonQuitarImagen.TabIndex = 2;
            this.buttonQuitarImagen.Text = "<- Quitar";
            this.buttonQuitarImagen.UseVisualStyleBackColor = false;
            this.buttonQuitarImagen.Click += new System.EventHandler(this.buttonQuitarImagen_Click);
            // 
            // buttonAgregarImagen
            // 
            this.buttonAgregarImagen.BackColor = System.Drawing.Color.DarkGray;
            this.buttonAgregarImagen.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.buttonAgregarImagen.ForeColor = System.Drawing.Color.Black;
            this.buttonAgregarImagen.Location = new System.Drawing.Point(344, 43);
            this.buttonAgregarImagen.Name = "buttonAgregarImagen";
            this.buttonAgregarImagen.Size = new System.Drawing.Size(99, 33);
            this.buttonAgregarImagen.TabIndex = 2;
            this.buttonAgregarImagen.Text = "Agregar ->";
            this.buttonAgregarImagen.UseVisualStyleBackColor = false;
            this.buttonAgregarImagen.Click += new System.EventHandler(this.buttonAgregarImagen_Click);
            // 
            // dataGridViewImagenesSeleccionadas
            // 
            this.dataGridViewImagenesSeleccionadas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewImagenesSeleccionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImagenesSeleccionadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            this.dataGridViewImagenesSeleccionadas.Location = new System.Drawing.Point(458, 25);
            this.dataGridViewImagenesSeleccionadas.Name = "dataGridViewImagenesSeleccionadas";
            this.dataGridViewImagenesSeleccionadas.ReadOnly = true;
            this.dataGridViewImagenesSeleccionadas.Size = new System.Drawing.Size(175, 150);
            this.dataGridViewImagenesSeleccionadas.TabIndex = 1;
            this.dataGridViewImagenesSeleccionadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewImagenesSeleccionadas_CellClick);
            // 
            // Nombre
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dataGridViewTodasLasImagenes.Location = new System.Drawing.Point(150, 25);
            this.dataGridViewTodasLasImagenes.Name = "dataGridViewTodasLasImagenes";
            this.dataGridViewTodasLasImagenes.ReadOnly = true;
            this.dataGridViewTodasLasImagenes.Size = new System.Drawing.Size(178, 150);
            this.dataGridViewTodasLasImagenes.TabIndex = 1;
            this.dataGridViewTodasLasImagenes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTodasLasImagenes_CellClick);
            // 
            // Nombres
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Nombres.DefaultCellStyle = dataGridViewCellStyle3;
            this.Nombres.HeaderText = "Nombre";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
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
            // FrmModificarCampania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.FondoSlogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(861, 635);
            this.Controls.Add(this.groupBoxImagenes);
            this.Controls.Add(this.buttonConsultarDisponibilidad);
            this.Controls.Add(this.btnCancelarCambios);
            this.Controls.Add(this.btnGuardarCampaniaModificada);
            this.Controls.Add(this.groupBoxFechaHoraModificarCampaña);
            this.Controls.Add(this.textBoxNombreCampania);
            this.Controls.Add(this.labelNombreModificarCampania);
            this.Controls.Add(this.labelModificarCampania);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmModificarCampania";
            this.Text = "FrmModificarCampania";
            this.Load += new System.EventHandler(this.FrmModificarCampania_Load);
            this.groupBoxFechaHoraModificarCampaña.ResumeLayout(false);
            this.groupBoxFechaHoraModificarCampaña.PerformLayout();
            this.groupBoxImagenes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenesActuales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImagenesSeleccionadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodasLasImagenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVistaPreviaImagenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelModificarCampania;
        private System.Windows.Forms.Label labelNombreModificarCampania;
        private System.Windows.Forms.TextBox textBoxNombreCampania;
        private System.Windows.Forms.GroupBox groupBoxFechaHoraModificarCampaña;
        private System.Windows.Forms.ComboBox comboBoxHoraFinCampania;
        private System.Windows.Forms.ComboBox comboBoxHoraInicioCampania;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFinCampania;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInicioCampania;
        private System.Windows.Forms.Label labelFechaHoraFin;
        private System.Windows.Forms.Label labelFHInicio;
        private System.Windows.Forms.Button btnGuardarCampaniaModificada;
        private System.Windows.Forms.Button btnCancelarCambios;
        private System.Windows.Forms.Button buttonConsultarDisponibilidad;
        private System.Windows.Forms.GroupBox groupBoxImagenes;
        private System.Windows.Forms.Button buttonQuitarImagen;
        private System.Windows.Forms.Button buttonAgregarImagen;
        private System.Windows.Forms.DataGridView dataGridViewImagenesSeleccionadas;
        private System.Windows.Forms.DataGridView dataGridViewTodasLasImagenes;
        private System.Windows.Forms.PictureBox pictureBoxVistaPreviaImagenes;
        private System.Windows.Forms.PictureBox pictureBoxImagenesActuales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
    }
}