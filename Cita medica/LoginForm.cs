using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CitaMedicaDll.Models;

namespace Cita_medica
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }




        //Botones
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CitaMedicaDll.DB.UsuarioRepo usuarioRepo = new CitaMedicaDll.DB.UsuarioRepo();

            Usuario userData = usuarioRepo.Login(txtuserName.Text);

            if (userData.UserName == null) 
            {
                MessageBox.Show("Usuario y/o contrasenna incorrectos");
                txtuserName.Text = "";
                txtPass.Text = "";

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
















        }

        private void botInicioSec_Click(object sender, EventArgs e)
        {

        }

        private void botSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
