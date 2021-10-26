using System.ComponentModel.DataAnnotations;

namespace Entity{
    public class Afiliados{
        [Key]
        public string Id { get; set; }
        public string TipoId { get; set; }
        public string Nombre { get; set; }
        public string FNacimiento { get; set; }
        public string FeAfiliacion { get; set; }
        public string Estado { get; set; }
    }
}