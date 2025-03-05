namespace BackEnd.DTO
{
    public class DireccionDTO
    {
        public int UsuarioId { get; set; }
        public string UsuarioNombre { get; set; }

        public string Linea1 { get; set; } = null!;

        public string? Linea2 { get; set; }

        public string Ciudad { get; set; } = null!;

        public string Estado { get; set; } = null!;

        public string CodigoPostal { get; set; } = null!;

        public string Pais { get; set; } = null!;
    }
}
