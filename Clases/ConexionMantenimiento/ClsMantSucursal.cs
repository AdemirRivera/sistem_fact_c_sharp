using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Clases
{
    public class ClsMantSucursal
    {

        public static int AgregarSucursal(ClsSucursal pSucursal)
        {
            int retorno = 0;
            using (SqlConnection conn = ClsConexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into SUCURSAL(ID_CIUDAD, NOMBRE, DIRECCION) values ('{0}','{1}','{2}')",
                    pSucursal.Id_ciudad, pSucursal.Nombre, pSucursal.Direccion), conn);
                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }
        public static List<ClsSucursal> CargarSucursal()
        {
            List<ClsSucursal> Lista = new List<ClsSucursal>();
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("SELECT ID_SUCURSAL, ID_CIUDAD, NOMBRE, DIRECCION FROM SUCURSAL"), conexion);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    ClsSucursal pSucursal = new ClsSucursal();
                    pSucursal.Id_sucursal = reader.GetInt32(0);
                    pSucursal.Id_ciudad = reader.GetInt32(1);
                    pSucursal.Nombre = reader.GetString(2);
                    pSucursal.Direccion = reader.GetString(3);

                    Lista.Add(pSucursal);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static List<ClsSucursal> BuscarSucursal(string pNombre)
        {
            List<ClsSucursal> Lista = new List<ClsSucursal>();
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("SELECT ID_SUCURSAL, ID_CIUDAD, NOMBRE, DIRECCION FROM SUCURSAL WHERE NOMBRE LIKE '%{0}%'", pNombre), conexion);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    ClsSucursal pSucursal = new ClsSucursal();
                    pSucursal.Id_sucursal = reader.GetInt32(0);
                    pSucursal.Id_ciudad = reader.GetInt32(1);
                    pSucursal.Nombre = reader.GetString(2);
                    pSucursal.Direccion = reader.GetString(3);

                    Lista.Add(pSucursal);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static ClsSucursal ObtenerSucursal(int pId_sucursal)
        {
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                ClsSucursal pSucursal = new ClsSucursal();
                SqlCommand Comando = new SqlCommand(string.Format("SELECT ID_SUCURSAL, ID_CIUDAD, NOMBRE, DIRECCION FROM SUCURSAL WHERE ID_SUCURSAL = {0}", pId_sucursal), conexion);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    pSucursal.Id_sucursal = reader.GetInt32(0);
                    pSucursal.Id_ciudad = reader.GetInt32(1);
                    pSucursal.Nombre = reader.GetString(2);
                    pSucursal.Direccion = reader.GetString(3);
                }
                conexion.Close();
                return pSucursal;
            }
        }
        public static int ModificarSucursal(ClsSucursal pSucursal)
        {
            int retorno = 0;
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("UPDATE SUCURSAL SET ID_CIUDAD = '{1}', NOMBRE = '{2}', DIRECCION = '{3}'  WHERE ID_SUCURSAL = {0}",
                    pSucursal.Id_sucursal, pSucursal.Id_ciudad, pSucursal.Nombre, pSucursal.Direccion), conexion);

                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int EliminarSucursal(int pId_sucursal)
        {
            int retorno = 0;
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("DELETE FROM SUCURSAL WHERE ID_SUCURSAL = {0}", pId_sucursal), conexion);

                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
    }
}
