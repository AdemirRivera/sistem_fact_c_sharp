using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace Clases
{
    public class ClsMantComboBox
    {
        #region CARGA DE COMBOBOX
        public DataTable CargarComboBoxProveedor()
        {
            using (SqlConnection conn = ClsConexion.obtenerConexion())
            {
                SqlDataAdapter Comando = new SqlDataAdapter("SELECT ID_PROVEEDOR, NOMBRE FROM PROVEEDOR", conn);
                Comando.SelectCommand.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                Comando.Fill(dt);
                return dt;

            }
        }
        public DataTable CargarComboBoxSucursal()
        {
            using (SqlConnection conn = ClsConexion.obtenerConexion())
            {
                SqlDataAdapter Comando = new SqlDataAdapter("SELECT ID_SUCURSAL, NOMBRE FROM SUCURSAL", conn);
                Comando.SelectCommand.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                Comando.Fill(dt);
                return dt;

            }
        }
        public DataTable CargarComboBoxProducto()
        {
            using (SqlConnection conn = ClsConexion.obtenerConexion())
            {
                SqlDataAdapter Comando = new SqlDataAdapter("Select ID_PRODUCTO, NOMBRE FROM PRODUCTO", conn);
                Comando.SelectCommand.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                Comando.Fill(dt);
                return dt;

            }
        }
        public DataTable CargarComboBoxCategoriaProducto()
        {
            using (SqlConnection conn = ClsConexion.obtenerConexion())
            {
                SqlDataAdapter Comando = new SqlDataAdapter("Select ID_CATEGORIA, NOMBRE FROM CATEGORIA_PRODUCTO", conn);
                Comando.SelectCommand.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                Comando.Fill(dt);
                return dt;

            }
        }
        public DataTable CargarComboBoxCiudad()
        {
            using (SqlConnection conn = ClsConexion.obtenerConexion())
            {
                SqlDataAdapter Comando = new SqlDataAdapter("SELECT ID_CIUDAD, NOMBRE FROM CIUDAD", conn);
                Comando.SelectCommand.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                Comando.Fill(dt);
                return dt;

            }
        }
        
        #endregion
    }
}
