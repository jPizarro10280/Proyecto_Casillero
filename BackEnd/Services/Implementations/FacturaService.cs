using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class FacturaService : IFacturaService
    {
        private IFacturaDAL _facturaDAL;

        public FacturaService(IFacturaDAL facturaDAL)
        {
            _facturaDAL = facturaDAL;
        }

        public void AddFactura(Factura factura)
        {
            _facturaDAL.Add(factura);
        }

        public void DeleteFactura(int id)
        {
            throw new NotImplementedException();
        }

        public List<Factura> GetFacturas()
        {
            throw new NotImplementedException();
        }

        public void UpdateFactura(Factura factura)
        {
            throw new NotImplementedException();
        }
    }
}
