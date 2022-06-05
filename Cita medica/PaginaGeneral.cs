using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cita_medica
{
    public partial class PaginaGeneral : Form
    {
        public PaginaGeneral()
        {
            InitializeComponent();
        }

        private void hideSubMenu()
        {
            panelReportesSubmenu.Visible = false;
     
        }

        private void showSubMenu(Panel panelReportesSubmenu)
        {
            if (panelReportesSubmenu.Visible == false)
            {
                hideSubMenu();
                panelReportesSubmenu.Visible = true;
            }
            else
                panelReportesSubmenu.Visible = false;
        }

        private void PaginaGeneral_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void panelReportesSubmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonMedicos_Click(object sender, EventArgs e)
        {

        }

        private void buttonCitas_Click(object sender, EventArgs e)
        {

        }

        private void buttonPacientes_Click(object sender, EventArgs e)
        {

        }

        private void buttonReportes_Click(object sender, EventArgs e)
        {
            {
                showSubMenu(panelReportesSubmenu;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
               
        }

        private void button7_Click(object sender, EventArgs e)
        {
            {
                open(new Form2());
                //..
                //your codes
                //..
                hidepanelReportesSubmenu();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelMenuLateral_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
