using CodingChallenge.Data.Classes;
using Core.Challenge.Repository.DataTest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Challenge.Repository.Shapes
{

    public class ShapeRepository : IShapeRepository
    {
        public ICollection<ShapeBasic> GetAllShapes() => CodingChallenge.Data.Classes.ShapesReportDataMock.GetDistintasFormas();
    }
}
