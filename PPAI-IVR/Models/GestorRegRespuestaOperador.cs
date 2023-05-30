﻿using PPAI_IVR.Clases;
using System.Runtime.CompilerServices;

namespace PPAI_IVR.Models
{
    public class GestorRegRespuestaOperador
    {
        public DateTime FechaHoraActual { get; set; }
        public Llamada LlamadaEnCurso { get; set; }
        public Estado EstadoEnCurso { get; set; }
        public CategoriaLlamada CategoriaSeleccionada { get; set; }







        public void obtenerFechaHoraActual()
        {
            FechaHoraActual = DateTime.Now;
        }

        public Estado buscarEstadoEnCurso()
        {
            Estado estado = new Estado();
            Estado estadoEnCurso = estado.esEnCurso();
            EstadoEnCurso = estadoEnCurso;
            return estadoEnCurso;
        }

        public void tomadaPorOperador() 
        {
            LlamadaEnCurso.EsTomadaPorOperador(EstadoEnCurso, FechaHoraActual);
        }

        public string buscarDatosLlamadaActual()
        {
            var nombreClienteLlamada = LlamadaEnCurso.obtenerNombreClienteLlamada();
            /*List<string> descripciones = LlamadaEnCurso.CategoriaLlamada.obtenerDescripcionCategoriaYOpcion();
            List<string> validaciones = LlamadaEnCurso.CategoriaLlamada.obtenerValidaciones();
            */
            return nombreClienteLlamada.ToString();
        }

        public void tomarOpcionDeValidacion()
        {
            LlamadaEnCurso.validarInformacionCliente();
        }

        public GestorRegRespuestaOperador()
        {
            
        }

    }
}
