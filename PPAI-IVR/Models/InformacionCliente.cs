namespace PPAI_IVR.Clases
{
    public class InformacionCliente
    {
        public int Id { get; set; }
        public DateTime datoAValidarNacimiento { get; set; }
        public int datoAValidarDni { get; set; }
        public Validacion Validacion { get; set; }
        public int ClienteId { get; set; }


        public bool EsInformaciónCorrecta(object datoAValidar)
        {
            if (datoAValidar is int)
            {
                int dato = (int)datoAValidar;
                if (dato == datoAValidarDni)
                {
                    return true;
                }
            }

            if (datoAValidar is DateTime)
            {
                DateTime dato = (DateTime)datoAValidar;
                if (dato == datoAValidarNacimiento)
                {
                    return true;
                }
            }
            return false;
        }

        public bool esValidacion()
        {
            return false;
        }
    }
}