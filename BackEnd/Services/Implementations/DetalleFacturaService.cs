using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class DetalleFacturaService : IDetalleFacturaService
    {
        private IDetalleFacturaDAL _detalleFacturaDAL;
        public DetalleFacturaService(IDetalleFacturaDAL detalleFacturaDAL)
        {
            _detalleFacturaDAL = detalleFacturaDAL;
        }

        public void AddDetalleFactura(DetalleFactura detalleFactura)
        {
            _detalleFacturaDAL.Add(detalleFactura);
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
