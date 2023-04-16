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
    public partial class frmTelSucursal : Form
    {
        public frmTelSucursal()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTelSucursal_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Telefono Sucursal";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCRUDTelSucursal.LlamarTelSuc.Show();
            frmCRUDTelSucursal.LlamarTelSuc.lblTitulo.Text = "Telefono Sucursal";
            frmCRUDTelSucursal.LlamarTelSuc.BringToFront();
            frmCRUDTelSucursal.LlamarTelSuc.btnModificar.Visible = false;
            frmCRUDTelSucursal.LlamarTelSuc.btnAceptar.Visible = true;
        }

        public ClsTelSucursal TelSucSeleccionado { get; set; }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                int Id = Convert.ToInt16(dgv.CurrentRow.Cells[0].Value);
                TelSucSeleccionado = ClsMantTelSucursal.ObtenerTelSucursal(Id);

                frmCRUDTelSucursal pEditar = new frmCRUDTelSucursal();
                pEditar._IdTelSucursal = TelSucSeleccionado.Id_tel_sucursal;

                pEditar._IdSucursal = TelSucSeleccionado.Id_sucursal;
                pEditar._Telefono = TelSucSeleccionado.Telefono;
                pEditar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Aún no ha seleccionado ningún Registro");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgv.DataSource = ClsMantTelSucursal.CargarTelSucursal();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea eliminar el Registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int Id = Convert.ToInt16(dgv.CurrentRow.Cells[0].Value);
                TelSucSeleccionado = ClsMantTelSucursal.ObtenerTelSucursal(Id);
                int resultado = ClsMantTelSucursal.EliminarTelSucursal(TelSucSeleccionado.Id_tel_sucursal);

                if (resultado > 0)
                {
                    MessageBox.Show("Registro eliminado correctamente", "Registro Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv.DataSource = ClsMantTelSucursal.CargarTelSucursal();
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
            dgv.DataSource = ClsMantTelSucursal.BuscarTelSucursal(int.Parse(txtBuscar.Text));
        }
    }
}
