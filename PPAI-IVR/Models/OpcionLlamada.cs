using PPAI_IVR.Models.Clases;

namespace PPAI_IVR.Clases
{
    public class OpcionLlamada
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int NroOrden { get; set; }
        public string mensajeSubOpcion { get; set; }
        public string audioMensajeSubOpciones { get; set; }
        public List<Validacion> validacionesRequeridas { get; set; }
        public List<SubOpcionLlamada> subOpcionesLlamada { get; set; }
        public int CategoriaLlamadaId { get; set; }
        public int LlamadaId { get; set; }

        public string getNombre () { return Nombre; }



        public string getAudiomensajeSubOpciones()
        {
            return audioMensajeSubOpciones;
        }
        public OpcionLlamadaViewModel getDescripcioneConSubOpcion()
        {
            OpcionLlamadaViewModel opcion = new OpcionLlamadaViewModel();
            opcion.SubOpcionLlamada = new SubOpcionLlamada();
            opcion.nombreOpcion = getNombre();
            opcion.SubOpcionLlamada.nombre = subOpcionesLlamada[0].getNombre();
            return opcion;
        }
        public List<string> getValidaciones(List<Validacion> validaciones)
        {
            List<string> audioMensajes = new List<string>();

            foreach (var validacion in validaciones)            
            {
                audioMensajes.Add(validacion.getAudioMensajeValidacion());
            }
            return audioMensajes;
        }
     }

 }



