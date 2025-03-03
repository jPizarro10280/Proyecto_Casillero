using Entities.Entities;

namespace BackEnd.Services.Interfaces
{
    public interface IFacturaService
    {
        void AddFactura(Factura factura);
        void UpdateFactura(Factura factura);
        void DeleteFactura(int id);
        List<Factura> GetFacturas();
    }
}
