namespace PPAI_IVR.Clases
{
    public class Estado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CambioEstadoId { get; set; }
        

        public Estado(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public Estado()
        {
        }

        public static Estado Iniciada { get; } = new Estado(1, "Iniciada");
        public static Estado EnCurso { get; } = new Estado(2, "EnCurso");
        public static Estado Cancelada { get; } = new Estado(3, "Cancelada");
        public static Estado Finalizada { get; } = new Estado(4, "Finalizada");
        

        public static List<Estado> Estados { get; } = new List<Estado>
    {
        Iniciada,
        EnCurso,
        Cancelada,
        Finalizada
    };


        public Estado esEnCurso()
        {
            Estado estadoEnCurso = null;

            foreach (var est in Estados)
            {
                if (est.Nombre == "EnCurso")
                {
                    estadoEnCurso = est;
                }                
            }
            return estadoEnCurso;
        }

        public Estado esFinalizada()
        {
            Estado estadoFinalizada = null;
            foreach (var est in Estados)
            {
                if (est.Nombre == "Finalizada")
                {
                    estadoFinalizada = est;
                }
            }
            return estadoFinalizada;
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