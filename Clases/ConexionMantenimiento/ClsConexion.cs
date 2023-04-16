using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Clases
{
    public class ClsConexion
    {
        public static SqlConnection obtenerConexion()
        {
            SqlConnection conn = new SqlConnection("Data source = NOTEBOOK\\SQLEXPRESS ; Initial Catalog = PROYECTO; Integrated Security = True");
            conn.Open();
            return conn;
            //DESKTOP-SDL25K5
            //NOTEBOOK\\SQLEXPRESS
        }

    }
}
