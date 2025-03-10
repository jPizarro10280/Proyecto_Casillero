using FrontEnd.Models;

namespace FrontEnd.Helpers.Interfaces
{
    public interface IPrealertumHelper
    {
        void AddPrealertum(PrealertumViewModel prealertum);
        void UpdatePrealertum(PrealertumViewModel prealertum);
        void DeletePrealertum(int id);
        List<PrealertumViewModel> GetPrealertas();
        PrealertumViewModel GetPrealertumByID(int id);
    }
}
