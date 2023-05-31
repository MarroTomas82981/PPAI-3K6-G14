using PPAI_IVR.Clases;
using System.Runtime.CompilerServices;

namespace PPAI_IVR.Models
{
    public class GestorRegRespuestaOperador
    {
        public DateTime FechaHoraActual { get; set; }
        public Llamada LlamadaEnCurso { get; set; }
        public Estado EstadoEnCurso { get; set; }
        public CategoriaLlamada CategoriaSeleccionada { get; set; }
        public string respuestaOperador { get; set; }
        public bool confimacion { get;set; }






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

        public List<object> buscarDatosLlamadaActual()
        {
            List<object> lista = new List<object>();            
            string nombreClienteLlamada = LlamadaEnCurso.obtenerNombreClienteLlamada();
            lista.Add(nombreClienteLlamada);
            List<object> descripciones = LlamadaEnCurso.CategoriaLlamada.obtenerDescripcionCategoriaYOpcion();
            lista.Add(descripciones);
            List<string> validaciones = LlamadaEnCurso.CategoriaLlamada.obtenerValidaciones();
            lista.Add(validaciones);

            return lista;
        }

        public void tomarOpcionDeValidacion(string respuesta)
        {
            LlamadaEnCurso.validarInformacionCliente(respuesta);
        }


        public void tomarRespuestaOperador(string respuesta)
        {
            respuestaOperador = respuesta;
        }

        public void tomarConfirmacion(bool seleccionadaConfirmacion)
        {
            confimacion = seleccionadaConfirmacion;
        }

        public GestorRegRespuestaOperador()
        {
            
        }

    }
}
