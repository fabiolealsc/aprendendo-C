    public class Bebida : Alimento
    {
        private const string TIPO = "Bebida";
        public Bebida(string _nome, double _calorias, double _preco, string _unidade)
            : base(_nome, TIPO, _calorias, _preco, _unidade)
        {
        }
    }

    public class Matinal : Alimento
    {
        private const string TIPO = "Matinal";
        public Matinal(string _nome, double _calorias, double _preco, string _unidade)
            : base(_nome, TIPO, _calorias, _preco, _unidade)
        {
        }
    }

    public class Peixe : Alimento
    {
        private const string TIPO = "Peixe";
        public Peixe(string _nome, double _calorias, double _preco, string _unidade)
            : base(_nome, TIPO, _calorias, _preco, _unidade)
        {
        }
    }

    public class Fruta : Alimento
    {
        private const string TIPO = "Fruta";
        private const string UNIDADE = "Kg";
        public Fruta(string _nome, double _calorias, double _preco)
            : base(_nome, TIPO, _calorias, _preco, UNIDADE)
        {
        }
    }

    public class Proteina : Alimento
    {
        private const string TIPO = "Proteina";
        public Proteina(string _nome, double _calorias, double _preco, string _unidade)
            : base(_nome, TIPO, _calorias, _preco, _unidade)
        {
        }
    }

    public class Vegetal : Alimento
    {
        private const string TIPO = "Vegetal";
        public Vegetal(string _nome, double _calorias, double _preco, string _unidade)
            : base(_nome, TIPO, _calorias, _preco, _unidade)
        {
        }
    }

    public class Banana : Fruta
    {
        private const string NOME = "Banana";
        private const double CALORIAS = 121;
        private const double PRECO = 1.50;
        public Banana()
            : base(NOME, CALORIAS, PRECO)
        {
        }
    }

    public class Cenoura : Vegetal
    {
        private const string NOME = "Cenoura";
        private const double CALORIAS = 27;
        private const double PRECO = 2.80;
        private const string UNIDADE = "kg";
        public Cenoura()
            : base(NOME, CALORIAS, PRECO, UNIDADE)
        {
        }
    }

    public class Queijo : Matinal
    {
        private const string NOME = "Queijo";
        private const double CALORIAS = 200;
        private const double PRECO = 6.50;
        private const string UNIDADE = "kg";
        public Queijo()
            : base(NOME, CALORIAS, PRECO, UNIDADE)
        {
        }
    }

    public class Ovo : Proteina
    {
        private const string NOME = "Ovo";
        private const double CALORIAS = 54;
        private const double PRECO = 3.50;
        private const string UNIDADE = "Duzia";
        public Ovo()
            : base(NOME, CALORIAS, PRECO, UNIDADE)
        {
        }
    }

    public class Alface : Vegetal
    {
        private const string NOME = "Alface";
        private const double CALORIAS = 4;
        private const double PRECO = 1.99;
        private const string UNIDADE = "unidade";
        public Alface()
            : base(NOME, CALORIAS, PRECO, UNIDADE)
        {
        }
    }

    public class Leite : Matinal
    {
        private const string NOME = "Leite";
        private const double CALORIAS = 90;
        private const double PRECO = 2.15;
        private const string UNIDADE = "Litro";
        public Leite()
            : base(NOME, CALORIAS, PRECO, UNIDADE)
        {
        }
    }

    public class Guarana : Bebida
    {
        private const string NOME = "Guarana";
        private const double CALORIAS = 120;
        private const double PRECO = 2.50;
        private const string UNIDADE = "Litro";
        public Guarana()
            : base(NOME, CALORIAS, PRECO, UNIDADE)
        {
        }
    }

    public class Agua : Bebida
    {
        private const string NOME = "Agua";
        private const double CALORIAS = 0.1;
        private const double PRECO = 1.25;
        private const string UNIDADE = "Litro";
        public Agua()
            : base(NOME, CALORIAS, PRECO, UNIDADE)
        {
        }
    }

    public class Laranja : Fruta
    {
        private const string NOME = "Laranja";
        private const double CALORIAS = 85;
        private const double PRECO = 1.50;
        public Laranja()
            : base(NOME, CALORIAS, PRECO)
        {
        }
    }

    public class Presunto : Proteina
    {
        private const string NOME = "`Presunto";
        private const double CALORIAS = 2.10;
        private const double PRECO = 5.40;
        private const string UNIDADE = "kg";
        public Presunto()
            : base(NOME, CALORIAS, PRECO, UNIDADE)
        {
        }
    }

    public class Salmao : Peixe
    {
        private const string NOME = "Salmão";
        private const double CALORIAS = 233;
        private const double PRECO = 8.60;
        private const string UNIDADE = "kg";
        public Salmao()
            : base(NOME, CALORIAS, PRECO, UNIDADE)
        {
        }
    }

    public class Tomate : Fruta
    {
        private const string NOME = "Tomate";
        private const double CALORIAS = 27;
        private const double PRECO = 3.50;
        public Tomate()
            : base(NOME, CALORIAS, PRECO)
        {
        }
    }
