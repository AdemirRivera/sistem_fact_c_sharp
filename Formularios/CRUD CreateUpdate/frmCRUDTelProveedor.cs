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

namespace Formularios
{
    public partial class frmCRUDTelProveedor : Form
    {
        public frmCRUDTelProveedor()
        {
            InitializeComponent();
        }

        ClsMantComboBox mantenimiento = new ClsMantComboBox();
        private void frmCRUDTelProveedor_Load(object sender, EventArgs e)
        {
            cmbId.DataSource = mantenimiento.CargarComboBoxProveedor();
            cmbId.DisplayMember = "NOMBRE";
            cmbId.ValueMember = "ID_PROVEEDOR";

            cmbId.SelectedValue = _IdProveedor;
            txtTelefono.Text = _Telefono;

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
        public static frmCRUDTelProveedor telprov = null;

        public static frmCRUDTelProveedor LlamarTelProv
        {
            get
            {
                if (telprov == null || telprov.IsDisposed)
                {
                    telprov = new frmCRUDTelProveedor();
                }
                return telprov;
            }
        }
        #endregion
        public void limpiar()
        {
            txtTelefono.Clear();
            cmbId.ResetText();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsTelProveedor telprov = new ClsTelProveedor();

                telprov.Id_proveedor = int.Parse(cmbId.SelectedValue.ToString());
                telprov.Telefono = txtTelefono.Text;


                int resultado = ClsMantTelProv.AgregarTelProveedor(telprov);

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
                MessageBox.Show("Se produjo un error! " + ex.ToString(), "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error! " + ex.Message);
            }
        }

        public int _IdTelProveedor;
        public int _IdProveedor;
        public string _Telefono;

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ClsTelProveedor obTelProv = new ClsTelProveedor();

            obTelProv.Telefono = txtTelefono.Text;
            obTelProv.Id_proveedor = int.Parse(cmbId.SelectedValue.ToString());
            obTelProv.Id_tel_proveedor = _IdTelProveedor;

            int resultado = ClsMantTelProv.ModificarTelProv(obTelProv);
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
            this.Close();
        }
    }
}
