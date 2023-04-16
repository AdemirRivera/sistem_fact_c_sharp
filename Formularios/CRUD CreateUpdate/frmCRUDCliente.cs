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
    public partial class frmCRUDCliente : Form
    {
        public frmCRUDCliente()
        {
            InitializeComponent();
        }
        ClsMantComboBox combobox = new ClsMantComboBox();
        private void frmCRUDCliente_Load(object sender, EventArgs e)
        {
            cmbIdCiudad.DataSource = combobox.CargarComboBoxCiudad();
            cmbIdCiudad.DisplayMember = "NOMBRE";
            cmbIdCiudad.ValueMember = "ID_CIUDAD";

            cmbIdCiudad.SelectedValue = _IdCiudad;
            txtNombre.Text = _Nombre;
            txtApellido.Text = _Apellido;
            txtDireccion.Text = _Direccion;
            msktxtFechaNacimiento.Text = _FechaNac.ToString();
            txtDUI.Text = _Dui;
            txtTelefono.Text = _Telefono;
            txtEmail.Text = _Email;
        }
        #region INSTANCIAMIENTO UNICO
        public static frmCRUDCliente cliente = null;

        public static frmCRUDCliente llamarCRUDCliente
        {
            get
            {
                if (cliente == null || cliente.IsDisposed)
                {
                    cliente = new frmCRUDCliente();
                }
                return cliente;
            }
        }
        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        public int _IdCliente;
        public int _IdCiudad;
        public string _Nombre;
        public string _Apellido;
        public string _Direccion;
        public DateTime _FechaNac;
        public string _Dui;
        public string _Telefono;
        public string _Email;

        public void limpiar()
        {
            cmbIdCiudad.Refresh();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            msktxtFechaNacimiento.Clear();
            txtDUI.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                ClsCliente obCliente = new ClsCliente();

                obCliente.Id_ciudad = int.Parse(cmbIdCiudad.SelectedValue.ToString());
                obCliente.Nombre = txtNombre.Text;
                obCliente.Apellido = txtApellido.Text;
                obCliente.Direccion = txtDireccion.Text;
                obCliente.Fecha_nacimiento = DateTime.Parse(msktxtFechaNacimiento.Text);
                obCliente.Dui = txtDUI.Text;
                obCliente.Telefono = txtTelefono.Text;
                obCliente.Email = txtEmail.Text;
                

                int resultado = ClsMantCliente.AgregarCliente(obCliente);

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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ClsCliente obCliente = new ClsCliente();
            obCliente.Id_cliente = _IdCliente;
            obCliente.Id_ciudad = int.Parse(cmbIdCiudad.SelectedValue.ToString());
            obCliente.Nombre = txtNombre.Text;
            obCliente.Apellido = txtApellido.Text;
            obCliente.Direccion = txtDireccion.Text;
            obCliente.Fecha_nacimiento = DateTime.Parse(msktxtFechaNacimiento.Text);
            obCliente.Dui = txtDUI.Text;
            obCliente.Telefono = txtTelefono.Text;
            obCliente.Email = txtEmail.Text;
            

            int resultado = ClsMantCliente.ModificarCliente(obCliente) ;
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
    }
}
