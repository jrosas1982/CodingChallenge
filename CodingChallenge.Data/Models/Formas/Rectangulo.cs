using CodingChallenge.Data.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Data.Models.Formas
{
    public class Rectangulo : FiguraGeometrica
    {
        public override string Name => "Rectangulo";
        public override decimal Width { get; set; }
        public decimal Height { get; set; }
        public override decimal GetArea() => Width * Height;
        public override decimal GetPerimetro() => Width * 2 + Height * 2;
        public override string GetNombreFiguraTraducida(ILenguaje idioma)
        {
            switch (idioma.Nombre)
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
