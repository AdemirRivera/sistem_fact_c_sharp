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
using Clases;
using System.Data.SqlClient;

namespace Formularios
{
    public partial class frmCRUDProveedor : Form
    {
        public frmCRUDProveedor()
        {
            InitializeComponent();
        }
        #region IMPORTACION DE DLL PARA MOVER VENTANA A TRAVEZ DEL PANEL TOP
        //IMPORTACION DE DLL PARA MOVER LA VENTANA
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region INSTANCIAMIENTO UNICO
        public static frmCRUDProveedor prov = null;

        public static frmCRUDProveedor LlamarProv
        {
            get
            {
                if (prov == null || prov.IsDisposed)
                {
                    prov = new frmCRUDProveedor();
                }
                return prov;
            }
        }
        #endregion

        private void frmCRUDProveedor_Load(object sender, EventArgs e)
        {
            txtNombre.Text = _Nombre;
            txtDireccion.Text = _Direccion;
            txtEmail.Text = _Email;
        }

        public int _IdProveedor;
        public string _Nombre;
        public string _Direccion;
        public string _Email;

        public void limpiar()
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ClsProveedor obProveeedor = new ClsProveedor();
            obProveeedor.Id_proveedor = _IdProveedor;
            obProveeedor.Nombre = txtNombre.Text;
            obProveeedor.Direccion = txtDireccion.Text;
            obProveeedor.Email = txtEmail.Text;


            int resultado = ClsMantProveedor.ModificarProveedor(obProveeedor);
            if (resultado > 0)
            {
                MessageBox.Show("Registro modificado con éxito", "Registro Modificado",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo modificar Registro", "Error Modificación",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsProveedor obProveeedor = new ClsProveedor();
                obProveeedor.Nombre = txtNombre.Text;
                obProveeedor.Direccion = txtDireccion.Text;
                obProveeedor.Email = txtEmail.Text;

                int resultado = ClsMantProveedor.AgregarProveedor(obProveeedor);

                if (resultado > 0)
                {
                    MessageBox.Show("Datos Guardados Correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                else
                {
                    MessageBox.Show("No se Pudieron Guardar los Datos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("Se produjo un Error" + ex.ToString(), "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un Error" + ex.Message);
            }
        }
    }

}
