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
    public partial class frmCRUDProducto : Form
    {
        public frmCRUDProducto()
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
        public static frmCRUDProducto prod = null;

        public static frmCRUDProducto LlamarProd
        {
            get
            {
                if (prod == null || prod.IsDisposed)
                {
                    prod = new frmCRUDProducto();
                }
                return prod;
            }
        }
        #endregion

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        ClsMantComboBox combobox = new ClsMantComboBox();
        private void frmCRUDProducto_Load(object sender, EventArgs e)
        {
            cmbIdProveedor.DataSource = combobox.CargarComboBoxProveedor();
            cmbIdProveedor.DisplayMember = "NOMBRE";
            cmbIdProveedor.ValueMember = "ID_PROVEEDOR";

            cmbIdCategoriaProducto.DataSource = combobox.CargarComboBoxCategoriaProducto();
            cmbIdCategoriaProducto.DisplayMember = "NOMBRE";
            cmbIdCategoriaProducto.ValueMember = "ID_CATEGORIA";

            cmbIdProveedor.SelectedValue = _IdProveedor;
            cmbIdCategoriaProducto.SelectedValue = _IdCategoriaProducto;
            txtNombre.Text = _Nombre;
            txtPrecio.Text = _Precio.ToString();
            txtExistencias.Text = _Existencias.ToString();
            msktxtFechaVencimiento.Text = _FechaVencimiento.ToString();

    }
        public void limpiar()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtExistencias.Clear();
            cmbIdProveedor.ResetText();
            cmbIdCategoriaProducto.ResetText();
            msktxtFechaVencimiento.Clear();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsProducto producto = new ClsProducto();

                producto.Id_proveedor = int.Parse(cmbIdProveedor.SelectedValue.ToString());
                producto.Id_categoria_producto = int.Parse(cmbIdCategoriaProducto.SelectedValue.ToString());
                producto.Nombre = txtNombre.Text;
                producto.Precio = decimal.Parse(txtPrecio.Text);
                producto.Existencias = int.Parse(txtExistencias.Text);
                producto.Fecha_Vencimiento = DateTime.Parse(msktxtFechaVencimiento.Text);


                int resultado = ClsMantProducto.AgregarProducto(producto);

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
        

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsProducto obProducto = new ClsProducto();

                obProducto.Id_producto = _IdProducto;
                obProducto.Id_proveedor = int.Parse(cmbIdProveedor.SelectedValue.ToString());
                obProducto.Id_categoria_producto = int.Parse(cmbIdCategoriaProducto.SelectedValue.ToString());
                obProducto.Nombre = txtNombre.Text;
                obProducto.Precio = decimal.Parse(txtPrecio.Text);
                obProducto.Existencias = int.Parse(txtExistencias.Text);
                obProducto.Fecha_Vencimiento = DateTime.Parse(msktxtFechaVencimiento.Text);


                int resultado = ClsMantProducto.ModificarProducto(obProducto);
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
            catch(Exception ex)
            {
                MessageBox.Show("Error! " + ex,"Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public int _IdProducto;
        public int _IdProveedor;
        public int _IdCategoriaProducto;
        public string _Nombre;
        public decimal _Precio;
        public int _Existencias;
        public DateTime _FechaVencimiento;
        
    }

}
