using SistemaMor.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace SistemaMor.DAO
{
    public class ItensDAO
    {
        public int Inserir(ItensEnt objTabela, string table)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO " + table + " ([item], [descricao], [imagem]) VALUES (@item, @descricao, @imagem)";
                cn.Parameters.Add("item", SqlDbType.VarChar).Value = objTabela.Item;
                cn.Parameters.Add("descricao", SqlDbType.VarChar).Value = objTabela.Descricao;
                cn.Parameters.Add("imagem", SqlDbType.Image).Value = imageToByteArray(objTabela.Imagem);

                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();

                return qtd;
            }
        }
        public List<ItensEnt> Lista(string table)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM " + table;

                cn.Connection = con;

                SqlDataReader dr;
                List<ItensEnt> lista = new List<ItensEnt>();

                dr = cn.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ItensEnt dado = new ItensEnt();
                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Item = Convert.ToString(dr["item"]);
                        dado.Descricao = Convert.ToString(dr["descricao"]);
                        try
                        {
                            dado.Imagem = ByteToImage((byte[])dr["imagem"]);
                        }
                        catch { }

                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }
        public int Editar(ItensEnt objTabela, string table)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "UPDATE " + table + " SET item = @item, descricao = @descricao, imagem = @imagem WHERE id = @id";

                cn.Parameters.Add("Item", SqlDbType.VarChar).Value = objTabela.Item;
                cn.Parameters.Add("descricao", SqlDbType.VarChar).Value = objTabela.Descricao;
                cn.Parameters.Add("imagem", SqlDbType.Image).Value = imageToByteArray(objTabela.Imagem);
                cn.Parameters.Add("id", SqlDbType.Int).Value = objTabela.Id;

                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();

                return qtd;
            }
        }
        public int Excluir(ItensEnt objTabela, string table)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM " + table + " WHERE id = @id";
                cn.Parameters.Add("table", SqlDbType.VarChar).Value = table;
                cn.Parameters.Add("id", SqlDbType.Int).Value = objTabela.Id;
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();

                return qtd;
            }
        }
        public List<ItensEnt> Buscar(ItensEnt objTabela, string table)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM " + table + " WHERE descricao LIKE @descricao";
                cn.Parameters.Add("table", SqlDbType.VarChar).Value = table;
                cn.Parameters.Add("descricao", SqlDbType.VarChar).Value = objTabela.Descricao + "%";
                cn.Connection = con;

                SqlDataReader dr;
                List<ItensEnt> lista = new List<ItensEnt>();

                dr = cn.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ItensEnt dado = new ItensEnt();
                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Item = Convert.ToString(dr["item"]);
                        dado.Descricao = Convert.ToString(dr["descricao"]);
                        dado.Imagem = ByteToImage((byte[])dr["Imagem"]);

                        lista.Add(dado);
                    }
                }
                return lista;
            };
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        public Image ByteToImage(byte[] imageArray)
        {
            ImageConverter converter = new ImageConverter();
            return (Image)converter.ConvertFrom(imageArray);
        }
    }
}
