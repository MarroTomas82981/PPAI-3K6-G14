namespace PPAI_IVR.Clases
{
    public class OpcionValidacion
    {
        public int Id { get; set; }
        public string descripcion { get; set; }
        public bool correcta { get; set; }


        public bool esCorrecta()
        {
            return correcta;
        }
        public string getDescripcion()
        {
            return descripcion;
        }
    }
}