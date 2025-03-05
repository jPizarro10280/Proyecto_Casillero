using BackEnd.DTO;
using DAL.Implementations;
using Entities.Entities;

namespace BackEnd.Services.Interfaces
{
    public interface IDireccionService
    {
        public void AddDireccion(DireccionDTO direccion);
        public void UpdateDireccion(DireccionDTO direccion);
        public void DeleteDireccion(int id);
        public List<Direccion> GetDirecciones();
    }
}
