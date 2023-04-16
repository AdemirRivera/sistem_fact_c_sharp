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
    public partial class frmCategoriaProducto : Form
    {
        public frmCategoriaProducto()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCategoriaProducto_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Categoria Producto";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCRUDCategoriaProducto.Llamarcat.Show();
            frmCRUDCategoriaProducto.Llamarcat.BringToFront();
            frmCRUDCategoriaProducto.Llamarcat.lblTitulo.Text = "Categoria Producto";
            frmCRUDCategoriaProducto.Llamarcat.btnModificar.Visible = false;
            frmCRUDCategoriaProducto.Llamarcat.btnAceptar.Visible = true;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public ClsCategoriaProducto CategoriaSeleccionado { get; set; }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                int Id = Convert.ToInt16(dgv.CurrentRow.Cells[0].Value);
                CategoriaSeleccionado = ClsMantCatProd.ObtenerCategoriaProducto(Id);

                frmCRUDCategoriaProducto pEditar = new frmCRUDCategoriaProducto();
                pEditar._IdCategoria = CategoriaSeleccionado.Id_categoria;
                pEditar._Nombre = CategoriaSeleccionado.Nombre;
                pEditar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Aún no ha seleccionado ningún Registro");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea eliminar el Registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int Id = Convert.ToInt16(dgv.CurrentRow.Cells[0].Value);
                CategoriaSeleccionado = ClsMantCatProd.ObtenerCategoriaProducto(Id);
                int resultado = ClsMantCatProd.EliminarCategoriaProducto(CategoriaSeleccionado.Id_categoria);

                if (resultado > 0)
                {
                    MessageBox.Show("Registro eliminado correctamente", "Registro Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgv.DataSource = ClsMantCatProd.CargarCategoriaProducto();
        }

        private void btnImageBuscar_Click(object sender, EventArgs e)
        {
            dgv.DataSource = ClsMantCatProd.BuscarCategoriaProducto(txtBuscar.Text);
        }
    }
}
