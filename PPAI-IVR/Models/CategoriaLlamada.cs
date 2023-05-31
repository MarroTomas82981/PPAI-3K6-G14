using PPAI_IVR.Models;

namespace PPAI_IVR.Clases
{
    public class CategoriaLlamada
    {
        public int Id { get; set; }
        public string audioMensajeOpciones { get; set; }
        public string mensajeOpciones {get; set; }
        public string nombre {get; set; }
        public int nroOrden { get; set; }
        public OpcionLlamada OpcionLlamada { get; set; }



        public string getAudioMensajeOpciones()
        {
            return audioMensajeOpciones;
        }
        public DescripcionCategoriaViewModel obtenerDescripcionCategoriaYOpcion()
        {
            DescripcionCategoriaViewModel lista = new DescripcionCategoriaViewModel();            
            string nombre = getNombre();
            lista.nombreCategoria = nombre;
            OpcionLlamadaViewModel nombreOpcion = OpcionLlamada.getDescripcioneConSubOpcion();
            lista.OpcionLlamada.Nombre = nombreOpcion.nombreOpcion;
            lista.OpcionLlamada.subOpcionesLlamada[0].nombre = nombreOpcion.SubOpcionLlamada.nombre;

            return lista;
        }
        public ValidacionesViewModel ObtenerValidaciones(List<Validacion> validaciones)
        {
            ValidacionesViewModel validacion = new ValidacionesViewModel();
            validacion.audioValidaciones = OpcionLlamada.getValidacion(validaciones);
            return validacion;
        }
        public string getNombre()
        {
            return nombre;
        }

    }
}
