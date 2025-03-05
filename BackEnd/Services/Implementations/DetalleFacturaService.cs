using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class DetalleFacturaService : IDetalleFacturaService
    {
        private IUnidadDeTrabajo _unidadDeTrabajo;

        public DetalleFacturaService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        public void AddDetalleFactura(DetalleFacturaDTO detalleFactura)
        {
            var detalleFacturaEntity = new DetalleFactura()
            {
                FacturaId = detalleFactura.FacturaId,
                Concepto = detalleFactura.Concepto,
                Cantidad = detalleFactura.Cantidad,
                PrecioUnitario = detalleFactura.PrecioUnitario,
                Subtotal = detalleFactura.Subtotal
            };
            _unidadDeTrabajo.DetalleFacturaDAL.Add(detalleFacturaEntity);
            _unidadDeTrabajo.Complete();
        }

        public void DeleteDetalleFactura(int id)
        {
            throw new NotImplementedException();
        }

        public List<DetalleFactura> GetDetalleFacturas()
        {
            throw new NotImplementedException();
        }

        public void UpdateDetalleFactura(DetalleFacturaDTO detalleFactura)
        {
            throw new NotImplementedException();
        }
    }
}
