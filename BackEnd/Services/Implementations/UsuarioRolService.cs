using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class UsuarioRolService : IUsuarioRolService
    {
        private IUsuarioRolDAL _usuarioRolDAL;

        public UsuarioRolService(IUsuarioRolDAL usuarioRolDAL)
        {
            _usuarioRolDAL = usuarioRolDAL;
        }

        public void AddUsuarioRol(UsuarioRol usuarioRol)
        {
            _usuarioRolDAL.Add(usuarioRol);
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
