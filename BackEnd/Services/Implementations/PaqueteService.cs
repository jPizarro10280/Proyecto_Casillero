using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class PaqueteService : IPaqueteService
    {
        private IUnidadDeTrabajo _unidadDeTrabajo;

        public PaqueteService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        Paquete Convertir(PaqueteDTO paquete)
        {
            return new Paquete()
            {
                UsuarioId = paquete.UsuarioId,
                FechaCreacion = paquete.FechaCreacion,
                Estado = paquete.Estado,
                MontoTotal = paquete.MontoTotal
            };
        }
        PaqueteDTO Convertir(Paquete paquete)
        {
            return new PaqueteDTO()
            {
                UsuarioId = paquete.UsuarioId,
                FechaCreacion = paquete.FechaCreacion,
                Estado = paquete.Estado,
                MontoTotal = paquete.MontoTotal
            };
        }

        public void AddPaquete(PaqueteDTO paquete)
        {
            var paqueteEntity = Convertir(paquete);            
            _unidadDeTrabajo.PaqueteDAL.Add(paqueteEntity);
            _unidadDeTrabajo.Complete();
        }

        public void DeletePaquete(int id)
        {
            var paquete = new Paquete { Id = id };
            _unidadDeTrabajo.PaqueteDAL.Remove(paquete);
        }

        public List<Paquete> GetPaquetes()
        {
            throw new NotImplementedException();
        }

        public void UpdatePaquete(PaqueteDTO paquete)
        {
            var paqueteEntity = Convertir(paquete);
            _unidadDeTrabajo.PaqueteDAL.Update(paqueteEntity);
            _unidadDeTrabajo.Complete();
        }
    }
}
