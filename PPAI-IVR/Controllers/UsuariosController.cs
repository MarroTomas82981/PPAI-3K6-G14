﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PPAI_IVR.Models;
using PPAI_IVR;
using System.Security.Claims;
using PPAI_IVR.Clases;


namespace TareasMVC.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly ApplicationDbContext context;

        public UsuariosController(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager, ApplicationDbContext context)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.context = context;
        }

        [AllowAnonymous]
        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Registro(RegistroViewModel modelo)
        {
            if (!ModelState.IsValid)
            {
                return View(modelo);
            }

            var usuario = new IdentityUser() { Email = modelo.Email, UserName = modelo.Email };

            var resultado = await userManager.CreateAsync(usuario, password: modelo.Password);

            if (resultado.Succeeded)
            {
                await signInManager.SignInAsync(usuario, isPersistent: true);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach (var error in resultado.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

                return View(modelo);
            }
        }

        [AllowAnonymous]
        public IActionResult Login(string mensaje = null)
        {
            if (mensaje is not null)
            {
                ViewData["mensaje"] = mensaje;
            }

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel modelo)
        {
            if (!ModelState.IsValid)
            {
                return View(modelo);
            }

            var resultado = await signInManager.PasswordSignInAsync(modelo.Email,
                modelo.Password, modelo.Recuerdame, lockoutOnFailure: false);

            if (resultado.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Nombre de usuario o password incorrecto.");
                return View(modelo);
            }

        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(IdentityConstants.ApplicationScheme);
            return RedirectToAction("Index", "Home");
        }

        //[AllowAnonymous]
        //[HttpGet]
        //public ChallengeResult LoginExterno(string proveedor, string urlRetorno = null)
        //{
        //    var urlRedireccion = Url.Action("RegistrarUsuarioExterno", values: new { urlRetorno });
        //    var propiedades = signInManager
        //        .ConfigureExternalAuthenticationProperties(proveedor, urlRedireccion);
        //    return new ChallengeResult(proveedor, propiedades);
        //}

        

        //[HttpGet]
        //[Authorize(Roles = Constantes.RolAdmin)]
        //public async Task<IActionResult> Listado(string mensaje = null)
        //{
        //    var usuarios = await context.Users.Select(u => new UsuarioViewModel
        //    {
        //        Email = u.Email
        //    }).ToListAsync();

        //    var modelo = new UsuariosListadoViewModel();
        //    modelo.Usuarios = usuarios;
        //    modelo.Mensaje = mensaje;
        //    return View(modelo);

        //}

        //[HttpPost]
        //[Authorize(Roles = Constantes.RolAdmin)]
        //public async Task<IActionResult> HacerAdmin(string email)
        //{
        //    var usuario = await context.Users.Where(u => u.Email == email).FirstOrDefaultAsync();

        //    if (usuario is null)
        //    {
        //        return NotFound();
        //    }

        //    await userManager.AddToRoleAsync(usuario, Constantes.RolAdmin);

        //    return RedirectToAction("Listado",
        //        routeValues: new { mensaje = "Rol asignado correctamente a " + email });
        //}

        //[HttpPost]
        //[Authorize(Roles = Constantes.RolAdmin)]
        //public async Task<IActionResult> RemoverAdmin(string email)
        //{
        //    var usuario = await context.Users.Where(u => u.Email == email).FirstOrDefaultAsync();

        //    if (usuario is null)
        //    {
        //        return NotFound();
        //    }

        //    await userManager.RemoveFromRoleAsync(usuario, Constantes.RolAdmin);

        //    return RedirectToAction("Listado",
        //        routeValues: new { mensaje = "Rol removido correctamente a " + email });
        //}
    }
}