using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class DireccionService : IDireccionService
    {
        private IUnidadDeTrabajo _unidadDeTrabajo;

        public DireccionService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        public void AddDireccion(Direccion direccion)
        {
            _unidadDeTrabajo.DireccionDAL.Add(direccion);
            _unidadDeTrabajo.Complete();
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
