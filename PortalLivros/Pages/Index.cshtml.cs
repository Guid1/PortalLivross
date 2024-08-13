using Business;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PortalLivros.Models;

namespace PortalLivros.Pages
{
    public class IndexModel : PageModel
    {

        private readonly ILogger<IndexModel> _logger;

        private readonly DestaqueBusiness _destaqueBusiness;
        public List<DestaqueEntity> listaDestaqueViewModel { get; set; }

        public IndexModel(ILogger<IndexModel> logger, DestaqueBusiness destaqueBusiness)           // construtor, eu adicionei um parâmetro da classe DestaqueBussines pra fazer a injeção
        {
            _logger = logger;
            _destaqueBusiness = destaqueBusiness;
        }

        public void OnGet()
        {
            //recebe tudo de business
            listaDestaqueViewModel = _destaqueBusiness.ListarLivros();
        }
    }
}
