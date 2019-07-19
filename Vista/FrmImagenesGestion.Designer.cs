namespace Vista
{
    partial class FrmImagenesGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImagenesGestion));
            this.labelNuevaImagen = new System.Windows.Forms.Label();
            this.btnExplorarBtn = new System.Windows.Forms.Button();
            this.comboBoxImagen = new System.Windows.Forms.ComboBox();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            this.btnInsertarImagen = new System.Windows.Forms.Button();
            this.btnBorrarImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNuevaImagen
            // 
            this.labelNuevaImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNuevaImagen.AutoSize = true;
            this.labelNuevaImagen.BackColor = System.Drawing.Color.Transparent;
            this.labelNuevaImagen.Font = new System.Drawing.Font("Lucida Calligraphy", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevaImagen.ForeColor = System.Drawing.Color.SandyBrown;
            this.labelNuevaImagen.Location = new System.Drawing.Point(-4, 9);
            this.labelNuevaImagen.Name = "labelNuevaImagen";
            this.labelNuevaImagen.Size = new System.Drawing.Size(397, 45);
            this.labelNuevaImagen.TabIndex = 18;
            this.labelNuevaImagen.Text = "Gestión de Imagenes";
            this.labelNuevaImagen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExplorarBtn
            // 
            this.btnExplorarBtn.BackColor = System.Drawing.Color.White;
            this.btnExplorarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExplorarBtn.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExplorarBtn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExplorarBtn.Location = new System.Drawing.Point(972, 60);
            this.btnExplorarBtn.Name = "btnExplorarBtn";
            this.btnExplorarBtn.Size = new System.Drawing.Size(51, 40);
            this.btnExplorarBtn.TabIndex = 20;
            this.btnExplorarBtn.Text = "...";
            this.btnExplorarBtn.UseVisualStyleBackColor = false;
            this.btnExplorarBtn.Click += new System.EventHandler(this.btnExplorarBtn_Click);
            // 
            // comboBoxImagen
            // 
            this.comboBoxImagen.Font = new System.Drawing.Font("Consolas", 20F);
            this.comboBoxImagen.FormattingEnabled = true;
            this.comboBoxImagen.Location = new System.Drawing.Point(44, 60);
            this.comboBoxImagen.Name = "comboBoxImagen";
            this.comboBoxImagen.Size = new System.Drawing.Size(909, 40);
            this.comboBoxImagen.TabIndex = 21;
            this.comboBoxImagen.SelectedIndexChanged += new System.EventHandler(this.comboBoxImagen_SelectedIndexChanged);
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.Location = new System.Drawing.Point(44, 106);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(979, 479);
            this.pictureBoxImagen.TabIndex = 22;
            this.pictureBoxImagen.TabStop = false;
            // 
            // btnInsertarImagen
            // 
            this.btnInsertarImagen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnInsertarImagen.AutoSize = true;
            this.btnInsertarImagen.BackColor = System.Drawing.Color.SandyBrown;
            this.btnInsertarImagen.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarImagen.Location = new System.Drawing.Point(271, 606);
            this.btnInsertarImagen.Name = "btnInsertarImagen";
            this.btnInsertarImagen.Size = new System.Drawing.Size(148, 45);
            this.btnInsertarImagen.TabIndex = 16;
            this.btnInsertarImagen.Text = "Insertar";
            this.btnInsertarImagen.UseVisualStyleBackColor = false;
            this.btnInsertarImagen.Click += new System.EventHandler(this.btnInsertarImagen_Click);
            // 
            // btnBorrarImagen
            // 
            this.btnBorrarImagen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBorrarImagen.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarImagen.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnBorrarImagen.Location = new System.Drawing.Point(613, 606);
            this.btnBorrarImagen.Name = "btnBorrarImagen";
            this.btnBorrarImagen.Size = new System.Drawing.Size(155, 45);
            this.btnBorrarImagen.TabIndex = 23;
            this.btnBorrarImagen.Text = "Borrar";
            this.btnBorrarImagen.UseVisualStyleBackColor = true;
            this.btnBorrarImagen.Click += new System.EventHandler(this.btnBorrarImagen_Click);
            // 
            // FrmImagenesGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 663);
            this.Controls.Add(this.btnBorrarImagen);
            this.Controls.Add(this.pictureBoxImagen);
            this.Controls.Add(this.comboBoxImagen);
            this.Controls.Add(this.btnExplorarBtn);
            this.Controls.Add(this.labelNuevaImagen);
            this.Controls.Add(this.btnInsertarImagen);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmImagenesGestion";
            this.Text = " Shout News";
            this.Load += new System.EventHandler(this.FrmGestionImagenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNuevaImagen;
        private System.Windows.Forms.Button btnExplorarBtn;
        private System.Windows.Forms.ComboBox comboBoxImagen;
        private System.Windows.Forms.PictureBox pictureBoxImagen;
        private System.Windows.Forms.Button btnInsertarImagen;
        private System.Windows.Forms.Button btnBorrarImagen;
    }
}