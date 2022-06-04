namespace Cita_medica
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtuserName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.botInicioSec = new System.Windows.Forms.Button();
            this.botAcceder = new System.Windows.Forms.Button();
            this.botSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-6, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 410);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 96);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(397, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de usuario";
            // 
            // txtuserName
            // 
            this.txtuserName.Location = new System.Drawing.Point(397, 140);
            this.txtuserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtuserName.Name = "txtuserName";
            this.txtuserName.Size = new System.Drawing.Size(181, 23);
            this.txtuserName.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(397, 213);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(181, 23);
            this.txtPass.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(397, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // botInicioSec
            // 
            this.botInicioSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.botInicioSec.FlatAppearance.BorderSize = 0;
            this.botInicioSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botInicioSec.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.botInicioSec.ForeColor = System.Drawing.Color.White;
            this.botInicioSec.Location = new System.Drawing.Point(452, 58);
            this.botInicioSec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botInicioSec.Name = "botInicioSec";
            this.botInicioSec.Size = new System.Drawing.Size(144, 26);
            this.botInicioSec.TabIndex = 5;
            this.botInicioSec.Text = "Iniciar sesion";
            this.botInicioSec.UseVisualStyleBackColor = false;
            this.botInicioSec.Click += new System.EventHandler(this.botInicioSec_Click);
            // 
            // botAcceder
            // 
            this.botAcceder.Location = new System.Drawing.Point(387, 283);
            this.botAcceder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botAcceder.Name = "botAcceder";
            this.botAcceder.Size = new System.Drawing.Size(108, 34);
            this.botAcceder.TabIndex = 7;
            this.botAcceder.Text = "Acceder";
            this.botAcceder.UseVisualStyleBackColor = true;
            this.botAcceder.Click += new System.EventHandler(this.button3_Click);
            // 
            // botSalir
            // 
            this.botSalir.Location = new System.Drawing.Point(528, 283);
            this.botSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botSalir.Name = "botSalir";
            this.botSalir.Size = new System.Drawing.Size(108, 34);
            this.botSalir.TabIndex = 8;
            this.botSalir.Text = "Salir";
            this.botSalir.UseVisualStyleBackColor = true;
            this.botSalir.Click += new System.EventHandler(this.botSalir_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(691, 393);
            this.Controls.Add(this.botSalir);
            this.Controls.Add(this.botAcceder);
            this.Controls.Add(this.botInicioSec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtuserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtuserName;
        private TextBox txtPass;
        private Label label2;
        private Button botInicioSec;
        private Button botAcceder;
        private Button botSalir;
    }
}