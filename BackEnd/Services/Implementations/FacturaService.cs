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

        public void AddFactura(Factura factura)
        {
            _unidadDeTrabajo.FacturaDAL.Add(factura);
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

        public void UpdateFactura(Factura factura)
        {
            throw new NotImplementedException();
        }
    }
}
