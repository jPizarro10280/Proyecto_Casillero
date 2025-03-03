using Entities.Entities;

namespace BackEnd.Services.Interfaces
{
    public interface IUsuarioRolService
    {
        void AddUsuarioRol(UsuarioRol usuarioRol);
        void UpdateUsuarioRol(UsuarioRol usuarioRol);
        void DeleteUsuarioRol(int id);
        List<UsuarioRol> GetUsuarioRoles();
    }
}
