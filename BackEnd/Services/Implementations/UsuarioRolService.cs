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

        public void AddUsuarioRol(UsuarioRol usuarioRol)
        {
            _unidadDeTrabajo.UsuarioRolDAL.Add(usuarioRol);
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

        public void UpdateUsuarioRol(UsuarioRol usuarioRol)
        {
            throw new NotImplementedException();
        }
    }
}
