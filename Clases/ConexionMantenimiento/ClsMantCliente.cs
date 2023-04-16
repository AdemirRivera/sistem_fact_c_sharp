using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Clases
{
    public class ClsMantCliente
    {
        public static int AgregarCliente(ClsCliente pCliente)
        {
            int retorno = 0;
            using (SqlConnection conn = ClsConexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into CLIENTE(ID_CIUDAD, NOMBRE, APELLIDO, DIRECCION, FECHA_NACIMIENTO, DUI, TELEFONO, EMAIL) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                    pCliente.Id_ciudad, pCliente.Nombre, pCliente.Apellido, pCliente.Direccion, pCliente.Fecha_nacimiento, pCliente.Dui, pCliente.Telefono, pCliente.Email), conn);
                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }
        public static List<ClsCliente> CargarCliente()
        {
            List<ClsCliente> Lista = new List<ClsCliente>();
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("SELECT ID_CLIENTE, ID_CIUDAD, NOMBRE, APELLIDO, DIRECCION, FECHA_NACIMIENTO, DUI, TELEFONO, EMAIL FROM CLIENTE"), conexion);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    ClsCliente pCliente = new ClsCliente();
                    pCliente.Id_cliente = reader.GetInt32(0);
                    pCliente.Id_ciudad = reader.GetInt32(1);
                    pCliente.Nombre = reader.GetString(2);
                    pCliente.Apellido = reader.GetString(3);
                    pCliente.Direccion = reader.GetString(4);
                    pCliente.Fecha_nacimiento = reader.GetDateTime(5);
                    pCliente.Dui = reader.GetString(6);
                    pCliente.Telefono = reader.GetString(7);
                    pCliente.Email = reader.GetString(8);

                    Lista.Add(pCliente);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static List<ClsCliente> BuscarCliente(string pNombre)
        {
            List<ClsCliente> Lista = new List<ClsCliente>();
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("SELECT ID_CLIENTE, ID_CIUDAD, NOMBRE, APELLIDO, DIRECCION, FECHA_NACIMIENTO, DUI, TELEFONO, EMAIL FROM CLIENTE WHERE NOMBRE LIKE '{0}%'", pNombre), conexion);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    ClsCliente pCliente = new ClsCliente();
                    pCliente.Id_cliente = reader.GetInt32(0);
                    pCliente.Id_ciudad = reader.GetInt32(1);
                    pCliente.Nombre = reader.GetString(2);
                    pCliente.Apellido = reader.GetString(3);
                    pCliente.Direccion = reader.GetString(4);
                    pCliente.Fecha_nacimiento = reader.GetDateTime(5);
                    pCliente.Dui = reader.GetString(6);
                    pCliente.Telefono = reader.GetString(7);
                    pCliente.Email = reader.GetString(8);

                    Lista.Add(pCliente);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static ClsCliente ObtenerCliente(int pId_cliente)
        {
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                ClsCliente pCliente = new ClsCliente();
                SqlCommand Comando = new SqlCommand(string.Format("SELECT ID_CLIENTE, ID_CIUDAD, NOMBRE, APELLIDO, DIRECCION, FECHA_NACIMIENTO, DUI, TELEFONO, EMAIL FROM CLIENTE WHERE ID_CLIENTE = {0}", pId_cliente), conexion);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    pCliente.Id_cliente = reader.GetInt32(0);
                    pCliente.Id_ciudad = reader.GetInt32(1);
                    pCliente.Nombre = reader.GetString(2);
                    pCliente.Apellido = reader.GetString(3);
                    pCliente.Direccion = reader.GetString(4);
                    pCliente.Fecha_nacimiento = reader.GetDateTime(5);
                    pCliente.Dui = reader.GetString(6);
                    pCliente.Telefono = reader.GetString(7);
                    pCliente.Email = reader.GetString(8);
                }
                conexion.Close();
                return pCliente;
            }
        }
        public static int ModificarCliente(ClsCliente pCliente)
        {
            int retorno = 0;
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("UPDATE CLIENTE SET ID_CIUDAD = '{1}', NOMBRE = '{2}', APELLIDO = '{3}', DIRECCION = '{4}', FECHA_NACIMIENTO = '{5}', DUI = '{6}', TELEFONO = '{7}', EMAIL = '{8}' WHERE ID_CLIENTE = {0}",
                    pCliente.Id_cliente,pCliente.Id_ciudad, pCliente.Nombre, pCliente.Apellido, pCliente.Direccion, pCliente.Fecha_nacimiento, pCliente.Dui, pCliente.Telefono, pCliente.Email), conexion);

                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int EliminarCliente(int pId_Cliente)
        {
            int retorno = 0;
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("DELETE FROM CLIENTE WHERE ID_CLIENTE = {0}", pId_Cliente), conexion);

                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
    }
}
