using Microsoft.AspNetCore.Http.HttpResults;

namespace PPAI_IVR.Clases
{
    public class Llamada
    {
        public int Id { get; set; }
        public string DescripcionOperador { get; set; }
        public string DetalleAccionRequerida { get; set; }
        public double Duracion { get; set; }
        public bool EncuestaEnviada { get; set; }
        public string ObservacionAuditor { get; set; }
        public Cliente Cliente { get; set; }
        public OpcionLlamada OpcionLlamada { get; set; }
        public List<CambioEstado> CambiosDeEstados { get; set; }


        public double calcualarDuracion()
        {
            return 8.89;
        }

        public bool esDePeriodo()
        {
            return true;
        }
        public bool esTomadaPorOperador()
        {
            return true;
        }

        public CambioEstado finalizar()
        {
            return null;
        }

        public double getDuracion()
        {
            return Duracion;
        }

        public string getRespuesta()
        {
            return "Respuesta";
        }

        public Llamada crear(string descripcionOperador, double duracion = 0, bool enviada = false, string observacion = null, string detalleAccion= null)
        {
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
        public void setDuracion(double duracion)
        {
            this.Duracion = duracion;
        }
        public void setEstadoActual()
        {

        }
        public void validarInformacionCliente()
        {

        }





    }
    
}
