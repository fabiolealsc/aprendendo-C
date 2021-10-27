    public class Alimento
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public double Custo { get; set; }
        public string Tipo { get; set; }
        public string Unidade { get; set; }
        public double Calorias { get; set; } 
        public Alimento(string _nome, string _tipo, double _calorias, double _preco, string _unidade)
        {
            Nome = _nome;
            Tipo = _tipo;
            Calorias = _calorias;
            Preco = _preco;
            Unidade = _unidade;
        }
        public void SetCusto(double _quantidade)
        {
            Custo += Preco * _quantidade;
        }
        public double  GetCustoCompra(double _quantidade)
        {
            return _quantidade * Preco;
        }
        public void ResetarCusto()
        {
            Custo = 0;
        }
    }
