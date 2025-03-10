using FrontEnd.Models;

namespace FrontEnd.Helpers.Interfaces
{
    public interface IDetalleFacturaHelper
    {
        void AddDetalleFactura(DetalleFacturaViewModel detalleFactura);
        void UpdateDetalleFactura(DetalleFacturaViewModel detalleFactura);
        void DeleteDetalleFactura(int id);
        List<DetalleFacturaViewModel> GetDetalleFacturas();
        DetalleFacturaViewModel GetDetalleFacturaByID(int id);
    }
}
