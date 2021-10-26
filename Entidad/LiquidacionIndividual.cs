using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity{
    public class LiquidacionIndividual{
        [Key]
        public string IdentificacionIndividual { get; set; }
        public string IdentificacionMensual { get; set; }
        public int MesAliquidar { get; set; }
        public int ALiquidar { get; set; }
        public int DiaAfiliacion { get; set; }               
        public double ValorLiquidacion { get; set; }
        [NotMapped]
        public Afiliados afiliados { get; set; } 

    }
}