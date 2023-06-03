using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using PPAI_IVR.Clases;
using System.Runtime.CompilerServices;

namespace PPAI_IVR.Models
{
    public class GestorRegRespuestaOperador
    {
        public DateTime FechaHoraActual { get; set; }
        public Llamada LlamadaEnCurso { get; set; }
        public Estado EstadoEnCurso { get; set; }
        public Estado EstadoFinalizada { get; set; }
        public CategoriaLlamada CategoriaSeleccionada { get; set; }
        public string respuestaOperador { get; set; }
        public bool confimacion { get;set; }






        public DateTime ObtenerFechaHoraActual()
        {
            DateTime fechaHoraActual = DateTime.Now;
            FechaHoraActual = fechaHoraActual;
            return fechaHoraActual;
        }

        public void buscarEstadoEnCurso()
        {
            Estado estado = new Estado();
            Estado estadoEnCurso = estado.getEnCurso();
            EstadoEnCurso = estadoEnCurso;
           
        }
        public void asignarEstadoEnCurso()
        {
            tomadaPorOperador();
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
            ValidacionesViewModel validaciones = CategoriaSeleccionada.ObtenerValidaciones(CategoriaSeleccionada.OpcionLlamada.validacionesRequeridas);
            lista.Validaciones = new List<Validacion>();
            foreach (var val in validaciones.validaciones)
            {
                lista.Validaciones.Add(val);
            }            

            return lista;
        }

        public bool tomarOpcionDeValidacion(string respuesta)
        {
            return LlamadaEnCurso.validarInformacionCliente(respuesta);
        }


        public void tomarRespuestaOperador(Llamada llamada, CategoriaLlamada categoriaLlamada)
        {
            LlamadaEnCurso = llamada;
            CategoriaSeleccionada = categoriaLlamada;
            ObtenerFechaHoraActual();
            buscarEstadoEnCurso();


        }

        public void tomarConfirmacion()
        {
            llamarACU28();
            EstadoFinalizada = buscarEstadoFinalizada();
            DateTime fechaHora = ObtenerFechaHoraActual();
            finalizarLlamada(fechaHora);

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

        public void finalizarLlamada( DateTime fechaHora )
        {
            LlamadaEnCurso.finalizar(fechaHora, EstadoEnCurso);
        }


        public void FinCU()
        {

        }

        public GestorRegRespuestaOperador()
        {
            
        }

    }
}
