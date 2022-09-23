using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioHistoria : IRepositorioHistoria
    {
        
        private readonly AppContext _appContext;
                
        public RepositorioHistoria(AppContext appContext)
        {
            _appContext = appContext;
        }

        public Historia AddHistoria(Historia historia)
        {
            var historiaAdicionada = _appContext.Historias.Add(historia);
            
            _appContext.SaveChanges();
            return historiaAdicionada.Entity;
        }

        public void DeleteHistoria(int idHistoria)
        {
            var historiaEncontrada = _appContext.Historias.FirstOrDefault(d => d.Id == idHistoria);
            if (historiaEncontrada == null)
                return;
            _appContext.Historias.Remove(historiaEncontrada);
            _appContext.SaveChanges();
        }

       public IEnumerable<Historia> GetAllHistorias()
        {
            return _appContext.Historias.Include(a => a.VisitasPyP);
        }

        public Historia GetHistoria(int idHistoria)
        {
            return _appContext.Historias.Include(a => a.VisitasPyP).FirstOrDefault(d => d.Id == idHistoria);
        }

        public Historia UpdateHistoria(Historia historia)
        {
            var historiaEncontrada = _appContext.Historias.FirstOrDefault(d => d.Id == historia.Id);
            if (historiaEncontrada != null)
            {
                historiaEncontrada.FechaInicial = historia.FechaInicial;
                historiaEncontrada.VisitasPyP = historia.VisitasPyP;
                _appContext.SaveChanges();
            }
            return historiaEncontrada;
        }     

        public VisitaPyP AsignarVisita (int idHistoria, int idVisita)  
        {
            var historiaEncontrado = _appContext.Historias.FirstOrDefault(m => m.Id == idHistoria);
            if (historiaEncontrado != null)
            {
                var visitaEncontrado =  _appContext.VisitasPyP.FirstOrDefault(d => d.Id == idVisita);
                if (visitaEncontrado != null)
                {
                    historiaEncontrado.VisitasPyP.Add(visitaEncontrado);
                    _appContext.SaveChanges();
                }

                return visitaEncontrado;
            }

            return null;
        }

    }
}