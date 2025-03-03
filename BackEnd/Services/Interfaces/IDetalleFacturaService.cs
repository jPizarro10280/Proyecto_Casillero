using Entities.Entities;

namespace BackEnd.Services.Interfaces
{
    public interface IDetalleFacturaService
    {
        void AddDetalleFactura(DetalleFactura detalleFactura);
        void UpdateDetalleFactura(DetalleFactura detalleFactura);
        void DeleteDetalleFactura(int id);
        List <DetalleFactura> GetDetalleFacturas();
    }
}
