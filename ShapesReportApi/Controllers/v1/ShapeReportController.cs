using CodingChallenge.Data.Classes;
using Core.Challenge.Application.Interface;
using Core.Challenge.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapesReportApi.Controllers.v1
{
    [ApiController]
    [Route("v1/[controller]")]
    public class ShapeReportController : ControllerBase
    {
        private readonly IReporteFigurasService _reporteFigurasService;
        private readonly ILogger<ShapeReportController> _logger;

        public ShapeReportController(ILogger<ShapeReportController> logger, IReporteFigurasService reporteFigurasService)
        {
            _logger = logger;
            _reporteFigurasService = reporteFigurasService;
        }

        [HttpGet]
        [SwaggerOperation("Retorna todos las formas")]
        public IEnumerable<ReporteFigura> Get()
        {
            return _reporteFigurasService.GetReportes().ToArray();
        }
        [HttpGet("GetDetails")]
        [SwaggerOperation("Retorna todos las formas con detalles")]
        public IEnumerable<ReporteFigura> GetDetails()
        {
            return _reporteFigurasService.GetReportes().ToArray();
        }
    }
}
