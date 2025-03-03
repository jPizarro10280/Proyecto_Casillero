using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class RolService : IRolService
    {
        private IUnidadDeTrabajo _unidadDeTrabajo;

        public RolService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        public void AddRol(Rol rol)
        {
            _unidadDeTrabajo.RolDAL.Add(rol);
            _unidadDeTrabajo.Complete();
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
