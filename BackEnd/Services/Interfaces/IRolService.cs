using Entities.Entities;

namespace BackEnd.Services.Interfaces
{
    public interface IRolService
    {
        void AddRol(Rol rol);
        void UpdateRol(Rol rol);
        void DeleteRol(int id);
        List<Rol> GetRoles();
    }
}
