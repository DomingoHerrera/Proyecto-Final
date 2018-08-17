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


    public partial class frmtransaccioncompra : Form
    {
        public frmtransaccioncompra()
        {
            InitializeComponent();
            usuario_activo();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmtransaccionventa frm = new frmtransaccionventa();
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

        private void limpiar()
        {
            txtccedula.Clear();
            txtccodigo.Clear();
            txtcnombre.Clear();
            txttcodigo.Clear();
            txttdevuelto.Clear();
            txttmonto.Clear();
            txttpesos.Clear();
            txttrecibido.Clear();
            txtttotal.Clear();
            
        }

        private void nuevo() 
        {
            if(txtccodigo.Text==string.Empty)
            {
            
            }
            else
            {
                if(txtcnombre.Text==string.Empty)
            {
            
            }
            else
            {
                    if(txtccedula.Text==string.Empty)
            {
            
            }
            else
            {
                        if(txttc.Text==string.Empty)
            {
            
            }
            else
            {
                            if(txttrecibido.Text==string.Empty)
            {
            
            }
            else
            {
                                if(txttmonto.Text==string.Empty)
            {
            
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

        private void nuevo_guardar()
        {
            try
            {
                conexion.Open();
                OleDbCommand com = new OleDbCommand("insert into Transacioncompra (CodigoCliente,Nombre,Cedula,Moneda,Valorventa,Dinerorecibido,ACambiar,Internacional,Devuelta,Total,usuarioregistrado) Values (" + "'" + txtccodigo.Text + "'" + "," + "'" + txtcnombre.Text + "'" + "," + "'" + txtccedula.Text + "'" + "," + "'" + label8.Text + "'" + "," + "'" + txttc.Text + "'" + "," + "'" + txttrecibido.Text + "'" + "," + "'" + txttmonto.Text + "'" + "," + "'" + txttpesos.Text + "'" + "," + "'" + txttdevuelto.Text + "'" + "," + "'" + txtttotal.Text + "'," + "'" + lblusuario.Text + "')", conexion);
                com.ExecuteNonQuery();
                MessageBox.Show("Se ha ingresado la transaccion correctamente");

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
        
        private void frmtransaccioncompra_Load(object sender, EventArgs e)
        {

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

        public void formula_cambio()
        {
         

                double a, b, c, d;
                double cambio;

                a = double.Parse(txttmonto.Text);
                c = double.Parse(txttc.Text);
                
                cambio = a * c;
                
                txttpesos.Text = cambio.ToString();
                
            }
        
        public void formula_devuelta()
        {
          


                double a, b;
                double  devuelta;

                a = double.Parse(txttmonto.Text);
               
                b = double.Parse(txttrecibido.Text);
               
                
                devuelta = b - a;
                
                txttdevuelto.Text = devuelta.ToString();
                
            
        }
      
        private void txtttotal_TextChanged(object sender, EventArgs e)
        {
            validar_facturar_end();
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

                    txtttotal.Text="RD$"+txttpesos.Text+"   US$"+txttdevuelto.Text;
                }
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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void lblconsultartasas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmtasas frm = new frmtasas();
            
            frm.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
       
        private void cargar_tasas()
        {
            try
            {
                string sentencia1 = "Select Compra From Tasas Where Moneda='" + label8.Text + "';";
                string sentencia2 = "Select Venta From Tasas Where Moneda='" + label8.Text + "';";
                

                conexion.Open();

                OleDbCommand com1 = new OleDbCommand(sentencia1, conexion);
                OleDbCommand com2 = new OleDbCommand(sentencia2, conexion);
                


                txttc.Text = com1.ExecuteScalar().ToString();
                txttv.Text = com2.ExecuteScalar().ToString();
              
            }

            catch (Exception ex)
            {
               // MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
        }
        
        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == string.Empty)
            {

            }
            else
            {
                cargar_tasas();
            }
        }

        private void btndolar_Click(object sender, EventArgs e)
        {
            label8.Text = "Dólar";
        }

        private void btneuro_Click(object sender, EventArgs e)
        {
            label8.Text = "Euro";

        }

        private void btnom_Click(object sender, EventArgs e)
        {
            label8.Text = "Yen";
        }
              
        int codigo=0;

        private void buscar_llenot()
        {
            codigo = int.Parse(txttcodigo.Text);

            try
            {
                //string sentencia1 = "Select Tcodigo From Transacioncompra Where Tcodigo= " + codigo;
                string sentencia2 = "Select CodigoCliente From Transacioncompra Where Tcodigo= " + codigo;
                string sentencia3 = "Select Nombre From Transacioncompra Where Tcodigo= " + codigo;
                string sentencia4 = "Select Cedula From Transacioncompra Where Tcodigo= " + codigo;
                string sentencia5 = "Select Moneda From Transacioncompra Where Tcodigo= " + codigo;
                string sentencia6 = "Select Valorventa From Transacioncompra Where Tcodigo= " + codigo;
                string sentencia7 = "Select Dinerorecibido From Transacioncompra Where Tcodigo= " + codigo;
                string sentencia8 = "Select ACambiar From Transacioncompra Where Tcodigo= " + codigo;
                string sentencia9 = "Select Internacional From Transacioncompra Where Tcodigo= " + codigo;
                string sentencia10 = "Select Devuelta From Transacioncompra Where Tcodigo= " + codigo;
                string sentencia11 = "Select Total From Transacioncompra Where Tcodigo= " + codigo;
                string sentencia12 = "Select usuarioregistrado From Transacioncompra Where Tcodigo= " + codigo;

                conexion.Open();
                //OleDbCommand com1 = new OleDbCommand(sentencia1, conexion);
                OleDbCommand com2 = new OleDbCommand(sentencia2, conexion);
                OleDbCommand com3 = new OleDbCommand(sentencia3, conexion);
                OleDbCommand com4 = new OleDbCommand(sentencia4, conexion);
                OleDbCommand com5 = new OleDbCommand(sentencia5, conexion);
                OleDbCommand com6 = new OleDbCommand(sentencia6, conexion);
                OleDbCommand com7 = new OleDbCommand(sentencia7, conexion);
                OleDbCommand com8 = new OleDbCommand(sentencia8, conexion);
                OleDbCommand com9 = new OleDbCommand(sentencia9, conexion);
                OleDbCommand com10 = new OleDbCommand(sentencia10, conexion);
                OleDbCommand com11 = new OleDbCommand(sentencia11, conexion);
                OleDbCommand com12 = new OleDbCommand(sentencia12, conexion);



                txtccodigo.Text = com2.ExecuteScalar().ToString();
                txtcnombre.Text = com3.ExecuteScalar().ToString();
                txtccedula.Text = com4.ExecuteScalar().ToString();
                label8.Text = com5.ExecuteScalar().ToString();
                txttc.Text = com6.ExecuteScalar().ToString();
                txttrecibido.Text = com7.ExecuteScalar().ToString();
                txttmonto.Text = com8.ExecuteScalar().ToString();
                txttpesos.Text = com9.ExecuteScalar().ToString();
                txttdevuelto.Text = com10.ExecuteScalar().ToString();
                txtttotal.Text = com11.ExecuteScalar().ToString();
                lblusuario.Text = com12.ExecuteScalar().ToString();



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
    

        private void buscar_lleno()
        {
              codigo = int.Parse(txtccodigo.Text);

            try
            {
                string sentencia1 = "Select Nombre From cliente Where Codigo= " + codigo;
                string sentencia2 = "Select Cedula From cliente Where Codigo= " + codigo;
           


                conexion.Open();
                OleDbCommand com1 = new OleDbCommand(sentencia1, conexion);
                OleDbCommand com2 = new OleDbCommand(sentencia2, conexion);
               


                txtcnombre.Text = com1.ExecuteScalar().ToString();
                txtccedula.Text = com2.ExecuteScalar().ToString();
               
                

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
     
        private void lblbuscar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
              if (txtccodigo.Text == string.Empty)
            {
                frmconsultacliente frm = new frmconsultacliente();

                frm.Show();
            }
            else
            {
                buscar_lleno();
                
            }
        }

        private void lblañadir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmregistroclientes frm = new frmregistroclientes();

            frm.Show();
        }

        private void limpiar1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtccedula.Clear();
            txtccodigo.Clear();
            txtcnombre.Clear();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txttc.Clear();
            txttcodigo.Clear();
            txttdevuelto.Clear();
            txttmonto.Clear();
            txttpesos.Clear();
            txtttotal.Clear();
            txttv.Clear();
        }

        private void btnfacturar_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void lblbuscart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (txttcodigo.Text == string.Empty)
            {
                frmconsultacompra frm = new frmconsultacompra();

                frm.Show();
            }
            else
            {
                buscar_llenot();

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        }
    }

