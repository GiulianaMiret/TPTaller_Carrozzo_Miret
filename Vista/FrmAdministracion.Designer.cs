namespace Vista
{
    partial class FrmAdministracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministracion));
            this.buttonAdmCampania = new System.Windows.Forms.Button();
            this.buttonNewBanner = new System.Windows.Forms.Button();
            this.labelAdmCampania = new System.Windows.Forms.Label();
            this.labelAdmBanner = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdmCampania
            // 
            this.buttonAdmCampania.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdmCampania.AutoSize = true;
            this.buttonAdmCampania.BackColor = System.Drawing.Color.White;
            this.buttonAdmCampania.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdmCampania.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmCampania.Location = new System.Drawing.Point(574, 88);
            this.buttonAdmCampania.Name = "buttonAdmCampania";
            this.buttonAdmCampania.Size = new System.Drawing.Size(148, 43);
            this.buttonAdmCampania.TabIndex = 0;
            this.buttonAdmCampania.Text = "Campañas";
            this.buttonAdmCampania.UseVisualStyleBackColor = false;
            // 
            // buttonNewBanner
            // 
            this.buttonNewBanner.BackColor = System.Drawing.Color.White;
            this.buttonNewBanner.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewBanner.Location = new System.Drawing.Point(304, 224);
            this.buttonNewBanner.Name = "buttonNewBanner";
            this.buttonNewBanner.Size = new System.Drawing.Size(148, 43);
            this.buttonNewBanner.TabIndex = 1;
            this.buttonNewBanner.Text = "Nuevo Banner";
            this.buttonNewBanner.UseVisualStyleBackColor = false;
            // 
            // labelAdmCampania
            // 
            this.labelAdmCampania.AutoSize = true;
            this.labelAdmCampania.BackColor = System.Drawing.Color.Transparent;
            this.labelAdmCampania.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmCampania.ForeColor = System.Drawing.Color.White;
            this.labelAdmCampania.Location = new System.Drawing.Point(543, 37);
            this.labelAdmCampania.Name = "labelAdmCampania";
            this.labelAdmCampania.Size = new System.Drawing.Size(155, 38);
            this.labelAdmCampania.TabIndex = 2;
            this.labelAdmCampania.Text = "Campañas";
            // 
            // labelAdmBanner
            // 
            this.labelAdmBanner.AutoSize = true;
            this.labelAdmBanner.BackColor = System.Drawing.Color.Transparent;
            this.labelAdmBanner.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmBanner.ForeColor = System.Drawing.Color.White;
            this.labelAdmBanner.Location = new System.Drawing.Point(297, 174);
            this.labelAdmBanner.Name = "labelAdmBanner";
            this.labelAdmBanner.Size = new System.Drawing.Size(125, 38);
            this.labelAdmBanner.TabIndex = 2;
            this.labelAdmBanner.Text = "Banners";
            // 
            // FrmAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(867, 489);
            this.Controls.Add(this.labelAdmBanner);
            this.Controls.Add(this.labelAdmCampania);
            this.Controls.Add(this.buttonNewBanner);
            this.Controls.Add(this.buttonAdmCampania);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdministracion";
            this.Text = "Shout News";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdmCampania;
        private System.Windows.Forms.Button buttonNewBanner;
        private System.Windows.Forms.Label labelAdmCampania;
        private System.Windows.Forms.Label labelAdmBanner;
    }
}