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

    public partial class frmmantenimientousuario : Form
    {
        public frmmantenimientousuario()
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

        OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Sistema_Cambio_Dinero\\Recursos\\BD\\Sistema_Cambio_Dinero.accdb");
        
        private void limpiar()
        {
            txtapellido.Clear();
            txtcargo.Clear();
            txtcc.Clear();
            txtclave.Clear();
            txtcodigo.Clear();
            txtcorreo.Clear();
            txtnombre.Clear();
            txtusuario.Clear();
            cbprivilegios.Text = "";
            txtapellido.Enabled = false;
            txtcargo.Enabled = false;
            txtcc.Enabled = false;
            txtclave.Enabled = false;
            txtcodigo.Enabled = false;
            txtcorreo.Enabled = false;
            txtnombre.Enabled = false;
            txtusuario.Enabled = false;
            cbprivilegios.Enabled = false;
            btnguardar.Enabled = false;
            btnactualizar.Enabled = true;
            btnborrar.Enabled = true;
            btnnuevo.Enabled = true;
        
        }
        int b = 0;
        private void nuevo()
        {
            txtapellido.Enabled = true;
            txtcargo.Enabled = true;
            txtcc.Enabled = true;
            txtclave.Enabled = true;
            txtcorreo.Enabled = true;
            txtnombre.Enabled = true;
            txtusuario.Enabled = true;
            cbprivilegios.Enabled = true;
            btnguardar.Enabled = true;
            btnactualizar.Enabled = false;
            btnborrar.Enabled = false;
            btnnuevo.Enabled = false;
            b = 1;
        
        }

        private void actualizar()
        {
            b = 2;
            txtcodigo.Enabled = true;
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
            b = 3;
        }


        private void  nuevo_guardar()
    {
             try
                {
            conexion.Open();
            OleDbCommand com = new OleDbCommand("insert into usuario (Nombre,Apellido,Correo,Cargo,Usuario,Clave,Privilegio,usuarioregistrado) Values (" + "'" + txtnombre.Text + "'" + "," + "'" + txtapellido.Text + "'" + "," + "'" + txtcorreo.Text + "'" + "," + "'" + txtcargo.Text + "'" + "," + "'" + txtusuario.Text + "'" + "," + "'" + txtclave.Text + "'" + "," + "'" + cbprivilegios.Text + "'," + "'" + lblusuario.Text + "')", conexion);
            com.ExecuteNonQuery();
            MessageBox.Show("Se ha ingresado el usuario correctamente");

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
            catch(Exception ex)
                {
                    MessageBox.Show(ex. Message);
                
                }           
            finally
            {
             if( conexion.State != ConnectionState.Closed)
             {
                 conexion.Close();

             }

            }
    }

        int codigo = 0;

        private void borrar_guardar()
        {
            try
            {
                codigo = int.Parse(txtcodigo.Text);
                string sentencia = "Delete From usuario Where Codigo=" + codigo + ";";
                conexion.Open();
                OleDbCommand com = new OleDbCommand(sentencia, conexion);

                com.ExecuteNonQuery();
                MessageBox.Show("Se ha borrado el usuario correctamente");

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

        private void actualizar_guardar()
        {
            try
                {

                    codigo = int.Parse(txtcodigo.Text);

                        conexion.Open();
                        OleDbCommand com1 = new OleDbCommand("Update usuario Set Nombre=" + "'" + txtnombre.Text + "'" + "Where Codigo=" +""+ codigo + "", conexion);
                        OleDbCommand com2 = new OleDbCommand("Update usuario Set Apellido=" + "'" + txtapellido.Text + "'" + "Where Codigo=" + "" + codigo + "", conexion);
                        OleDbCommand com3 = new OleDbCommand("Update usuario Set Correo=" + "'" + txtcorreo.Text + "'" + "Where Codigo=" + "" + codigo + "", conexion);
                        OleDbCommand com4 = new OleDbCommand("Update usuario Set Cargo=" + "'" + txtcargo.Text + "'" + "Where Codigo=" + "" + codigo + "", conexion);
                        OleDbCommand com5 = new OleDbCommand("Update usuario Set Usuario=" + "'" + txtusuario.Text + "'" + "Where Codigo=" + "" + codigo + "", conexion);
                        OleDbCommand com6 = new OleDbCommand("Update usuario Set Clave=" + "'" + txtclave.Text + "'" + "Where Codigo=" + "" + codigo + "", conexion);
                        OleDbCommand com7 = new OleDbCommand("Update usuario Set Privilegio=" + "'" + cbprivilegios.Text + "'" + "Where Codigo=" + "" + codigo + "", conexion);
                        OleDbCommand com8 = new OleDbCommand("Update usuario Set usuarioregistrado=" + "'" + lblusuario.Text + "'" + "Where Codigo=" + "" + codigo + "", conexion);

                   
                    com1.ExecuteNonQuery();
                    com2.ExecuteNonQuery();
                    com3.ExecuteNonQuery();
                    com4.ExecuteNonQuery();
                    com5.ExecuteNonQuery();
                    com6.ExecuteNonQuery();
                    com7.ExecuteNonQuery();
                    com8.ExecuteNonQuery();
                
                    MessageBox.Show("Se ha actualizado el usuario correctamente");

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

        private void validar_nuevo()
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
                        if (txtcargo.Text == string.Empty)
                        {
                            MessageBox.Show("No ha introducido ningun dato.");
                            txtcargo.Select();
                        }
                        else
                        {
                            if (txtusuario.Text == string.Empty)
                            {
                                MessageBox.Show("No ha introducido ningun dato.");
                                txtusuario.Select();
                            }
                            else
                            {
                                if (txtclave.Text == string.Empty)
                                {
                                    MessageBox.Show("No ha introducido ningun dato.");
                                    txtclave.Select();
                                }
                                else
                                {
                                    if (txtcc.Text == string.Empty)
                                    {
                                        MessageBox.Show("No ha introducido ningun dato.");
                                        txtcc.Select();
                                    }
                                    else
                                    {
                                        if (cbprivilegios.Text == "")
                                        {
                                            MessageBox.Show("No ha introducido ningun dato.");
                                            cbprivilegios.Select();
                                        }
                                        else
                                        {
                                            if (txtclave.Text != txtcc.Text)
                                            {
                                                MessageBox.Show("Las contraseñas no coinciden.");
                                                txtclave.Select();
                                                txtcc.Clear();
                                                txtclave.Clear();
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
                            if (txtcargo.Text == string.Empty)
                            {
                                MessageBox.Show("No ha introducido ningun dato.");
                                txtcargo.Select();
                            }
                            else
                            {
                                if (txtusuario.Text == string.Empty)
                                {
                                    MessageBox.Show("No ha introducido ningun dato.");
                                    txtusuario.Select();
                                }
                                else
                                {
                                    if (txtclave.Text == string.Empty)
                                    {
                                        MessageBox.Show("No ha introducido ningun dato.");
                                        txtclave.Select();
                                    }
                                    else
                                    {
                                        if (txtcc.Text == string.Empty)
                                        {
                                            MessageBox.Show("No ha introducido ningun dato.");
                                            txtcc.Select();
                                        }
                                        else
                                        {
                                            if (cbprivilegios.Text == "")
                                            {
                                                MessageBox.Show("No ha introducido ningun dato.");
                                                cbprivilegios.Select();
                                            }
                                            else
                                            {
                                                if (txtclave.Text != txtcc.Text)
                                                {
                                                    MessageBox.Show("Las contraseñas no coinciden.");
                                                    txtclave.Select();
                                                    txtcc.Clear();
                                                    txtclave.Clear();
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

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            borrar();
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

        private void frmmantenimientousuario_Load(object sender, EventArgs e)
        {
        }

        private void buscar_lleno()
        {
            codigo = int.Parse(txtcodigo.Text);

            try
            {
                string sentencia1 = "Select Nombre From usuario Where Codigo= "+codigo;
                string sentencia2 = "Select Apellido From usuario Where Codigo= " + codigo;
                string sentencia3 = "Select Correo From usuario Where Codigo= " + codigo;
                string sentencia4 = "Select Cargo From usuario Where Codigo= " + codigo;
                string sentencia5 = "Select Usuario From usuario Where Codigo= " + codigo;
                string sentenciap = "Select Privilegio From usuario Where Codigo= " + codigo;
                string sentenciac = "Select Clave From usuario Where Codigo= " + codigo;


                conexion.Open();
                OleDbCommand com1 = new OleDbCommand(sentencia1, conexion);
                OleDbCommand com2 = new OleDbCommand(sentencia2, conexion);
                OleDbCommand com3 = new OleDbCommand(sentencia3, conexion);
                OleDbCommand com4 = new OleDbCommand(sentencia4, conexion);
                OleDbCommand com5 = new OleDbCommand(sentencia5, conexion);
                OleDbCommand comp = new OleDbCommand(sentenciap, conexion);
                OleDbCommand comc = new OleDbCommand(sentenciac, conexion);
                
                
                    txtnombre.Text = com1.ExecuteScalar().ToString();
                    txtapellido.Text=com2.ExecuteScalar().ToString();
                    txtcargo.Text=com4.ExecuteScalar().ToString();
                    txtcorreo.Text=com3.ExecuteScalar().ToString();
                    txtusuario.Text=com5.ExecuteScalar().ToString();
                    txtclave.Text=comc.ExecuteScalar().ToString();
                    cbprivilegios.Text=comp.ExecuteScalar().ToString();






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
       
        private void lblbuscar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
                txtcargo.Enabled = true;
                txtcc.Enabled = true;
                txtclave.Enabled = true;
                txtcorreo.Enabled = true;
                txtnombre.Enabled = true;
                txtusuario.Enabled = true;
                cbprivilegios.Enabled = true;
            }
        }

        private void txtcc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
