using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    [Table("DESTAQUE")]
    public class DestaqueEntity
    {
        [Key]
        public int Id { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }
        [ForeignKey("IdLivro")]
        public int IdLivro { get; set; }

        public LivroEntity Livro { get; set; }

    }
}
