using CodingChallenge.Data.Classes.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Shapes
{
    public class Trapecio : ShapeComplex
    {


        public override int Id { get; set; }
        public override string Name => "Trapecio";
        public override decimal Width_high { get; set; }
        public override decimal Width_low { get; set; }
        public override decimal Height { get; set; }
        public override decimal Width { get; set ; }
        public override decimal Side_left { get; set; }
        public override decimal Side_Rigth { get; set; }
        public override decimal GetArea() => ((Width_high + Width_low) / 2) * Height;
        public override decimal GetPerimeter() => (Side_left + Side_Rigth + Width_high + Width_low);
        public override string GetShapeNametraslated(Idioma idioma)
        {
            switch (idioma.Name)
            {
                case "Ingles":
                    return "Trapeze";
                case "Frances":
                    return "Trapèze";
            }
            return Name;
        }
    }
}
