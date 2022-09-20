using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioVisitaPyP : IRepositorioVisitaPyP
    {
        
        private readonly AppContext _appContext;
        
        
        public RepositorioVisitaPyP(AppContext appContext)
        {
            _appContext = appContext;
        }

        public VisitaPyP AddVisitaPyP(VisitaPyP visitaPyP)
        {
            var visitaPyPAdicionado = _appContext.VisitasPyP.Add(visitaPyP);
            _appContext.SaveChanges();
            return visitaPyPAdicionado.Entity;
        }

        public void DeleteVisitaPyP(int idVisitaPyP)
        {
            var visitaPyPEncontrada = _appContext.VisitasPyP.FirstOrDefault(d => d.Id == idVisitaPyP);
            if (visitaPyPEncontrada == null)
                return;
            _appContext.VisitasPyP.Remove(visitaPyPEncontrada);
            _appContext.SaveChanges();
        }

       public IEnumerable<VisitaPyP> GetAllVisitasPyP()
        {
            return GetAllVisitasPyP_();
        }

        public IEnumerable<VisitaPyP> GetAllVisitasPyP_()
        {
            return _appContext.VisitasPyP;
        }

        public VisitaPyP GetVisitaPyP(int idVisitaPyP)
        {
            return _appContext.VisitasPyP.FirstOrDefault(d => d.Id == idVisitaPyP);
        }

        public VisitaPyP UpdateVisitaPyP(VisitaPyP visitaPyP)
        {
            var visitaPyPEncontrada = _appContext.VisitasPyP.FirstOrDefault(d => d.Id == visitaPyP.Id);
            if (visitaPyPEncontrada != null)
            {
                visitaPyPEncontrada.FechaVisita = visitaPyP.FechaVisita;
                visitaPyPEncontrada.Temperatura = visitaPyP.Temperatura;
                visitaPyPEncontrada.Peso = visitaPyP.Peso;
                visitaPyPEncontrada.FrecuenciaRespiratoria = visitaPyP.FrecuenciaRespiratoria;
                visitaPyPEncontrada.FrecuenciaCardiaca = visitaPyP.FrecuenciaCardiaca;
                visitaPyPEncontrada.EstadoAnimo = visitaPyP.EstadoAnimo;
                visitaPyPEncontrada.IdVeterinario = visitaPyP.IdVeterinario;
                visitaPyPEncontrada.Recomendaciones = visitaPyP.Recomendaciones;
                _appContext.SaveChanges();
            }
            return visitaPyPEncontrada;
        }     
    }
}