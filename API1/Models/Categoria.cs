using System.Collections.ObjectModel;

namespace API1.Models
{
    public class Categoria
    {
        public Categoria()
        {
            Produtos = new Collection<Produto>();
        }

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? ImageUrl { get; set; }
        public ICollection<Produto>? Produtos { get; set; }
    }
}