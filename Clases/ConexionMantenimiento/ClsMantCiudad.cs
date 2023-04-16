using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Clases
{
    public class ClsMantCiudad
    {
        public static int AgregarCiudad(ClsCiudad pCiudad)
        {
            int retorno = 0;
            using (SqlConnection conn = ClsConexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into CIUDAD(NOMBRE) values ('{0}')",
                    pCiudad.Nombre), conn);
                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }
        public static List<ClsCiudad> CargarCiudad()
        {
            List<ClsCiudad> Lista = new List<ClsCiudad>();
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("SELECT ID_CIUDAD, NOMBRE FROM CIUDAD"), conexion);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    ClsCiudad pCiudad = new ClsCiudad();
                    pCiudad.Id_ciudad = reader.GetInt32(0);
                    pCiudad.Nombre = reader.GetString(1);

                    Lista.Add(pCiudad);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static List<ClsCiudad> BuscarCiudad(string pNombre)
        {
            List<ClsCiudad> Lista = new List<ClsCiudad>();
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("SELECT ID_CIUDAD, NOMBRE FROM CIUDAD WHERE NOMBRE LIKE '{0}%'", pNombre), conexion);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    ClsCiudad pCiudad = new ClsCiudad();
                    pCiudad.Id_ciudad = reader.GetInt32(0);
                    pCiudad.Nombre = reader.GetString(1);

                    Lista.Add(pCiudad);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static ClsCiudad ObtenerCiudad(int pId_ciudad)
        {
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                ClsCiudad pCiudad = new ClsCiudad();
                SqlCommand Comando = new SqlCommand(string.Format("SELECT ID_CIUDAD, NOMBRE FROM CIUDAD WHERE ID_CIUDAD = {0}", pId_ciudad), conexion);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    pCiudad.Id_ciudad = reader.GetInt32(0);
                    pCiudad.Nombre = reader.GetString(1);
                }
                conexion.Close();
                return pCiudad;
            }
        }
        public static int ModificarCiudad(ClsCiudad pCiudad)
        {
            int retorno = 0;
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("UPDATE CIUDAD SET NOMBRE = '{1}' WHERE ID_CIUDAD = {0}",
                    pCiudad.Id_ciudad, pCiudad.Nombre), conexion);

                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int EliminarCiudad(int pId_Ciudad)
        {
            int retorno = 0;
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("DELETE FROM CIUDAD WHERE ID_CIUDAD = {0}", pId_Ciudad), conexion);

                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
    }
}
