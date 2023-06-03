using Microsoft.AspNetCore.Mvc;
using PPAI_IVR.Clases;
using PPAI_IVR.Models.Clases;
using PPAI_IVR.Models;

namespace PPAI_IVR.Controllers
{
    public class LlamadasController : Controller
    {

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> RegistrarLlamada()
        {
            return View();
        } 
        public async Task<IActionResult> LlamadaCU28()
        {
            return View();
        }


        public async Task<IActionResult> ComunicarseConOperador()
        {
            return View();
        }

        //public async Task<IActionResult> MostrarDatosLlamadaActual()
        //{
            
        //    GestorRegRespuestaOperador gestor = new GestorRegRespuestaOperador
        //    {
        //        LlamadaEnCurso = new Llamada
        //        {
        //            Cliente = new Cliente
        //            {
        //                Id = 1,
        //                NombreCompleto = "Antonio Lopez",
        //                InformacionDelCliente = new InformacionCliente
        //                {
                            
        //                        datoAValidar = "4 Hijos",
        //                        Id = 2,
                            
        //                }                  
                        
        //            },
        //            OpcionLlamada = new OpcionLlamada
        //            {

        //                validacionesRequeridas = new List<Validacion>
        //                {
        //                    new Validacion
        //                    {
        //                        Id = 1,
        //                        NroOrden = 1,
        //                        audioMensajeValidacion = " 2 Hijos",
        //                        Nombre = "Primera Opcion"
        //                    },
        //                    new Validacion
        //                    {
        //                        NroOrden= 2,
        //                        Id = 2,
        //                        audioMensajeValidacion = " 5 Hijos",
        //                        Nombre = "Segunda Opcion"
        //                    },
        //                    new Validacion
        //                    {
        //                        NroOrden = 3,
        //                        Id = 3,
        //                        audioMensajeValidacion = " 4 Hijos",
        //                        Nombre = "Tercera Opcion"
        //                    }
        //                },
        //                subOpcionesLlamada = new List<SubOpcionLlamada>{
        //    new SubOpcionLlamada{
        //        Id = 1,
        //        nombre = "Comunicarse con un Operador",
        //        nroOrden = 2
        //                        }
        //                                                            }
        //            }
        //        },
        //        CategoriaSeleccionada = new CategoriaLlamada
        //        {
        //            Id = 1,
        //            nombre = "Robo",
        //            nroOrden = 5,
        //            OpcionLlamada = new OpcionLlamada
        //            {
        //                Nombre = "Solicitar cancelación de la tarjeta de crédito"
        //            }
        //        }
        //    };

        //    DatosLlamadaViewModel paraMostrar = gestor.buscarDatosLlamadaActual();
        //    return View(paraMostrar);
        //}

        

    }
}
