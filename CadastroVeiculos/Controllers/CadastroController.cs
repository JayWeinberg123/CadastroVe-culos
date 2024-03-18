    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Diagnostics;
    using CadastroVeiculos.Models;

    namespace CadastroVeiculos.Controllers
    {

        public class CadastroController : Controller
        {

            public IActionResult Index()
            {
                return View();
            }
        

         public IActionResult Cadastrar()
            {
                return View();
            }

         public IActionResult Editar()
            {
                return View();
            }

         public IActionResult Visualizar()
            {
                return View();
            }

        public IActionResult Cor()
            {
                return View();
            }
        public IActionResult Combustivel()
            {
                return View();
            }
        public IActionResult ConfirmaApagar()
            {
                return View();
            }
        public IActionResult Apagar()
            {
                return View();
            }                  
        }
    }

