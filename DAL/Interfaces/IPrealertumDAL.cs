using DAL.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Implementations
{
    public class PrealertumDAL : IPrealertumDAL
    {
        public void AgregarPrealerta(Prealertum prealerta)
        {
            using (var context = new CasilleroProyectoContext())
            {
                context.Prealertum.Add(prealerta);
                context.SaveChanges();
            }
        }

        public List<Prealertum> ObtenerPrealertasPendientesPorUsuario(int usuarioId)
        {
            using (var context = new CasilleroProyectoContext())
            {
                return context.Prealertum
                    .Where(p => p.IdUsuario == usuarioId && p.Estado == "Pendiente")
                    .ToList();
            }
        }

        public void ConsolidarPrealertas(int usuarioId, List<int> idsPrealertas)
        {
            using (var context = new CasilleroProyectoContext())
            {
                var prealertas = context.Prealertum
                    .Where(p => idsPrealertas.Contains(p.IdPrealerta) && p.IdUsuario == usuarioId)
                    .ToList();

                foreach (var prealerta in prealertas)
                {
                    prealerta.Estado = "Consolidado";
                }

                context.SaveChanges();
            }
        }

        public void EliminarPrealerta(int prealertaId)
        {
            using (var context = new CasilleroProyectoContext())
            {
                var prealerta = context.Prealertum.Find(prealertaId);
                if (prealerta != null)
                {
                    context.Prealertum.Remove(prealerta);
                    context.SaveChanges();
                }
            }
        }
    }
}
