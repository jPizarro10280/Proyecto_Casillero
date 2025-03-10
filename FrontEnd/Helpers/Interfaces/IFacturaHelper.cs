using FrontEnd.Models;

namespace FrontEnd.Helpers.Interfaces
{
    public interface IFacturaHelper
    {
        void AddFactura(FacturaViewModel factura);
        void UpdateFactura(FacturaViewModel factura);
        void DeleteFactura(int id);
        List<FacturaViewModel> GetFacturas();
        FacturaViewModel GetFacturaByID(int id);
    }
}
