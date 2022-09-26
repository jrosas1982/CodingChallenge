using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Languages
{
    public abstract class Idioma
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; }
        public abstract string ShapeName { get; }
        public abstract string GetEmptyResult();
        public abstract string GetHeader();
        public abstract string GetBody(ShapeBasic shape,int cantidad, decimal area, decimal perimetro);
        public abstract string GetFooter(int TotalShapes, Idioma idioma, decimal totalPerimeters, decimal totalAreas);
        public abstract string GetAreaName();
        public abstract string GetPerimeterName();

    }
}
