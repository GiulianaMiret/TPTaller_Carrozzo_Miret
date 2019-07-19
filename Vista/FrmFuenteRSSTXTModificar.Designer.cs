namespace Vista
{
    partial class FrmFuenteRSSTXTModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuenteRSSTXTModificar));
            this.labelModificarFuentes = new System.Windows.Forms.Label();
            this.dataGridViewModificar = new System.Windows.Forms.DataGridView();
            this.radioButtonRSS = new System.Windows.Forms.RadioButton();
            this.radioButtonTXT = new System.Windows.Forms.RadioButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.lblTextoFijo = new System.Windows.Forms.Label();
            this.textBoxTextoFijo = new System.Windows.Forms.TextBox();
            this.textBoxURLfuente = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModificar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelModificarFuentes
            // 
            this.labelModificarFuentes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelModificarFuentes.AutoSize = true;
            this.labelModificarFuentes.BackColor = System.Drawing.Color.Transparent;
            this.labelModificarFuentes.Font = new System.Drawing.Font("Lucida Calligraphy", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModificarFuentes.ForeColor = System.Drawing.Color.SandyBrown;
            this.labelModificarFuentes.Location = new System.Drawing.Point(252, 20);
            this.labelModificarFuentes.Name = "labelModificarFuentes";
            this.labelModificarFuentes.Size = new System.Drawing.Size(364, 45);
            this.labelModificarFuentes.TabIndex = 6;
            this.labelModificarFuentes.Text = "Modificar Fuentes";
            this.labelModificarFuentes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridViewModificar
            // 
            this.dataGridViewModificar.AllowUserToAddRows = false;
            this.dataGridViewModificar.AllowUserToDeleteRows = false;
            this.dataGridViewModificar.AllowUserToResizeColumns = false;
            this.dataGridViewModificar.AllowUserToResizeRows = false;
            this.dataGridViewModificar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewModificar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModificar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Titulo,
            this.Valor,
            this.URL});
            this.dataGridViewModificar.Location = new System.Drawing.Point(26, 235);
            this.dataGridViewModificar.Name = "dataGridViewModificar";
            this.dataGridViewModificar.ReadOnly = true;
            this.dataGridViewModificar.Size = new System.Drawing.Size(752, 177);
            this.dataGridViewModificar.TabIndex = 7;
            // 
            // radioButtonRSS
            // 
            this.radioButtonRSS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButtonRSS.AutoSize = true;
            this.radioButtonRSS.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonRSS.Font = new System.Drawing.Font("Perpetua Titling MT", 12F);
            this.radioButtonRSS.ForeColor = System.Drawing.Color.White;
            this.radioButtonRSS.Location = new System.Drawing.Point(39, 177);
            this.radioButtonRSS.Name = "radioButtonRSS";
            this.radioButtonRSS.Size = new System.Drawing.Size(118, 23);
            this.radioButtonRSS.TabIndex = 24;
            this.radioButtonRSS.Text = "Fuente RSS";
            this.radioButtonRSS.UseVisualStyleBackColor = false;
            this.radioButtonRSS.CheckedChanged += new System.EventHandler(this.radioButtonRSS_CheckedChanged);
            // 
            // radioButtonTXT
            // 
            this.radioButtonTXT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButtonTXT.AutoSize = true;
            this.radioButtonTXT.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonTXT.Font = new System.Drawing.Font("Perpetua Titling MT", 12F);
            this.radioButtonTXT.ForeColor = System.Drawing.Color.White;
            this.radioButtonTXT.Location = new System.Drawing.Point(39, 206);
            this.radioButtonTXT.Name = "radioButtonTXT";
            this.radioButtonTXT.Size = new System.Drawing.Size(121, 23);
            this.radioButtonTXT.TabIndex = 25;
            this.radioButtonTXT.Text = "Texto fijo";
            this.radioButtonTXT.UseVisualStyleBackColor = false;
            this.radioButtonTXT.CheckedChanged += new System.EventHandler(this.radioButtonTXT_CheckedChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(87, 100);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(70, 19);
            this.lblTitulo.TabIndex = 26;
            this.lblTitulo.Text = "Titulo";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxTitulo.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitulo.Location = new System.Drawing.Point(181, 93);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(461, 30);
            this.textBoxTitulo.TabIndex = 27;
            // 
            // lblURL
            // 
            this.lblURL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblURL.AutoSize = true;
            this.lblURL.BackColor = System.Drawing.Color.Transparent;
            this.lblURL.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURL.ForeColor = System.Drawing.Color.White;
            this.lblURL.Location = new System.Drawing.Point(12, 140);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(153, 19);
            this.lblURL.TabIndex = 28;
            this.lblURL.Text = "URL de la fuente";
            this.lblURL.Visible = false;
            // 
            // lblTextoFijo
            // 
            this.lblTextoFijo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTextoFijo.AutoSize = true;
            this.lblTextoFijo.BackColor = System.Drawing.Color.Transparent;
            this.lblTextoFijo.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoFijo.ForeColor = System.Drawing.Color.White;
            this.lblTextoFijo.Location = new System.Drawing.Point(95, 140);
            this.lblTextoFijo.Name = "lblTextoFijo";
            this.lblTextoFijo.Size = new System.Drawing.Size(65, 19);
            this.lblTextoFijo.TabIndex = 29;
            this.lblTextoFijo.Text = "Texto";
            this.lblTextoFijo.Visible = false;
            // 
            // textBoxTextoFijo
            // 
            this.textBoxTextoFijo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxTextoFijo.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTextoFijo.Location = new System.Drawing.Point(181, 133);
            this.textBoxTextoFijo.Name = "textBoxTextoFijo";
            this.textBoxTextoFijo.Size = new System.Drawing.Size(564, 30);
            this.textBoxTextoFijo.TabIndex = 30;
            this.textBoxTextoFijo.Visible = false;
            // 
            // textBoxURLfuente
            // 
            this.textBoxURLfuente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxURLfuente.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxURLfuente.Location = new System.Drawing.Point(181, 133);
            this.textBoxURLfuente.Name = "textBoxURLfuente";
            this.textBoxURLfuente.Size = new System.Drawing.Size(564, 30);
            this.textBoxURLfuente.TabIndex = 31;
            this.textBoxURLfuente.Visible = false;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonBuscar.AutoSize = true;
            this.buttonBuscar.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonBuscar.Font = new System.Drawing.Font("Copperplate Gothic Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(673, 94);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(94, 33);
            this.buttonBuscar.TabIndex = 32;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonCargar
            // 
            this.buttonCargar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonCargar.AutoSize = true;
            this.buttonCargar.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonCargar.Font = new System.Drawing.Font("Copperplate Gothic Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargar.Location = new System.Drawing.Point(229, 187);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(94, 33);
            this.buttonCargar.TabIndex = 33;
            this.buttonCargar.Text = "Cargar";
            this.buttonCargar.UseVisualStyleBackColor = false;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(229, 443);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(134, 33);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCancelar.Location = new System.Drawing.Point(443, 443);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(134, 33);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "Titulo";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Titulo.DefaultCellStyle = dataGridViewCellStyle1;
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Valor.DefaultCellStyle = dataGridViewCellStyle2;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // URL
            // 
            this.URL.DataPropertyName = "URL";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.URL.DefaultCellStyle = dataGridViewCellStyle3;
            this.URL.HeaderText = "URL";
            this.URL.Name = "URL";
            this.URL.ReadOnly = true;
            // 
            // FrmFuenteRSSTXTModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.FondoSlogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxURLfuente);
            this.Controls.Add(this.textBoxTextoFijo);
            this.Controls.Add(this.lblTextoFijo);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.radioButtonRSS);
            this.Controls.Add(this.radioButtonTXT);
            this.Controls.Add(this.dataGridViewModificar);
            this.Controls.Add(this.labelModificarFuentes);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFuenteRSSTXTModificar";
            this.Text = "Shout News";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModificar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelModificarFuentes;
        private System.Windows.Forms.DataGridView dataGridViewModificar;
        private System.Windows.Forms.RadioButton radioButtonRSS;
        private System.Windows.Forms.RadioButton radioButtonTXT;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Label lblTextoFijo;
        private System.Windows.Forms.TextBox textBoxTextoFijo;
        private System.Windows.Forms.TextBox textBoxURLfuente;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
    }
}