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
        private readonly IRepositorioDueno _repoDueno;
        private readonly IRepositorioVeterinario _repoVeterinario;
        private readonly IRepositorioHistoria _repoHistoria;
        [BindProperty]
        public Mascota mascota { get; set; }
        public Veterinario veterinario { get; set; }
        public Dueno dueno { get; set; }
        public Historia historia {get;set;}

        public IEnumerable<Dueno> listaDuenos { get; set; }
        public IEnumerable<Veterinario> listaVeterinarios { get; set; }


        public EditarMascotasModel()
        {
            this._repoMascota = new RepositorioMascota(new Persistencia.AppContext());
            this._repoDueno = new RepositorioDueno(new Persistencia.AppContext());
            this._repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
            this._repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        }

        public void OnGet(int? mascotaId)
        {
            listaDuenos = _repoDueno.GetAllDuenos();
            listaVeterinarios = _repoVeterinario.GetAllVeterinarios();

            if (mascotaId.HasValue)
            {
                mascota = _repoMascota.GetMascota(mascotaId.Value);
            }
            else 
            {
                mascota = new Mascota();
            }
            if (mascota == null)
            {
                RedirectToPage("./NotFound");
            }
                Page();
            
        }

        public IActionResult OnPost(Mascota mascota, int duenoId, int veterinarioId, int historiaId)
        {
            if (ModelState.IsValid)
            {
                dueno = _repoDueno.GetDueno(duenoId);
                veterinario = _repoVeterinario.GetVeterinario(veterinarioId);
                historia = _repoHistoria.GetHistoria(historiaId);
                if (mascota.Id > 0)
                {
                    mascota.Veterinario = veterinario;
                    mascota.Dueno = dueno;
                    mascota.Historia = historia;
                    mascota = _repoMascota.UpdateMascota(mascota);
                }
                else
                {
                    mascota = _repoMascota.AddMascota(mascota);
                    _repoMascota.AsignarDueno(mascota.Id,dueno.Id);
                    _repoMascota.AsignarVeterinario(mascota.Id,veterinario.Id);
                    historia = new Historia();
                    historia = _repoHistoria.AddHistoria(historia);
                    _repoMascota.AsignarHistoria(mascota.Id,historia.Id);
                }
                return RedirectToPage("/Mascotas/ListaMascotas");

            }
            else
            {
               return Page();
            }
        }
    }
}
