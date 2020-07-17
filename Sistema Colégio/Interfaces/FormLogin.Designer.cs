namespace SistemaColegioMLBS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.txContrasena = new System.Windows.Forms.TextBox();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label1 = new System.Windows.Forms.Label();
            this.btlogin = new System.Windows.Forms.Button();
            this.lnbcontra = new System.Windows.Forms.LinkLabel();
            this.btcerrar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 316);
            this.panel1.TabIndex = 0;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(584, 316);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 273;
            this.lineShape1.X2 = 540;
            this.lineShape1.Y1 = 142;
            this.lineShape1.Y2 = 142;
            this.lineShape1.Click += new System.EventHandler(this.lineShape1_Click);
            // 
            // txUsuario
            // 
            this.txUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(227)))), ((int)(((byte)(221)))));
            this.txUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txUsuario.ForeColor = System.Drawing.Color.DarkBlue;
            this.txUsuario.Location = new System.Drawing.Point(273, 115);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(268, 16);
            this.txUsuario.TabIndex = 3;
            this.txUsuario.Text = "USUARIO";
            this.txUsuario.Enter += new System.EventHandler(this.txUsuario_Enter);
            // 
            // txContrasena
            // 
            this.txContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(227)))), ((int)(((byte)(221)))));
            this.txContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txContrasena.ForeColor = System.Drawing.Color.DarkBlue;
            this.txContrasena.Location = new System.Drawing.Point(273, 176);
            this.txContrasena.Name = "txContrasena";
            this.txContrasena.Size = new System.Drawing.Size(268, 16);
            this.txContrasena.TabIndex = 4;
            this.txContrasena.Text = "CONTRASEÑA";
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 267;
            this.lineShape2.X2 = 534;
            this.lineShape2.Y1 = 199;
            this.lineShape2.Y2 = 199;
            this.lineShape2.Click += new System.EventHandler(this.lineShape1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sistema de Gestión Académica\r\n                      y \r\n        Registro Arancela" +
    "rio ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btlogin
            // 
            this.btlogin.BackColor = System.Drawing.Color.Silver;
            this.btlogin.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btlogin.FlatAppearance.BorderSize = 0;
            this.btlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btlogin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btlogin.ForeColor = System.Drawing.Color.DarkBlue;
            this.btlogin.Location = new System.Drawing.Point(320, 234);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(175, 29);
            this.btlogin.TabIndex = 6;
            this.btlogin.Text = "ACCEDER";
            this.btlogin.UseVisualStyleBackColor = false;
            // 
            // lnbcontra
            // 
            this.lnbcontra.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lnbcontra.AutoSize = true;
            this.lnbcontra.LinkColor = System.Drawing.Color.DarkBlue;
            this.lnbcontra.Location = new System.Drawing.Point(336, 266);
            this.lnbcontra.Name = "lnbcontra";
            this.lnbcontra.Size = new System.Drawing.Size(148, 13);
            this.lnbcontra.TabIndex = 7;
            this.lnbcontra.TabStop = true;
            this.lnbcontra.Text = "¿Has olvidado la contraseña?";
            // 
            // btcerrar
            // 
            this.btcerrar.Image = ((System.Drawing.Image)(resources.GetObject("btcerrar.Image")));
            this.btcerrar.Location = new System.Drawing.Point(561, 3);
            this.btcerrar.Name = "btcerrar";
            this.btcerrar.Size = new System.Drawing.Size(20, 20);
            this.btcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btcerrar.TabIndex = 8;
            this.btcerrar.TabStop = false;
            // 
            // btnminimizar
            // 
            this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
            this.btnminimizar.Location = new System.Drawing.Point(535, 3);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(20, 20);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnminimizar.TabIndex = 9;
            this.btnminimizar.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 89);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(213, 205);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.label2.Location = new System.Drawing.Point(387, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(227)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(584, 316);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnminimizar);
            this.Controls.Add(this.btcerrar);
            this.Controls.Add(this.lnbcontra);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.txContrasena);
            this.Controls.Add(this.txUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.TextBox txUsuario;
        private System.Windows.Forms.TextBox txContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.LinkLabel lnbcontra;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox btcerrar;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.Label label2;
    }
}

