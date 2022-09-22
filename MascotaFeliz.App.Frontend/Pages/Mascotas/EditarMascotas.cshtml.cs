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
    public class EditarMascotasModel : PageModel
    {
        private readonly IRepositorioMascota _repoMascota;
        private static IRepositorioDueno _repoDueno = new RepositorioDueno (new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario (new Persistencia.AppContext());
        
        [BindProperty]
        public Mascota mascota {get;set;}
        public Dueno dueno {get;set;}
        public Veterinario veterinario {get;set;}
        
        public IEnumerable<Dueno> duenos {get;set;}
        public IEnumerable<Veterinario> veterinarios {get;set;}

        public EditarMascotasModel()
        {
            this._repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        }
        
        public IActionResult OnGet(int? mascotaId)
        {
            duenos = _repoDueno.GetAllDuenos();
            veterinarios = _repoVeterinario.GetAllVeterinarios();

            if (mascotaId.HasValue)
            {
                mascota = _repoMascota.GetMascota(mascotaId.Value);
                
            }
            else 
            {
                mascota = new Mascota();
                
            }
            if(mascota == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();  
        }
         
        public IActionResult OnPost(int? idDueno)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(mascota.Id>0)
            {
                
                mascota = _repoMascota.UpdateMascota(mascota);
                if (idDueno.HasValue)
                {
                    mascota = _repoMascota.AsignarDueno(mascota.Id, idDueno.Value);
                }
                
                return RedirectToPage ("./ListaMascotas");
            }
            else
            {
                _repoMascota.AddMascota(mascota);
                //_repoMascota.AsignarDueno(mascota.Id, idDueno.Value);

                return RedirectToPage ("./ListaMascotas");
            }
            return Page();
        }   
    }
}
