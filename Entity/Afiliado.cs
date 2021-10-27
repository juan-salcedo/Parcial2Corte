using System;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Afiliado
    {
        [Key]
        public string CodigoAfiliado { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string FechaNacimiento { get; set; }
        public string FechaAfilacion { get; set; }
        public string EstadoAfiliado { get; set; }
    }
}
