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
    public class Cliente : Pessoa
    {
        bool clienteEspecial;
        public Cliente(String nome, int idade, int altura, bool sabeNadar, bool clienteEspecial)
            : base(nome, idade, altura, sabeNadar)
        {
            this.clienteEspecial = clienteEspecial;
        }
        public bool comprar(Produto p)
        {
            return true;
        }
        public void irAoCaixa(float velocidade)
        {
            base.andar(velocidade);
            this.pagar();
        }
        public Cliente(string Nome, string Cpf): base(Nome, Cpf)
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
        }
        public Cliente() : base("","")
        {
            //É criado um objeto Cliente vazio.
        }
        public virtual bool comprar(Produto P)
        {
            return true;
        }
    }
    public class ClienteEspecial : Cliente
    {
        public override bool comprar(Produto p)
        {
            return true;
        }
    }
}
