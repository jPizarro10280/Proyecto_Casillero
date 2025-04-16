using FrontEnd.ApiModels;
using FrontEnd.Helpers.Interfaces;
using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Helpers.Implementations
{
    public class DireccionHelper : IDireccionHelper
    {
        IServiceRepository _serviceRepository;

        public DireccionHelper(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        DireccionViewModel Convertir(DireccionAPI direccion)
        {
            return new DireccionViewModel()
            {
                Id = direccion.Id,
                UsuarioId = direccion.UsuarioId,
                Linea1 = direccion.Linea1,
                Linea2 = direccion.Linea2,
                Ciudad = direccion.Ciudad,
                Estado = direccion.Estado,
                CodigoPostal = direccion.CodigoPostal,
                Pais = direccion.Pais
            };
        }

        public DireccionViewModel Add(DireccionViewModel direccion)
        {
            HttpResponseMessage response= _serviceRepository.PostResponse("api/Direccion", direccion);
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
            }
            return direccion;
        }

        public void Delete(int id)
        {
            _serviceRepository.DeleteResponse("api/Direccion/" + id);
        }

        public List<DireccionViewModel> GetDir()
        {
            HttpResponseMessage response = _serviceRepository.GetResponse("api/Direccion");
            List<DireccionAPI> direcciones = new List<DireccionAPI>();
            if (response != null)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                direcciones = JsonConvert.DeserializeObject<List<DireccionAPI>>(content);
            }
            List<DireccionViewModel>list = new List<DireccionViewModel>();
            if (direcciones == null) {
                return list;
            }
            foreach (var direccion in direcciones)
            {
                list.Add(Convertir(direccion));
            }
            return list;
        }

        public DireccionViewModel GetByID(int? id)
        {
            HttpResponseMessage response = _serviceRepository.GetResponse("api/Direccion/" + id.ToString());
            DireccionAPI direccion = new DireccionAPI();
            if (response != null)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                direccion = JsonConvert.DeserializeObject<DireccionAPI>(content);
            }
            DireccionViewModel result = Convertir(direccion);
            return result;
        }

        public DireccionViewModel Update(DireccionViewModel direccion)
        {
            HttpResponseMessage response = _serviceRepository.PutResponse("api/Direccion", direccion);
            if (response.IsSuccessStatusCode) {
                var content = response.Content.ReadAsStringAsync().Result;
            }
            return direccion;
        }
    }

}
