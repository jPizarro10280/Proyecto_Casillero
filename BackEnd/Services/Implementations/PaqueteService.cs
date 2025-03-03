using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class PaqueteService : IPaqueteService
    {
        private IPaqueteDAL _paqueteDAL;

        public PaqueteService(IPaqueteDAL paqueteDAL)
        {
            _paqueteDAL = paqueteDAL;
        }

        public void AddPaquete(Paquete paquete)
        {
            _paqueteDAL.Add(paquete);
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
