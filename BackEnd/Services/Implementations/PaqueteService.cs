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

        public void AddPaquete(PaqueteDTO paquete)
        {
            var paqueteEntity = new Paquete() 
            {
                UsuarioId=paquete.UsuarioId,
                FechaCreacion=paquete.FechaCreacion,
                Estado=paquete.Estado,
                MontoTotal=paquete.MontoTotal
            };
            _unidadDeTrabajo.PaqueteDAL.Add(paqueteEntity);
            _unidadDeTrabajo.Complete();
        }

        public void DeletePaquete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Paquete> GetPaquetes()
        {
            throw new NotImplementedException();
        }

        public void UpdatePaquete(PaqueteDTO paquete)
        {
            throw new NotImplementedException();
        }
    }
}
