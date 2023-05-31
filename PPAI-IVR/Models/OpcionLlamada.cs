﻿using PPAI_IVR.Models.Clases;

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



        public string getAudiomensajeSubOpciones()
        {
            return audioMensajeSubOpciones;
        }
        public List<string> getDescripcioneConSubOpcion()
        {
            var list = new List<string>();
            for (int i = 0; i < subOpcionesLlamada.Count; i++)
            {
                list.Add(subOpcionesLlamada[i].getNombre());
            }
            return list;
        }
        public List<string> getValidacion()
        {
            var audioMensajes = new List<string>();
            for (int i = 0; i < validacionesRequeridas.Count; i++)
            {
                audioMensajes.Add(validacionesRequeridas[i].getAudioMensajeValidacion());
            }
            return audioMensajes;
        }
     }

 }



