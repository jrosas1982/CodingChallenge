using CodingChallenge.Data.Models.Lenguajes;
using Core.Challenge.Application.Interface;
using Core.Challenge.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShapesReport.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ShapesReport.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IReporteFigurasService _reporteFigurasService;
       // private readonly IShapesReportService _shapesReportService;

        public HomeController(ILogger<HomeController> logger, IReporteFigurasService reporteFigurasService)
        {
            _logger = logger;
            _reporteFigurasService = reporteFigurasService;
        }
        public IActionResult Index()
        {
            ViewBag.repoImpreso = _reporteFigurasService.GetReporteImprimible(new Castellano());
            return View();
        }

        public IActionResult Report()
        {
           var reportShapesViewModel = _reporteFigurasService.GetReportes(new Castellano());
            return View(reportShapesViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
