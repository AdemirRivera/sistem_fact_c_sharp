using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Clases;

namespace Formularios
{
    public partial class frmRegistrarUser : Form
    {
        public frmRegistrarUser()
        {
            InitializeComponent();
        }

        private void frmRegistrarse_Load(object sender, EventArgs e)
        {

        }

        private void btnImageClose_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuAdmin menu = new frmMenuAdmin();
            menu.Show();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
    //IMPORTACION DE DLL PARA MOVER LA VENTANA
    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = ClsConexion.obtenerConexion())
            {
                if (txtContrasena.Text == txtConfirmarContra.Text)
                {
                    string query = "INSERT INTO USUARIO VALUES(@Usuario,PWDENCRYPT(@Contrasena),@TipoUsuario)";
                    SqlCommand comando = new SqlCommand(query, conn);
                    comando.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                    comando.Parameters.AddWithValue("@Contrasena", txtContrasena.Text);
                    comando.Parameters.AddWithValue("@TipoUsuario", "Empleado");
                    comando.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Registrado Correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    Menu menu = new Menu();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Contraseña Incorrecta", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContrasena.Clear();
                    txtConfirmarContra.Clear();
                    txtContrasena.Focus();
                }
            }
        }

        private void checkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMostrar.Checked == true)
            {
                if (txtContrasena.PasswordChar == '•')
                {
                    txtContrasena.PasswordChar = '\0';                  
                }

            }
            else
            {
                txtContrasena.PasswordChar = '•';
            }
        }

        private void checkMostrarPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMostrarPass.Checked == true)
            {
                if (txtConfirmarContra.PasswordChar == '•')
                {
                    txtConfirmarContra.PasswordChar = '\0';
                }

            }
            else
            {
                txtConfirmarContra.PasswordChar = '•';
            }
        }
    }
}
