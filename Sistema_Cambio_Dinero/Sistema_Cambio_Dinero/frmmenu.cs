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


    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();

            a = a+1;
        }

        int a = 0;

        private void btntransacion_Click(object sender, EventArgs e)
        {
            frmtransaccion frm = new frmtransaccion();
            this.Hide();
            frm.Show();
        }

        private void cerrarSeccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar seccion?", "Cerrar seccion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                frmlogin frm = new frmlogin();
                this.Hide();
                frm.Show();              
            }
        }

        private void cerrarAplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtransaccioncompra frm = new frmtransaccioncompra();
            this.Hide();
            frm.Show();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtransaccionventa frm = new frmtransaccionventa();
            this.Hide();
            frm.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar seccion?", "Cerrar seccion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                frmlogin frm = new frmlogin();
                this.Hide();
                frm.Show();
                
            }
        }

        OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Sistema_Cambio_Dinero\\Recursos\\BD\\Sistema_Cambio_Dinero.accdb");


        private void btnadministracion_Click(object sender, EventArgs e)
        {
            frmadministracion frm = new frmadministracion();
         
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmconsultacliente frm = new frmconsultacliente();
            this.Hide();
            frm.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmconsultausuario frm = new frmconsultausuario();
            this.Hide();
            frm.Show();
        }

        private void cuadroDeCajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmconsultacuadre frm = new frmconsultacuadre();
            this.Hide();
            frm.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmconsultaventa frm = new frmconsultaventa();
            this.Hide();
            frm.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmconsultacompra frm = new frmconsultacompra();
            this.Hide();
            frm.Show();
        }

        private void tasasDeCambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmconsultatasas frm = new frmconsultatasas();
            this.Hide();
            frm.Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmantenimientousuario frm = new frmmantenimientousuario();
            this.Hide();
            frm.Show();
        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            frmconsulta frm = new frmconsulta();
            this.Hide();
            frm.Show();
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            frmregistroclientes frm = new frmregistroclientes();
            this.Hide();
            frm.Show();
        }

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
        private void frmmenu_Load(object sender, EventArgs e)
        {
            
                usuario_activo();

            
        }
    }
}
