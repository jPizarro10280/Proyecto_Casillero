using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class RolService : IRolService
    {
        private IRolDAL _rolDAL;

        public RolService(IRolDAL rolDAL)
        {
            _rolDAL = rolDAL;
        }

        public void AddRol(Rol rol)
        {
            _rolDAL.Add(rol);
        }

        public void DeleteRol(int id)
        {
            throw new NotImplementedException();
        }

        public List<Rol> GetRoles()
        {
            throw new NotImplementedException();
        }

        public void UpdateRol(Rol rol)
        {
            throw new NotImplementedException();
        }
    }

}
