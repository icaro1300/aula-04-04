using Gestao_de_sala.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestao_de_sala.Controllers
{
    public class SalaController : Controller
    {
        SalaDAO tbSala = new SalaDAO();
        public IActionResult Index()
        {
            ViewBag.listasalas = tbSala.getTodaAsSalas();
            return View();
        }
    }
}
