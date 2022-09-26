using CodingChallenge.Data.Classes;
using System.Collections.Generic;

namespace Core.Challenge.Repository.Shapes
{
    public interface IShapeRepository
    {
        ICollection<ShapeBasic> GetAllShapes();
    }
}
