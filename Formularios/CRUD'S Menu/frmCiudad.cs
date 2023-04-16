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
    public partial class frmCiudad : Form
    {
        public frmCiudad()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void frmCiudad_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Ciudad";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCRUDCiudad.LlamarCRUDCiudad.Show();
            frmCRUDCiudad.LlamarCRUDCiudad.lblTitulo.Text = "Ciudad";
            frmCRUDCiudad.LlamarCRUDCiudad.BringToFront();
            frmCRUDCiudad.LlamarCRUDCiudad.btnModificar.Visible = false;
            frmCRUDCiudad.LlamarCRUDCiudad.btnAceptar.Visible = true;
        }

        //ACTUALIZAR DATAGRID
        public void cargarDGV(DataGridView dgvCiudad)
        {
            try
            {
                ClsConexion.obtenerConexion();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CIUDAD", ClsConexion.obtenerConexion());

                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el DataGridView: " + ex.ToString());
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgv.DataSource = ClsMantCiudad.CargarCiudad();
        }
        public ClsCiudad CiudadSeleccionada { get; set; }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                int Id = Convert.ToInt16(dgv.CurrentRow.Cells[0].Value);
                CiudadSeleccionada = ClsMantCiudad.ObtenerCiudad(Id);

                frmCRUDCiudad pEditar = new frmCRUDCiudad();
                pEditar._ID = CiudadSeleccionada.Id_ciudad;
                pEditar._Nombre = CiudadSeleccionada.Nombre;
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
                CiudadSeleccionada = ClsMantCiudad.ObtenerCiudad(Id);
                int resultado = ClsMantCiudad.EliminarCiudad(CiudadSeleccionada.Id_ciudad);

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

        private void btnImageBuscar_Click(object sender, EventArgs e)
        {
            dgv.DataSource = ClsMantCiudad.BuscarCiudad(txtBuscar.Text);
        }
    }
}
