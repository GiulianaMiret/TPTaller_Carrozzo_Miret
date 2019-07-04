namespace Vista
{
    partial class FrmBorrarCampania
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
            this.labelNuevaCampania = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNuevaCampania
            // 
            this.labelNuevaCampania.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNuevaCampania.AutoSize = true;
            this.labelNuevaCampania.BackColor = System.Drawing.Color.Transparent;
            this.labelNuevaCampania.Font = new System.Drawing.Font("Lucida Calligraphy", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevaCampania.ForeColor = System.Drawing.Color.SandyBrown;
            this.labelNuevaCampania.Location = new System.Drawing.Point(204, 28);
            this.labelNuevaCampania.Name = "labelNuevaCampania";
            this.labelNuevaCampania.Size = new System.Drawing.Size(336, 45);
            this.labelNuevaCampania.TabIndex = 19;
            this.labelNuevaCampania.Text = "Nueva Campaña";
            this.labelNuevaCampania.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmBorrarCampania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNuevaCampania);
            this.Name = "FrmBorrarCampania";
            this.Text = "FrmBorrarCampania";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNuevaCampania;
    }
}