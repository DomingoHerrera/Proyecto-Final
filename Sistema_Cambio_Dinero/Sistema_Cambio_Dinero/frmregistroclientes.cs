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


    public partial class frmregistroclientes : Form
    {
        public frmregistroclientes()
        {
            InitializeComponent();
            usuario_activo();
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

        private void limpiar()
        {
            txtapellido.Clear();
            txtcedula.Clear();
            txtcedula.Clear();
            txtcelular.Clear();
            txtcodigo.Clear();
            txtcorreo.Clear();
            txtdireccion.Clear();
            txtnombre.Clear();
            txttelefono.Clear();
            btnguardar.Enabled = false;
            btnactualizar.Enabled = true;
            btnborrar.Enabled = true;
            btnnuevo.Enabled = true;  
        }

        private void nuevo()
        {
            txtapellido.Enabled = true;
            txtcedula.Enabled = true;
            txtcelular.Enabled = true;
            txtcorreo.Enabled = true;
            txtdireccion.Enabled = true;
            txtnombre.Enabled = true;
            txttelefono.Enabled = true;
            btnguardar.Enabled = true;
            btnactualizar.Enabled = false;
            btnborrar.Enabled = false;
            btnnuevo.Enabled = false;
        }

        private void borrar()
        {
            txtcodigo.Enabled = true;
            btnguardar.Enabled = true;
            btnactualizar.Enabled = false;
            btnborrar.Enabled = false;
            btnnuevo.Enabled = false;
        }

        private void actualizar()
        {
            txtcodigo.Enabled = true;
            btnguardar.Enabled = true;
            btnactualizar.Enabled = false;
            btnborrar.Enabled = false;
            btnnuevo.Enabled = false;
        }
        int codigo = 0;

        private void nuevo_guardar()


        {
            try
            {
                conexion.Open();
                OleDbCommand com = new OleDbCommand("insert into cliente (Nombre,Apellido,Correo,Cedula,Telefono,Celular,Direccion,usuarioregistrado) Values (" + "'" + txtnombre.Text + "'" + "," + "'" + txtapellido.Text + "'" + "," + "'" + txtcorreo.Text + "'" + "," + "'" + txtcedula.Text + "'" + "," + "'" + txttelefono.Text + "'" + "," + "'" + txtcelular.Text + "'" + "," + "'" + txtdireccion.Text + "'," + "'" + lblusuario.Text + "')", conexion);
                com.ExecuteNonQuery();
                MessageBox.Show("Se ha ingresado el cliente correctamente");

                if (MessageBox.Show("¿Termino la tarea deseada?", "Que hara", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {

                    frmmenu frm = new frmmenu();
                    this.Close();
                    frm.Show();
                }
                else
                {
                    limpiar();
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

        private void actualizar_guardar()
        {
            try
            {

                codigo = int.Parse(txtcodigo.Text);

                conexion.Open();
                OleDbCommand com1 = new OleDbCommand("Update cliente Set Nombre=" + "'" + txtnombre.Text + "'" + "Where Codigo=" + "" + codigo + "", conexion);
                OleDbCommand com2 = new OleDbCommand("Update cliente Set Apellido=" + "'" + txtapellido.Text + "'" + "Where Codigo=" + "" + codigo + "", conexion);
                OleDbCommand com3 = new OleDbCommand("Update cliente Set Correo=" + "'" + txtcorreo.Text + "'" + "Where Codigo=" + "" + codigo + "", conexion);
                OleDbCommand com4 = new OleDbCommand("Update cliente Set Cedula=" + "'" + txtcedula.Text + "'" + "Where Codigo=" + "" + codigo + "", conexion);
                OleDbCommand com5 = new OleDbCommand("Update cliente Set Telefono=" + "'" + txttelefono.Text + "'" + "Where Codigo=" + "" + codigo + "", conexion);
                OleDbCommand com6 = new OleDbCommand("Update cliente Set Celular=" + "'" + txtcelular.Text + "'" + "Where Codigo=" + "" + codigo + "", conexion);
                OleDbCommand com7 = new OleDbCommand("Update cliente Set Direccion=" + "'" + txtdireccion.Text + "'" + "Where Codigo=" + "" + codigo + "", conexion);
                OleDbCommand com8 = new OleDbCommand("Update cliente Set usuarioregistrado=" + "'" + lblusuario.Text + "'" + "Where Codigo=" + "" + codigo + "", conexion);


                com1.ExecuteNonQuery();
                com2.ExecuteNonQuery();
                com3.ExecuteNonQuery();
                com4.ExecuteNonQuery();
                com5.ExecuteNonQuery();
                com6.ExecuteNonQuery();
                com7.ExecuteNonQuery();
                com8.ExecuteNonQuery();

                MessageBox.Show("Se ha actualizado el cliente correctamente");

                if (MessageBox.Show("¿Termino la tarea deseada?", "Que hara", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    frmmenu frm = new frmmenu();
                    this.Close();
                    frm.Show();
                }
                else
                {
                    limpiar();
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

        private void borrar_guardar()
        {
            try
            {
                codigo = int.Parse(txtcodigo.Text);
                string sentencia = "Delete From cliente Where Codigo=" + codigo + ";";
                conexion.Open();
                OleDbCommand com = new OleDbCommand(sentencia, conexion);

                com.ExecuteNonQuery();
                MessageBox.Show("Se ha borrado el cliente correctamente");

                if (MessageBox.Show("¿Termino la tarea deseada?", "Que hara", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    frmmenu frm = new frmmenu();
                    this.Close();
                    frm.Show();
                }
                else
                {
                    limpiar();
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

                else
                {

                }
            }
        }

        private void validar_actualizar()
        {
            if (txtcodigo.Text == string.Empty)
            {
                MessageBox.Show("No ha introducido ningun dato.");
                txtcodigo.Select();
            }
            else
            {
                if (txtnombre.Text == string.Empty)
                {
                    MessageBox.Show("No ha introducido ningun dato.");
                    txtnombre.Select();
                }
                else
                {
                    if (txtapellido.Text == string.Empty)
                    {
                        MessageBox.Show("No ha introducido ningun dato.");
                        txtapellido.Select();
                    }
                    else
                    {
                        if (txtcorreo.Text == string.Empty)
                        {
                            MessageBox.Show("No ha introducido ningun dato.");
                            txtcorreo.Select();
                        }
                        else
                        {
                            if (txttelefono.Text == string.Empty)
                            {
                                MessageBox.Show("No ha introducido ningun dato.");
                                txttelefono.Select();
                            }
                            else
                            {
                                if (txtcelular.Text == string.Empty)
                                {
                                    MessageBox.Show("No ha introducido ningun dato.");
                                    txtcelular.Select();
                                }
                                else
                                {
                                    if (txtdireccion.Text == string.Empty)
                                    {
                                        MessageBox.Show("No ha introducido ningun dato.");
                                        txtdireccion.Select();
                                    }
                                    else
                                    {
                                        actualizar_guardar();
                                    }
                                }

                            }
                        }
                    }
                }
            }
        }

        private void validar_borrar()
        {
            if (txtcodigo.Text == string.Empty)
            {
                MessageBox.Show("No ha introducido ningun dato.");
                txtcodigo.Select();
            }
            else
            {
                borrar_guardar();

            }
        }

        private void validar_nuevo()
        {
            if(txtnombre.Text==string.Empty)
            {
            MessageBox.Show("No ha introducido ningun dato.");
            txtnombre.Select();
            }
            else
            {
                if(txtapellido.Text==string.Empty)
            {
            MessageBox.Show("No ha introducido ningun dato.");
            txtapellido.Select();
            }
            else
            {
                    if(txtcedula.Text==string.Empty)
            {
            MessageBox.Show("No ha introducido ningun dato.");
            txtcedula.Select();
            }
            else
            {
                        if(txtcorreo.Text==string.Empty)
            {
            MessageBox.Show("No ha introducido ningun dato.");
            txtcorreo.Select();
            }
            else
            {
                            if(txttelefono.Text==string.Empty)
            {
            MessageBox.Show("No ha introducido ningun dato.");
            txttelefono.Select();
            }
            else
            {
                                if(txtcelular.Text==string.Empty)
            {
            MessageBox.Show("No ha introducido ningun dato.");
            txtcelular.Select();
            }
            else
            {
                nuevo_guardar();
            }
            }
            }
            }
            }
            }
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

        private void frmregistroclientes_Load(object sender, EventArgs e)
        {

        }
        int b = 0;
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            b = 1;
            nuevo();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (b == 1)
            {
                validar_nuevo();
            }
            else
            {
                if (b == 2)
                {
                    validar_actualizar();
                }
                else
                {
                    if (b == 3)
                    {
                        validar_borrar();
                    }
                }
            }
        }

        private void buscar_lleno()
        {
            codigo = int.Parse(txtcodigo.Text);

            try
            {
                string sentencia1 = "Select Nombre From cliente Where Codigo= " + codigo;
                string sentencia2 = "Select Apellido From cliente Where Codigo= " + codigo;
                string sentencia3 = "Select Correo From cliente Where Codigo= " + codigo;
                string sentencia4 = "Select Cedula From cliente Where Codigo= " + codigo;
                string sentencia5 = "Select Telefono From cliente Where Codigo= " + codigo;
                string sentencia6 = "Select Celular From cliente Where Codigo= " + codigo;
                string sentencia7 = "Select Direccion From cliente Where Codigo= " + codigo;


                conexion.Open();
                OleDbCommand com1 = new OleDbCommand(sentencia1, conexion);
                OleDbCommand com2 = new OleDbCommand(sentencia2, conexion);
                OleDbCommand com3 = new OleDbCommand(sentencia3, conexion);
                OleDbCommand com4 = new OleDbCommand(sentencia4, conexion);
                OleDbCommand com5 = new OleDbCommand(sentencia5, conexion);
                OleDbCommand com6 = new OleDbCommand(sentencia6, conexion);
                OleDbCommand com7 = new OleDbCommand(sentencia7, conexion);


                txtnombre.Text = com1.ExecuteScalar().ToString();
                txtapellido.Text = com2.ExecuteScalar().ToString();
                txtcedula.Text = com4.ExecuteScalar().ToString();
                txtcorreo.Text = com3.ExecuteScalar().ToString();
                txttelefono.Text = com5.ExecuteScalar().ToString();
                txtcelular.Text = com6.ExecuteScalar().ToString();
                txtdireccion.Text = com7.ExecuteScalar().ToString();
                
            }

            catch (Exception ex)
            {
                MessageBox.Show("Clave no valida");
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
            if (txtcodigo.Text == string.Empty)
            {
                frmconsultausuario frm = new frmconsultausuario();
                frm.Show();
            }
            else
            {
                buscar_lleno();
                btnguardar.Enabled = true;
                txtapellido.Enabled = true;
                txtdireccion.Enabled = true;
                txttelefono.Enabled = true;
                txtdireccion.Enabled = true;
                txtcorreo.Enabled = true;
                txtnombre.Enabled = true;
                txtcedula.Enabled = true;
                txtcelular.Enabled = true;
            }
        
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            actualizar();
                b=2;
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            borrar();
            b = 3;
        }
    }
}
