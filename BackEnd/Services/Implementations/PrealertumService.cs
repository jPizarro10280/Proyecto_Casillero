using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class PrealertumService : IPrealertumService
    {
        private IUnidadDeTrabajo _unidadDeTrabajo;

        public PrealertumService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        public void AddPrealertum(Prealertum prealertum)
        {
            var prealertumEntity = new Prealertum()
            {
                UsuarioId = prealertum.UsuarioId,
                NumeroSeguimiento = prealertum.NumeroSeguimiento,
                Descripcion = prealertum.Descripcion,
                Peso = prealertum.Peso,
                Estado = prealertum.Estado,
                FechaCreacion = prealertum.FechaCreacion,
                FechaActualizacion = prealertum.FechaActualizacion
            };
            _unidadDeTrabajo.PrealertumDAL.Add(prealertum);
            _unidadDeTrabajo.Complete();
        }

        public void DeletePrealertum(int id)
        {
            throw new NotImplementedException();
        }

        public List<Prealertum> GetPrealerta()
        {
            throw new NotImplementedException();
        }

        public void UpdatePrealertum(PrealertumDTO prealertum)
        {
            throw new NotImplementedException();
        }
    }

}
