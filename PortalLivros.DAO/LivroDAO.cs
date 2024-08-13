using DAO.Interfaces;
using Entity;
using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LivroDAO : ILivroDAO   
    {
        private readonly LivroContext _livroContext;
        public LivroDAO(LivroContext livroContext)
        { 
            _livroContext = livroContext;   
        }

        public List<LivroEntity> ListarLivros()
        {
            List<LivroEntity> listaLivro = _livroContext.Livros.ToList();

            return listaLivro;
        }




    }
}
