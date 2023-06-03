namespace PPAI_IVR.Clases
{
    public class InformacionCliente
    {
        public int Id { get; set; }
        
        public string datoAValidar { get; set; }

        public OpcionValidacion opcioneCorrecta { get; set; }
        
        public int ClienteId { get; set; }


        public bool EsInformaciónCorrecta(OpcionValidacion respuestaAValidar)
        {         
           return opcioneCorrecta.descripcion == respuestaAValidar.descripcion;
                  
                      
        }

        public bool esValidacion()
        {
            return true;
        }
    }
}