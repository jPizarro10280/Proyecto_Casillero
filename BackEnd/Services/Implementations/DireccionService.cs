using BackEnd.DTO;
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

        public void AddDireccion(DireccionDTO direccion)
        {
            var direccionEntity = new Direccion()
            {
                UsuarioId = direccion.UsuarioId,
                Linea1 = direccion.Linea1,
                Linea2 = direccion.Linea2,
                Ciudad = direccion.Ciudad,
                Estado = direccion.Estado,
                CodigoPostal = direccion.CodigoPostal,
                Pais = direccion.Pais
            };
            _unidadDeTrabajo.DireccionDAL.Add(direccionEntity);
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

        public void UpdateDireccion(DireccionDTO direccion)
        {
            throw new NotImplementedException();
        }
    }
}
