namespace PPAI_IVR.Clases
{
    public class InformacionCliente
    {
        public int Id { get; set; }
        public DateTime datoAValidar { get; set; }
        public Validacion Validacion { get; set; }
        public int ClienteId { get; set; }


        public bool esInformaciónCorrecta()
        {
            return true;
        }

        public bool esValidacion()
        {
            return false;
        }
    }
}