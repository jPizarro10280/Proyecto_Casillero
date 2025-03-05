using BackEnd.DTO;
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

        Usuario Convertir(UsuarioDTO usuario)
        {
            return new Usuario()
            {
                Id = usuario.Id,
                Nombre = usuario.Nombre,
                Correo = usuario.Correo,
                Contrasena = usuario.Contrasena,
                Telefono = usuario.Telefono
            };
        }

        public void AddUsuario(UsuarioDTO usuario)
        {
            var usuarioEntity = Convertir(usuario);            
            _unidadDeTrabajo.UsuarioDAL.Add(usuarioEntity);
            _unidadDeTrabajo.Complete();
        }

        public void DeleteUsuario(int id)
        {
            var usuario = new Usuario { Id = id };
            _unidadDeTrabajo.UsuarioDAL.Remove(usuario);
        }

        public List<Usuario> GetUsuarios()
        {
            throw new NotImplementedException();
        }

        public void UpdateUsuario(UsuarioDTO usuario)
        {
            var usuarioEntity = Convertir(usuario);
            _unidadDeTrabajo.UsuarioDAL.Update(usuarioEntity);
            _unidadDeTrabajo.Complete();
        }
    }
}
