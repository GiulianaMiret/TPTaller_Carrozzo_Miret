namespace Vista
{
    partial class FrmBannerAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBannerAgregar));
            this.labelNuevoBanner = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxBannerNombre = new System.Windows.Forms.TextBox();
            this.btnBannerCancelar = new System.Windows.Forms.Button();
            this.btnBannerGuardar = new System.Windows.Forms.Button();
            this.groupBoxFechaHora = new System.Windows.Forms.GroupBox();
            this.comboBoxBannerHoraFin = new System.Windows.Forms.ComboBox();
            this.comboBoxBannerHoraInicio = new System.Windows.Forms.ComboBox();
            this.dateTimePickerBannerFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBannerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.labelFechaHoraFin = new System.Windows.Forms.Label();
            this.labelFHInicio = new System.Windows.Forms.Label();
            this.buttonConsultarDisponibilidad = new System.Windows.Forms.Button();
            this.dataGridViewHorariosDisponibles = new System.Windows.Forms.DataGridView();
            this.dataGridViewFuentes = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSeleccionarFuente = new System.Windows.Forms.Button();
            this.groupBoxFuente = new System.Windows.Forms.GroupBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.comboBoxTipoFuente = new System.Windows.Forms.ComboBox();
            this.textBoxValorFuente = new System.Windows.Forms.TextBox();
            this.textBoxTituloFuente = new System.Windows.Forms.TextBox();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.groupBoxFechaHora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorariosDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuentes)).BeginInit();
            this.groupBoxFuente.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNuevoBanner
            // 
            this.labelNuevoBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNuevoBanner.AutoSize = true;
            this.labelNuevoBanner.BackColor = System.Drawing.Color.Transparent;
            this.labelNuevoBanner.Font = new System.Drawing.Font("Lucida Calligraphy", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevoBanner.ForeColor = System.Drawing.Color.SandyBrown;
            this.labelNuevoBanner.Location = new System.Drawing.Point(363, 9);
            this.labelNuevoBanner.Name = "labelNuevoBanner";
            this.labelNuevoBanner.Size = new System.Drawing.Size(295, 45);
            this.labelNuevoBanner.TabIndex = 0;
            this.labelNuevoBanner.Text = "Nuevo Banner";
            this.labelNuevoBanner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(14, 88);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(77, 19);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxBannerNombre
            // 
            this.textBoxBannerNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxBannerNombre.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBannerNombre.Location = new System.Drawing.Point(97, 83);
            this.textBoxBannerNombre.Name = "textBoxBannerNombre";
            this.textBoxBannerNombre.Size = new System.Drawing.Size(377, 30);
            this.textBoxBannerNombre.TabIndex = 2;
            // 
            // btnBannerCancelar
            // 
            this.btnBannerCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBannerCancelar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBannerCancelar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnBannerCancelar.Location = new System.Drawing.Point(627, 532);
            this.btnBannerCancelar.Name = "btnBannerCancelar";
            this.btnBannerCancelar.Size = new System.Drawing.Size(134, 33);
            this.btnBannerCancelar.TabIndex = 14;
            this.btnBannerCancelar.Text = "Cancelar";
            this.btnBannerCancelar.UseVisualStyleBackColor = true;
            this.btnBannerCancelar.Click += new System.EventHandler(this.btnBannerCancelar_Click);
            // 
            // btnBannerGuardar
            // 
            this.btnBannerGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBannerGuardar.AutoSize = true;
            this.btnBannerGuardar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBannerGuardar.Location = new System.Drawing.Point(403, 532);
            this.btnBannerGuardar.Name = "btnBannerGuardar";
            this.btnBannerGuardar.Size = new System.Drawing.Size(134, 33);
            this.btnBannerGuardar.TabIndex = 15;
            this.btnBannerGuardar.Text = "Guardar";
            this.btnBannerGuardar.UseVisualStyleBackColor = true;
            this.btnBannerGuardar.Click += new System.EventHandler(this.btnBannerGuardar_Click);
            // 
            // groupBoxFechaHora
            // 
            this.groupBoxFechaHora.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBoxFechaHora.AutoSize = true;
            this.groupBoxFechaHora.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxFechaHora.Controls.Add(this.comboBoxBannerHoraFin);
            this.groupBoxFechaHora.Controls.Add(this.comboBoxBannerHoraInicio);
            this.groupBoxFechaHora.Controls.Add(this.dateTimePickerBannerFechaFin);
            this.groupBoxFechaHora.Controls.Add(this.dateTimePickerBannerFechaInicio);
            this.groupBoxFechaHora.Controls.Add(this.labelFechaHoraFin);
            this.groupBoxFechaHora.Controls.Add(this.labelFHInicio);
            this.groupBoxFechaHora.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFechaHora.ForeColor = System.Drawing.Color.White;
            this.groupBoxFechaHora.Location = new System.Drawing.Point(32, 138);
            this.groupBoxFechaHora.Name = "groupBoxFechaHora";
            this.groupBoxFechaHora.Size = new System.Drawing.Size(456, 113);
            this.groupBoxFechaHora.TabIndex = 21;
            this.groupBoxFechaHora.TabStop = false;
            this.groupBoxFechaHora.Text = "Fecha y Hora";
            // 
            // comboBoxBannerHoraFin
            // 
            this.comboBoxBannerHoraFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBannerHoraFin.FormattingEnabled = true;
            this.comboBoxBannerHoraFin.Items.AddRange(new object[] {
            "00",
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
            "23"});
            this.comboBoxBannerHoraFin.Location = new System.Drawing.Point(272, 61);
            this.comboBoxBannerHoraFin.Name = "comboBoxBannerHoraFin";
            this.comboBoxBannerHoraFin.Size = new System.Drawing.Size(81, 27);
            this.comboBoxBannerHoraFin.TabIndex = 10;
            // 
            // comboBoxBannerHoraInicio
            // 
            this.comboBoxBannerHoraInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBannerHoraInicio.FormattingEnabled = true;
            this.comboBoxBannerHoraInicio.Items.AddRange(new object[] {
            "00",
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
            "23"});
            this.comboBoxBannerHoraInicio.Location = new System.Drawing.Point(272, 27);
            this.comboBoxBannerHoraInicio.Name = "comboBoxBannerHoraInicio";
            this.comboBoxBannerHoraInicio.Size = new System.Drawing.Size(81, 27);
            this.comboBoxBannerHoraInicio.TabIndex = 10;
            // 
            // dateTimePickerBannerFechaFin
            // 
            this.dateTimePickerBannerFechaFin.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerBannerFechaFin.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBannerFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBannerFechaFin.Location = new System.Drawing.Point(79, 61);
            this.dateTimePickerBannerFechaFin.Name = "dateTimePickerBannerFechaFin";
            this.dateTimePickerBannerFechaFin.Size = new System.Drawing.Size(161, 26);
            this.dateTimePickerBannerFechaFin.TabIndex = 9;
            // 
            // dateTimePickerBannerFechaInicio
            // 
            this.dateTimePickerBannerFechaInicio.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerBannerFechaInicio.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBannerFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBannerFechaInicio.Location = new System.Drawing.Point(79, 27);
            this.dateTimePickerBannerFechaInicio.Name = "dateTimePickerBannerFechaInicio";
            this.dateTimePickerBannerFechaInicio.Size = new System.Drawing.Size(161, 26);
            this.dateTimePickerBannerFechaInicio.TabIndex = 6;
            // 
            // labelFechaHoraFin
            // 
            this.labelFechaHoraFin.AutoSize = true;
            this.labelFechaHoraFin.BackColor = System.Drawing.Color.Transparent;
            this.labelFechaHoraFin.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaHoraFin.ForeColor = System.Drawing.Color.White;
            this.labelFechaHoraFin.Location = new System.Drawing.Point(24, 59);
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
            this.labelFHInicio.Location = new System.Drawing.Point(10, 28);
            this.labelFHInicio.Name = "labelFHInicio";
            this.labelFHInicio.Size = new System.Drawing.Size(49, 22);
            this.labelFHInicio.TabIndex = 5;
            this.labelFHInicio.Text = "Inicio";
            // 
            // buttonConsultarDisponibilidad
            // 
            this.buttonConsultarDisponibilidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonConsultarDisponibilidad.AutoSize = true;
            this.buttonConsultarDisponibilidad.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonConsultarDisponibilidad.Font = new System.Drawing.Font("Copperplate Gothic Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultarDisponibilidad.Location = new System.Drawing.Point(82, 253);
            this.buttonConsultarDisponibilidad.Name = "buttonConsultarDisponibilidad";
            this.buttonConsultarDisponibilidad.Size = new System.Drawing.Size(229, 39);
            this.buttonConsultarDisponibilidad.TabIndex = 23;
            this.buttonConsultarDisponibilidad.Text = "Ver Horarios Disponibles";
            this.buttonConsultarDisponibilidad.UseVisualStyleBackColor = false;
            this.buttonConsultarDisponibilidad.Click += new System.EventHandler(this.buttonConsultarDisponibilidad_Click);
            // 
            // dataGridViewHorariosDisponibles
            // 
            this.dataGridViewHorariosDisponibles.AllowUserToAddRows = false;
            this.dataGridViewHorariosDisponibles.AllowUserToDeleteRows = false;
            this.dataGridViewHorariosDisponibles.AllowUserToOrderColumns = true;
            this.dataGridViewHorariosDisponibles.AllowUserToResizeColumns = false;
            this.dataGridViewHorariosDisponibles.AllowUserToResizeRows = false;
            this.dataGridViewHorariosDisponibles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewHorariosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHorariosDisponibles.Location = new System.Drawing.Point(56, 295);
            this.dataGridViewHorariosDisponibles.Name = "dataGridViewHorariosDisponibles";
            this.dataGridViewHorariosDisponibles.Size = new System.Drawing.Size(271, 270);
            this.dataGridViewHorariosDisponibles.TabIndex = 24;
            this.dataGridViewHorariosDisponibles.Visible = false;
            // 
            // dataGridViewFuentes
            // 
            this.dataGridViewFuentes.AllowUserToAddRows = false;
            this.dataGridViewFuentes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dataGridViewFuentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFuentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFuentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Id,
            this.Valor,
            this.URL});
            this.dataGridViewFuentes.Location = new System.Drawing.Point(371, 367);
            this.dataGridViewFuentes.Name = "dataGridViewFuentes";
            this.dataGridViewFuentes.Size = new System.Drawing.Size(390, 142);
            this.dataGridViewFuentes.TabIndex = 25;
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // URL
            // 
            this.URL.DataPropertyName = "URL";
            this.URL.HeaderText = "URL";
            this.URL.Name = "URL";
            this.URL.Visible = false;
            // 
            // buttonSeleccionarFuente
            // 
            this.buttonSeleccionarFuente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSeleccionarFuente.AutoSize = true;
            this.buttonSeleccionarFuente.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonSeleccionarFuente.Font = new System.Drawing.Font("Copperplate Gothic Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeleccionarFuente.Location = new System.Drawing.Point(776, 398);
            this.buttonSeleccionarFuente.Name = "buttonSeleccionarFuente";
            this.buttonSeleccionarFuente.Size = new System.Drawing.Size(184, 33);
            this.buttonSeleccionarFuente.TabIndex = 32;
            this.buttonSeleccionarFuente.Text = "Seleccionar Fuente";
            this.buttonSeleccionarFuente.UseVisualStyleBackColor = false;
            this.buttonSeleccionarFuente.Click += new System.EventHandler(this.buttonSeleccionarFuente_Click);
            // 
            // groupBoxFuente
            // 
            this.groupBoxFuente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBoxFuente.AutoSize = true;
            this.groupBoxFuente.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxFuente.Controls.Add(this.textBoxId);
            this.groupBoxFuente.Controls.Add(this.comboBoxTipoFuente);
            this.groupBoxFuente.Controls.Add(this.textBoxValorFuente);
            this.groupBoxFuente.Controls.Add(this.textBoxTituloFuente);
            this.groupBoxFuente.Controls.Add(this.labelTipo);
            this.groupBoxFuente.Controls.Add(this.labelValor);
            this.groupBoxFuente.Controls.Add(this.labelTitulo);
            this.groupBoxFuente.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFuente.ForeColor = System.Drawing.Color.White;
            this.groupBoxFuente.Location = new System.Drawing.Point(494, 83);
            this.groupBoxFuente.Name = "groupBoxFuente";
            this.groupBoxFuente.Size = new System.Drawing.Size(493, 272);
            this.groupBoxFuente.TabIndex = 22;
            this.groupBoxFuente.TabStop = false;
            this.groupBoxFuente.Text = "Fuente";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(242, 74);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(42, 26);
            this.textBoxId.TabIndex = 37;
            this.textBoxId.Visible = false;
            // 
            // comboBoxTipoFuente
            // 
            this.comboBoxTipoFuente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoFuente.FormattingEnabled = true;
            this.comboBoxTipoFuente.Items.AddRange(new object[] {
            "RSS",
            "Texto Fijo"});
            this.comboBoxTipoFuente.Location = new System.Drawing.Point(74, 73);
            this.comboBoxTipoFuente.Name = "comboBoxTipoFuente";
            this.comboBoxTipoFuente.Size = new System.Drawing.Size(121, 27);
            this.comboBoxTipoFuente.TabIndex = 36;
            this.comboBoxTipoFuente.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoFuente_SelectedIndexChanged);
            // 
            // textBoxValorFuente
            // 
            this.textBoxValorFuente.Location = new System.Drawing.Point(74, 115);
            this.textBoxValorFuente.Multiline = true;
            this.textBoxValorFuente.Name = "textBoxValorFuente";
            this.textBoxValorFuente.ReadOnly = true;
            this.textBoxValorFuente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxValorFuente.Size = new System.Drawing.Size(399, 132);
            this.textBoxValorFuente.TabIndex = 35;
            // 
            // textBoxTituloFuente
            // 
            this.textBoxTituloFuente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTituloFuente.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTituloFuente.Location = new System.Drawing.Point(74, 33);
            this.textBoxTituloFuente.Name = "textBoxTituloFuente";
            this.textBoxTituloFuente.ReadOnly = true;
            this.textBoxTituloFuente.Size = new System.Drawing.Size(399, 30);
            this.textBoxTituloFuente.TabIndex = 33;
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.BackColor = System.Drawing.Color.Transparent;
            this.labelTipo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipo.ForeColor = System.Drawing.Color.White;
            this.labelTipo.Location = new System.Drawing.Point(11, 73);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(41, 22);
            this.labelTipo.TabIndex = 13;
            this.labelTipo.Text = "Tipo";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.BackColor = System.Drawing.Color.Transparent;
            this.labelValor.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValor.ForeColor = System.Drawing.Color.White;
            this.labelValor.Location = new System.Drawing.Point(11, 115);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(45, 22);
            this.labelValor.TabIndex = 12;
            this.labelValor.Text = "Valor";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.labelTitulo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(6, 33);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(50, 22);
            this.labelTitulo.TabIndex = 11;
            this.labelTitulo.Text = "Titulo";
            // 
            // FrmBannerAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(999, 577);
            this.Controls.Add(this.groupBoxFuente);
            this.Controls.Add(this.buttonSeleccionarFuente);
            this.Controls.Add(this.dataGridViewFuentes);
            this.Controls.Add(this.dataGridViewHorariosDisponibles);
            this.Controls.Add(this.buttonConsultarDisponibilidad);
            this.Controls.Add(this.groupBoxFechaHora);
            this.Controls.Add(this.btnBannerGuardar);
            this.Controls.Add(this.btnBannerCancelar);
            this.Controls.Add(this.textBoxBannerNombre);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelNuevoBanner);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBannerAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shout News";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBannerAgregar_Load);
            this.groupBoxFechaHora.ResumeLayout(false);
            this.groupBoxFechaHora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorariosDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuentes)).EndInit();
            this.groupBoxFuente.ResumeLayout(false);
            this.groupBoxFuente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNuevoBanner;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxBannerNombre;
        private System.Windows.Forms.Button btnBannerCancelar;
        private System.Windows.Forms.Button btnBannerGuardar;
        private System.Windows.Forms.GroupBox groupBoxFechaHora;
        private System.Windows.Forms.ComboBox comboBoxBannerHoraFin;
        private System.Windows.Forms.ComboBox comboBoxBannerHoraInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerBannerFechaFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerBannerFechaInicio;
        private System.Windows.Forms.Label labelFechaHoraFin;
        private System.Windows.Forms.Label labelFHInicio;
        private System.Windows.Forms.Button buttonConsultarDisponibilidad;
        private System.Windows.Forms.DataGridView dataGridViewHorariosDisponibles;
        private System.Windows.Forms.DataGridView dataGridViewFuentes;
        private System.Windows.Forms.Button buttonSeleccionarFuente;
        private System.Windows.Forms.GroupBox groupBoxFuente;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textBoxValorFuente;
        private System.Windows.Forms.TextBox textBoxTituloFuente;
        protected System.Windows.Forms.ComboBox comboBoxTipoFuente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.TextBox textBoxId;
    }
}