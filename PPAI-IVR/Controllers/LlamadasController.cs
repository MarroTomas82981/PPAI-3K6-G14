﻿using Microsoft.AspNetCore.Mvc;

namespace PPAI_IVR.Controllers
{
    public class LlamadasController: Controller
    {

        public async Task<IActionResult> Index()
        {
            return View();
        }
        
        public async Task<IActionResult> RegistrarLlamada()
        {
            return View();
        }

         

    }
}
