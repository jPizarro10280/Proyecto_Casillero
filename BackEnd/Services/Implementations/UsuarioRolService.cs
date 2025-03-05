using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class UsuarioRolService : IUsuarioRolService
    {
        private IUnidadDeTrabajo _unidadDeTrabajo;

        public UsuarioRolService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        public void AddUsuarioRol(UsuarioRolDTO usuarioRol)
        {
            var usuarioRolEntity = new UsuarioRol()
            {
                RolId = usuarioRol.RolId,
                UsuarioId = usuarioRol.UsuarioId
            };
        
            _unidadDeTrabajo.UsuarioRolDAL.Add(usuarioRolEntity);
            _unidadDeTrabajo.Complete();
        }

        public void DeleteUsuarioRol(int id)
        {
            throw new NotImplementedException();
        }

        public List<UsuarioRol> GetUsuarioRoles()
        {
            throw new NotImplementedException();
        }


        public void UpdateUsuarioRol(UsuarioRolDTO usuarioRol)
        {
            throw new NotImplementedException();
        }
    }
}
