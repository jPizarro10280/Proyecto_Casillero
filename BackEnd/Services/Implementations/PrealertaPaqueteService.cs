using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class PrealertaPaqueteService : IPrealertaPaqueteService
    {
        private IUnidadDeTrabajo _unidadDeTrabajo;

        public PrealertaPaqueteService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        public void AddPrealertaPaquete(PrealertaPaquete prealertaPaquete)
        {
            _unidadDeTrabajo.PrealertaPaqueteDAL.Add(prealertaPaquete);
            _unidadDeTrabajo.Complete();
        }

        public void DeletePrealertaPaquete(int id)
        {
            throw new NotImplementedException();
        }

        public List<PrealertaPaquete> GetPrealertaPaquetes()
        {
            throw new NotImplementedException();
        }

        public void UpdatePrealertaPaquete(PrealertaPaquete prealertaPaquete)
        {
            throw new NotImplementedException();
        }
    }
}
