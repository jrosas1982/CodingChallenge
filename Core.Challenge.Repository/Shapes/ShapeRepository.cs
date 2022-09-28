using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Models.Formas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Challenge.Repository.Shapes
{

    public class ShapeRepository : IShapeRepository
    {
        public ICollection<FiguraGeometrica> GetAll() => ShapesReportDataMock.GetDistintasFormasCompleta();
     
       // public ICollection<ShapeBasic> GetAllShapes() => ShapesReportDataMock.GetDistintasFormasCompleta();
    }
}
