using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class PrealertumService : IPrealertumService
    {
        private IPrealertumDAL _prealertumDAL;

        public PrealertumService(IPrealertumDAL prealertumDAL)
        {
            _prealertumDAL = prealertumDAL;
        }

        public void AddPrealertum(Prealertum prealertum)
        {
            _prealertumDAL.Add(prealertum);
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
