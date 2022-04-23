using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.DAO;

namespace Sistema.Model
{
    public class ProdutoModel
    {
        public static int Inserir(ProdutoEnt objTabela)
        {
            return new ProdutoDAO().Inserir(objTabela);
        }
        public List<ProdutoEnt> Lista()
        {
            return new ProdutoDAO().Lista();
        }
        public static int Excluir(ProdutoEnt objTabela)
        {
            return new ProdutoDAO().Excluir(objTabela);
        }

        public static int Editar(ProdutoEnt objTabela)
        {
            return new ProdutoDAO().Editar(objTabela);
        }

        public List<ProdutoEnt> Buscar(ProdutoEnt objTabela)
        {
            return new ProdutoDAO().Buscar(objTabela);
        }
    }
}
