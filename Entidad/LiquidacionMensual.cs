using System.ComponentModel.DataAnnotations;

namespace Entity{
    public class LiquidacionMensual{
        [Key]
        public string IdLiquidacion { get; set; }
        public int Mesliquidar { get; set; }
        public int Anoliquidar { get; set; }
        public double TotalLiquidar { get; set; }
        
    }
}