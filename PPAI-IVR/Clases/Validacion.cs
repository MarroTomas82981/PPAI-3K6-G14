﻿namespace PPAI_IVR.Clases
{
    public class Validacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string audioMensajeValidacion { get; set; }
        public int opcionLlamadaId { get; set; }


        public string getAudioMensajeValidacion()
        {
            return this.audioMensajeValidacion;
        }
    }
}