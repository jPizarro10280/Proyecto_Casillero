using FrontEnd.Models;

namespace FrontEnd.Helpers.Interfaces
{
    public interface IUsuarioRolHelper
    {
        void AddUsuarioRol(UsuarioRolViewModel usuarioRol);
        void UpdateUsuarioRol(UsuarioRolViewModel usuarioRol);
        void DeleteUsuarioRol(int id);
        List<UsuarioRolViewModel> GetUsuarioRoles();
        UsuarioRolViewModel GetUsuarioRolByID(int id);
    }
}
