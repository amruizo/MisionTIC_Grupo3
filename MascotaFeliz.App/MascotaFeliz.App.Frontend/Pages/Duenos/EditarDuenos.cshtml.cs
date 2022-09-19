using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class EditarDuenosModel : PageModel
    {
         private readonly IRepositorioDueno _repoDueno;
        public Dueno dueno {get;set;}
        public EditarDuenosModel()
            {
                this._repoDueno = new RepositorioDueno(new Persistencia.AppContext());
            }

        
       
        public void OnGet()
        {
        }
    }
}
