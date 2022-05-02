namespace appSistemaEscolar.gui
{
    partial class frmVentana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentana));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.pibCerrar = new System.Windows.Forms.Button();
            this.panelRegistroSubMenu = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.stsVentanas = new System.Windows.Forms.StatusStrip();
            this.lblFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timHora = new System.Windows.Forms.Timer(this.components);
            this.panelSideMenu.SuspendLayout();
            this.panelRegistroSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.stsVentanas.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.Black;
            this.panelSideMenu.Controls.Add(this.pibCerrar);
            this.panelSideMenu.Controls.Add(this.panelRegistroSubMenu);
            this.panelSideMenu.Controls.Add(this.btnRegistro);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 424);
            this.panelSideMenu.TabIndex = 0;
            // 
            // pibCerrar
            // 
            this.pibCerrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pibCerrar.FlatAppearance.BorderSize = 0;
            this.pibCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pibCerrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.pibCerrar.ForeColor = System.Drawing.Color.LightGray;
            this.pibCerrar.Location = new System.Drawing.Point(0, 311);
            this.pibCerrar.Name = "pibCerrar";
            this.pibCerrar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pibCerrar.Size = new System.Drawing.Size(250, 45);
            this.pibCerrar.TabIndex = 4;
            this.pibCerrar.Text = "Salir";
            this.pibCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pibCerrar.UseVisualStyleBackColor = true;
            this.pibCerrar.Click += new System.EventHandler(this.pibCerrar_Click);
            // 
            // panelRegistroSubMenu
            // 
            this.panelRegistroSubMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelRegistroSubMenu.Controls.Add(this.button5);
            this.panelRegistroSubMenu.Controls.Add(this.button4);
            this.panelRegistroSubMenu.Controls.Add(this.button3);
            this.panelRegistroSubMenu.Controls.Add(this.button2);
            this.panelRegistroSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRegistroSubMenu.Location = new System.Drawing.Point(0, 145);
            this.panelRegistroSubMenu.Name = "panelRegistroSubMenu";
            this.panelRegistroSubMenu.Size = new System.Drawing.Size(250, 166);
            this.panelRegistroSubMenu.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.LightGray;
            this.button5.Location = new System.Drawing.Point(0, 120);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(250, 40);
            this.button5.TabIndex = 3;
            this.button5.Text = "Cursos";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.LightGray;
            this.button4.Location = new System.Drawing.Point(0, 80);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(250, 40);
            this.button4.TabIndex = 2;
            this.button4.Text = "Profesores";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.LightGray;
            this.button3.Location = new System.Drawing.Point(0, 40);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(250, 40);
            this.button3.TabIndex = 1;
            this.button3.Text = "Alumnos";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(250, 40);
            this.button2.TabIndex = 0;
            this.button2.Text = "Cargos";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.ForeColor = System.Drawing.Color.LightGray;
            this.btnRegistro.Location = new System.Drawing.Point(0, 100);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRegistro.Size = new System.Drawing.Size(250, 45);
            this.btnRegistro.TabIndex = 1;
            this.btnRegistro.Text = "Registros";
            this.btnRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Controls.Add(this.lblUsuario);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Black;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.LightGray;
            this.lblUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsuario.Location = new System.Drawing.Point(92, 34);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 37);
            this.lblUsuario.TabIndex = 0;
            // 
            // stsVentanas
            // 
            this.stsVentanas.BackColor = System.Drawing.Color.Peru;
            this.stsVentanas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.stsVentanas.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsVentanas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFecha,
            this.lblHora});
            this.stsVentanas.Location = new System.Drawing.Point(0, 400);
            this.stsVentanas.Name = "stsVentanas";
            this.stsVentanas.Size = new System.Drawing.Size(786, 24);
            this.stsVentanas.TabIndex = 5;
            this.stsVentanas.Text = "statusStrip1";
            // 
            // lblFecha
            // 
            this.lblFecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(168, 18);
            this.lblFecha.Text = "Fecha :  dd/mm/yyyy";
            // 
            // lblHora
            // 
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(121, 18);
            this.lblHora.Text = "Hora : hh:mm:ss";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelContenedor.Controls.Add(this.pictureBox1);
            this.panelContenedor.Controls.Add(this.stsVentanas);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(786, 424);
            this.panelContenedor.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(234, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timHora
            // 
            this.timHora.Enabled = true;
            this.timHora.Interval = 1000;
            this.timHora.Tick += new System.EventHandler(this.timHora_Tick);
            // 
            // frmVentana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 424);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "frmVentana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SENATI";
            this.Load += new System.EventHandler(this.frmVentana_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelRegistroSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.stsVentanas.ResumeLayout(false);
            this.stsVentanas.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button pibCerrar;
        private System.Windows.Forms.Panel panelRegistroSubMenu;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timHora;
        private System.Windows.Forms.StatusStrip stsVentanas;
        private System.Windows.Forms.ToolStripStatusLabel lblFecha;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}