using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using System.Data.SqlClient;

namespace Formularios
{
    public partial class frmProducto_ : Form
    {
        public frmProducto_()
        {
            InitializeComponent();
        }
        private void frmProducto__Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Producto";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCRUDProducto.LlamarProd.Show();
            frmCRUDProducto.LlamarProd.lblTitulo.Text = "Producto";
            frmCRUDProducto.LlamarProd.BringToFront();
            frmCRUDProducto.LlamarProd.btnModificar.Visible = false;
            frmCRUDProducto.LlamarProd.btnAceptar.Visible = true;
            frmCRUDProducto.LlamarProd.msktxtFechaVencimiento.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            /*frmCRUDProducto.LlamarProd.Show();
            frmCRUDProducto.LlamarProd.lblTitulo.Text = "Producto";
            frmCRUDProducto.LlamarProd.BringToFront();
            frmCRUDProducto.LlamarProd.btnModificar.Visible = true;
            frmCRUDProducto.LlamarProd.btnAceptar.Visible = false;*/
            if (dgv.SelectedRows.Count == 1)
            {
                int Id = Convert.ToInt16(dgv.CurrentRow.Cells[0].Value);
                ProductoSeleccionado = ClsMantProducto.ObtenerProducto(Id);

                frmCRUDProducto pEditar = new frmCRUDProducto();
                pEditar._IdProducto = ProductoSeleccionado.Id_producto;
                pEditar._IdProveedor = ProductoSeleccionado.Id_proveedor;
                pEditar._IdCategoriaProducto = ProductoSeleccionado.Id_categoria_producto;
                pEditar._Nombre = ProductoSeleccionado.Nombre;
                pEditar._Precio = ProductoSeleccionado.Precio;
                pEditar._Existencias = ProductoSeleccionado.Existencias;
                pEditar._FechaVencimiento = ProductoSeleccionado.Fecha_Vencimiento;
                pEditar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Aún no ha seleccionado ningún Registro");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgv.DataSource = ClsMantProducto.CargarProducto();
        }
        public ClsProducto ProductoSeleccionado { get; set; }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea eliminar el Registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int Id = Convert.ToInt16(dgv.CurrentRow.Cells[0].Value);
                ProductoSeleccionado = ClsMantProducto.ObtenerProducto(Id);
                int resultado = ClsMantProducto.EliminarProducto(ProductoSeleccionado.Id_producto);

                if (resultado > 0)
                {
                    MessageBox.Show("Registro eliminado correctamente", "Registro Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv.DataSource = ClsMantProducto.CargarProducto();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Registro", "Error de Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Se canceló la eliminación", "Cancelación");
            }
        }

        private void btnImageBuscar_Click(object sender, EventArgs e)
        {
            dgv.DataSource = ClsMantProducto.BuscarProducto(txtBuscar.Text);
        }
    }
}
