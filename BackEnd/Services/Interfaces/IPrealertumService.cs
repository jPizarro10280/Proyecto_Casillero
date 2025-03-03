using Entities.Entities;

namespace BackEnd.Services.Interfaces
{
    public interface IPrealertumService
    {
        void AddPrealertum(Prealertum prealertum);
        void UpdatePrealertum(Prealertum prealertum);
        void DeletePrealertum(int id);
        List<Prealertum> GetPrealerta();
    }
}
