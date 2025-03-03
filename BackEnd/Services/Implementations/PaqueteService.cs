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

        public void AddPaquete(Paquete paquete)
        {
            _unidadDeTrabajo.PaqueteDAL.Add(paquete);
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

        public void UpdatePaquete(Paquete paquete)
        {
            throw new NotImplementedException();
        }
    }
}
