namespace PPAI_IVR.Clases
{
    public class SubOpcionLlamada
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public int nroOrden { get; set; }
        public int opcionLlamadaId { get; set; }


        public string getNombre()
        {
            return this.nombre;
        }

        public bool esNro()
        {
            return true;
        }
    }
}