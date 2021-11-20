using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

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
                
                cmd.CommandText = "SELECT item as 'Código do Item', descricao as 'Descrição' FROM " + table;
                da = new SQLiteDataAdapter(cmd.CommandText, cban);
                da.Fill(dt);
                cban.Close();
                return (dt);
                
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public static void cadastrar(int ite, String descrica, String table)
        {
            int it = ite;
            string desc = descrica;
            String tab = table;

            try
            {
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO " + tab + " (item, descricao, id) VALUES (@it,@desc, NULL)";
                cmd.Parameters.AddWithValue("@it", it);
                cmd.Parameters.AddWithValue("@desc", desc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastrou!");
                ConexaoBanco().Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable deletar(String btn, int codigo)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "DELETE FROM " + btn + " WHERE item=" + codigo;
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                da.Fill(dt);
                ConexaoBanco().Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
         
    }
}
