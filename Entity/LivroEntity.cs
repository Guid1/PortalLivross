using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    [Table("Livros")]
    public class LivroEntity
    {
        [Key]
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public decimal Preco { get; set; }

        public string Url { get; set; }



    }
}
