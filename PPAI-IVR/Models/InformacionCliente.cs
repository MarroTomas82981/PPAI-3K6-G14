namespace PPAI_IVR.Clases
{
    public class InformacionCliente
    {
        public int Id { get; set; }
        
        public string datoAValidar { get; set; }
        
        public int ClienteId { get; set; }


        public bool EsInformaciónCorrecta(string respuestaAValidar)
        {
           if (datoAValidar == respuestaAValidar) 
            {
                return true;
                    
            }
            return false;
        }

        public bool esValidacion()
        {
            return true;
        }
    }
}