using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace projetoElias
{
    class Banco
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source = C:\\Users\\fabio\\Documents\\estudos\\fabiolealsc\\aprendendo-C\\c#\\projetoElias\\banco\\banco_itens.db");
            conexao.Open();
            return conexao;
        }
        public static DataTable ObterDados(String table)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var cban = ConexaoBanco();
                var cmd = cban.CreateCommand();
                
                cmd.CommandText = "SELECT item, descricao FROM " + table;
                da = new SQLiteDataAdapter(cmd.CommandText, cban);
                da.Fill(dt);
                cban.Close();
                return (dt);
                
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
