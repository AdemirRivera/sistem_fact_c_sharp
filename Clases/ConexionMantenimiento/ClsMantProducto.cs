using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Clases
{
    public class ClsMantProducto
    {
        public static int AgregarProducto(ClsProducto pProducto)
        {
            int retorno = 0;
            using (SqlConnection conn = ClsConexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into PRODUCTO(ID_PROVEEDOR, ID_CATEGORIA_PRODUCTO, NOMBRE, PRECIO,EXISTENCIAS, FECHA_VENCIMIENTO) values ('{0}','{1}','{2}','{3}','{4}','{5}')",
                    pProducto.Id_proveedor, pProducto.Id_categoria_producto, pProducto.Nombre, pProducto.Precio, pProducto.Existencias, pProducto.Fecha_Vencimiento), conn);
                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }

        public static List<ClsProducto> CargarProducto()
        {
            List<ClsProducto> Lista = new List<ClsProducto>();
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("SELECT ID_PRODUCTO,ID_PROVEEDOR,ID_CATEGORIA_PRODUCTO,NOMBRE,PRECIO,EXISTENCIAS,FECHA_VENCIMIENTO FROM PRODUCTO"), conexion);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    ClsProducto pProducto = new ClsProducto();
                    pProducto.Id_producto = reader.GetInt32(0);
                    pProducto.Id_proveedor = reader.GetInt32(1);
                    pProducto.Id_categoria_producto = reader.GetInt32(2);
                    pProducto.Nombre = reader.GetString(3);
                    pProducto.Precio = reader.GetDecimal(4);
                    pProducto.Existencias = reader.GetInt32(5);
                    pProducto.Fecha_Vencimiento = reader.GetDateTime(6);

                    Lista.Add(pProducto);
                }
                conexion.Close();
                return Lista;
            }
        }

            public static List<ClsProducto> BuscarProducto(string pNombre)
        {
            List<ClsProducto> Lista = new List<ClsProducto>();
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Select Id_Producto, Categoria, Nombre, Precio, Existencias, Fecha_Vencimiento from Producto where NOMBRE like '%{0}%'", pNombre), conexion);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    ClsProducto pProducto = new ClsProducto();
                    pProducto.Id_producto = reader.GetInt32(0);
                    pProducto.Id_categoria_producto = reader.GetInt32(1);
                    pProducto.Nombre = reader.GetString(2);
                    pProducto.Precio = reader.GetDecimal(3);
                    pProducto.Existencias = reader.GetInt32(4);
                    pProducto.Fecha_Vencimiento = reader.GetDateTime(5);

                    Lista.Add(pProducto);
                }
                conexion.Close();
                return Lista;
            }
        }

        public static ClsProducto ObtenerProducto(int pId)
        {
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                ClsProducto pProducto = new ClsProducto();
                SqlCommand Comando = new SqlCommand(string.Format(" Select ID_PRODUCTO,ID_PROVEEDOR, ID_CATEGORIA_PRODUCTO, NOMBRE, PRECIO, EXISTENCIAS, FECHA_VENCIMIENTO from PRODUCTO where ID_PRODUCTO={0}", pId), conexion);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    pProducto.Id_producto = reader.GetInt32(0);
                    pProducto.Id_proveedor = reader.GetInt32(1);
                    pProducto.Id_categoria_producto = reader.GetInt32(2);
                    pProducto.Nombre = reader.GetString(3);
                    pProducto.Precio = reader.GetDecimal(4);
                    pProducto.Existencias = reader.GetInt32(5);
                    pProducto.Fecha_Vencimiento = reader.GetDateTime(6);
                }
                conexion.Close();
                return pProducto;
            }
        }
        public static int EliminarProducto(int pId_Producto)
        {
            int retorno = 0;
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("DELETE FROM PRODUCTO WHERE ID_PRODUCTO = {0}", pId_Producto), conexion);

                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int ModificarProducto(ClsProducto pProducto)
        {
            int retorno = 0;
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("UPDATE PRODUCTO SET ID_PROVEEDOR = '{1}', ID_CATEGORIA_PRODUCTO = '{2}', NOMBRE = '{3}', PRECIO = '{4}', EXISTENCIAS = '{5}', FECHA_VENCIMIENTO = '{6}' WHERE ID_PRODUCTO = {0}",
                    pProducto.Id_producto, pProducto.Id_proveedor, pProducto.Id_categoria_producto, pProducto.Nombre, pProducto.Precio, pProducto.Existencias, pProducto.Fecha_Vencimiento), conexion);

                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
    }
}
