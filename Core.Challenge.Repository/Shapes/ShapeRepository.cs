using CodingChallenge.Data.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Challenge.Repository.Shapes
{

    public class ShapeRepository : IShapeRepository
    {
        public ICollection<ShapeBasic> GetAllShapes() => ShapesReportDataMock.GetDistintasFormasCompleta();
    }
}
