using CodingChallenge.Data.Classes.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Shapes
{
    public class Rectangulo : ShapeBasic
    {
        public override int Id { get; set; }
        public override string Name => "Rectangulo";
        public override decimal Width { get; set; }
        public decimal Height { get; set; }
        public override decimal GetArea() => Width * Height ;
        public override decimal GetPerimeter() => Width * 2 + Height * 2;
        public override string GetShapeNametraslated(Idioma idioma)
        {
            switch (idioma.Name)
            {
                case "Ingles":
                    return "Rectangle";
                case "Frances":
                    return "Rectangle";
            }
            return Name;
        }
    }
}
