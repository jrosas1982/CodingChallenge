using CodingChallenge.Data.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Data.Models.Formas
{
    public class Circulo : FiguraGeometrica
    {
        public override string  Name => "Círculo";
        public override decimal Width { get; set; }
        public override decimal GetArea() => (decimal)Math.PI * (Width / 2) * (Width / 2);
        public override decimal GetPerimetro() => (decimal)Math.PI * Width;
        public override string GetNombreFiguraTraducida(ILenguaje idioma)
        {
            switch (idioma.Nombre)
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
