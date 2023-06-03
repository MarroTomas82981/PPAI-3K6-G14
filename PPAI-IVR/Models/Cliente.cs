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
        public List<InformacionCliente> InformacionesDelCliente { get; set; }
        


        public bool esCliente()
        {
            return true;
        }

        public string getNombre()
        {
            return NombreCompleto;
        }
        public bool  esInfoCorrecta(OpcionValidacion opcionAValidar)//Datos que pasa como parametros
        {
            foreach (var opcion in InformacionesDelCliente)
            {
                if (opcionAValidar == opcion.opcioneCorrecta)
                {
                    return true;
                }

            }
            return false;
        }
    }
}