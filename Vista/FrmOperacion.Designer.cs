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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOperacion));
            this.pictureBoxOperacion = new System.Windows.Forms.PictureBox();
            this.lblBanner = new System.Windows.Forms.Label();
            this.timerLabelBanner = new System.Windows.Forms.Timer(this.components);
            this.timerPictureBoxCampaña = new System.Windows.Forms.Timer(this.components);
            this.timerBanner = new System.Windows.Forms.Timer(this.components);
            this.timerCampaña = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOperacion)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOperacion
            // 
            this.pictureBoxOperacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxOperacion.InitialImage = global::Vista.Properties.Resources.Imagen1;
            this.pictureBoxOperacion.Location = new System.Drawing.Point(19, 68);
            this.pictureBoxOperacion.Name = "pictureBoxOperacion";
            this.pictureBoxOperacion.Size = new System.Drawing.Size(314, 196);
            this.pictureBoxOperacion.TabIndex = 0;
            this.pictureBoxOperacion.TabStop = false;
            // 
            // lblBanner
            // 
            this.lblBanner.AutoSize = true;
            this.lblBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBanner.Location = new System.Drawing.Point(12, 9);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Size = new System.Drawing.Size(103, 38);
            this.lblBanner.TabIndex = 1;
            this.lblBanner.Text = "label1";
            this.lblBanner.AutoSizeChanged += new System.EventHandler(this.lblBanner_AutoSizeChanged);
            // 
            // timerLabelBanner
            // 
            this.timerLabelBanner.Enabled = true;
            this.timerLabelBanner.Tick += new System.EventHandler(this.timerLabelBanner_Tick);
            // 
            // timerBanner
            // 
            this.timerBanner.Enabled = true;
            this.timerBanner.Interval = 300000;
            this.timerBanner.Tick += new System.EventHandler(this.timerBanner_Tick);
            // 
            // FrmOperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(868, 485);
            this.Controls.Add(this.lblBanner);
            this.Controls.Add(this.pictureBoxOperacion);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOperacion";
            this.Text = "Shout News";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmOperacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOperacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOperacion;
        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.Timer timerLabelBanner;
        private System.Windows.Forms.Timer timerPictureBoxCampaña;
        private System.Windows.Forms.Timer timerBanner;
        private System.Windows.Forms.Timer timerCampaña;
    }
}