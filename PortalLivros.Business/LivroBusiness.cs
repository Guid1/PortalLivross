using DAO.Interfaces;
using Entity;
using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    
    public class LivroBusiness          
    { 
        private readonly ILivroDAO _livroDAO;
        public LivroBusiness(ILivroDAO livroDAO)                        
        { 
            _livroDAO = livroDAO;   
                                                                                                             
        }


        public List<LivroEntity> ListarLivros() 
        {
            List<LivroEntity> listaLivro = _livroDAO.ListarLivros();

            return listaLivro;           
        }

    }
}
