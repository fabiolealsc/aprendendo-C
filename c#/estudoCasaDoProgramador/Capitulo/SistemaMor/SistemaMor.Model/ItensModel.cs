using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaMor.Entidades;
using SistemaMor.DAO;

namespace SistemaMor.Model
{
    public class ItensModel
    {
        public static int Inserir(ItensEnt objTabela, string table)
        {
            return new ItensDAO().Inserir(objTabela, table);
        }
        public List<ItensEnt> Lista(string table)
        {
            return new ItensDAO().Lista(table);
        }
        public static int Excluir(ItensEnt objTabela, string table)
        {
            return new ItensDAO().Excluir(objTabela, table);
        }

        public static int Editar(ItensEnt objTabela, string table)
        {
            return new ItensDAO().Editar(objTabela, table);
        }

        public List<ItensEnt> Buscar(ItensEnt objTabela, string table)
        {
            return new ItensDAO().Buscar(objTabela, table);
        }
    }
}

