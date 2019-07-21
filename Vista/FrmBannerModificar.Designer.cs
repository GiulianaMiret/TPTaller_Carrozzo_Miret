namespace Vista
{
    partial class FrmBannerModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBannerModificar));
            this.labelModificarBanner = new System.Windows.Forms.Label();
            this.groupBoxFechaHoraModificarCampaña = new System.Windows.Forms.GroupBox();
            this.comboBoxHoraFinBanner = new System.Windows.Forms.ComboBox();
            this.comboBoxHoraInicioBanner = new System.Windows.Forms.ComboBox();
            this.dateTimePickerBannerFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBannerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.labelFechaHoraFin = new System.Windows.Forms.Label();
            this.labelFHInicio = new System.Windows.Forms.Label();
            this.buttonConsultarDisponibilidad = new System.Windows.Forms.Button();
            this.dataGridViewHorariosDisponibles = new System.Windows.Forms.DataGridView();
            this.textBoxNombreBanner = new System.Windows.Forms.TextBox();
            this.labelNombreModificarCampania = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
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
            this.dataGridViewBanners = new System.Windows.Forms.DataGridView();
            this.Id_Banner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Banner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio_Banner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin_Banner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fuente_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxFechaHoraModificarCampaña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorariosDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuentes)).BeginInit();
            this.groupBoxFuente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBanners)).BeginInit();
            this.SuspendLayout();
            // 
            // labelModificarBanner
            // 
            this.labelModificarBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelModificarBanner.AutoSize = true;
            this.labelModificarBanner.BackColor = System.Drawing.Color.Transparent;
            this.labelModificarBanner.Font = new System.Drawing.Font("Lucida Calligraphy", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModificarBanner.ForeColor = System.Drawing.Color.SandyBrown;
            this.labelModificarBanner.Location = new System.Drawing.Point(356, 9);
            this.labelModificarBanner.Name = "labelModificarBanner";
            this.labelModificarBanner.Size = new System.Drawing.Size(357, 45);
            this.labelModificarBanner.TabIndex = 20;
            this.labelModificarBanner.Text = "Modificar Banner";
            this.labelModificarBanner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBoxFechaHoraModificarCampaña
            // 
            this.groupBoxFechaHoraModificarCampaña.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBoxFechaHoraModificarCampaña.AutoSize = true;
            this.groupBoxFechaHoraModificarCampaña.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxFechaHoraModificarCampaña.Controls.Add(this.comboBoxHoraFinBanner);
            this.groupBoxFechaHoraModificarCampaña.Controls.Add(this.comboBoxHoraInicioBanner);
            this.groupBoxFechaHoraModificarCampaña.Controls.Add(this.dateTimePickerBannerFechaFin);
            this.groupBoxFechaHoraModificarCampaña.Controls.Add(this.dateTimePickerBannerFechaInicio);
            this.groupBoxFechaHoraModificarCampaña.Controls.Add(this.labelFechaHoraFin);
            this.groupBoxFechaHoraModificarCampaña.Controls.Add(this.labelFHInicio);
            this.groupBoxFechaHoraModificarCampaña.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFechaHoraModificarCampaña.ForeColor = System.Drawing.Color.White;
            this.groupBoxFechaHoraModificarCampaña.Location = new System.Drawing.Point(23, 68);
            this.groupBoxFechaHoraModificarCampaña.Name = "groupBoxFechaHoraModificarCampaña";
            this.groupBoxFechaHoraModificarCampaña.Size = new System.Drawing.Size(326, 111);
            this.groupBoxFechaHoraModificarCampaña.TabIndex = 24;
            this.groupBoxFechaHoraModificarCampaña.TabStop = false;
            this.groupBoxFechaHoraModificarCampaña.Text = "Fecha y Hora";
            // 
            // comboBoxHoraFinBanner
            // 
            this.comboBoxHoraFinBanner.FormattingEnabled = true;
            this.comboBoxHoraFinBanner.Items.AddRange(new object[] {
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
            this.comboBoxHoraFinBanner.Location = new System.Drawing.Point(228, 59);
            this.comboBoxHoraFinBanner.Name = "comboBoxHoraFinBanner";
            this.comboBoxHoraFinBanner.Size = new System.Drawing.Size(81, 27);
            this.comboBoxHoraFinBanner.TabIndex = 10;
            // 
            // comboBoxHoraInicioBanner
            // 
            this.comboBoxHoraInicioBanner.FormattingEnabled = true;
            this.comboBoxHoraInicioBanner.Items.AddRange(new object[] {
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
            this.comboBoxHoraInicioBanner.Location = new System.Drawing.Point(228, 27);
            this.comboBoxHoraInicioBanner.Name = "comboBoxHoraInicioBanner";
            this.comboBoxHoraInicioBanner.Size = new System.Drawing.Size(81, 27);
            this.comboBoxHoraInicioBanner.TabIndex = 10;
            // 
            // dateTimePickerBannerFechaFin
            // 
            this.dateTimePickerBannerFechaFin.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerBannerFechaFin.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBannerFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBannerFechaFin.Location = new System.Drawing.Point(61, 59);
            this.dateTimePickerBannerFechaFin.Name = "dateTimePickerBannerFechaFin";
            this.dateTimePickerBannerFechaFin.Size = new System.Drawing.Size(161, 26);
            this.dateTimePickerBannerFechaFin.TabIndex = 9;
            // 
            // dateTimePickerBannerFechaInicio
            // 
            this.dateTimePickerBannerFechaInicio.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerBannerFechaInicio.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBannerFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBannerFechaInicio.Location = new System.Drawing.Point(61, 27);
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
            this.labelFechaHoraFin.Location = new System.Drawing.Point(6, 59);
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
            // buttonConsultarDisponibilidad
            // 
            this.buttonConsultarDisponibilidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonConsultarDisponibilidad.AutoSize = true;
            this.buttonConsultarDisponibilidad.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonConsultarDisponibilidad.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultarDisponibilidad.Location = new System.Drawing.Point(68, 185);
            this.buttonConsultarDisponibilidad.Name = "buttonConsultarDisponibilidad";
            this.buttonConsultarDisponibilidad.Size = new System.Drawing.Size(241, 39);
            this.buttonConsultarDisponibilidad.TabIndex = 27;
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
            this.dataGridViewHorariosDisponibles.Location = new System.Drawing.Point(23, 228);
            this.dataGridViewHorariosDisponibles.Name = "dataGridViewHorariosDisponibles";
            this.dataGridViewHorariosDisponibles.ReadOnly = true;
            this.dataGridViewHorariosDisponibles.Size = new System.Drawing.Size(297, 370);
            this.dataGridViewHorariosDisponibles.TabIndex = 31;
            this.dataGridViewHorariosDisponibles.Visible = false;
            // 
            // textBoxNombreBanner
            // 
            this.textBoxNombreBanner.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNombreBanner.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreBanner.Location = new System.Drawing.Point(527, 68);
            this.textBoxNombreBanner.Name = "textBoxNombreBanner";
            this.textBoxNombreBanner.Size = new System.Drawing.Size(196, 30);
            this.textBoxNombreBanner.TabIndex = 32;
            // 
            // labelNombreModificarCampania
            // 
            this.labelNombreModificarCampania.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNombreModificarCampania.AutoSize = true;
            this.labelNombreModificarCampania.BackColor = System.Drawing.Color.Transparent;
            this.labelNombreModificarCampania.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreModificarCampania.ForeColor = System.Drawing.Color.White;
            this.labelNombreModificarCampania.Location = new System.Drawing.Point(434, 72);
            this.labelNombreModificarCampania.Name = "labelNombreModificarCampania";
            this.labelNombreModificarCampania.Size = new System.Drawing.Size(77, 19);
            this.labelNombreModificarCampania.TabIndex = 33;
            this.labelNombreModificarCampania.Text = "Nombre";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonBuscar.AutoSize = true;
            this.buttonBuscar.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonBuscar.Font = new System.Drawing.Font("Copperplate Gothic Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(739, 65);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(94, 33);
            this.buttonBuscar.TabIndex = 34;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonCargar
            // 
            this.buttonCargar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCargar.AutoSize = true;
            this.buttonCargar.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonCargar.Font = new System.Drawing.Font("Copperplate Gothic Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargar.Location = new System.Drawing.Point(629, 228);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(94, 33);
            this.buttonCargar.TabIndex = 37;
            this.buttonCargar.Text = "Cargar";
            this.buttonCargar.UseVisualStyleBackColor = false;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(328, 620);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(134, 33);
            this.btnGuardar.TabIndex = 38;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCancelar.Location = new System.Drawing.Point(486, 620);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(134, 33);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dataGridViewFuentes
            // 
            this.dataGridViewFuentes.AllowUserToAddRows = false;
            this.dataGridViewFuentes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFuentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFuentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFuentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Id,
            this.Valor,
            this.URL});
            this.dataGridViewFuentes.Location = new System.Drawing.Point(379, 531);
            this.dataGridViewFuentes.Name = "dataGridViewFuentes";
            this.dataGridViewFuentes.Size = new System.Drawing.Size(425, 83);
            this.dataGridViewFuentes.TabIndex = 40;
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
            this.buttonSeleccionarFuente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSeleccionarFuente.AutoSize = true;
            this.buttonSeleccionarFuente.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonSeleccionarFuente.Font = new System.Drawing.Font("Copperplate Gothic Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeleccionarFuente.Location = new System.Drawing.Point(807, 547);
            this.buttonSeleccionarFuente.Name = "buttonSeleccionarFuente";
            this.buttonSeleccionarFuente.Size = new System.Drawing.Size(184, 33);
            this.buttonSeleccionarFuente.TabIndex = 41;
            this.buttonSeleccionarFuente.Text = "Seleccionar Fuente";
            this.buttonSeleccionarFuente.UseVisualStyleBackColor = false;
            this.buttonSeleccionarFuente.Click += new System.EventHandler(this.buttonSeleccionarFuente_Click);
            // 
            // groupBoxFuente
            // 
            this.groupBoxFuente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFuente.AutoSize = true;
            this.groupBoxFuente.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxFuente.Controls.Add(this.textBoxId);
            this.groupBoxFuente.Controls.Add(this.comboBoxTipoFuente);
            this.groupBoxFuente.Controls.Add(this.textBoxValorFuente);
            this.groupBoxFuente.Controls.Add(this.textBoxTituloFuente);
            this.groupBoxFuente.Controls.Add(this.labelTipo);
            this.groupBoxFuente.Controls.Add(this.labelValor);
            this.groupBoxFuente.Controls.Add(this.labelTitulo);
            this.groupBoxFuente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFuente.ForeColor = System.Drawing.Color.White;
            this.groupBoxFuente.Location = new System.Drawing.Point(364, 267);
            this.groupBoxFuente.Name = "groupBoxFuente";
            this.groupBoxFuente.Size = new System.Drawing.Size(604, 222);
            this.groupBoxFuente.TabIndex = 42;
            this.groupBoxFuente.TabStop = false;
            this.groupBoxFuente.Text = "Fuente";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(524, 73);
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
            this.comboBoxTipoFuente.Size = new System.Drawing.Size(121, 28);
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
            this.textBoxValorFuente.Size = new System.Drawing.Size(510, 82);
            this.textBoxValorFuente.TabIndex = 35;
            // 
            // textBoxTituloFuente
            // 
            this.textBoxTituloFuente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTituloFuente.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTituloFuente.Location = new System.Drawing.Point(74, 33);
            this.textBoxTituloFuente.Name = "textBoxTituloFuente";
            this.textBoxTituloFuente.ReadOnly = true;
            this.textBoxTituloFuente.Size = new System.Drawing.Size(510, 29);
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
            // dataGridViewBanners
            // 
            this.dataGridViewBanners.AllowUserToAddRows = false;
            this.dataGridViewBanners.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBanners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBanners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBanners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Banner,
            this.Nombre_Banner,
            this.FechaInicio_Banner,
            this.FechaFin_Banner,
            this.Fuente_Id});
            this.dataGridViewBanners.Location = new System.Drawing.Point(374, 104);
            this.dataGridViewBanners.Name = "dataGridViewBanners";
            this.dataGridViewBanners.Size = new System.Drawing.Size(544, 118);
            this.dataGridViewBanners.TabIndex = 43;
            // 
            // Id_Banner
            // 
            this.Id_Banner.DataPropertyName = "Id";
            this.Id_Banner.HeaderText = "Id";
            this.Id_Banner.Name = "Id_Banner";
            this.Id_Banner.Visible = false;
            // 
            // Nombre_Banner
            // 
            this.Nombre_Banner.DataPropertyName = "Nombre";
            this.Nombre_Banner.HeaderText = "Nombre";
            this.Nombre_Banner.Name = "Nombre_Banner";
            // 
            // FechaInicio_Banner
            // 
            this.FechaInicio_Banner.DataPropertyName = "FechaInicio";
            this.FechaInicio_Banner.HeaderText = "Fecha Inicio";
            this.FechaInicio_Banner.Name = "FechaInicio_Banner";
            // 
            // FechaFin_Banner
            // 
            this.FechaFin_Banner.DataPropertyName = "FechaFin";
            this.FechaFin_Banner.HeaderText = "Fecha Fin";
            this.FechaFin_Banner.Name = "FechaFin_Banner";
            // 
            // Fuente_Id
            // 
            this.Fuente_Id.DataPropertyName = "Fuente";
            this.Fuente_Id.HeaderText = "Fuente";
            this.Fuente_Id.Name = "Fuente_Id";
            this.Fuente_Id.Visible = false;
            // 
            // FrmBannerModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.FondoSlogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 653);
            this.Controls.Add(this.dataGridViewBanners);
            this.Controls.Add(this.groupBoxFuente);
            this.Controls.Add(this.buttonSeleccionarFuente);
            this.Controls.Add(this.dataGridViewFuentes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.labelNombreModificarCampania);
            this.Controls.Add(this.textBoxNombreBanner);
            this.Controls.Add(this.dataGridViewHorariosDisponibles);
            this.Controls.Add(this.buttonConsultarDisponibilidad);
            this.Controls.Add(this.groupBoxFechaHoraModificarCampaña);
            this.Controls.Add(this.labelModificarBanner);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBannerModificar";
            this.Text = "Shout News";
            this.Load += new System.EventHandler(this.FrmBannerModificar_Load);
            this.groupBoxFechaHoraModificarCampaña.ResumeLayout(false);
            this.groupBoxFechaHoraModificarCampaña.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorariosDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuentes)).EndInit();
            this.groupBoxFuente.ResumeLayout(false);
            this.groupBoxFuente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBanners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelModificarBanner;
        private System.Windows.Forms.GroupBox groupBoxFechaHoraModificarCampaña;
        private System.Windows.Forms.ComboBox comboBoxHoraFinBanner;
        private System.Windows.Forms.ComboBox comboBoxHoraInicioBanner;
        private System.Windows.Forms.DateTimePicker dateTimePickerBannerFechaFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerBannerFechaInicio;
        private System.Windows.Forms.Label labelFechaHoraFin;
        private System.Windows.Forms.Label labelFHInicio;
        private System.Windows.Forms.Button buttonConsultarDisponibilidad;
        private System.Windows.Forms.DataGridView dataGridViewHorariosDisponibles;
        private System.Windows.Forms.TextBox textBoxNombreBanner;
        private System.Windows.Forms.Label labelNombreModificarCampania;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dataGridViewFuentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.Button buttonSeleccionarFuente;
        private System.Windows.Forms.GroupBox groupBoxFuente;
        private System.Windows.Forms.TextBox textBoxId;
        protected System.Windows.Forms.ComboBox comboBoxTipoFuente;
        private System.Windows.Forms.TextBox textBoxValorFuente;
        private System.Windows.Forms.TextBox textBoxTituloFuente;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.DataGridView dataGridViewBanners;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Banner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Banner;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio_Banner;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin_Banner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fuente_Id;
    }
}