using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;

namespace Sistema_Cambio_Dinero
{
    /*Trabajo Final realizado por
      * Domingo Javier 12-EISN-1-157
      */


    public partial class frmtasas : Form
    {
        public frmtasas()
        {
            InitializeComponent();
            rbdolar.Checked = false;
            rbeuro.Checked = false;
            rbotras.Checked = false;
            usuario_activo();
        }


      
        private void frmtasas_Load(object sender, EventArgs e)
        {
            cargar_tasas();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                btncambiar.Enabled = true;
                btnnuevo.Enabled = true;
                btnguardar.Enabled = false;
            }
        }

        private void btncambiar_Click(object sender, EventArgs e)
        {
            btncambiar.Enabled = false;
            btnnuevo.Enabled = false;
            btnguardar.Enabled = true;
            d= 2;
        }

        OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Sistema_Cambio_Dinero\\Recursos\\BD\\Sistema_Cambio_Dinero.accdb");

    
        
        private void nuevo_guardar3()
        {
            d = 1;
            try
            {
                conexion.Open();
                OleDbCommand com = new OleDbCommand("insert into Tasas (Moneda,Compra,Venta,usuarioregistrado) Values (" + "'" + cbotras.Text + "'" + "," + "'" + txtcomprao.Text + "'" + "," + "'" + txtventao.Text + "'" + "," + "'" + lblusuario.Text + "')", conexion);
                com.ExecuteNonQuery();
                MessageBox.Show("Se ha ingresado el costo de "+cbotras.Text+" correctamente");

                if (MessageBox.Show("¿Termino la tarea deseada?", "Que hara", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {

                    frmmenu frm = new frmmenu();
                    this.Close();
                    frm.Show();
                }
                else
                {
                    btncambiar.Enabled = true;
                    btnnuevo.Enabled = true;
                    btnguardar.Enabled = false;                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();

                }

            }
        }

        int b = 0, c = 0, d=0;
        private void actualizar_guardar1()
        {
            c = 1;
            try
            {

                
                conexion.Open();
                OleDbCommand com1 = new OleDbCommand("Update Tasas Set Compra=" + "'" + txtcomprad.Text + "'" + "Where Moneda=" + "'" + lbldolar.Text + "'", conexion);
                OleDbCommand com2 = new OleDbCommand("Update Tasas Set Venta=" + "'" + txtventad.Text + "'" + "Where Moneda=" + "'" + lbldolar.Text + "'", conexion);

                com1.ExecuteNonQuery();
                com2.ExecuteNonQuery();
                
                 MessageBox.Show("Se ha actualizado las tasas correctamente");

                if (MessageBox.Show("¿Termino la tarea deseada?", "Que hara", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    frmmenu frm = new frmmenu();
                    this.Close();
                    frm.Show();
                }
                else
                {
                    btncambiar.Enabled = true;
                    btnnuevo.Enabled = true;
                    btnguardar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                    
                }
            }
        }
        private void actualizar_guardar2()
        {
            c = 2;
            try
            {


                conexion.Open();
                OleDbCommand com1 = new OleDbCommand("Update Tasas Set Compra=" + "'" + txtcomprae.Text + "'" + "Where Moneda=" + "'" + lbleuro.Text + "'", conexion);
                OleDbCommand com2 = new OleDbCommand("Update Tasas Set Venta=" + "'" + txtventae.Text + "'" + "Where Moneda=" + "'" + lbleuro.Text + "'", conexion);

                com1.ExecuteNonQuery();
                com2.ExecuteNonQuery();

                MessageBox.Show("Se ha actualizado las tasas correctamente");

                if (MessageBox.Show("¿Termino la tarea deseada?", "Que hara", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    frmmenu frm = new frmmenu();
                    this.Close();
                    frm.Show();
                }
                else
                {
                    btncambiar.Enabled = true;
                    btnnuevo.Enabled = true;
                    btnguardar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();

                }
            }
        }
        private void actualizar_guardar3()
        {
           d = 2;
            try
            {


                conexion.Open();
                OleDbCommand com3 = new OleDbCommand("Update Tasas Set Moneda=" + "'" + cbotras.Text + "'" + "Where Moneda=" + "'" + cbotras.Text + "'", conexion);
                OleDbCommand com1 = new OleDbCommand("Update Tasas Set Compra=" + "'" + txtcomprad.Text + "'" + "Where Moneda=" + "'" + lbldolar.Text + "'", conexion);
                OleDbCommand com2 = new OleDbCommand("Update Tasas Set Venta=" + "'" + txtventad.Text + "'" + "Where Moneda=" + "'" + lbldolar.Text + "'", conexion);

                com1.ExecuteNonQuery();
                com1.ExecuteNonQuery();

                MessageBox.Show("Se ha actualizado las tasas correctamente");

                if (MessageBox.Show("¿Termino la tarea deseada?", "Que hara", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    frmmenu frm = new frmmenu();
                    this.Close();
                    frm.Show();
                }
                else
                {
                    btncambiar.Enabled = true;
                    btnnuevo.Enabled = true;
                    btnguardar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();

                }
            }
        }

        private void actualizados()
        {
            if (c == 1)
            {
                actualizar_guardar1();
            }
            else
            {
                if (c == 2)
                {
                    actualizar_guardar2();
                }
                else
                {
                    if (c == 3)
                    {
                        actualizar_guardar3();
                    }
                    else
                    {
                        MessageBox.Show("No ha seleccionado una opcion.");
                    }
                }
            }
        }
        private void nuevos()
        {
            if (d == 1)
                    {
                        nuevo_guardar3();
                    }
                    else
                    {
                        MessageBox.Show("No ha seleccionado una opcion.");
                    }
                
            
        }

        private void validar_vacios()
        {
            if(txtcomprad.Text==string.Empty)
            {
                txtcomprad.Select();
                MessageBox.Show("Este valor no puede ser nulo.");
            }
            else
            {
                if(txtventad.Text==string.Empty)
            {
                txtventad.Select();
                MessageBox.Show("Este valor no puede ser nulo.");
            }
            else
            {
                if(txtcomprae.Text==string.Empty)
            {
                txtcomprae.Select();
                MessageBox.Show("Este valor no puede ser nulo.");
            }
            else
            {
                    if(txtventae.Text==string.Empty)
            {

                txtventad.Select();
                MessageBox.Show("Este valor no puede ser nulo.");
            }
            else
            {
                if(txtcomprao.Text==string.Empty)
            {
                txtcomprao.Select();
                MessageBox.Show("Este valor no puede ser nulo.");
            }
            else
            {
                if(txtventao.Text==string.Empty)
            {

                txtventao.Select();
                MessageBox.Show("Este valor no puede ser nulo.");
            }
            else
            {
            }
            }
            }
            }
            }
            }

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

        private void seleccion()
        {
            if(rbdolar.Checked==true)
            {
                c = 1;
                txtcomprad.Enabled=true;
                txtventad.Enabled=true;
                txtcomprae.Enabled=false;
                txtventae.Enabled=false;
                txtcomprao.Enabled=false;
                txtventao.Enabled=false;
                //
               
                cbotras.Enabled = true;
            }
            else
            {
            if(rbeuro.Checked==true)
            {
                c = 2;
                txtcomprae.Enabled=true;
                txtventae.Enabled=true;
                txtcomprad.Enabled=false;
                txtventad.Enabled=false;
                txtcomprao.Enabled=false;
                txtventao.Enabled=false;
                //
               
                cbotras.Enabled = true;
            }
            else
            {
                if (rbotras.Checked == true)
            {
               
                txtcomprao.Enabled=true;
                txtventao.Enabled=true;
                txtcomprae.Enabled=false;
                txtventae.Enabled=false;
                txtcomprad.Enabled=false;
                txtventad.Enabled=false;
                //
            
                cbotras.Enabled = true;
            }
            else
            {
            }
            }
            }
        }
        int a = 0;
        private void rbdolar_CheckedChanged(object sender, EventArgs e)
        {
            seleccion();
           
        }

        private void rbeuro_CheckedChanged(object sender, EventArgs e)
        {
            seleccion();
           
        }

        private void rbotras_CheckedChanged(object sender, EventArgs e)
        {
            seleccion();
           
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            validar_vacios();
            if (d == 1)
            {
                nuevos();
            }
            else
            {
                actualizados();
            }
           
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            btncambiar.Enabled = false;
            btnnuevo.Enabled = false;
            btnguardar.Enabled = true;
            d = 1;
        }

        private void cargar_tasas()
        {
            try
            {
                string sentencia1 = "Select Compra From Tasas Where Moneda='" + lbldolar.Text + "';";
                string sentencia2 = "Select Venta From Tasas Where Moneda='" + lbldolar.Text + "';";
                string sentencia3 = "Select Compra From Tasas Where Moneda='" + lbleuro.Text + "';";
                string sentencia4 = "Select Venta From Tasas Where Moneda='" + lbleuro.Text + "';";
                string sentencia5 = "Select Compra From Tasas Where Moneda='" + cbotras.Text + "';";
                string sentencia6 = "Select Venta From Tasas Where Moneda='" + cbotras.Text + "';";
                string sentencia7 = "Select Moneda From Tasas Where Moneda='" + cbotras.Text + "';";
                
                conexion.Open();
                                
                OleDbCommand com1 = new OleDbCommand(sentencia1, conexion);
                OleDbCommand com2 = new OleDbCommand(sentencia2, conexion);
                OleDbCommand com3 = new OleDbCommand(sentencia3, conexion);
                OleDbCommand com4 = new OleDbCommand(sentencia4, conexion);
                OleDbCommand com5 = new OleDbCommand(sentencia5, conexion);
                OleDbCommand com6 = new OleDbCommand(sentencia6, conexion);
                OleDbCommand com7 = new OleDbCommand(sentencia7, conexion);
                
                
                txtcomprad.Text = com1.ExecuteScalar().ToString();
                txtventad.Text = com2.ExecuteScalar().ToString();
                txtcomprae.Text = com3.ExecuteScalar().ToString();
                txtventae.Text = com4.ExecuteScalar().ToString();
                cbotras.Text = com7.ExecuteScalar().ToString();
                txtcomprao.Text = com5.ExecuteScalar().ToString();
                txtventao.Text = com6.ExecuteScalar().ToString();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
        }

        private void otras()
        {
            try
            {
               
                string sentencia5 = "Select Compra From usuarioactivo Where Moneda=" + cbotras.Text + ";";
                string sentencia6 = "Select Venta From usuarioactivo Where Moneda=" + cbotras.Text + ";";
                string sentencia7 = "Select Moneda From usuarioactivo Where Moneda=" + cbotras.Text + ";";

                conexion.Open();
;
                OleDbCommand com5 = new OleDbCommand(sentencia5, conexion);
                OleDbCommand com6 = new OleDbCommand(sentencia6, conexion);
                OleDbCommand com7 = new OleDbCommand(sentencia7, conexion);


               
                cbotras.Text = com7.ExecuteScalar().ToString();
                txtcomprao.Text = com5.ExecuteScalar().ToString();
                txtventao.Text = com6.ExecuteScalar().ToString();

            }

            catch (Exception)
            {
                MessageBox.Show("Problema con las tasas");
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
