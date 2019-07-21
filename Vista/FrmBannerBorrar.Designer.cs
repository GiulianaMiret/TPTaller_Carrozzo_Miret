namespace Vista
{
    partial class FrmBannerBorrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBannerBorrar));
            this.labelNuevaCampania = new System.Windows.Forms.Label();
            this.textBoxNombreBanner = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dataGridViewBanners = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fuente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBanners)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNuevaCampania
            // 
            this.labelNuevaCampania.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNuevaCampania.AutoSize = true;
            this.labelNuevaCampania.BackColor = System.Drawing.Color.Transparent;
            this.labelNuevaCampania.Font = new System.Drawing.Font("Lucida Calligraphy", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevaCampania.ForeColor = System.Drawing.Color.SandyBrown;
            this.labelNuevaCampania.Location = new System.Drawing.Point(267, 9);
            this.labelNuevaCampania.Name = "labelNuevaCampania";
            this.labelNuevaCampania.Size = new System.Drawing.Size(317, 45);
            this.labelNuevaCampania.TabIndex = 20;
            this.labelNuevaCampania.Text = "Borrar Banners";
            this.labelNuevaCampania.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNombreBanner
            // 
            this.textBoxNombreBanner.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreBanner.Location = new System.Drawing.Point(151, 77);
            this.textBoxNombreBanner.Name = "textBoxNombreBanner";
            this.textBoxNombreBanner.Size = new System.Drawing.Size(305, 30);
            this.textBoxNombreBanner.TabIndex = 31;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(43, 77);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(77, 19);
            this.labelNombre.TabIndex = 32;
            this.labelNombre.Text = "Nombre";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.AutoSize = true;
            this.buttonBuscar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonBuscar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(502, 75);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(120, 32);
            this.buttonBuscar.TabIndex = 34;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // dataGridViewBanners
            // 
            this.dataGridViewBanners.AllowUserToAddRows = false;
            this.dataGridViewBanners.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBanners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBanners.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewBanners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBanners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.FechaInicio,
            this.FechaFin,
            this.Fuente});
            this.dataGridViewBanners.Location = new System.Drawing.Point(47, 132);
            this.dataGridViewBanners.Name = "dataGridViewBanners";
            this.dataGridViewBanners.ReadOnly = true;
            this.dataGridViewBanners.Size = new System.Drawing.Size(715, 225);
            this.dataGridViewBanners.TabIndex = 35;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle1;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // FechaInicio
            // 
            this.FechaInicio.DataPropertyName = "FechaInicio";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            this.FechaInicio.DefaultCellStyle = dataGridViewCellStyle2;
            this.FechaInicio.HeaderText = "Fecha Inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            // 
            // FechaFin
            // 
            this.FechaFin.DataPropertyName = "FechaFin";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue;
            this.FechaFin.DefaultCellStyle = dataGridViewCellStyle3;
            this.FechaFin.HeaderText = "Fecha Fin";
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            // 
            // Fuente
            // 
            this.Fuente.DataPropertyName = "Fuente_Id";
            this.Fuente.HeaderText = "Fuente";
            this.Fuente.Name = "Fuente";
            this.Fuente.ReadOnly = true;
            this.Fuente.Visible = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBorrar.AutoSize = true;
            this.btnBorrar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnBorrar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(220, 421);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(155, 47);
            this.btnBorrar.TabIndex = 36;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCancelar.Location = new System.Drawing.Point(446, 421);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 47);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmBannerBorrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.FondoSlogo;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.dataGridViewBanners);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxNombreBanner);
            this.Controls.Add(this.labelNuevaCampania);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBannerBorrar";
            this.Text = "Shout News";
            this.Load += new System.EventHandler(this.FrmBannerBorrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBanners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNuevaCampania;
        private System.Windows.Forms.TextBox textBoxNombreBanner;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridView dataGridViewBanners;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fuente;
    }
}