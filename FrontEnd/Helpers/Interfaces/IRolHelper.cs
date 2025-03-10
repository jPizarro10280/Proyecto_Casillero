using FrontEnd.Models;

namespace FrontEnd.Helpers.Interfaces
{
    public interface IRolHelper
    {
        void AddRol(RolViewModel rol);
        void UpdateRol(RolViewModel rol);
        void DeleteRol(int id);
        List<RolViewModel> GetRoles();
        RolViewModel GetRolByID(int id);
    }
}
