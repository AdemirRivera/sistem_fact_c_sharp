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
    public partial class frmCRUDVendedor : Form
    {
        public frmCRUDVendedor()
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
        public static frmCRUDVendedor vendedor = null;

        public static frmCRUDVendedor LlamarVendedor
        {
            get
            {
                if (vendedor == null || vendedor.IsDisposed)
                {
                    vendedor = new frmCRUDVendedor();
                }
                return vendedor;
            }
        }
        #endregion

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ClsVendedor obVendedor = new ClsVendedor();
            obVendedor.Id_vendedor = _IdVendedor;
            obVendedor.Id_sucursal = int.Parse(cmbIdSucursal.SelectedValue.ToString());
            obVendedor.Nombre = txtNombre.Text;
            obVendedor.Apellido = txtApellido.Text;
            obVendedor.Direccion = txtDireccion.Text;
            obVendedor.Dui = txtDUI.Text;
            obVendedor.Telefono = txtTelefono.Text;
            obVendedor.Email = txtEmail.Text;


            int resultado = ClsMantVendedor.ModificarVendedor(obVendedor);
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

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        ClsMantComboBox combobox = new ClsMantComboBox();

        public int _IdVendedor;
        public int _IdSucursal;
        public string _Nombre;
        public string _Apellido;
        public string _Direccion;
        public string _Dui;
        public string _Telefono;
        public string _Email;

        public void limpiar()
        {
            cmbIdSucursal.Refresh();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtDUI.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
        }

        private void frmCRUDVendedor_Load(object sender, EventArgs e)
        {
            cmbIdSucursal.DataSource = combobox.CargarComboBoxSucursal();
            cmbIdSucursal.DisplayMember = "NOMBRE";
            cmbIdSucursal.ValueMember = "ID_SUCURSAL";

            cmbIdSucursal.SelectedValue = _IdSucursal;
            txtNombre.Text = _Nombre;
            txtApellido.Text = _Apellido;
            txtDireccion.Text = _Direccion;
            txtDUI.Text = _Dui;
            txtTelefono.Text = _Telefono;
            txtEmail.Text = _Email;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsVendedor obVendedor = new ClsVendedor();

                obVendedor.Id_sucursal = int.Parse(cmbIdSucursal.SelectedValue.ToString());
                obVendedor.Nombre = txtNombre.Text;
                obVendedor.Apellido = txtApellido.Text;
                obVendedor.Direccion = txtDireccion.Text;
                obVendedor.Dui = txtDUI.Text;
                obVendedor.Telefono = txtTelefono.Text;
                obVendedor.Email = txtEmail.Text;


                int resultado = ClsMantVendedor.AgregarVendedor(obVendedor);

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
