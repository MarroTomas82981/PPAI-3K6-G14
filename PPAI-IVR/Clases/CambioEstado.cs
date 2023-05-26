namespace PPAI_IVR.Clases
{
    public class CambioEstado
    {
        public int Id { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public Estado Estado { get; set; }
        

        public bool esEstadoInicial()
        {
            return false;
        }
        public bool esUltimoEstado()
        {
            return false;
        }

        public DateTime getFechaHoraInicio()
        {
            return FechaHoraInicio;
        }
        public string getNombreEstado()
        {
            return "Estado";
        }
        public CambioEstado crear(DateTime fechaHoraInicio, Estado estadoACambiar)
        {
           var cambioEstado = new CambioEstado
           {
               FechaHoraInicio = fechaHoraInicio,
               Estado =estadoACambiar
           };
            return cambioEstado;
        }
    }
}