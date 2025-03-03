using DAL.Implementations;
using Entities.Entities;

namespace BackEnd.Services.Interfaces
{
    public interface IDireccionService
    {
        public void AddDireccion(Direccion direccion);
        public void UpdateDireccion(Direccion direccion);
        public void DeleteDireccion(int id);
        public List<Direccion> GetDirecciones();
    }
}
