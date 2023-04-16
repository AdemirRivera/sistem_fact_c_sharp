using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Clases
{
    public class ClsMantVendedor
    {
        public static int AgregarVendedor(ClsVendedor pVendedor)
        {
            int retorno = 0;
            using (SqlConnection conn = ClsConexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into VENDEDOR(ID_SUCURSAL, NOMBRE, APELLIDO, DIRECCION, DUI, TELEFONO, EMAIL) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                    pVendedor.Id_sucursal, pVendedor.Nombre, pVendedor.Apellido, pVendedor.Direccion, pVendedor.Dui, pVendedor.Telefono, pVendedor.Email), conn);
                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }
        public static List<ClsVendedor> CargarVendedor()
        {
            List<ClsVendedor> Lista = new List<ClsVendedor>();
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("SELECT ID_VENDEDOR, ID_SUCURSAL, NOMBRE, APELLIDO, DIRECCION, DUI, TELEFONO, EMAIL FROM VENDEDOR"), conexion);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    ClsVendedor pVendedor = new ClsVendedor();
                    pVendedor.Id_vendedor = reader.GetInt32(0);
                    pVendedor.Id_sucursal = reader.GetInt32(1);
                    pVendedor.Nombre = reader.GetString(2);
                    pVendedor.Apellido = reader.GetString(3);
                    pVendedor.Direccion = reader.GetString(4);
                    pVendedor.Dui = reader.GetString(5);
                    pVendedor.Telefono = reader.GetString(6);
                    pVendedor.Email = reader.GetString(7);

                    Lista.Add(pVendedor);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static List<ClsVendedor> BuscarVendedor(string pNombre)
        {
            List<ClsVendedor> Lista = new List<ClsVendedor>();
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("SELECT ID_VENDEDOR, ID_SUCURSAL, NOMBRE, APELLIDO, DIRECCION, DUI, TELEFONO, EMAIL FROM VENDEDOR WHERE NOMBRE LIKE '{0}%'", pNombre), conexion);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    ClsVendedor pVendedor = new ClsVendedor();
                    pVendedor.Id_vendedor = reader.GetInt32(0);
                    pVendedor.Id_sucursal = reader.GetInt32(1);
                    pVendedor.Nombre = reader.GetString(2);
                    pVendedor.Apellido = reader.GetString(3);
                    pVendedor.Direccion = reader.GetString(4);
                    pVendedor.Dui = reader.GetString(5);
                    pVendedor.Telefono = reader.GetString(6);
                    pVendedor.Email = reader.GetString(7);

                    Lista.Add(pVendedor);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static ClsVendedor ObtenerVendedor(int pId_vendedor)
        {
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                ClsVendedor pVendedor = new ClsVendedor();
                SqlCommand Comando = new SqlCommand(string.Format("SELECT ID_VENDEDOR, ID_SUCURSAL, NOMBRE, APELLIDO, DIRECCION, DUI, TELEFONO, EMAIL FROM VENDEDOR WHERE ID_VENDEDOR = {0}", pId_vendedor), conexion);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    pVendedor.Id_vendedor = reader.GetInt32(0);
                    pVendedor.Id_sucursal = reader.GetInt32(1);
                    pVendedor.Nombre = reader.GetString(2);
                    pVendedor.Apellido = reader.GetString(3);
                    pVendedor.Direccion = reader.GetString(4);
                    pVendedor.Dui = reader.GetString(5);
                    pVendedor.Telefono = reader.GetString(6);
                    pVendedor.Email = reader.GetString(7);
                }
                conexion.Close();
                return pVendedor;
            }
        }

        public static int ModificarVendedor(ClsVendedor pVendedor)
        {
            int retorno = 0;
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("UPDATE VENDEDOR SET ID_SUCURSAL = '{1}', NOMBRE = '{2}', APELLIDO = '{3}', DIRECCION = '{4}', DUI = '{5}', TELEFONO = '{6}', EMAIL = '{7}' WHERE ID_VENDEDOR = {0}",
                    pVendedor.Id_vendedor, pVendedor.Id_sucursal, pVendedor.Nombre, pVendedor.Apellido, pVendedor.Direccion, pVendedor.Dui, pVendedor.Telefono, pVendedor.Email), conexion);

                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int EliminarVendedor(int pId_vendedor)
        {
            int retorno = 0;
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("DELETE FROM VENDEDOR WHERE ID_VENDEDOR = {0}", pId_vendedor), conexion);

                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
    }
}
