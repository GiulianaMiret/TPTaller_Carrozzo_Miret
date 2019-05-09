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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelDescripcionFuente = new System.Windows.Forms.Label();
            this.labelURLFuente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(594, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(171, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(594, 20);
            this.textBox2.TabIndex = 1;
            // 
            // labelDescripcionFuente
            // 
            this.labelDescripcionFuente.AutoSize = true;
            this.labelDescripcionFuente.Location = new System.Drawing.Point(12, 77);
            this.labelDescripcionFuente.Name = "labelDescripcionFuente";
            this.labelDescripcionFuente.Size = new System.Drawing.Size(125, 13);
            this.labelDescripcionFuente.TabIndex = 2;
            this.labelDescripcionFuente.Text = "Descripción de la fuente:";
            // 
            // labelURLFuente
            // 
            this.labelURLFuente.AutoSize = true;
            this.labelURLFuente.Location = new System.Drawing.Point(12, 37);
            this.labelURLFuente.Name = "labelURLFuente";
            this.labelURLFuente.Size = new System.Drawing.Size(91, 13);
            this.labelURLFuente.TabIndex = 3;
            this.labelURLFuente.Text = "URL de la fuente:";
            // 
            // FrmAgregarFuente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelURLFuente);
            this.Controls.Add(this.labelDescripcionFuente);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmAgregarFuente";
            this.Text = "FrmAgregarFuente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelDescripcionFuente;
        private System.Windows.Forms.Label labelURLFuente;
    }
}