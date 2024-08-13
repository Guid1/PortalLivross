using Business;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PortalLivros.Models;

namespace PortalLivros.Pages
{
    public class LivrosModel : PageModel
    {
        private readonly ILogger<LivrosModel> _logger;

        private readonly LivroBusiness _livroBusiness;
        public List<LivroEntity> listaLivroViewModel { get; set; }
        
        public LivrosModel(ILogger<LivrosModel> logger, LivroBusiness livroBusiness)       
        {
            _logger = logger;
            _livroBusiness = livroBusiness;
        }

        public void OnGet()
        {
            //recebe tudo de business
            listaLivroViewModel = _livroBusiness.ListarLivros();
        }


    }
}
