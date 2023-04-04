using Gestao_de_sala.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestao_de_sala.Controllers
{
    public class OcupacaoController : Controller
    {
        OcupacaoDAO tbocupacao = new OcupacaoDAO();
        public IActionResult Index()
        {
            ViewBag.listaocupacao = tbocupacao.getTodaAsOcupacoes();
            return View();
        }
    }
}
