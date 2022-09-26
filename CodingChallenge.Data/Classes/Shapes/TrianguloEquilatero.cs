using CodingChallenge.Data.Classes.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class TrianguloEquilatero : ShapeBasic
    {
        public override int Id { get; set; }
        public override string Name => "Triángulo";
        public override decimal Width { get; set; }

        public override decimal GetArea() => ((decimal)Math.Sqrt(3) / 4) * Width * Width;
        public override decimal GetPerimeter() => Width * 3;

        public override string GetShapeNametraslated(Idioma idioma)
        {
            switch (idioma.Name)
            {
                case "Ingles":
                    return "Triangle";
                case "Frances":
                    return "Triangle";
            }
            return Name;
        }
    }
}
