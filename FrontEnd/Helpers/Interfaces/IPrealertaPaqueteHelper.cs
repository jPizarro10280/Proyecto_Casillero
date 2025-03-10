using FrontEnd.Models;

namespace FrontEnd.Helpers.Interfaces
{
    public interface IPrealertaPaqueteHelper
    {
        void AddPrealertaPaquete(PrealertaPaqueteViewModel prealertaPaquete);
        void UpdatePrealertaPaquete(PrealertaPaqueteViewModel prealertaPaquete);
        void DeletePrealertaPaquete(int id);
        List<PrealertaPaqueteViewModel> GetPrealertaPaquetes();
        PrealertaPaqueteViewModel GetPrealertaPaqueteByID(int id);
    }
}
