using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.DAO
{
    public class ProdutoDAO
    {
        public int Inserir(ProdutoEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO produtos ([produto], [descricao], [valor]) VALUES (@produto, @descricao, @valor)";
                cn.Parameters.Add("produto", SqlDbType.VarChar).Value = objTabela.Produto;
                cn.Parameters.Add("descricao", SqlDbType.VarChar).Value = objTabela.Descricao;
                cn.Parameters.Add("valor", SqlDbType.VarChar).Value = objTabela.Valor;

                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();

                return qtd;
            }
        }
        public List<ProdutoEnt> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM produtos";
                cn.Connection = con;

                SqlDataReader dr;
                List<ProdutoEnt> lista = new List<ProdutoEnt>();

                dr = cn.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ProdutoEnt dado = new ProdutoEnt();
                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Produto = Convert.ToString(dr["produto"]);
                        dado.Descricao = Convert.ToString(dr["descricao"]);
                        dado.Valor = Convert.ToDouble(dr["valor"]);

                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }
        public List<ProdutoEnt> Buscar(ProdutoEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM produtos WHERE produto LIKE @produto";
                cn.Parameters.Add("produto", SqlDbType.VarChar).Value = objTabela.Produto + "%";
                cn.Connection = con;

                SqlDataReader dr;
                List<ProdutoEnt> lista = new List<ProdutoEnt>();

                dr = cn.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ProdutoEnt dado = new ProdutoEnt();
                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Produto = Convert.ToString(dr["produto"]);
                        dado.Descricao = Convert.ToString(dr["descricao"]);
                        dado.Valor = Convert.ToDouble(dr["valor"]);

                        lista.Add(dado);
                    }
                }
                return lista;
            };

        }
        public int Excluir(ProdutoEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM produtos where id = @id";
                cn.Parameters.Add("id", SqlDbType.Int).Value = objTabela.Id;
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();

                return qtd;
            }
        }
        public int Editar(ProdutoEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "UPDATE produtos SET produto = @produto, descricao = @descricao, valor = @valor WHERE id = @id";

                cn.Parameters.Add("produto", SqlDbType.VarChar).Value = objTabela.Produto;
                cn.Parameters.Add("descricao", SqlDbType.VarChar).Value = objTabela.Descricao;
                cn.Parameters.Add("valor", SqlDbType.VarChar).Value = objTabela.Valor;
                cn.Parameters.Add("id", SqlDbType.Int).Value = objTabela.Id;

                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();

                return qtd;
            }
        }
    }
}
