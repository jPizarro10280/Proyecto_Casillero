using FrontEnd.ApiModels;
using FrontEnd.Helpers.Interfaces;
using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Helpers.Implementations
{
    public class UsuarioHelper : IUsuarioHelper
    {
        IServiceRepository _serviceRepository;
        UsuarioViewModel Convertir(UsuarioAPI usuario)
        {
            return new UsuarioViewModel()
            {
                Id = usuario.Id,
                Nombre = usuario.Nombre,
                Correo = usuario.Correo,
                Contrasena = usuario.Contrasena,
                Telefono = usuario.Telefono
            };
        }

        public UsuarioHelper(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
        public void AddUsuario(UsuarioViewModel usuario)
        {
            throw new NotImplementedException();
        }

        public void DeleteUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public UsuarioViewModel GetUsuarioByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<UsuarioViewModel> GetUsuarios()
        {
            HttpResponseMessage responseMessage = _serviceRepository.GetResponse("api/Usuario");
            List<UsuarioAPI> usuarios = new List<UsuarioAPI>();
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                usuarios = JsonConvert.DeserializeObject<List<UsuarioAPI>>(content);
            }
            List<UsuarioViewModel> lista = new List<UsuarioViewModel>();
            foreach (var item in usuarios)
            {
                lista.Add(Convertir(item));
            }
            return lista;
        }

        public void UpdateUsuario(UsuarioViewModel usuario)
        {
            throw new NotImplementedException();
        }
    }
}
