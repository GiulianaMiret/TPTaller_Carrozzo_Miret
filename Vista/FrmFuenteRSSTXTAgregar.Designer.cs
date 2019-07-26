namespace Vista
{
    partial class FrmFuenteRSSTXTAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuenteRSSTXTAgregar));
            this.textBoxURLfuente = new System.Windows.Forms.TextBox();
            this.labelNuevaFuente = new System.Windows.Forms.Label();
            this.lblURL = new System.Windows.Forms.Label();
            this.btnFuenteGuardar = new System.Windows.Forms.Button();
            this.btnFuenteCancelar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonRSS = new System.Windows.Forms.RadioButton();
            this.radioButtonTXT = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblTextoFijo = new System.Windows.Forms.Label();
            this.textBoxTextoFijo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rSSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarValoresDeFuentesRSSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxURLfuente
            // 
            this.textBoxURLfuente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxURLfuente.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxURLfuente.Location = new System.Drawing.Point(173, 282);
            this.textBoxURLfuente.Name = "textBoxURLfuente";
            this.textBoxURLfuente.Size = new System.Drawing.Size(1035, 30);
            this.textBoxURLfuente.TabIndex = 0;
            this.textBoxURLfuente.Visible = false;
            // 
            // labelNuevaFuente
            // 
            this.labelNuevaFuente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNuevaFuente.AutoSize = true;
            this.labelNuevaFuente.BackColor = System.Drawing.Color.Transparent;
            this.labelNuevaFuente.Font = new System.Drawing.Font("Lucida Calligraphy", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevaFuente.Location = new System.Drawing.Point(392, 25);
            this.labelNuevaFuente.Name = "labelNuevaFuente";
            this.labelNuevaFuente.Size = new System.Drawing.Size(289, 45);
            this.labelNuevaFuente.TabIndex = 5;
            this.labelNuevaFuente.Text = "Nueva Fuente";
            this.labelNuevaFuente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblURL
            // 
            this.lblURL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblURL.AutoSize = true;
            this.lblURL.BackColor = System.Drawing.Color.Transparent;
            this.lblURL.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURL.ForeColor = System.Drawing.Color.White;
            this.lblURL.Location = new System.Drawing.Point(12, 289);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(153, 19);
            this.lblURL.TabIndex = 6;
            this.lblURL.Text = "URL de la fuente";
            this.lblURL.Visible = false;
            // 
            // btnFuenteGuardar
            // 
            this.btnFuenteGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFuenteGuardar.AutoSize = true;
            this.btnFuenteGuardar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuenteGuardar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnFuenteGuardar.Location = new System.Drawing.Point(381, 494);
            this.btnFuenteGuardar.Name = "btnFuenteGuardar";
            this.btnFuenteGuardar.Size = new System.Drawing.Size(188, 44);
            this.btnFuenteGuardar.TabIndex = 16;
            this.btnFuenteGuardar.Text = "Guardar";
            this.btnFuenteGuardar.UseVisualStyleBackColor = true;
            this.btnFuenteGuardar.Click += new System.EventHandler(this.btnFuenteGuardar_Click);
            // 
            // btnFuenteCancelar
            // 
            this.btnFuenteCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFuenteCancelar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuenteCancelar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnFuenteCancelar.Location = new System.Drawing.Point(608, 494);
            this.btnFuenteCancelar.Name = "btnFuenteCancelar";
            this.btnFuenteCancelar.Size = new System.Drawing.Size(188, 44);
            this.btnFuenteCancelar.TabIndex = 17;
            this.btnFuenteCancelar.Text = "Cancelar";
            this.btnFuenteCancelar.UseVisualStyleBackColor = true;
            this.btnFuenteCancelar.Click += new System.EventHandler(this.btnFuenteCancelar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 214);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(70, 19);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(194, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(585, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ejemplo:  http://www.lapoliticaonline.com/files/rss/economia.xml";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(-24, 604);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1017, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "NOTA: Para guardar una nueva fuente RSS se necesita de conexión a internet para v" +
    "alidar si la misma es correcta.";
            // 
            // radioButtonRSS
            // 
            this.radioButtonRSS.AutoSize = true;
            this.radioButtonRSS.Font = new System.Drawing.Font("Perpetua Titling MT", 12F);
            this.radioButtonRSS.ForeColor = System.Drawing.Color.White;
            this.radioButtonRSS.Location = new System.Drawing.Point(3, 9);
            this.radioButtonRSS.Name = "radioButtonRSS";
            this.radioButtonRSS.Size = new System.Drawing.Size(118, 23);
            this.radioButtonRSS.TabIndex = 22;
            this.radioButtonRSS.Text = "Fuente RSS";
            this.radioButtonRSS.UseVisualStyleBackColor = true;
            this.radioButtonRSS.CheckedChanged += new System.EventHandler(this.radioButtonRSS_CheckedChanged);
            // 
            // radioButtonTXT
            // 
            this.radioButtonTXT.AutoSize = true;
            this.radioButtonTXT.Font = new System.Drawing.Font("Perpetua Titling MT", 12F);
            this.radioButtonTXT.ForeColor = System.Drawing.Color.White;
            this.radioButtonTXT.Location = new System.Drawing.Point(3, 38);
            this.radioButtonTXT.Name = "radioButtonTXT";
            this.radioButtonTXT.Size = new System.Drawing.Size(121, 23);
            this.radioButtonTXT.TabIndex = 23;
            this.radioButtonTXT.Text = "Texto fijo";
            this.radioButtonTXT.UseVisualStyleBackColor = true;
            this.radioButtonTXT.CheckedChanged += new System.EventHandler(this.radioButtonTXT_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButtonRSS);
            this.groupBox1.Controls.Add(this.radioButtonTXT);
            this.groupBox1.Location = new System.Drawing.Point(170, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 65);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipo.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(12, 127);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(48, 19);
            this.lblTipo.TabIndex = 25;
            this.lblTipo.Text = "TIPO";
            // 
            // lblTextoFijo
            // 
            this.lblTextoFijo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTextoFijo.AutoSize = true;
            this.lblTextoFijo.BackColor = System.Drawing.Color.Transparent;
            this.lblTextoFijo.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoFijo.ForeColor = System.Drawing.Color.White;
            this.lblTextoFijo.Location = new System.Drawing.Point(17, 289);
            this.lblTextoFijo.Name = "lblTextoFijo";
            this.lblTextoFijo.Size = new System.Drawing.Size(65, 19);
            this.lblTextoFijo.TabIndex = 26;
            this.lblTextoFijo.Text = "Texto";
            this.lblTextoFijo.Visible = false;
            // 
            // textBoxTextoFijo
            // 
            this.textBoxTextoFijo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTextoFijo.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTextoFijo.Location = new System.Drawing.Point(173, 282);
            this.textBoxTextoFijo.Name = "textBoxTextoFijo";
            this.textBoxTextoFijo.Size = new System.Drawing.Size(1035, 30);
            this.textBoxTextoFijo.TabIndex = 27;
            this.textBoxTextoFijo.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(227, 388);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 28;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1241, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rSSToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // rSSToolStripMenuItem
            // 
            this.rSSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarValoresDeFuentesRSSToolStripMenuItem});
            this.rSSToolStripMenuItem.Name = "rSSToolStripMenuItem";
            this.rSSToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.rSSToolStripMenuItem.Text = "RSS";
            // 
            // actualizarValoresDeFuentesRSSToolStripMenuItem
            // 
            this.actualizarValoresDeFuentesRSSToolStripMenuItem.Name = "actualizarValoresDeFuentesRSSToolStripMenuItem";
            this.actualizarValoresDeFuentesRSSToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.actualizarValoresDeFuentesRSSToolStripMenuItem.Text = "Actualizar valores de Fuentes RSS";
            this.actualizarValoresDeFuentesRSSToolStripMenuItem.Click += new System.EventHandler(this.actualizarValoresDeFuentesRSSToolStripMenuItem_Click);
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTitulo.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitulo.Location = new System.Drawing.Point(173, 207);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(1035, 30);
            this.textBoxTitulo.TabIndex = 19;
            // 
            // FrmFuenteRSSTXTAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1241, 629);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxTextoFijo);
            this.Controls.Add(this.lblTextoFijo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnFuenteCancelar);
            this.Controls.Add(this.btnFuenteGuardar);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.labelNuevaFuente);
            this.Controls.Add(this.textBoxURLfuente);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.SandyBrown;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmFuenteRSSTXTAgregar";
            this.Text = "Shout News";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxURLfuente;
        private System.Windows.Forms.Label labelNuevaFuente;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Button btnFuenteGuardar;
        private System.Windows.Forms.Button btnFuenteCancelar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonRSS;
        private System.Windows.Forms.RadioButton radioButtonTXT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblTextoFijo;
        private System.Windows.Forms.TextBox textBoxTextoFijo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rSSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarValoresDeFuentesRSSToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxTitulo;
    }
}