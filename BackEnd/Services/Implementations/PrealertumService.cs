using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class PrealertumService : IPrealertumService
    {
        private IUnidadDeTrabajo _unidadDeTrabajo;

        public PrealertumService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        public void AddPrealertum(Prealertum prealertum)
        {
            _unidadDeTrabajo.PrealertumDAL.Add(prealertum);
            _unidadDeTrabajo.Complete();
        }

        public void DeletePrealertum(int id)
        {
            throw new NotImplementedException();
        }

        public List<Prealertum> GetPrealerta()
        {
            throw new NotImplementedException();
        }

        public void UpdatePrealertum(Prealertum prealertum)
        {
            throw new NotImplementedException();
        }
    }

}
