﻿namespace Vista
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.gestiónDeCampañaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCampañaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarCampañaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónDeBannersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarBannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarBannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarBannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónDeFuentesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarFuentesRSSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.agregarFuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarFuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarFuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripFrmPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOperacion
            // 
            this.btnOperacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOperacion.BackColor = System.Drawing.Color.Transparent;
            this.btnOperacion.BackgroundImage = global::Vista.Properties.Resources.Start;
            this.btnOperacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOperacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOperacion.FlatAppearance.BorderSize = 0;
            this.btnOperacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOperacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOperacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperacion.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperacion.ForeColor = System.Drawing.Color.Transparent;
            this.btnOperacion.Location = new System.Drawing.Point(493, 91);
            this.btnOperacion.Name = "btnOperacion";
            this.btnOperacion.Size = new System.Drawing.Size(346, 100);
            this.btnOperacion.TabIndex = 0;
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
            this.menuStripFrmPrincipal.Size = new System.Drawing.Size(884, 24);
            this.menuStripFrmPrincipal.TabIndex = 1;
            this.menuStripFrmPrincipal.Text = "menuStrip1";
            // 
            // administraciónDeFuentesToolStripMenuItem
            // 
            this.administraciónDeFuentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDeImagenesToolStripMenuItem,
            this.toolStripSeparator1,
            this.gestiónDeCampañaToolStripMenuItem,
            this.modificarCampañaToolStripMenuItem,
            this.borrarCampañaToolStripMenuItem});
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // gestiónDeCampañaToolStripMenuItem
            // 
            this.gestiónDeCampañaToolStripMenuItem.Name = "gestiónDeCampañaToolStripMenuItem";
            this.gestiónDeCampañaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.gestiónDeCampañaToolStripMenuItem.Text = "Agregar Campaña";
            this.gestiónDeCampañaToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeCampañaToolStripMenuItem_Click);
            // 
            // modificarCampañaToolStripMenuItem
            // 
            this.modificarCampañaToolStripMenuItem.Name = "modificarCampañaToolStripMenuItem";
            this.modificarCampañaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.modificarCampañaToolStripMenuItem.Text = "Modificar Campaña";
            this.modificarCampañaToolStripMenuItem.Click += new System.EventHandler(this.modificarCampañaToolStripMenuItem_Click);
            // 
            // borrarCampañaToolStripMenuItem
            // 
            this.borrarCampañaToolStripMenuItem.Name = "borrarCampañaToolStripMenuItem";
            this.borrarCampañaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.borrarCampañaToolStripMenuItem.Text = "Borrar Campaña";
            this.borrarCampañaToolStripMenuItem.Click += new System.EventHandler(this.borrarCampañaToolStripMenuItem_Click);
            // 
            // administraciónDeBannersToolStripMenuItem
            // 
            this.administraciónDeBannersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarBannerToolStripMenuItem,
            this.modificarBannerToolStripMenuItem,
            this.borrarBannerToolStripMenuItem});
            this.administraciónDeBannersToolStripMenuItem.Name = "administraciónDeBannersToolStripMenuItem";
            this.administraciónDeBannersToolStripMenuItem.Size = new System.Drawing.Size(161, 20);
            this.administraciónDeBannersToolStripMenuItem.Text = "Administración de Banners";
            // 
            // agregarBannerToolStripMenuItem
            // 
            this.agregarBannerToolStripMenuItem.Name = "agregarBannerToolStripMenuItem";
            this.agregarBannerToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.agregarBannerToolStripMenuItem.Text = "Agregar Banner";
            this.agregarBannerToolStripMenuItem.Click += new System.EventHandler(this.agregarBannerToolStripMenuItem_Click);
            // 
            // modificarBannerToolStripMenuItem
            // 
            this.modificarBannerToolStripMenuItem.Name = "modificarBannerToolStripMenuItem";
            this.modificarBannerToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.modificarBannerToolStripMenuItem.Text = "Modificar Banner";
            this.modificarBannerToolStripMenuItem.Click += new System.EventHandler(this.modificarBannerToolStripMenuItem_Click);
            // 
            // borrarBannerToolStripMenuItem
            // 
            this.borrarBannerToolStripMenuItem.Name = "borrarBannerToolStripMenuItem";
            this.borrarBannerToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.borrarBannerToolStripMenuItem.Text = "Borrar Banner";
            this.borrarBannerToolStripMenuItem.Click += new System.EventHandler(this.borrarBannerToolStripMenuItem_Click);
            // 
            // administraciónDeFuentesToolStripMenuItem1
            // 
            this.administraciónDeFuentesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdToolStripMenuItem,
            this.toolStripSeparator2,
            this.agregarFuenteToolStripMenuItem,
            this.modificarFuenteToolStripMenuItem,
            this.eliminarFuenteToolStripMenuItem});
            this.administraciónDeFuentesToolStripMenuItem1.Name = "administraciónDeFuentesToolStripMenuItem1";
            this.administraciónDeFuentesToolStripMenuItem1.Size = new System.Drawing.Size(160, 20);
            this.administraciónDeFuentesToolStripMenuItem1.Text = "Administración de Fuentes";
            // 
            // asdToolStripMenuItem
            // 
            this.asdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarFuentesRSSToolStripMenuItem});
            this.asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            this.asdToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.asdToolStripMenuItem.Text = "RSS";
            // 
            // actualizarFuentesRSSToolStripMenuItem
            // 
            this.actualizarFuentesRSSToolStripMenuItem.Name = "actualizarFuentesRSSToolStripMenuItem";
            this.actualizarFuentesRSSToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.actualizarFuentesRSSToolStripMenuItem.Text = "Actualizar fuentes RSS";
            this.actualizarFuentesRSSToolStripMenuItem.Click += new System.EventHandler(this.actualizarFuentesRSSToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // agregarFuenteToolStripMenuItem
            // 
            this.agregarFuenteToolStripMenuItem.Name = "agregarFuenteToolStripMenuItem";
            this.agregarFuenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarFuenteToolStripMenuItem.Text = "Agregar Fuente";
            this.agregarFuenteToolStripMenuItem.Click += new System.EventHandler(this.agregarFuenteToolStripMenuItem_Click);
            // 
            // modificarFuenteToolStripMenuItem
            // 
            this.modificarFuenteToolStripMenuItem.Name = "modificarFuenteToolStripMenuItem";
            this.modificarFuenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarFuenteToolStripMenuItem.Text = "Modificar Fuente";
            this.modificarFuenteToolStripMenuItem.Click += new System.EventHandler(this.modificarFuenteToolStripMenuItem_Click);
            // 
            // eliminarFuenteToolStripMenuItem
            // 
            this.eliminarFuenteToolStripMenuItem.Name = "eliminarFuenteToolStripMenuItem";
            this.eliminarFuenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarFuenteToolStripMenuItem.Text = "Eliminar Fuente";
            this.eliminarFuenteToolStripMenuItem.Click += new System.EventHandler(this.eliminarFuenteToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Vista.Properties.Resources.FondoPrincipal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 485);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeCampañaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarCampañaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarCampañaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarFuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarFuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarBannerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarBannerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarBannerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem actualizarFuentesRSSToolStripMenuItem;
    }
}

