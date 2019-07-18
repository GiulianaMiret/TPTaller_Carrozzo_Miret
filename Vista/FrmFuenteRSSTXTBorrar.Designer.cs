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
            this.dataGridViewEliminar = new System.Windows.Forms.DataGridView();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonRSS = new System.Windows.Forms.RadioButton();
            this.radioButtonTXT = new System.Windows.Forms.RadioButton();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridViewEliminar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEliminar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Titulo,
            this.Valor,
            this.URL});
            this.dataGridViewEliminar.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewEliminar.Name = "dataGridViewEliminar";
            this.dataGridViewEliminar.ReadOnly = true;
            this.dataGridViewEliminar.Size = new System.Drawing.Size(882, 414);
            this.dataGridViewEliminar.TabIndex = 0;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.Location = new System.Drawing.Point(148, 441);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(746, 51);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.radioButtonRSS);
            this.groupBox1.Controls.Add(this.radioButtonTXT);
            this.groupBox1.Location = new System.Drawing.Point(6, 432);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 65);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonRSS
            // 
            this.radioButtonRSS.AutoSize = true;
            this.radioButtonRSS.Font = new System.Drawing.Font("Perpetua Titling MT", 12F);
            this.radioButtonRSS.Location = new System.Drawing.Point(3, 9);
            this.radioButtonRSS.Name = "radioButtonRSS";
            this.radioButtonRSS.Size = new System.Drawing.Size(118, 23);
            this.radioButtonRSS.TabIndex = 22;
            this.radioButtonRSS.Text = "Fuente RSS";
            this.radioButtonRSS.UseVisualStyleBackColor = true;
            this.radioButtonRSS.CheckedChanged += new System.EventHandler(this.radioButtonRSS_CheckedChanged);
            // 
            // radioButtonTXT
            // 
            this.radioButtonTXT.AutoSize = true;
            this.radioButtonTXT.Font = new System.Drawing.Font("Perpetua Titling MT", 12F);
            this.radioButtonTXT.Location = new System.Drawing.Point(3, 38);
            this.radioButtonTXT.Name = "radioButtonTXT";
            this.radioButtonTXT.Size = new System.Drawing.Size(121, 23);
            this.radioButtonTXT.TabIndex = 23;
            this.radioButtonTXT.Text = "Texto fijo";
            this.radioButtonTXT.UseVisualStyleBackColor = true;
            this.radioButtonTXT.CheckedChanged += new System.EventHandler(this.radioButtonTXT_CheckedChanged);
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
            // FrmFuenteRSSTXTBorrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 502);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.dataGridViewEliminar);
            this.Name = "FrmFuenteRSSTXTBorrar";
            this.Text = "Borrar fuente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEliminar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}