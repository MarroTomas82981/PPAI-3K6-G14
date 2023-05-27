using PPAI_IVR.Clases;

namespace PPAI_IVR.Models.Clases
{
    public class Cliente
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public int nroCelular { get; set; }
        public int Dni { get; set; }
        public List<InformacionCliente> InformacionCliente { get; set; }
        public int LlamadaId { get; set; }


        public bool esCliente()
        {
            return true;
        }

        public string getNombre()
        {
            return NombreCompleto;
        }
        public bool esInfoCorrecta()//Datos que pasa como parametros
        {
            return true; //ACA 
        }
    }
}