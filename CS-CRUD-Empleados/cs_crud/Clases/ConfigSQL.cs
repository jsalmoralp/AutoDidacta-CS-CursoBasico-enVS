using System.Data.SqlClient;

namespace cs_crud.Clases
{
    class ConfigSQL
    {
        public static SqlConnection ConexionBdSQL()
        {
            string cadena = @"Data Source=DESKTOP-L54VDI4\RASKANSQL;Initial Catalog=cs_crud;Integrated Security=True;";
            SqlConnection databaseconnection = new SqlConnection(cadena);
            return databaseconnection;
        }
    }
}
