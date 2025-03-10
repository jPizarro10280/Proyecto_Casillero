using FrontEnd.Models;

namespace FrontEnd.Helpers.Interfaces
{
    public interface IUsuarioHelper
    {
        void AddUsuario(UsuarioViewModel usuario);
        void UpdateUsuario(UsuarioViewModel usuario);
        void DeleteUsuario(int id);
        List<UsuarioViewModel> GetUsuarios();
        UsuarioViewModel GetUsuarioByID(int id);
    }
}
