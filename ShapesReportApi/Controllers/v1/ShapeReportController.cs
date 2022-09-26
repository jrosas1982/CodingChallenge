using CodingChallenge.Data.Classes;
using Core.Challenge.Application.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        public IEnumerable<ShapeBasic> Get()
        {
            return _shapesReportService.GetShapes().ToArray();
        }
    }
}
