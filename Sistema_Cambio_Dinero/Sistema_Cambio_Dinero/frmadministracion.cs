using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Cambio_Dinero
{
    /*Trabajo Final realizado por
      * Domingo Javier 12-EISN-1-157
      */

    public partial class frmadministracion : Form
    {
        public frmadministracion()
        {
            InitializeComponent();
        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
            frmmantenimientousuario frm = new frmmantenimientousuario();
            this.Hide();
            frm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                frmmenu frm = new frmmenu();
                this.Hide();
                frm.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmtasas frm = new frmtasas();
            this.Hide();
            frm.Show();
        }

        private void frmadministracion_Load(object sender, EventArgs e)
        {

        }
    }
}
