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
    public partial class frmSucursal : Form
    {
        public frmSucursal()
        {
            InitializeComponent();
        }

        private void frmSucursal_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Sucursal";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu panel = new Menu();
            panel.sidePanel.Visible = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCRUDSucursal.LlamarSuc.Show();
            frmCRUDSucursal.LlamarSuc.lblTitulo.Text = "Sucursal";
            frmCRUDSucursal.LlamarSuc.BringToFront();
            frmCRUDSucursal.LlamarSuc.btnModificar.Visible = false;
            frmCRUDSucursal.LlamarSuc.btnAceptar.Visible = true;
        }

        public ClsSucursal SucursalSeleccionado { get; set; }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                int Id = Convert.ToInt16(dgv.CurrentRow.Cells[0].Value);
                SucursalSeleccionado = ClsMantSucursal.ObtenerSucursal(Id);

                frmCRUDSucursal pEditar = new frmCRUDSucursal();
                pEditar._IdSucursal = SucursalSeleccionado.Id_sucursal;
                pEditar._IdCiudad = SucursalSeleccionado.Id_ciudad;
                pEditar._Nombre = SucursalSeleccionado.Nombre;
                pEditar._Direccion = SucursalSeleccionado.Direccion;
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
                SucursalSeleccionado = ClsMantSucursal.ObtenerSucursal(Id);
                int resultado = ClsMantSucursal.EliminarSucursal(SucursalSeleccionado.Id_sucursal);

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
            dgv.DataSource = ClsMantSucursal.CargarSucursal();
        }

        private void btnImageBuscar_Click(object sender, EventArgs e)
        {
            dgv.DataSource = ClsMantSucursal.BuscarSucursal(txtBuscar.Text);
        }
    }
}
