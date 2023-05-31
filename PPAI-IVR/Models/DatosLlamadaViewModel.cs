using PPAI_IVR.Clases;

namespace PPAI_IVR.Models
{
    public class DatosLlamadaViewModel 
    {
        public string nombreCliente {  get; set; }

        public DescripcionCategoriaViewModel CategoriaAMostrar { get; set; }

        public ValidacionesViewModel Validaciones { get; set; }
        
    }
}
