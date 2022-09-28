using CodingChallenge.Data.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Data.Models.Formas
{
    public class Trapecio : FiguraGeometrica
    {
        public override string Name => "Trapecio";
        public decimal Width_high { get; set; }
        public decimal Width_low { get; set; }
        public decimal Height { get; set; }
        public decimal Side_left { get; set; }
        public decimal Side_Rigth { get; set; }
        public override decimal Width { get; set; }
        public override decimal GetArea() => (Width_high + Width_low) / 2 * Height;
        public override decimal GetPerimetro() => Side_left + Side_Rigth + Width_high + Width_low;
        public override string GetNombreFiguraTraducida(ILenguaje idioma)
        {
            switch (idioma.Nombre)
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
