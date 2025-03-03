using Entities.Entities;

namespace BackEnd.Services.Interfaces
{
    public interface IPaqueteService
    {
        void AddPaquete(Paquete paquete);
        void UpdatePaquete(Paquete paquete);
        void DeletePaquete(int id);
        List<Paquete> GetPaquetes();
    }
}
