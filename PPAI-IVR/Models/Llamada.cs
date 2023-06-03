using Microsoft.AspNetCore.Http.HttpResults;
using PPAI_IVR.Models.Clases;

namespace PPAI_IVR.Clases
{
    public class Llamada
    {
        public int Id { get; set; }
        public string DescripcionOperador { get; set; }
        public string DetalleAccionRequerida { get; set; }
        public TimeSpan Duracion { get; set; }
        public bool EncuestaEnviada { get; set; }
        public string ObservacionAuditor { get; set; }
        public Cliente Cliente { get; set; }
        public OpcionLlamada OpcionLlamada { get; set; }
        public List<CambioEstado> CambiosDeEstados { get; set; }
        


        public TimeSpan calcualarDuracion(DateTime fechaHoraFin, DateTime fechaHoraInicio)
        {
            return fechaHoraFin - fechaHoraInicio;
        }

        public bool esDePeriodo()
        {
            return true;
        }
        public void EsTomadaPorOperador(Estado nombreDeEstadoACambiar, DateTime FechaHoraActual)
        {
            CambioEstado nuevoCambioEstado = new CambioEstado {
            FechaHoraInicio = FechaHoraActual,
            EstadoActual = nombreDeEstadoACambiar
            };
            CambiosDeEstados.Add(nuevoCambioEstado);

        }

        public void finalizar(DateTime fechaHoraActual, Estado estadoEnCurso)
        {
            TimeSpan duracion = this.calcualarDuracion(fechaHoraActual, CambiosDeEstados[0].FechaHoraInicio);
            this.setDuracion(duracion);
            CambioEstado nuevoCambioEstado = new CambioEstado
            {
                FechaHoraInicio = fechaHoraActual,
                EstadoActual = estadoEnCurso
            };
            CambiosDeEstados.Add(nuevoCambioEstado);
        }

        public TimeSpan getDuracion()
        {
            return Duracion;
        }

        public string getRespuesta()
        {
            return "Respuesta";
        }

        public Llamada crear(string descripcionOperador, bool enviada = false, string observacion = null, string detalleAccion= null)
        {
            TimeSpan duracion = TimeSpan.Zero;
            var llamada = new Llamada{
                DescripcionOperador = descripcionOperador,
                Duracion = duracion,
                EncuestaEnviada = enviada,
                ObservacionAuditor = observacion,
                DetalleAccionRequerida = detalleAccion
            }; 
            return llamada;
        }
        

        public Cliente obtenerCliente() 
        {
            return this.Cliente;
        }
        public string obtenerNombreClienteLlamada()
        {
            return this.Cliente.getNombre();
        }

        public void setDescripcionOperador(string descripcion)
        {
            this.DescripcionOperador = descripcion;
        } 
        public void setDuracion(TimeSpan duracion)
        {
            this.Duracion = duracion;
        }
        public void setEstadoActual(TimeSpan duracion)
        {
            Duracion = duracion;
        }
        public bool validarInformacionCliente(OpcionValidacion respuestaAValidar)
        {
            bool correcta = false;
            correcta = Cliente.esInfoCorrecta(respuestaAValidar);
            return correcta;
        }





    }
    
}
