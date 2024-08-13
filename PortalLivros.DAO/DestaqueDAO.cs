using DAO.Interfaces;
using Entity;
using Infra;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DestaqueDAO : IDestaqueDAO
    {
        private readonly LivroContext _livroContext;
        public DestaqueDAO(LivroContext livroContext)
        {
            _livroContext = livroContext;
        }

        public List<DestaqueEntity> ListarLivros()
        {
            List<DestaqueEntity> listaLivro = _livroContext.Destaque.Include(x=> x.Livro).ToList();

            return listaLivro;
        }

    }
}
