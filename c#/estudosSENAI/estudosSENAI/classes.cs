using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosSENAI
{
    public class Pessoa
    {
        String nome;
        int idade;
        int altura;
        bool sabeNadar;
        private static int quantidadePessoas = 0;
        public void andar(float velocidade)
        {

        }
        public void nadar(float velocidade)
        {

        }
        public Pessoa(String nome, int idade, int altura, bool sabeNadar)
        {
            quantidadePessoas++;
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            this.sabeNadar = sabeNadar;
        }
        public static int getQuantidadePessoas()
        {
            return quantidadePessoas;
        }
    }
}
