using System.Data.SqlClient;

namespace Model.DAO
{
    internal class ConexaoDB
    {
        private static ConexaoDB objConexaoDB = null;
        private SqlConnection con;
        private ConexaoDB() => con = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = financeiro; Integrate Security = True");

        public static ConexaoDB saberEstado()
        {
            if (objConexaoDB == null)
            {
                objConexaoDB = new ConexaoDB();
            }
            return objConexaoDB;
        }
        public SqlConnection getCon() => con;
        public void CloseDB() => objConexaoDB = null;
    }
}
