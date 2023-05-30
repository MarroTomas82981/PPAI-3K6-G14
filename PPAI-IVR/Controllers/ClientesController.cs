using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using PPAI_IVR.Migrations;
using PPAI_IVR.Models.Clases;
using PPAI_IVR.Servicios;

namespace PPAI_IVR.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IRepositorioClientes repositorioClientes;

        public ClientesController(IRepositorioClientes repositorioClientes)
        {
            this.repositorioClientes = repositorioClientes;
        }

        public async Task<IActionResult> Index()
        {
            var clientes = await repositorioClientes.Obtener();
            return View(clientes);
        }

        public IActionResult Crear()
        {

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Crear(Cliente cliente)
        {
            if (!ModelState.IsValid)
            {

                return View(cliente);
            }


            cliente.InformacionDelCliente = null;
            var yaExisteCliente = await repositorioClientes.Existe(cliente.NombreCompleto, cliente.Dni);

            if (yaExisteCliente)
            {
                ModelState.AddModelError(nameof(cliente.NombreCompleto),
                    $"El nombre {cliente.NombreCompleto} Con el DNI {cliente.Dni} ya existe.");
                return View(cliente);
            }

            await repositorioClientes.Crear(cliente);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Editar(int id)
        {

            var tipoCuenta = await repositorioClientes.ObtenerPorId(id);

            if (tipoCuenta is null)
            {
                return RedirectToAction("NoEncontrado", "Home");
            }
            return View(tipoCuenta);
        }
        [HttpPost]
        public async Task<IActionResult> Editar(Cliente cliente)
        {

            var clienteee = await repositorioClientes.ObtenerPorId(cliente.Id);

            if (clienteee is null)
            {
                return RedirectToAction("NoEncontrado", "Home");
            }


            await repositorioClientes.Actualizar(cliente);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Borrar(int id)
        {

            var cliente = await repositorioClientes.ObtenerPorId(id);

            if (cliente is null)
            {
                return RedirectToAction("NoEncontrado", "Home");
            }

            return View(cliente);

        }
        [HttpPost]
        public async Task<IActionResult> BorrarCliente(int id)
        {
            var cliente = await repositorioClientes.ObtenerPorId(id);

            if (cliente is null)
            {
                return RedirectToAction("NoEncontrado", "Home");
            }
            await repositorioClientes.Borrar(id);
            return RedirectToAction("Index");
        }
    }
}