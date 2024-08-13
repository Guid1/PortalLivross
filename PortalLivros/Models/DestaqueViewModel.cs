namespace PortalLivros.Models
{
    public class DestaqueViewModel
    {
        public int Id { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public int IdLivro { get; set; }

        public LivroViewModel LivroViewModel{ get; set; }    
    }
}
