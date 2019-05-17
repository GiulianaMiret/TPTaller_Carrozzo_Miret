namespace Vista
{
    partial class FrmAgregarImagen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarImagen));
            this.btnImagenGuardar = new System.Windows.Forms.Button();
            this.btnImagenCancelar = new System.Windows.Forms.Button();
            this.labelNuevaImagen = new System.Windows.Forms.Label();
            this.pictureBoxNuevaImagen = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNuevaImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImagenGuardar
            // 
            this.btnImagenGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImagenGuardar.AutoSize = true;
            this.btnImagenGuardar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagenGuardar.Location = new System.Drawing.Point(204, 384);
            this.btnImagenGuardar.Name = "btnImagenGuardar";
            this.btnImagenGuardar.Size = new System.Drawing.Size(134, 33);
            this.btnImagenGuardar.TabIndex = 16;
            this.btnImagenGuardar.Text = "Guardar";
            this.btnImagenGuardar.UseVisualStyleBackColor = true;
            // 
            // btnImagenCancelar
            // 
            this.btnImagenCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImagenCancelar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagenCancelar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnImagenCancelar.Location = new System.Drawing.Point(392, 384);
            this.btnImagenCancelar.Name = "btnImagenCancelar";
            this.btnImagenCancelar.Size = new System.Drawing.Size(134, 33);
            this.btnImagenCancelar.TabIndex = 17;
            this.btnImagenCancelar.Text = "Cancelar";
            this.btnImagenCancelar.UseVisualStyleBackColor = true;
            // 
            // labelNuevaImagen
            // 
            this.labelNuevaImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNuevaImagen.AutoSize = true;
            this.labelNuevaImagen.BackColor = System.Drawing.Color.Transparent;
            this.labelNuevaImagen.Font = new System.Drawing.Font("Lucida Calligraphy", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevaImagen.ForeColor = System.Drawing.Color.SandyBrown;
            this.labelNuevaImagen.Location = new System.Drawing.Point(57, 23);
            this.labelNuevaImagen.Name = "labelNuevaImagen";
            this.labelNuevaImagen.Size = new System.Drawing.Size(299, 45);
            this.labelNuevaImagen.TabIndex = 18;
            this.labelNuevaImagen.Text = "Nueva Imagen";
            this.labelNuevaImagen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxNuevaImagen
            // 
            this.pictureBoxNuevaImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxNuevaImagen.BackColor = System.Drawing.Color.White;
            this.pictureBoxNuevaImagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxNuevaImagen.BackgroundImage")));
            this.pictureBoxNuevaImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxNuevaImagen.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxNuevaImagen.InitialImage")));
            this.pictureBoxNuevaImagen.Location = new System.Drawing.Point(248, 99);
            this.pictureBoxNuevaImagen.Name = "pictureBoxNuevaImagen";
            this.pictureBoxNuevaImagen.Size = new System.Drawing.Size(234, 245);
            this.pictureBoxNuevaImagen.TabIndex = 19;
            this.pictureBoxNuevaImagen.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmAgregarImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxNuevaImagen);
            this.Controls.Add(this.labelNuevaImagen);
            this.Controls.Add(this.btnImagenCancelar);
            this.Controls.Add(this.btnImagenGuardar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAgregarImagen";
            this.Text = "Shout News";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNuevaImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImagenGuardar;
        private System.Windows.Forms.Button btnImagenCancelar;
        private System.Windows.Forms.Label labelNuevaImagen;
        private System.Windows.Forms.PictureBox pictureBoxNuevaImagen;
        private System.Windows.Forms.Button button1;
    }
}