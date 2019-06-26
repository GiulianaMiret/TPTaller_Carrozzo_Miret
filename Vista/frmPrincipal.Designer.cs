namespace Vista
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnOperacion = new System.Windows.Forms.Button();
            this.menuStripFrmPrincipal = new System.Windows.Forms.MenuStrip();
            this.administraciónDeFuentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeImagenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónDeBannersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónDeFuentesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarFuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripFrmPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOperacion
            // 
            this.btnOperacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOperacion.BackColor = System.Drawing.Color.White;
            this.btnOperacion.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperacion.Location = new System.Drawing.Point(118, 115);
            this.btnOperacion.Name = "btnOperacion";
            this.btnOperacion.Size = new System.Drawing.Size(239, 79);
            this.btnOperacion.TabIndex = 0;
            this.btnOperacion.Text = "INICIAR";
            this.btnOperacion.UseVisualStyleBackColor = false;
            this.btnOperacion.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // menuStripFrmPrincipal
            // 
            this.menuStripFrmPrincipal.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStripFrmPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraciónDeFuentesToolStripMenuItem,
            this.administraciónDeBannersToolStripMenuItem,
            this.administraciónDeFuentesToolStripMenuItem1});
            this.menuStripFrmPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripFrmPrincipal.Name = "menuStripFrmPrincipal";
            this.menuStripFrmPrincipal.Size = new System.Drawing.Size(507, 24);
            this.menuStripFrmPrincipal.TabIndex = 1;
            this.menuStripFrmPrincipal.Text = "menuStrip1";
            // 
            // administraciónDeFuentesToolStripMenuItem
            // 
            this.administraciónDeFuentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDeImagenesToolStripMenuItem});
            this.administraciónDeFuentesToolStripMenuItem.Name = "administraciónDeFuentesToolStripMenuItem";
            this.administraciónDeFuentesToolStripMenuItem.Size = new System.Drawing.Size(175, 20);
            this.administraciónDeFuentesToolStripMenuItem.Text = "Administración de Campañas";
            // 
            // gestiónDeImagenesToolStripMenuItem
            // 
            this.gestiónDeImagenesToolStripMenuItem.Name = "gestiónDeImagenesToolStripMenuItem";
            this.gestiónDeImagenesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.gestiónDeImagenesToolStripMenuItem.Text = "Gestión de Imagenes";
            this.gestiónDeImagenesToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeImagenesToolStripMenuItem_Click);
            // 
            // administraciónDeBannersToolStripMenuItem
            // 
            this.administraciónDeBannersToolStripMenuItem.Name = "administraciónDeBannersToolStripMenuItem";
            this.administraciónDeBannersToolStripMenuItem.Size = new System.Drawing.Size(161, 20);
            this.administraciónDeBannersToolStripMenuItem.Text = "Administración de Banners";
            // 
            // administraciónDeFuentesToolStripMenuItem1
            // 
            this.administraciónDeFuentesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarFuenteToolStripMenuItem});
            this.administraciónDeFuentesToolStripMenuItem1.Name = "administraciónDeFuentesToolStripMenuItem1";
            this.administraciónDeFuentesToolStripMenuItem1.Size = new System.Drawing.Size(160, 20);
            this.administraciónDeFuentesToolStripMenuItem1.Text = "Administración de Fuentes";
            // 
            // agregarFuenteToolStripMenuItem
            // 
            this.agregarFuenteToolStripMenuItem.Name = "agregarFuenteToolStripMenuItem";
            this.agregarFuenteToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.agregarFuenteToolStripMenuItem.Text = "Agregar fuente";
            this.agregarFuenteToolStripMenuItem.Click += new System.EventHandler(this.agregarFuenteToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(507, 280);
            this.Controls.Add(this.btnOperacion);
            this.Controls.Add(this.menuStripFrmPrincipal);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripFrmPrincipal;
            this.Name = "FrmPrincipal";
            this.Text = "Shout News";
            this.menuStripFrmPrincipal.ResumeLayout(false);
            this.menuStripFrmPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOperacion;
        private System.Windows.Forms.MenuStrip menuStripFrmPrincipal;
        private System.Windows.Forms.ToolStripMenuItem administraciónDeFuentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónDeBannersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónDeFuentesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarFuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeImagenesToolStripMenuItem;
    }
}

