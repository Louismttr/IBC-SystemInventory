using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBC_SystemInventory
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        //clasesita
        private void OcultarSubMenu()
        {
            if (pnSM_Inven.Visible == true)
                pnSM_Inven.Visible = false;
        }
        private void MostrarSubMenu(Panel Submenu)
        {
            if (Submenu.Visible == false)
            {
                OcultarSubMenu();
                Submenu.Visible = true;
            }
            else {Submenu.Visible = false;}
        }

        private void btn_Inventarios_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnSM_Inven);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
