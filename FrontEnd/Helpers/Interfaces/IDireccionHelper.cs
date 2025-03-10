using FrontEnd.Models;

namespace FrontEnd.Helpers.Interfaces
{
    public interface IDireccionHelper
    {
        void AddDireccion(DireccionViewModel direccion);
        void UpdateDireccion(DireccionViewModel direccion);
        void DeleteDireccion(int id);
        List<DireccionViewModel> GetDirecciones();
        DireccionViewModel GetDireccionByID(int id);
    }
}
