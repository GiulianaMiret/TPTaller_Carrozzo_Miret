namespace Vista
{
    partial class FrmFuenteRSSTXTBorrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuenteRSSTXTBorrar));
            this.dataGridViewEliminar = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonRSS = new System.Windows.Forms.RadioButton();
            this.radioButtonTXT = new System.Windows.Forms.RadioButton();
            this.labelBorrar = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEliminar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewEliminar
            // 
            this.dataGridViewEliminar.AllowUserToAddRows = false;
            this.dataGridViewEliminar.AllowUserToDeleteRows = false;
            this.dataGridViewEliminar.AllowUserToResizeColumns = false;
            this.dataGridViewEliminar.AllowUserToResizeRows = false;
            this.dataGridViewEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEliminar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEliminar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Titulo,
            this.Valor,
            this.URL});
            this.dataGridViewEliminar.Location = new System.Drawing.Point(12, 72);
            this.dataGridViewEliminar.Name = "dataGridViewEliminar";
            this.dataGridViewEliminar.ReadOnly = true;
            this.dataGridViewEliminar.Size = new System.Drawing.Size(882, 296);
            this.dataGridViewEliminar.TabIndex = 0;
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
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // URL
            // 
            this.URL.DataPropertyName = "URL";
            this.URL.HeaderText = "URL";
            this.URL.Name = "URL";
            this.URL.ReadOnly = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBorrar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnBorrar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.btnBorrar.Location = new System.Drawing.Point(244, 439);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(146, 51);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButtonRSS);
            this.groupBox1.Controls.Add(this.radioButtonTXT);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(244, 370);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 53);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione el Tipo";
            // 
            // radioButtonRSS
            // 
            this.radioButtonRSS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonRSS.AutoSize = true;
            this.radioButtonRSS.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonRSS.Font = new System.Drawing.Font("Perpetua Titling MT", 12F);
            this.radioButtonRSS.ForeColor = System.Drawing.Color.White;
            this.radioButtonRSS.Location = new System.Drawing.Point(28, 19);
            this.radioButtonRSS.Name = "radioButtonRSS";
            this.radioButtonRSS.Size = new System.Drawing.Size(118, 23);
            this.radioButtonRSS.TabIndex = 22;
            this.radioButtonRSS.Text = "Fuente RSS";
            this.radioButtonRSS.UseVisualStyleBackColor = false;
            this.radioButtonRSS.CheckedChanged += new System.EventHandler(this.radioButtonRSS_CheckedChanged);
            // 
            // radioButtonTXT
            // 
            this.radioButtonTXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonTXT.AutoSize = true;
            this.radioButtonTXT.Font = new System.Drawing.Font("Perpetua Titling MT", 12F);
            this.radioButtonTXT.ForeColor = System.Drawing.Color.White;
            this.radioButtonTXT.Location = new System.Drawing.Point(234, 19);
            this.radioButtonTXT.Name = "radioButtonTXT";
            this.radioButtonTXT.Size = new System.Drawing.Size(121, 23);
            this.radioButtonTXT.TabIndex = 23;
            this.radioButtonTXT.Text = "Texto fijo";
            this.radioButtonTXT.UseVisualStyleBackColor = true;
            this.radioButtonTXT.CheckedChanged += new System.EventHandler(this.radioButtonTXT_CheckedChanged);
            // 
            // labelBorrar
            // 
            this.labelBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBorrar.AutoSize = true;
            this.labelBorrar.BackColor = System.Drawing.Color.Transparent;
            this.labelBorrar.Font = new System.Drawing.Font("Lucida Calligraphy", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBorrar.ForeColor = System.Drawing.Color.SandyBrown;
            this.labelBorrar.Location = new System.Drawing.Point(308, 9);
            this.labelBorrar.Name = "labelBorrar";
            this.labelBorrar.Size = new System.Drawing.Size(308, 45);
            this.labelBorrar.TabIndex = 26;
            this.labelBorrar.Text = "Borrar Fuentes";
            this.labelBorrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCancelar.Location = new System.Drawing.Point(478, 439);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 47);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmFuenteRSSTXTBorrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.FondoSlogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(906, 502);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.labelBorrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.dataGridViewEliminar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFuenteRSSTXTBorrar";
            this.Text = "Shout News";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEliminar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEliminar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonRSS;
        private System.Windows.Forms.RadioButton radioButtonTXT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.Label labelBorrar;
        private System.Windows.Forms.Button btnCancelar;
    }
}