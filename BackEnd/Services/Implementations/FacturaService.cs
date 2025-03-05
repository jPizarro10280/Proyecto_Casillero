using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class FacturaService : IFacturaService
    {
        private IUnidadDeTrabajo _unidadDeTrabajo;

        public FacturaService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        public void AddFactura(FacturaDTO factura)
        {
            var facturaEntity = new Factura()
            {
                UsuarioId = factura.UsuarioId,
                PaqueteId = factura.PaqueteId,
                FechaEmision = factura.FechaEmision,
                MontoTotal = factura.MontoTotal,
                Impuestos = factura.Impuestos,
                Estado = factura.Estado
            };
            _unidadDeTrabajo.FacturaDAL.Add(facturaEntity);
            _unidadDeTrabajo.Complete();
        }

        public void DeleteFactura(int id)
        {
            throw new NotImplementedException();
        }

        public List<Factura> GetFacturas()
        {
            throw new NotImplementedException();
        }

        public void UpdateFactura(FacturaDTO factura)
        {
            throw new NotImplementedException();
        }
    }
}
