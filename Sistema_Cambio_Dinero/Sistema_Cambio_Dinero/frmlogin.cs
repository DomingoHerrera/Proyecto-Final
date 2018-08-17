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

    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
            //marca de agua propiedades inicio//
            List<TextBox> tlist = new List<TextBox>();
            List<string> slist = new List<string>();
            tlist.Add(txtusuario);
            slist.Add("Usuario");
            SetCueBanner(ref tlist, slist);
            tlist.Add(txtclave);
            slist.Add("Contraseña");
            SetCueBanner(ref tlist, slist);
            //marca de agua propiedades final//
        }

        //marca de agua codigo inicio
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr i, string str);
        void SetCueBanner(ref List<TextBox> textBox, List<string> CueText)
        {
            for (int x = 0; x < textBox.Count; x++)
            {
                SendMessage(textBox[x].Handle, 0x1501, (IntPtr)1, CueText[x]);
            }
        }
        //marca de agua codigo final

     
        private void frmlogin_Load(object sender, EventArgs e)
        {

        }
        public void llamar_menu()
        {
            frmcontrolacceso frm = new frmcontrolacceso();
            this.Hide();
            frm.Show();
            
        }

        OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Sistema_Cambio_Dinero\\Recursos\\BD\\Sistema_Cambio_Dinero.accdb");

        int a;

        private void btnaceptar_Click(object sender, EventArgs e)
        {

            
                        if (txtclave.Text == string.Empty)
                        {
                            MessageBox.Show("No se Ha Introducido la clave", "Error");
                        }
                        else
                        {
                            try
                            {
                                string sentencia = "Select Nombre From usuario Where Clave='" + txtclave.Text + "';";
                                conexion.Open();
                                OleDbCommand com = new OleDbCommand(sentencia, conexion);
                                txtusuario.Text = com.ExecuteScalar().ToString();
                                MessageBox.Show("Se ha Logeado correctamente");
                                OleDbCommand com1 = new OleDbCommand("Update usuarioactivo Set usuarioactivo=" + "'" + txtusuario.Text + "'" + "Where Id= 1", conexion);
                                com1.ExecuteNonQuery();

                                llamar_menu();
                  
                                txtusuario.Clear();
                                txtclave.Clear();
                                txtclave.Select();

                            }
                 
                            catch (Exception)
                            {
                                MessageBox.Show("Clave no valida");

                                a = a + 1;
                                if (a == 3)
                                {
                                    MessageBox.Show("Ha ingresado mal la clave demasiadas veces por favor reporte este problema con su operador del servicio e intente mas tarde", "Atencion");

                                    this.Close();
                                }
                            }
                            finally
                            {
                                if (conexion.State != ConnectionState.Closed)
                                {
                                    conexion.Close();

                                }
                            }
                        }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


