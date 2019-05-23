namespace Vista
{
    partial class FrmAgregarFuente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarFuente));
            this.textBoxURLfuente = new System.Windows.Forms.TextBox();
            this.textBoxDescripfuente = new System.Windows.Forms.TextBox();
            this.labelNuevaFuente = new System.Windows.Forms.Label();
            this.labelURL = new System.Windows.Forms.Label();
            this.labeldescfuen = new System.Windows.Forms.Label();
            this.btnFuenteGuardar = new System.Windows.Forms.Button();
            this.btnFuenteCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxURLfuente
            // 
            this.textBoxURLfuente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxURLfuente.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxURLfuente.Location = new System.Drawing.Point(173, 149);
            this.textBoxURLfuente.Name = "textBoxURLfuente";
            this.textBoxURLfuente.Size = new System.Drawing.Size(594, 30);
            this.textBoxURLfuente.TabIndex = 0;
            // 
            // textBoxDescripfuente
            // 
            this.textBoxDescripfuente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescripfuente.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescripfuente.Location = new System.Drawing.Point(173, 308);
            this.textBoxDescripfuente.Name = "textBoxDescripfuente";
            this.textBoxDescripfuente.Size = new System.Drawing.Size(594, 30);
            this.textBoxDescripfuente.TabIndex = 1;
            // 
            // labelNuevaFuente
            // 
            this.labelNuevaFuente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNuevaFuente.AutoSize = true;
            this.labelNuevaFuente.BackColor = System.Drawing.Color.Transparent;
            this.labelNuevaFuente.Font = new System.Drawing.Font("Lucida Calligraphy", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevaFuente.Location = new System.Drawing.Point(37, 28);
            this.labelNuevaFuente.Name = "labelNuevaFuente";
            this.labelNuevaFuente.Size = new System.Drawing.Size(289, 45);
            this.labelNuevaFuente.TabIndex = 5;
            this.labelNuevaFuente.Text = "Nueva Fuente";
            this.labelNuevaFuente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelURL
            // 
            this.labelURL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelURL.AutoSize = true;
            this.labelURL.BackColor = System.Drawing.Color.Transparent;
            this.labelURL.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelURL.ForeColor = System.Drawing.Color.White;
            this.labelURL.Location = new System.Drawing.Point(11, 151);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(153, 19);
            this.labelURL.TabIndex = 6;
            this.labelURL.Text = "URL de la fuente";
            // 
            // labeldescfuen
            // 
            this.labeldescfuen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labeldescfuen.AutoSize = true;
            this.labeldescfuen.BackColor = System.Drawing.Color.Transparent;
            this.labeldescfuen.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldescfuen.ForeColor = System.Drawing.Color.White;
            this.labeldescfuen.Location = new System.Drawing.Point(24, 314);
            this.labeldescfuen.Name = "labeldescfuen";
            this.labeldescfuen.Size = new System.Drawing.Size(117, 19);
            this.labeldescfuen.TabIndex = 7;
            this.labeldescfuen.Text = "Descripción";
            // 
            // btnFuenteGuardar
            // 
            this.btnFuenteGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFuenteGuardar.AutoSize = true;
            this.btnFuenteGuardar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuenteGuardar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnFuenteGuardar.Location = new System.Drawing.Point(234, 385);
            this.btnFuenteGuardar.Name = "btnFuenteGuardar";
            this.btnFuenteGuardar.Size = new System.Drawing.Size(134, 33);
            this.btnFuenteGuardar.TabIndex = 16;
            this.btnFuenteGuardar.Text = "Guardar";
            this.btnFuenteGuardar.UseVisualStyleBackColor = true;
            this.btnFuenteGuardar.Click += new System.EventHandler(this.btnFuenteGuardar_Click);
            // 
            // btnFuenteCancelar
            // 
            this.btnFuenteCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFuenteCancelar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuenteCancelar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnFuenteCancelar.Location = new System.Drawing.Point(422, 385);
            this.btnFuenteCancelar.Name = "btnFuenteCancelar";
            this.btnFuenteCancelar.Size = new System.Drawing.Size(134, 33);
            this.btnFuenteCancelar.TabIndex = 17;
            this.btnFuenteCancelar.Text = "Cancelar";
            this.btnFuenteCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmAgregarFuente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFuenteCancelar);
            this.Controls.Add(this.btnFuenteGuardar);
            this.Controls.Add(this.labeldescfuen);
            this.Controls.Add(this.labelURL);
            this.Controls.Add(this.labelNuevaFuente);
            this.Controls.Add(this.textBoxDescripfuente);
            this.Controls.Add(this.textBoxURLfuente);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.SandyBrown;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAgregarFuente";
            this.Text = "Shout News";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxURLfuente;
        private System.Windows.Forms.TextBox textBoxDescripfuente;
        private System.Windows.Forms.Label labelNuevaFuente;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.Label labeldescfuen;
        private System.Windows.Forms.Button btnFuenteGuardar;
        private System.Windows.Forms.Button btnFuenteCancelar;
    }
}