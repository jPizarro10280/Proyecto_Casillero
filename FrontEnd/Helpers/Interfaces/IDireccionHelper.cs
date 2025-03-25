using FrontEnd.Models;

namespace FrontEnd.Helpers.Interfaces
{
    public interface IDireccionHelper
    {
        DireccionViewModel Add(DireccionViewModel direccion);
        DireccionViewModel Update(DireccionViewModel direccion);
        void Delete(int id);
        List<DireccionViewModel> GetDir();
        DireccionViewModel GetByID(int? id);
    }
}
