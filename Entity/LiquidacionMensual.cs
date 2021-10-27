using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    public class LiquidacionMensual
    {
        [Key]
        public int CodigoLiquidacionMensual { get; set; }
        public int MesLiquidar { get; set; }
        public int Anioliquidar { get; set; }
        public decimal Total { get; set; }
        public string IdAfiliado { get; set; }
        [NotMapped]
        public Afiliado Afiliado{get; set;}
        
        
    }
}