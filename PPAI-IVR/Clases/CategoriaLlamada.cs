namespace PPAI_IVR.Clases
{
    public class CategoriaLlamada
    {
        public int Id { get; set; }
        public string audioMensajeOpciones { get; set; }
        public string mensajeOpciones {get; set; }
        public string nombre {get; set; }
        public int nroOrden { get; set; }



        public string getAudioMensajeOpciones()
        {
            return audioMensajeOpciones;
        }
        public Task obtenerDescripcionCategoriaYOpcion()
        {
            return Task.FromResult(0);
        }
        public string obtenerValidaciones()
        {
            return "Aqui irian las validaciones";
        }

    }
}
