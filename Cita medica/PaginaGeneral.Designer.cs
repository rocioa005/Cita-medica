namespace Cita_medica
{
    partial class PaginaGeneral
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
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.buttonMedicos = new System.Windows.Forms.Button();
            this.buttonCitas = new System.Windows.Forms.Button();
            this.buttonPacientes = new System.Windows.Forms.Button();
            this.panelReportesSubmenu = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonReportes = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panelMenuLateral.SuspendLayout();
            this.panelReportesSubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panelMenuLateral.Controls.Add(this.panelReportesSubmenu);
            this.panelMenuLateral.Controls.Add(this.buttonReportes);
            this.panelMenuLateral.Controls.Add(this.buttonPacientes);
            this.panelMenuLateral.Controls.Add(this.buttonCitas);
            this.panelMenuLateral.Controls.Add(this.buttonMedicos);
            this.panelMenuLateral.Controls.Add(this.panelLogo);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(341, 845);
            this.panelMenuLateral.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(341, 185);
            this.panelLogo.TabIndex = 0;
            // 
            // buttonMedicos
            // 
            this.buttonMedicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(204)))));
            this.buttonMedicos.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMedicos.ForeColor = System.Drawing.Color.Black;
            this.buttonMedicos.Location = new System.Drawing.Point(45, 236);
            this.buttonMedicos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMedicos.Name = "buttonMedicos";
            this.buttonMedicos.Size = new System.Drawing.Size(256, 56);
            this.buttonMedicos.TabIndex = 1;
            this.buttonMedicos.Text = "Medicos";
            this.buttonMedicos.UseVisualStyleBackColor = false;
            this.buttonMedicos.Click += new System.EventHandler(this.buttonMedicos_Click);
            // 
            // buttonCitas
            // 
            this.buttonCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(204)))));
            this.buttonCitas.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCitas.ForeColor = System.Drawing.Color.Black;
            this.buttonCitas.Location = new System.Drawing.Point(45, 342);
            this.buttonCitas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCitas.Name = "buttonCitas";
            this.buttonCitas.Size = new System.Drawing.Size(256, 56);
            this.buttonCitas.TabIndex = 2;
            this.buttonCitas.Text = "Citas";
            this.buttonCitas.UseVisualStyleBackColor = false;
            this.buttonCitas.Click += new System.EventHandler(this.buttonCitas_Click);
            // 
            // buttonPacientes
            // 
            this.buttonPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(204)))));
            this.buttonPacientes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPacientes.ForeColor = System.Drawing.Color.Black;
            this.buttonPacientes.Location = new System.Drawing.Point(45, 450);
            this.buttonPacientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPacientes.Name = "buttonPacientes";
            this.buttonPacientes.Size = new System.Drawing.Size(256, 56);
            this.buttonPacientes.TabIndex = 3;
            this.buttonPacientes.Text = "Pacientes";
            this.buttonPacientes.UseVisualStyleBackColor = false;
            this.buttonPacientes.Click += new System.EventHandler(this.buttonPacientes_Click);
            // 
            // panelReportesSubmenu
            // 
            this.panelReportesSubmenu.BackColor = System.Drawing.Color.Transparent;
            this.panelReportesSubmenu.Controls.Add(this.button7);
            this.panelReportesSubmenu.Controls.Add(this.button6);
            this.panelReportesSubmenu.Controls.Add(this.button4);
            this.panelReportesSubmenu.Location = new System.Drawing.Point(69, 628);
            this.panelReportesSubmenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelReportesSubmenu.Name = "panelReportesSubmenu";
            this.panelReportesSubmenu.Size = new System.Drawing.Size(213, 170);
            this.panelReportesSubmenu.TabIndex = 4;
            this.panelReportesSubmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelReportesSubmenu_Paint);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(213, 50);
            this.button4.TabIndex = 0;
            this.button4.Text = "Pacientes";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonReportes
            // 
            this.buttonReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(204)))));
            this.buttonReportes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReportes.ForeColor = System.Drawing.Color.Black;
            this.buttonReportes.Location = new System.Drawing.Point(45, 564);
            this.buttonReportes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonReportes.Name = "buttonReportes";
            this.buttonReportes.Size = new System.Drawing.Size(256, 56);
            this.buttonReportes.TabIndex = 4;
            this.buttonReportes.Text = "Reportes";
            this.buttonReportes.UseVisualStyleBackColor = false;
            this.buttonReportes.Click += new System.EventHandler(this.buttonReportes_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button6.FlatAppearance.BorderSize = 3;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(0, 50);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(213, 50);
            this.button6.TabIndex = 1;
            this.button6.Text = "Medicos";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button7.FlatAppearance.BorderSize = 3;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(0, 100);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(213, 50);
            this.button7.TabIndex = 2;
            this.button7.Text = "Citas";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // PaginaGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1407, 845);
            this.Controls.Add(this.panelMenuLateral);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "PaginaGeneral";
            this.Text = "PaginaGeneral";
            this.Load += new System.EventHandler(this.PaginaGeneral_Load);
            this.panelMenuLateral.ResumeLayout(false);
            this.panelReportesSubmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panelMenuLateral;
        private Panel panelReportesSubmenu;
        private Button button7;
        private Button button6;
        private Button button4;
        private Button buttonReportes;
        private Button buttonPacientes;
        private Button buttonCitas;
        private Button buttonMedicos;
        private Panel panelLogo;
    }
}