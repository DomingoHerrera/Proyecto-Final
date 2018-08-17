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

    public partial class frmconsulta : Form
    {
        public frmconsulta()
        {
            InitializeComponent();
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

        private void btnusuario_Click(object sender, EventArgs e)
        {
            frmconsultausuario frm = new frmconsultausuario();
            this.Hide();
            frm.Show();
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            frmconsultacliente frm = new frmconsultacliente();
            this.Hide();
            frm.Show();
        }

        private void btntasas_Click(object sender, EventArgs e)
        {
            frmconsultatasas frm = new frmconsultatasas();
            this.Hide();
            frm.Show();
        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            frmconsultaventa frm = new frmconsultaventa();
            this.Hide();
            frm.Show();
        }

        private void btncompras_Click(object sender, EventArgs e)
        {
            frmconsultacompra frm = new frmconsultacompra();
            this.Hide();
            frm.Show();
        }

        private void btncuadre_Click(object sender, EventArgs e)
        {
            frmconsultacuadre frm = new frmconsultacuadre();
            this.Hide();
            frm.Show();
        }

        private void frmconsulta_Load(object sender, EventArgs e)
        {

        }
    }
}
