using CodingChallenge.Data.Classes.Languages;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : ShapeBasic
    {
        public override int Id { get; set ; }
        public override string Name => "Cuadrado";
        public override decimal Width { get; set; }
        public Cuadrado()
        {

        }
        public override decimal GetArea() => Width * Width;
        public override decimal GetPerimeter() => Width * 4;

        public override string GetShapeNametraslated(Idioma idioma)
        {
            switch (idioma.Name)
            {
                case "Ingles":
                    return "Square";
                case "Frances":
                    return "Carré";
            }
            return Name;
        }
    }
}
