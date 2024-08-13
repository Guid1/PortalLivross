using DAO.Interfaces;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class DestaqueBusiness
    {
        private readonly IDestaqueDAO _destaqueDAO;
        public DestaqueBusiness(IDestaqueDAO destaqueDAO)
        {
            _destaqueDAO = destaqueDAO;

        }


        public List<DestaqueEntity> ListarLivros()
        {
            List<DestaqueEntity> listaLivro = _destaqueDAO.ListarLivros();

            return listaLivro;
        }

    }
}
