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

    public partial class frmcontrolacceso : Form
    {
        public frmcontrolacceso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmmenu frm = new frmmenu();
            this.Hide();
            frm.Show();
        }

        private void frmcontrolacceso_Load(object sender, EventArgs e)
        {

        }
    }
}
