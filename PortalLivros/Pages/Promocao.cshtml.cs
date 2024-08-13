using Business;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PortalLivros.Pages
{
    public class PromocaoModel : PageModel
    {
        private readonly DestaqueBusiness _destaqueBusiness;
        public List<DestaqueEntity> listaDestaqueViewModel { get; set; }
        public PromocaoModel(DestaqueBusiness destaqueBusiness) 

        { 

            _destaqueBusiness =  destaqueBusiness;


        }
        public void OnGet()
        {
            listaDestaqueViewModel = _destaqueBusiness.ListarLivros();  
        }
    }
}
