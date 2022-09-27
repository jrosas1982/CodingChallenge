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
        private readonly IShapesReportService _shapesReportService;
        private readonly ILogger<ShapeReportController> _logger;

        public ShapeReportController(ILogger<ShapeReportController> logger, IShapesReportService shapesReportService)
        {
            _logger = logger;
            _shapesReportService = shapesReportService;
        }

        [HttpGet]
        [SwaggerOperation("Retorna todos las formas")]
        public IEnumerable<ShapeBasic> Get()
        {
            return _shapesReportService.GetShapes().ToArray();
        }
        [HttpGet("GetDetails")]
        [SwaggerOperation("Retorna todos las formas con detalles")]
        public IEnumerable<ReportShapesViewModel> GetDetails()
        {
            return _shapesReportService.GetReportsShapesViewModel().ToArray();
        }
    }
}
