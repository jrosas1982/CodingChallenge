using CodingChallenge.Data.Classes;
using Core.Challenge.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Challenge.Application.Interface
{
    public interface IShapesReportService
    {
        //ICollection<ShapeBasic> GetShapes();
        string GetShapesPrinted();
        IEnumerable<ReportShapesViewModel> GetReportsShapesViewModel();
    }
}
