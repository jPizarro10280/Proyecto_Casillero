using FrontEnd.ApiModels;
using FrontEnd.Helpers.Interfaces;
using FrontEnd.Models;
using Newtonsoft.Json;
using NuGet.Protocol.Core.Types;

namespace FrontEnd.Helpers.Implementations
{
    public class FacturaHelper : IFacturaHelper
    {
        private readonly IServiceRepository _serviceRepository;

        public FacturaHelper(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        private FacturaViewModel Convertir(FacturaAPI factura)
        {
            return new FacturaViewModel()
            {
                Id = factura.Id,
                UsuarioId = factura.UsuarioId,
                PaqueteId = factura.PaqueteId,
                FechaEmision = factura.FechaEmision,
                MontoTotal = factura.MontoTotal,
                Impuestos = factura.Impuestos,
                Estado = factura.Estado
            };
        }

        FacturaAPI Convertir(FacturaViewModel factura) {
            return new FacturaAPI() {
                Id = factura.Id,
                UsuarioId = factura.UsuarioId,
                PaqueteId = factura.PaqueteId,
                FechaEmision = factura.FechaEmision,
                MontoTotal = factura.MontoTotal,
                Impuestos = factura.Impuestos,
                Estado = factura.Estado
            };
        }

        public void Add(FacturaViewModel factura)
        {
            HttpResponseMessage responseMessage = _serviceRepository.PostResponse("api/Factura", Convertir(factura));
        }

        public void Delete(int id)
        {
            _serviceRepository.DeleteResponse("api/Factura/" + id);
        }

        public List<FacturaViewModel> Get()
        {
            var response = _serviceRepository.GetResponse("api/Factura");
            var facturas = JsonConvert.DeserializeObject<List<FacturaAPI>>(response.Content.ReadAsStringAsync().Result);
            return facturas.Select(Convertir).ToList();
        }

        public FacturaViewModel GetByID(int id)
        {
            FacturaAPI facturaAPI = new FacturaAPI();
            HttpResponseMessage responseMessage = _serviceRepository.GetResponse("api/Factura/" + id.ToString());


            if (responseMessage != null) {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                facturaAPI = JsonConvert.DeserializeObject<FacturaAPI>(content);


            }
            return Convertir(facturaAPI);
        }

        public void Update(FacturaViewModel factura)
        {
            _serviceRepository.PutResponse("api/Factura", factura);
        }
    }
}
