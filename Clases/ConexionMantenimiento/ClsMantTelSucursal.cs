using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Clases
{
    public class ClsMantTelSucursal
    {
        
        public static int AgregarTelSucursal(ClsTelSucursal pTelSucursal)
        {
            int retorno = 0;
            using (SqlConnection conn = ClsConexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into TEL_SUCURSAL(ID_SUCURSAL,TELEFONO) values ('{0}','{1}')",
                    pTelSucursal.Id_sucursal, pTelSucursal.Telefono), conn);
                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }

        public static List<ClsTelSucursal> CargarTelSucursal()
        {
            List<ClsTelSucursal> Lista = new List<ClsTelSucursal>();
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("SELECT ID_TEL_SUCURSAL, ID_SUCURSAL, TELEFONO FROM TEL_SUCURSAL"), conexion);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    ClsTelSucursal pTelSucursal = new ClsTelSucursal();
                    pTelSucursal.Id_tel_sucursal = reader.GetInt32(0);
                    pTelSucursal.Id_sucursal = reader.GetInt32(1);
                    pTelSucursal.Telefono = reader.GetString(2);

                    Lista.Add(pTelSucursal);
                }
                conexion.Close();
                return Lista;
            }
        }

        public static List<ClsTelSucursal> BuscarTelSucursal(int pIdTel)
        {
            List<ClsTelSucursal> Lista = new List<ClsTelSucursal>();
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("SELECT ID_TEL_SUCURSAL, ID_SUCURSAL, TELEFONO FROM TEL_SUCURSAL WHERE ID_TEL_SUCURSAL LIKE '{0}%'", pIdTel), conexion);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    ClsTelSucursal pTelSucursal = new ClsTelSucursal();
                    pTelSucursal.Id_tel_sucursal = reader.GetInt32(0);
                    pTelSucursal.Id_sucursal = reader.GetInt32(1);
                    pTelSucursal.Telefono = reader.GetString(2);

                    Lista.Add(pTelSucursal);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static ClsTelSucursal ObtenerTelSucursal(int pId_TelSucursal)
        {
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                ClsTelSucursal pTelSucursal = new ClsTelSucursal();
                SqlCommand Comando = new SqlCommand(string.Format("SELECT ID_TEL_SUCURSAL, ID_SUCURSAL, TELEFONO FROM TEL_SUCURSAL WHERE ID_TEL_SUCURSAL = {0}", pId_TelSucursal), conexion);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    pTelSucursal.Id_tel_sucursal = reader.GetInt32(0);
                    pTelSucursal.Id_sucursal = reader.GetInt32(1);
                    pTelSucursal.Telefono = reader.GetString(2);
                }
                conexion.Close();
                return pTelSucursal;
            }
        }
        public static int ModificarTelSucursal(ClsTelSucursal pTelSucursal)
        {
            int retorno = 0;
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("UPDATE TEL_SUCURSAL SET ID_SUCURSAL = '{1}', TELEFONO = '{2}' WHERE ID_TEL_SUCURSAL = {0}",
                    pTelSucursal.Id_tel_sucursal, pTelSucursal.Id_sucursal, pTelSucursal.Telefono), conexion);

                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int EliminarTelSucursal(int pId_TelSucursal)
        {
            int retorno = 0;
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("DELETE FROM TEL_SUCURSAL WHERE ID_TEL_SUCURSAL = {0}", pId_TelSucursal), conexion);

                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
    }
}
