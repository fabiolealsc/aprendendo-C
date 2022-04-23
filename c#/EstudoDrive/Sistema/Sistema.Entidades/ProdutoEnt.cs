using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class ProdutoEnt
    {
        private int id;
        private string produto;
        private string descricao;
        private double valor;

        public int Id { get => id; set => id = value; }
        public string Produto { get => produto; set => produto = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Valor { get => valor; set => valor = value; }
    }
}
