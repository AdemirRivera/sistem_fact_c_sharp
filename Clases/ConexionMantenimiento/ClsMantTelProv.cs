using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Clases
{
    public class ClsMantTelProv
    {
        public static int AgregarTelProveedor(ClsTelProveedor pTelProv)
        {
            int retorno = 0;
            using (SqlConnection conn = ClsConexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into TEL_PROVEEDOR(ID_PROVEEDOR,TELEFONO) values ('{0}','{1}')",
                    pTelProv.Id_proveedor, pTelProv.Telefono), conn);
                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }

        public static List<ClsTelProveedor> CargarTelProv()
        {
            List<ClsTelProveedor> Lista = new List<ClsTelProveedor>();
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("SELECT ID_TEL_PROVEEDOR, ID_PROVEEDOR, TELEFONO FROM TEL_PROVEEDOR"), conexion);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    ClsTelProveedor pTelProv = new ClsTelProveedor();
                    pTelProv.Id_tel_proveedor = reader.GetInt32(0);
                    pTelProv.Id_proveedor = reader.GetInt32(1);
                    pTelProv.Telefono = reader.GetString(2);

                    Lista.Add(pTelProv);
                }
                conexion.Close();
                return Lista;
            }
        }

        public static List<ClsTelProveedor> BuscarTelProv(int pIdTel)
        {
            List<ClsTelProveedor> Lista = new List<ClsTelProveedor>();
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("SELECT ID_TEL_PROVEEDOR, ID_PROVEEDOR, TELEFONO FROM TEL_PROVEEDOR WHERE ID_TELPROVEEDOR LIKE '{0}%'", pIdTel), conexion);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    ClsTelProveedor pTelProv = new ClsTelProveedor();
                    pTelProv.Id_tel_proveedor = reader.GetInt32(0);
                    pTelProv.Id_proveedor = reader.GetInt32(1);
                    pTelProv.Telefono = reader.GetString(2);

                    Lista.Add(pTelProv);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static ClsTelProveedor ObtenerTelProv(int pId_telprov)
        {
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                ClsTelProveedor pTelProv = new ClsTelProveedor();
                SqlCommand Comando = new SqlCommand(string.Format("SELECT ID_TEL_PROVEEDOR, ID_PROVEEDOR, TELEFONO FROM TEL_PROVEEDOR WHERE ID_TEL_PROVEEDOR = {0}", pId_telprov), conexion);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    pTelProv.Id_tel_proveedor = reader.GetInt32(0);
                    pTelProv.Id_proveedor = reader.GetInt32(1);
                    pTelProv.Telefono = reader.GetString(2);
                }
                conexion.Close();
                return pTelProv;
            }
        }
        public static int ModificarTelProv(ClsTelProveedor pTelProv)
        {
            int retorno = 0;
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("UPDATE TEL_PROVEEDOR SET ID_PROVEEDOR = '{1}', TELEFONO = '{2}' WHERE ID_TEL_PROVEEDOR = {0}",
                    pTelProv.Id_tel_proveedor, pTelProv.Id_proveedor, pTelProv.Telefono), conexion);

                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int EliminarTelProv(int pId_TelProv)
        {
            int retorno = 0;
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("DELETE FROM TEL_PROVEEDOR WHERE ID_TEL_PROVEEDOR = {0}", pId_TelProv), conexion);

                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
    }
}
