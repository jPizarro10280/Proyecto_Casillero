using BackEnd.DTO;
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

        Rol Convertir(RolDTO rol)
        {
            return new Rol()
            {
                Nombre = rol.Nombre
            };
        }
        RolDTO Convertir(Rol rol)
        {
            return new RolDTO()
            {
                Nombre = rol.Nombre
            };
        }

        public void AddRol(RolDTO rol)
        {
            var rolEntity = Convertir(rol);            
            _unidadDeTrabajo.RolDAL.Add(rolEntity);
            _unidadDeTrabajo.Complete();
        }

        public void DeleteRol(int id)
        {
            var rol = new Rol { Id = id };
            _unidadDeTrabajo.RolDAL.Remove(rol);
        }

        public List<Rol> GetRoles()
        {
            throw new NotImplementedException();
        }

        public void UpdateRol(RolDTO rol)
        {
            var rolEntity = Convertir(rol);
            _unidadDeTrabajo.RolDAL.Update(rolEntity);
            _unidadDeTrabajo.Complete();
        }
    }

}
