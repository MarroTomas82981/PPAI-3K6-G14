namespace PPAI_IVR.Clases
{
    public class Cliente
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public int nroCelular { get; set; }
        public List<InformacionCliente> InformacionCliente { get; set; }
        public int LlamadaId { get; set; }


        public bool esCliente()
        {
            return true;
        }

        public string getNombre()
        {
            return this.NombreCompleto;
        }
        public bool esInfoCorrecta()//Datos que pasa como parametros
        {
            return true; //ACA 
        }
    }
}