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
        public List<SubOpcionLlamada> subOpcionLlamadas { get; set; }
        public int CategoriaLlamadaId { get; set; }
        public int LlamadaId { get; set; }



        public string getAudiomensajeSubOpciones()
        {
            return audioMensajeSubOpciones;
        }
        public List<string> getDescripcioneConSubOpcion()
        {
            var list = new List<string>();
            for (int i = 0; i < validacionesRequeridas.Count; i++)
            {
                list.Add(subOpcionLlamadas[i].nombre);
            }
            return list;
        }
        public List<string> getValidacion()
        {
            var list = new List<string>();
            for (int i = 0; i < validacionesRequeridas.Count; i++)
            {
                list.Add(validacionesRequeridas[i].getAudioMensajeValidacion());
            }
            return list;
        }
     }

 }



