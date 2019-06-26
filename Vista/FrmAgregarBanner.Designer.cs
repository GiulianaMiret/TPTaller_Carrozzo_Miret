namespace Vista
{
    partial class FrmAgregarBanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarBanner));
            this.labelNuevoBanner = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxBannerNombre = new System.Windows.Forms.TextBox();
            this.groupBoxFechaHora = new System.Windows.Forms.GroupBox();
            this.dateTimePickerBannerFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBannerHoraFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBannerHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBannerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.labelFechaHoraFin = new System.Windows.Forms.Label();
            this.labelFHInicio = new System.Windows.Forms.Label();
            this.groupBoxTipoBanner = new System.Windows.Forms.GroupBox();
            this.radioButtonRSS = new System.Windows.Forms.RadioButton();
            this.radioButtonTextoFijo = new System.Windows.Forms.RadioButton();
            this.groupBoxTextoFijo = new System.Windows.Forms.GroupBox();
            this.textBoxTXTTexto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxRSS = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBannerCancelar = new System.Windows.Forms.Button();
            this.btnBannerGuardar = new System.Windows.Forms.Button();
            this.dataGridViewNewBanner = new System.Windows.Forms.DataGridView();
            this.groupBoxFechaHora.SuspendLayout();
            this.groupBoxTipoBanner.SuspendLayout();
            this.groupBoxTextoFijo.SuspendLayout();
            this.groupBoxRSS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNewBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNuevoBanner
            // 
            this.labelNuevoBanner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNuevoBanner.AutoSize = true;
            this.labelNuevoBanner.BackColor = System.Drawing.Color.Transparent;
            this.labelNuevoBanner.Font = new System.Drawing.Font("Lucida Calligraphy", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevoBanner.ForeColor = System.Drawing.Color.SandyBrown;
            this.labelNuevoBanner.Location = new System.Drawing.Point(24, 20);
            this.labelNuevoBanner.Name = "labelNuevoBanner";
            this.labelNuevoBanner.Size = new System.Drawing.Size(295, 45);
            this.labelNuevoBanner.TabIndex = 0;
            this.labelNuevoBanner.Text = "Nuevo Banner";
            this.labelNuevoBanner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(28, 88);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(77, 19);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxBannerNombre
            // 
            this.textBoxBannerNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBannerNombre.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBannerNombre.Location = new System.Drawing.Point(111, 83);
            this.textBoxBannerNombre.Name = "textBoxBannerNombre";
            this.textBoxBannerNombre.Size = new System.Drawing.Size(382, 30);
            this.textBoxBannerNombre.TabIndex = 2;
            // 
            // groupBoxFechaHora
            // 
            this.groupBoxFechaHora.AutoSize = true;
            this.groupBoxFechaHora.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxFechaHora.Controls.Add(this.dateTimePickerBannerFechaFin);
            this.groupBoxFechaHora.Controls.Add(this.dateTimePickerBannerHoraFin);
            this.groupBoxFechaHora.Controls.Add(this.dateTimePickerBannerHoraInicio);
            this.groupBoxFechaHora.Controls.Add(this.dateTimePickerBannerFechaInicio);
            this.groupBoxFechaHora.Controls.Add(this.labelFechaHoraFin);
            this.groupBoxFechaHora.Controls.Add(this.labelFHInicio);
            this.groupBoxFechaHora.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFechaHora.ForeColor = System.Drawing.Color.White;
            this.groupBoxFechaHora.Location = new System.Drawing.Point(32, 180);
            this.groupBoxFechaHora.Name = "groupBoxFechaHora";
            this.groupBoxFechaHora.Size = new System.Drawing.Size(298, 112);
            this.groupBoxFechaHora.TabIndex = 4;
            this.groupBoxFechaHora.TabStop = false;
            this.groupBoxFechaHora.Text = "Fecha y Hora";
            // 
            // dateTimePickerBannerFechaFin
            // 
            this.dateTimePickerBannerFechaFin.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerBannerFechaFin.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBannerFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBannerFechaFin.Location = new System.Drawing.Point(64, 61);
            this.dateTimePickerBannerFechaFin.Name = "dateTimePickerBannerFechaFin";
            this.dateTimePickerBannerFechaFin.Size = new System.Drawing.Size(121, 26);
            this.dateTimePickerBannerFechaFin.TabIndex = 9;
            // 
            // dateTimePickerBannerHoraFin
            // 
            this.dateTimePickerBannerHoraFin.CustomFormat = "hh:mm";
            this.dateTimePickerBannerHoraFin.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBannerHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBannerHoraFin.Location = new System.Drawing.Point(202, 61);
            this.dateTimePickerBannerHoraFin.Name = "dateTimePickerBannerHoraFin";
            this.dateTimePickerBannerHoraFin.ShowUpDown = true;
            this.dateTimePickerBannerHoraFin.Size = new System.Drawing.Size(72, 26);
            this.dateTimePickerBannerHoraFin.TabIndex = 6;
            // 
            // dateTimePickerBannerHoraInicio
            // 
            this.dateTimePickerBannerHoraInicio.CustomFormat = "hh:mm";
            this.dateTimePickerBannerHoraInicio.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBannerHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBannerHoraInicio.Location = new System.Drawing.Point(202, 21);
            this.dateTimePickerBannerHoraInicio.Name = "dateTimePickerBannerHoraInicio";
            this.dateTimePickerBannerHoraInicio.ShowUpDown = true;
            this.dateTimePickerBannerHoraInicio.Size = new System.Drawing.Size(72, 26);
            this.dateTimePickerBannerHoraInicio.TabIndex = 6;
            // 
            // dateTimePickerBannerFechaInicio
            // 
            this.dateTimePickerBannerFechaInicio.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerBannerFechaInicio.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBannerFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBannerFechaInicio.Location = new System.Drawing.Point(64, 21);
            this.dateTimePickerBannerFechaInicio.Name = "dateTimePickerBannerFechaInicio";
            this.dateTimePickerBannerFechaInicio.Size = new System.Drawing.Size(121, 26);
            this.dateTimePickerBannerFechaInicio.TabIndex = 6;
            // 
            // labelFechaHoraFin
            // 
            this.labelFechaHoraFin.AutoSize = true;
            this.labelFechaHoraFin.BackColor = System.Drawing.Color.Transparent;
            this.labelFechaHoraFin.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaHoraFin.ForeColor = System.Drawing.Color.White;
            this.labelFechaHoraFin.Location = new System.Drawing.Point(9, 61);
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
            // groupBoxTipoBanner
            // 
            this.groupBoxTipoBanner.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBoxTipoBanner.AutoSize = true;
            this.groupBoxTipoBanner.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTipoBanner.Controls.Add(this.radioButtonRSS);
            this.groupBoxTipoBanner.Controls.Add(this.radioButtonTextoFijo);
            this.groupBoxTipoBanner.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTipoBanner.ForeColor = System.Drawing.Color.White;
            this.groupBoxTipoBanner.Location = new System.Drawing.Point(32, 317);
            this.groupBoxTipoBanner.Name = "groupBoxTipoBanner";
            this.groupBoxTipoBanner.Size = new System.Drawing.Size(185, 107);
            this.groupBoxTipoBanner.TabIndex = 8;
            this.groupBoxTipoBanner.TabStop = false;
            this.groupBoxTipoBanner.Text = "Tipo de Banner";
            // 
            // radioButtonRSS
            // 
            this.radioButtonRSS.AutoSize = true;
            this.radioButtonRSS.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRSS.Location = new System.Drawing.Point(27, 54);
            this.radioButtonRSS.Name = "radioButtonRSS";
            this.radioButtonRSS.Size = new System.Drawing.Size(123, 28);
            this.radioButtonRSS.TabIndex = 7;
            this.radioButtonRSS.TabStop = true;
            this.radioButtonRSS.Text = "Fuente RSS";
            this.radioButtonRSS.UseVisualStyleBackColor = true;
            this.radioButtonRSS.Click += new System.EventHandler(this.radioButtonRSS_Click);
            // 
            // radioButtonTextoFijo
            // 
            this.radioButtonTextoFijo.AutoSize = true;
            this.radioButtonTextoFijo.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTextoFijo.Location = new System.Drawing.Point(27, 25);
            this.radioButtonTextoFijo.Name = "radioButtonTextoFijo";
            this.radioButtonTextoFijo.Size = new System.Drawing.Size(113, 28);
            this.radioButtonTextoFijo.TabIndex = 6;
            this.radioButtonTextoFijo.TabStop = true;
            this.radioButtonTextoFijo.Text = "Texto Fijo";
            this.radioButtonTextoFijo.UseVisualStyleBackColor = true;
            this.radioButtonTextoFijo.Click += new System.EventHandler(this.radioButtonTextoFijo_Click);
            // 
            // groupBoxTextoFijo
            // 
            this.groupBoxTextoFijo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBoxTextoFijo.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTextoFijo.Controls.Add(this.textBoxTXTTexto);
            this.groupBoxTextoFijo.Controls.Add(this.label2);
            this.groupBoxTextoFijo.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTextoFijo.ForeColor = System.Drawing.Color.White;
            this.groupBoxTextoFijo.Location = new System.Drawing.Point(258, 301);
            this.groupBoxTextoFijo.Name = "groupBoxTextoFijo";
            this.groupBoxTextoFijo.Size = new System.Drawing.Size(580, 160);
            this.groupBoxTextoFijo.TabIndex = 9;
            this.groupBoxTextoFijo.TabStop = false;
            this.groupBoxTextoFijo.Text = "Propiedades";
            this.groupBoxTextoFijo.Visible = false;
            // 
            // textBoxTXTTexto
            // 
            this.textBoxTXTTexto.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTXTTexto.Location = new System.Drawing.Point(17, 52);
            this.textBoxTXTTexto.Name = "textBoxTXTTexto";
            this.textBoxTXTTexto.Size = new System.Drawing.Size(557, 30);
            this.textBoxTXTTexto.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Texto";
            // 
            // groupBoxRSS
            // 
            this.groupBoxRSS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBoxRSS.AutoSize = true;
            this.groupBoxRSS.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxRSS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxRSS.Controls.Add(this.label3);
            this.groupBoxRSS.Controls.Add(this.dataGridView1);
            this.groupBoxRSS.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRSS.ForeColor = System.Drawing.Color.White;
            this.groupBoxRSS.Location = new System.Drawing.Point(258, 301);
            this.groupBoxRSS.Name = "groupBoxRSS";
            this.groupBoxRSS.Size = new System.Drawing.Size(592, 164);
            this.groupBoxRSS.TabIndex = 11;
            this.groupBoxRSS.TabStop = false;
            this.groupBoxRSS.Text = "Propiedades";
            this.groupBoxRSS.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seleccione la Fuente";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(558, 90);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnBannerCancelar
            // 
            this.btnBannerCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBannerCancelar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBannerCancelar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnBannerCancelar.Location = new System.Drawing.Point(463, 467);
            this.btnBannerCancelar.Name = "btnBannerCancelar";
            this.btnBannerCancelar.Size = new System.Drawing.Size(134, 33);
            this.btnBannerCancelar.TabIndex = 14;
            this.btnBannerCancelar.Text = "Cancelar";
            this.btnBannerCancelar.UseVisualStyleBackColor = true;
            // 
            // btnBannerGuardar
            // 
            this.btnBannerGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBannerGuardar.AutoSize = true;
            this.btnBannerGuardar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBannerGuardar.Location = new System.Drawing.Point(258, 467);
            this.btnBannerGuardar.Name = "btnBannerGuardar";
            this.btnBannerGuardar.Size = new System.Drawing.Size(134, 33);
            this.btnBannerGuardar.TabIndex = 15;
            this.btnBannerGuardar.Text = "Guardar";
            this.btnBannerGuardar.UseVisualStyleBackColor = true;
            this.btnBannerGuardar.Click += new System.EventHandler(this.btnBannerGuardar_Click);
            // 
            // dataGridViewNewBanner
            // 
            this.dataGridViewNewBanner.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewNewBanner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNewBanner.Location = new System.Drawing.Point(397, 184);
            this.dataGridViewNewBanner.Name = "dataGridViewNewBanner";
            this.dataGridViewNewBanner.Size = new System.Drawing.Size(468, 100);
            this.dataGridViewNewBanner.TabIndex = 16;
            // 
            // FrmAgregarBanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(877, 512);
            this.Controls.Add(this.dataGridViewNewBanner);
            this.Controls.Add(this.btnBannerGuardar);
            this.Controls.Add(this.groupBoxTextoFijo);
            this.Controls.Add(this.btnBannerCancelar);
            this.Controls.Add(this.groupBoxRSS);
            this.Controls.Add(this.groupBoxTipoBanner);
            this.Controls.Add(this.groupBoxFechaHora);
            this.Controls.Add(this.textBoxBannerNombre);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelNuevoBanner);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAgregarBanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shout News";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBoxFechaHora.ResumeLayout(false);
            this.groupBoxFechaHora.PerformLayout();
            this.groupBoxTipoBanner.ResumeLayout(false);
            this.groupBoxTipoBanner.PerformLayout();
            this.groupBoxTextoFijo.ResumeLayout(false);
            this.groupBoxTextoFijo.PerformLayout();
            this.groupBoxRSS.ResumeLayout(false);
            this.groupBoxRSS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNewBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNuevoBanner;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxBannerNombre;
        private System.Windows.Forms.GroupBox groupBoxFechaHora;
        private System.Windows.Forms.Label labelFechaHoraFin;
        private System.Windows.Forms.Label labelFHInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerBannerFechaInicio;
        private System.Windows.Forms.GroupBox groupBoxTipoBanner;
        private System.Windows.Forms.RadioButton radioButtonRSS;
        private System.Windows.Forms.RadioButton radioButtonTextoFijo;
        private System.Windows.Forms.DateTimePicker dateTimePickerBannerFechaFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerBannerHoraFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerBannerHoraInicio;
        private System.Windows.Forms.GroupBox groupBoxTextoFijo;
        private System.Windows.Forms.TextBox textBoxTXTTexto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxRSS;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBannerCancelar;
        private System.Windows.Forms.Button btnBannerGuardar;
        private System.Windows.Forms.DataGridView dataGridViewNewBanner;
    }
}