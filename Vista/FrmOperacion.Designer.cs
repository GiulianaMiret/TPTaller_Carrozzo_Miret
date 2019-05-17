namespace Vista
{
    partial class FrmOperacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOperacion));
            this.pictureBoxOperacion = new System.Windows.Forms.PictureBox();
            this.textBoxOperacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOperacion)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOperacion
            // 
            this.pictureBoxOperacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxOperacion.Location = new System.Drawing.Point(307, 156);
            this.pictureBoxOperacion.Name = "pictureBoxOperacion";
            this.pictureBoxOperacion.Size = new System.Drawing.Size(168, 85);
            this.pictureBoxOperacion.TabIndex = 0;
            this.pictureBoxOperacion.TabStop = false;
            // 
            // textBoxOperacion
            // 
            this.textBoxOperacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOperacion.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOperacion.Location = new System.Drawing.Point(12, 408);
            this.textBoxOperacion.Name = "textBoxOperacion";
            this.textBoxOperacion.Size = new System.Drawing.Size(844, 41);
            this.textBoxOperacion.TabIndex = 1;
            // 
            // FrmOperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(868, 485);
            this.Controls.Add(this.textBoxOperacion);
            this.Controls.Add(this.pictureBoxOperacion);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOperacion";
            this.Text = "Shout News";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOperacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOperacion;
        private System.Windows.Forms.TextBox textBoxOperacion;
    }
}