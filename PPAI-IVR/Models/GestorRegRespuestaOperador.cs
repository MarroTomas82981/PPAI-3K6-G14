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

        public DatosLlamadaViewModel buscarDatosLlamadaActual()
        {
            DatosLlamadaViewModel lista = new DatosLlamadaViewModel();             
            string nombreClienteLlamada = LlamadaEnCurso.obtenerNombreClienteLlamada();
            lista.nombreCliente = nombreClienteLlamada;
            DescripcionCategoriaViewModel descripciones = CategoriaSeleccionada.obtenerDescripcionCategoriaYOpcion();
            lista.CategoriaAMostrar = descripciones;
            ValidacionesViewModel validaciones = CategoriaSeleccionada.ObtenerValidaciones(LlamadaEnCurso.OpcionLlamada.validacionesRequeridas);
            

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


        public void llamarACU28()
        {

        }

        public Estado buscarEstadoFinalizada()
        {
            Estado estado = new Estado();
            Estado estadoFinalizada = estado.esFinalizada();
            EstadoEnCurso = estadoFinalizada;
            return estadoFinalizada;
        }

        public void finalizarLlamada()
        {
            LlamadaEnCurso.finalizar(FechaHoraActual, EstadoEnCurso);
        }


        public void FinCU()
        {

        }

        public GestorRegRespuestaOperador()
        {
            
        }

    }
}
