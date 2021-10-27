using Entity;

namespace Parcial.models
{
    public class AfiliadoInputModel
    {
        public string CodigoAfiliado { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string FechaNacimiento { get; set; }
        public string FechaAfilacion { get; set; }
        public string EstadoAfiliado { get; set; }
    }

    public class AfiliadoViewModel : AfiliadoInputModel{
        public AfiliadoViewModel()
        {
            
        }

        public AfiliadoViewModel(Afiliado afiliado)
        {
            CodigoAfiliado=afiliado.CodigoAfiliado;
            Nombre = afiliado.Nombre;
            Tipo = afiliado.Tipo;
            FechaNacimiento = afiliado.FechaNacimiento;
            FechaAfilacion = afiliado.FechaAfilacion;
            EstadoAfiliado = afiliado.EstadoAfiliado;
        }


    }
}