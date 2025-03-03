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

        public void AddDetalleFactura(DetalleFactura detalleFactura)
        {
            _unidadDeTrabajo.DetalleFacturaDAL.Add(detalleFactura);
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

        public void UpdateDetalleFactura(DetalleFactura detalleFactura)
        {
            throw new NotImplementedException();
        }
    }
}
