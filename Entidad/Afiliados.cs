namespace Entity{
    public class Afiliados{
        [Key]
        public string Id { get; set; }
        public string TipoId { get; set; }
        public string Nombre { get; set; }
        public string FechaNacimiento { get; set; }
        public string FechaAfiliacion { get; set; }
        public string Estado { get; set; }
    }
}