using Entities.Entities;

namespace BackEnd.Services.Interfaces
{
    public interface IUsuarioService
    {
        void AddUsuario(Usuario usuario);
        void UpdateUsuario(Usuario usuario);
        void DeleteUsuario(int id);
        List<Usuario> GetUsuarios();
    }
}
