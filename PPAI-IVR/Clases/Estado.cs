namespace PPAI_IVR.Clases
{
    public class Estado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CambioEstadoId { get; set; }

        public class EnCurso : Estado
        {
            public EnCurso()
            {
                Id = 1;
                Nombre = "EnCurso";
            }
        }

        public class Finalizada : Estado
        {
            public Finalizada()
            {
                Id = 2;
                Nombre = "Finalizada";
            }
        }

        public class Iniciada : Estado
        {
            public Iniciada()
            {
                Id = 3;
                Nombre = "Iniciada";
            }
        }


        public bool esEnCurso()
        {
            if (this.Nombre == "EnCurso") 
            { 
                return true;
            }else { return false; }
        }

        public bool esFinalizada()
        {
            if (this.Nombre == "Finalizada")
            {
                return true;
            }
            else { return false; }
        }
        public bool esIniciada()
        {
            if (this.Nombre == "Iniciada")
            {
                return true;
            }
            else { return false; }
        }        
        public string getNombre()
        {
            return this.Nombre;
        }
    }
}