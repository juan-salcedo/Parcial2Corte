using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    public class LiquidacionIndividual
    {
        [Key]
        public int CodigoLiquidacionIndividual { get; set; }
        public int CodigoLiquidacionMensual { get; set; }
        [NotMapped]
        public LiquidacionMensual LiquidacionMensual { get; set; }
        public string CodigoAfiliado { get; set;}
        [NotMapped]
        public Afiliado Afiliado { get; set; }

        public int DiaAfiliacion{ get; set;}
        public decimal ValorLiquidacion{ get; set; }

        public void CalcularValorLiquidacion(){ 
            ValorLiquidacion =900000 * DiaAfiliacion;
        }
        
    }
}