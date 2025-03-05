using BackEnd.DTO;
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

        public void AddPrealertaPaquete(PrealertaPaqueteDTO prealertaPaquete)
        {
            var prealertaPaqueteEntity = new PrealertaPaquete()
            {
                PrealertaId=prealertaPaquete.PrealertaId,
                PaqueteId=prealertaPaquete.PaqueteId
            };
            _unidadDeTrabajo.PrealertaPaqueteDAL.Add(prealertaPaqueteEntity);
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

        public void UpdatePrealertaPaquete(PrealertaPaqueteDTO prealertaPaquete)
        {
            throw new NotImplementedException();
        }
    }
}
