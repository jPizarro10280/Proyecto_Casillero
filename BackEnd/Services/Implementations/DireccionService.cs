using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class DireccionService : IDireccionService
    {
        private IDireccionDAL _direccionDAL;

        public DireccionService(IDireccionDAL direccionDAL)
        {
            _direccionDAL = direccionDAL;
        }

        public void AddDireccion(Direccion direccion)
        {
            _direccionDAL.Add(direccion);
        }

        public void DeleteDireccion(int id)
        {
            throw new NotImplementedException();
        }

        public List<Direccion> GetDirecciones()
        {
            throw new NotImplementedException();
        }

        public void UpdateDireccion(Direccion direccion)
        {
            throw new NotImplementedException();
        }
    }
}
