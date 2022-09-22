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
    public class ListaMascotasModel : PageModel
    {

        private readonly IRepositorioMascota _repoMascota;
        private readonly IRepositorioDueno _repoDueno;
        //private readonly IRepositorioMascota _repoVeterinario;

        public IEnumerable<Mascota> listaMascotas {get;set;}


        public ListaMascotasModel()
        {
            this._repoMascota = new RepositorioMascota(new Persistencia.AppContext());
            this._repoDueno = new RepositorioDueno(new Persistencia.AppContext());
            //this._repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        }

        public void OnGet()
        {
            listaMascotas = _repoMascota.GetAllMascotas();
        }

        /*public void OnPost(int idMascota)
        {
            _repoMascota.DeleteMascota(idMascota);
            ViewData["Respuesta"]= Alerts.ShowAlert(Alert.Danger, "<span> La mascota seleccionada se eliminó.</span>");
            Mascotas = _repoMascota.GetAllMascotas();
        }*/
    }
}
