using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Sistema_Cambio_Dinero
{
    /*Trabajo Final realizado por
      * Domingo Javier 12-EISN-1-157
      */

    public partial class frmtransaccionventa : Form
    {
        public frmtransaccionventa()
        {
            InitializeComponent();
            usuario_activo();
        }

        OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Sistema_Cambio_Dinero\\Recursos\\BD\\Sistema_Cambio_Dinero.accdb");

        private void usuario_activo()
        {
            try
            {
                string sentencia = "Select usuarioactivo From usuarioactivo Where Id= 1;";

                conexion.Open();
                OleDbCommand com = new OleDbCommand(sentencia, conexion);
                lblusuario.Text = com.ExecuteScalar().ToString();






            }

            catch (Exception)
            {
                MessageBox.Show("Clave no valida");


            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();

                }
            }
        }

        private void frmtransaccionventa_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmtransaccioncompra frm = new frmtransaccioncompra();
            this.Hide();
            frm.Show();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                frmmenu frm = new frmmenu();
                this.Hide();
                frm.Show();
            }
        }

        private void txttmonto_TextChanged(object sender, EventArgs e)
        {
            if (txttrecibido.Text == string.Empty)
            {
                txttpesos.Clear();
                txttdevuelto.Clear();
            }
            else
            {
                if (txttmonto.Text == string.Empty)
                {
                    txttpesos.Clear();
                    txttdevuelto.Clear();
                    txtttotal.Clear();
                }
                else
                {
                    formula_devuelta();
                    formula_cambio();

                    txtttotal.Text = "US$" + txttpesos.Text + "   RD$" + txttdevuelto.Text;
                }
            }
        }
        public void formula_cambio()
        {


            double a, b, c, d;
            double cambio;

            a = double.Parse(txttmonto.Text);
            c = double.Parse(txtventa.Text);

            cambio = a / c;

            txttpesos.Text = cambio.ToString();

        }

        public void formula_devuelta()
        {



            float a, b;
            float devuelta;

            a = float.Parse(txttmonto.Text);

            b = float.Parse(txttrecibido.Text);


            devuelta = b - a;

            txttdevuelto.Text = devuelta.ToString();


        }
        
        private void validar_facturar_end()
        {
            if (txtttotal.Text != string.Empty)
            {
                btnfacturar.Enabled = true;
            }
            else
            {
                btnfacturar.Enabled = false;
            }
        }

        private void txttrecibido_TextChanged(object sender, EventArgs e)
        {
            if (txttrecibido.Text == string.Empty)
            {
                txttpesos.Clear();
                txttdevuelto.Clear();
                txtttotal.Clear();

            }
            else
            {
            }
        }

        private void txtttotal_TextChanged(object sender, EventArgs e)
        {
            validar_facturar_end();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmtasas frm = new frmtasas();
           
            frm.Show();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txttcodigo.Clear();
            txttdevuelto.Clear();
            txttmonto.Clear();
            txttpesos.Clear();
            txttrecibido.Clear();
            txtttotal.Clear();
        }
    }
}
