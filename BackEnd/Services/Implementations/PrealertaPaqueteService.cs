using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class PrealertaPaqueteService : IPrealertaPaqueteService
    {
        private IPrealertaPaqueteDAL _prealertaPaqueteDAL;

        public PrealertaPaqueteService(IPrealertaPaqueteDAL prealertaPaqueteDAL)
        {
            _prealertaPaqueteDAL = prealertaPaqueteDAL;
        }

        public void AddPrealertaPaquete(PrealertaPaquete prealertaPaquete)
        {
            _prealertaPaqueteDAL.Add(prealertaPaquete);
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
