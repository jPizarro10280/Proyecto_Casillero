using Entities.Entities;

namespace BackEnd.Services.Interfaces
{
    public interface IPrealertaPaqueteService
    {
        void AddPrealertaPaquete(PrealertaPaquete prealertaPaquete);
        void UpdatePrealertaPaquete(PrealertaPaquete prealertaPaquete);
        void DeletePrealertaPaquete(int id);
        List<PrealertaPaquete> GetPrealertaPaquetes();
    }
}
