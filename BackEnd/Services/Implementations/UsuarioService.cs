using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class UsuarioService : IUsuarioService
    {
        private IUnidadDeTrabajo _unidadDeTrabajo;

        public UsuarioService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        public void AddUsuario(Usuario usuario)
        {
            _unidadDeTrabajo.UsuarioDAL.Add(usuario);
            _unidadDeTrabajo.Complete();
        }

        public void DeleteUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> GetUsuarios()
        {
            throw new NotImplementedException();
        }

        public void UpdateUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
