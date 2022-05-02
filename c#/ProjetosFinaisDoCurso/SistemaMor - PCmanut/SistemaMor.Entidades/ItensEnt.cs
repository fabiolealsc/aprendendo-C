using System.Drawing;

namespace SistemaMor.Entidades
{
    public class ItensEnt
    {
        private int id;
        private string item;
        private string descricao;
        private Image imagem;

        public int Id { get => id; set => id = value; }
        public string Item { get => item; set => item = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public Image Imagem { get => imagem; set => imagem = value; }
    }
}
