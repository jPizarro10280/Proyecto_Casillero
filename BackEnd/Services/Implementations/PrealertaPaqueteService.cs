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

        PrealertaPaquete Convertir(PrealertaPaqueteDTO prealertaPaquete)
        {
            return new PrealertaPaquete()
            {
                PrealertaId = prealertaPaquete.PrealertaId,
                PaqueteId = prealertaPaquete.PaqueteId
            };
        }
        PrealertaPaqueteDTO Convertir(PrealertaPaquete prealertaPaquete)
        {
            return new PrealertaPaqueteDTO()
            {
                PrealertaId = prealertaPaquete.PrealertaId,
                PaqueteId = prealertaPaquete.PaqueteId
            };
        }

        public void AddPrealertaPaquete(PrealertaPaqueteDTO prealertaPaquete)
        {
            var prealertaPaqueteEntity = Convertir(prealertaPaquete);            
            _unidadDeTrabajo.PrealertaPaqueteDAL.Add(prealertaPaqueteEntity);
            _unidadDeTrabajo.Complete();
        }

        public void DeletePrealertaPaquete(int id)
        {
            var prealertaPaquete = new PrealertaPaquete { Id = id };
            _unidadDeTrabajo.PrealertaPaqueteDAL.Remove(prealertaPaquete);
        }

        public List<PrealertaPaquete> GetPrealertaPaquetes()
        {
            throw new NotImplementedException();
        }

        public void UpdatePrealertaPaquete(PrealertaPaqueteDTO prealertaPaquete)
        {
            var prealertaPaqueteEntity = Convertir(prealertaPaquete);
            _unidadDeTrabajo.PrealertaPaqueteDAL.Update(prealertaPaqueteEntity);
            _unidadDeTrabajo.Complete();
        }
    }
}
