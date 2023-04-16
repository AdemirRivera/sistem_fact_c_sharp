using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Clases
{
    public class ClsMantProveedor
    {
        public static int AgregarProveedor(ClsProveedor pProveedor)
        {
            int retorno = 0;
            using (SqlConnection conn = ClsConexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into PROVEEDOR(NOMBRE, DIRECCION, EMAIL) values ('{0}', '{1}', '{2}')",
                    pProveedor.Nombre, pProveedor.Direccion, pProveedor.Direccion), conn);
                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }
        public static List<ClsProveedor> CargarProveedor()
        {
            List<ClsProveedor> Lista = new List<ClsProveedor>();
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("SELECT ID_PROVEEDOR, NOMBRE, DIRECCION, EMAIL FROM PROVEEDOR"), conexion);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    ClsProveedor pProveedor = new ClsProveedor();
                    pProveedor.Id_proveedor = reader.GetInt32(0);
                    pProveedor.Nombre = reader.GetString(1);
                    pProveedor.Direccion = reader.GetString(2);
                    pProveedor.Email = reader.GetString(3);


                    Lista.Add(pProveedor);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static List<ClsProveedor> BuscarProveedor(string pNombre)
        {
            List<ClsProveedor> Lista = new List<ClsProveedor>();
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("SELECT ID_PROVEEDOR, NOMBRE, DIRECCION, EMAIL FROM PROVEEDOR WHERE NOMBRE LIKE '{0}%' ", pNombre), conexion);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    ClsProveedor pProveedor = new ClsProveedor();
                    pProveedor.Id_proveedor = reader.GetInt32(0);
                    pProveedor.Nombre = reader.GetString(1);
                    pProveedor.Direccion = reader.GetString(2);
                    pProveedor.Email = reader.GetString(3);

                    Lista.Add(pProveedor);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static ClsProveedor ObtenerProveedor(int pId_Proveedor)
        {
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                ClsProveedor pProveedor = new ClsProveedor();
                SqlCommand Comando = new SqlCommand(string.Format("SELECT ID_PROVEEDOR, NOMBRE, DIRECCION, EMAIL FROM PROVEEDOR WHERE ID_PROVEEDOR = {0}", pId_Proveedor), conexion);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    pProveedor.Id_proveedor = reader.GetInt32(0);
                    pProveedor.Nombre = reader.GetString(1);
                    pProveedor.Direccion = reader.GetString(2);
                    pProveedor.Email = reader.GetString(3);
                }
                conexion.Close();
                return pProveedor;
            }
        }
        public static int ModificarProveedor(ClsProveedor pProveedor)
        {
            int retorno = 0;
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("UPDATE PROVEEDOR SET NOMBRE = '{1}', DIRECCION = '{2}', EMAIL = '{3}'  WHERE ID_PROVEEDOR = {0}",
                    pProveedor.Id_proveedor, pProveedor.Nombre, pProveedor.Direccion, pProveedor.Email), conexion);

                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int EliminarProveedor(int pId_Proveedor)
        {
            int retorno = 0;
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("DELETE FROM PROVEEDOR WHERE ID_PROVEEDOR = {0}", pId_Proveedor), conexion);

                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
    }
}
