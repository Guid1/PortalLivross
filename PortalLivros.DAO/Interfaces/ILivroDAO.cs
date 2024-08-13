using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Interfaces
{
    public interface ILivroDAO
    {
        public List<LivroEntity> ListarLivros();
    }

}
