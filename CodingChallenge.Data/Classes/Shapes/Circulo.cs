using CodingChallenge.Data.Classes.Languages;
using System;

namespace CodingChallenge.Data.Classes
{
    public class Circulo : ShapeBasic
    {
        public override int Id { get; set; }
        public override string Name => "Círculo";
        public override decimal Width { get; set; }
        public override decimal GetArea() => (decimal)Math.PI * (Width / 2) * (Width / 2);
        public override decimal GetPerimeter() => (decimal)Math.PI * Width;
        public override string GetShapeNametraslated(Idioma idioma)
        { 
            switch (idioma.Name)
            {
                case "Ingles":
                    return "Circle";
                case "Frances":
                    return "Cercle";
            }
            return Name;
        }
    }
}
