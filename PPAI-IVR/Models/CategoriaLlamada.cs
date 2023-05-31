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
        public List<object> obtenerDescripcionCategoriaYOpcion()
        {
            List<object> lista = new List<object>();
            string nombre = getNombre();
            lista.Add(nombre);
            var descripcion = OpcionLlamada.getDescripcioneConSubOpcion();
            lista.Add(descripcion);


            return lista;
        }
        public List<string> obtenerValidaciones()
        {
            List<string> validacion = OpcionLlamada.getValidacion();
            return validacion;
        }
        public string getNombre()
        {
            return nombre;
        }

    }
}
