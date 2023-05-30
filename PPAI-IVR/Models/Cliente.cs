using PPAI_IVR.Clases;
using System.ComponentModel.DataAnnotations;

namespace PPAI_IVR.Models.Clases
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Nombre Completo")]
        public string NombreCompleto { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Numero de celular")]
        public int nroCelular { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "DNI")]
        public int Dni { get; set; }
        public List<InformacionCliente> InformacionDelCliente { get; set; }
        


        public bool esCliente()
        {
            return true;
        }

        public string getNombre()
        {
            return NombreCompleto;
        }
        public bool  esInfoCorrecta()//Datos que pasa como parametros
        {
            List<object> datosAValidar = new List<object>();
            for (int i = 0; i < datosAValidar.Count; i++)
            {
                var datoAValidar = 1;
                InformacionDelCliente[i].esValidacion();
                bool info = InformacionDelCliente[i].EsInformaciónCorrecta(datoAValidar);

            }    
            return true;
        }
    }
}