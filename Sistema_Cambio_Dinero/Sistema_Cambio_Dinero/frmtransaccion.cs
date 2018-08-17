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


    public partial class frmtransaccion : Form
    {
        public frmtransaccion()
        {
            InitializeComponent();
        }

        private void btncompra_Click(object sender, EventArgs e)
        {
            frmtransaccioncompra frm = new frmtransaccioncompra();
            this.Hide();
            frm.Show();
        }

        private void btnventa_Click(object sender, EventArgs e)
        {
            frmtransaccionventa frm = new frmtransaccionventa();
            this.Hide();
            frm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmmenu frm = new frmmenu();
            this.Hide();
            frm.Show();
        }

        private void frmtransaccion_Load(object sender, EventArgs e)
        {

        }
    }
}
