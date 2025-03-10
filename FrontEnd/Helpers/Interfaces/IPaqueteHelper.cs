using FrontEnd.Models;

namespace FrontEnd.Helpers.Interfaces
{
    public interface IPaqueteHelper
    {
        void AddPaquete(PaqueteViewModel paquete);
        void UpdatePaquete(PaqueteViewModel paquete);
        void DeletePaquete(int id);
        List<PaqueteViewModel> GetPaquetes();
        PaqueteViewModel GetPaqueteByID(int id);
    }
}
