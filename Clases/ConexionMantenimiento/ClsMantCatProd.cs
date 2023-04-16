using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Clases
{
    public class ClsMantCatProd
    {
        public static int AgregarCateProd(ClsCategoriaProducto pCateProd)
        {
            int retorno = 0;
            using (SqlConnection conn = ClsConexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into CATEGORIA_PRODUCTO(NOMBRE) values ('{0}')",
                    pCateProd.Nombre), conn);
                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }
        public static List<ClsCategoriaProducto> CargarCategoriaProducto()
        {
            List<ClsCategoriaProducto> Lista = new List<ClsCategoriaProducto>();
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("SELECT ID_CATEGORIA, NOMBRE FROM CATEGORIA_PRODUCTO"), conexion);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    ClsCategoriaProducto pCateProducto = new ClsCategoriaProducto();
                    pCateProducto.Id_categoria = reader.GetInt32(0);
                    pCateProducto.Nombre = reader.GetString(1);

                    Lista.Add(pCateProducto);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static List<ClsCategoriaProducto> BuscarCategoriaProducto(string pNombre)
        {
            List<ClsCategoriaProducto> Lista = new List<ClsCategoriaProducto>();
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("SELECT ID_CATEGORIA, NOMBRE FROM CATEGORIA_PRODUCTO WHERE NOMBRE LIKE '{0}%'", pNombre), conexion);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    ClsCategoriaProducto pCateProd = new ClsCategoriaProducto();
                    pCateProd.Id_categoria = reader.GetInt32(0);
                    pCateProd.Nombre = reader.GetString(1);

                    Lista.Add(pCateProd);
                }
                conexion.Close();
                return Lista;
            }
        }
        public static ClsCategoriaProducto ObtenerCategoriaProducto(int pId_cateprod)
        {
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                ClsCategoriaProducto pCateProd= new ClsCategoriaProducto();
                SqlCommand Comando = new SqlCommand(string.Format("SELECT ID_CATEGORIA, NOMBRE FROM CATEGORIA_PRODUCTO WHERE ID_CATEGORIA = {0}", pId_cateprod), conexion);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    pCateProd.Id_categoria = reader.GetInt32(0);
                    pCateProd.Nombre = reader.GetString(1);
                }
                conexion.Close();
                return pCateProd;
            }
        }
        public static int ModificarCategoriaProducto(ClsCategoriaProducto pCateProd)
        {
            int retorno = 0;
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("UPDATE CATEGORIA_PRODUCTO SET NOMBRE = '{1}' WHERE ID_CATEGORIA = {0}",
                    pCateProd.Id_categoria, pCateProd.Nombre), conexion);

                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int EliminarCategoriaProducto(int pId_CateProd)
        {
            int retorno = 0;
            using (SqlConnection conexion = ClsConexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("DELETE FROM CATEGORIA_PRODUCTO WHERE ID_CATEGORIA = {0}", pId_CateProd), conexion);

                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
    }
}
