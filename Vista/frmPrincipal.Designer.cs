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
            this.buttonOperacion = new System.Windows.Forms.Button();
            this.buttonAdministracion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOperacion
            // 
            this.buttonOperacion.BackColor = System.Drawing.Color.White;
            this.buttonOperacion.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOperacion.Location = new System.Drawing.Point(279, 101);
            this.buttonOperacion.Name = "buttonOperacion";
            this.buttonOperacion.Size = new System.Drawing.Size(207, 52);
            this.buttonOperacion.TabIndex = 0;
            this.buttonOperacion.Text = "Operación";
            this.buttonOperacion.UseVisualStyleBackColor = false;
            // 
            // buttonAdministracion
            // 
            this.buttonAdministracion.BackColor = System.Drawing.Color.White;
            this.buttonAdministracion.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdministracion.Location = new System.Drawing.Point(279, 192);
            this.buttonAdministracion.Name = "buttonAdministracion";
            this.buttonAdministracion.Size = new System.Drawing.Size(207, 52);
            this.buttonAdministracion.TabIndex = 1;
            this.buttonAdministracion.Text = "Administración";
            this.buttonAdministracion.UseVisualStyleBackColor = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(499, 285);
            this.Controls.Add(this.buttonAdministracion);
            this.Controls.Add(this.buttonOperacion);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Shout News";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOperacion;
        private System.Windows.Forms.Button buttonAdministracion;
    }
}

