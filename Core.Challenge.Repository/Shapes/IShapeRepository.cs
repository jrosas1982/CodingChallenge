using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Models.Formas;
using System.Collections.Generic;

namespace Core.Challenge.Repository.Shapes
{
    public interface IShapeRepository
    {
       // ICollection<ShapeBasic> GetAllShapes();
        ICollection<FiguraGeometrica> GetAll();
    }
}
