using CodingChallenge.Data.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Data.Models.Formas
{
    public class Cuadrado : FiguraGeometrica
    {
        public override string Name => "Cuadrado";
        public override decimal Width { get; set; }
        public override decimal GetArea() => Width * Width;
        public override decimal GetPerimetro() => Width * 4;
        public override string GetNombreFiguraTraducida(ILenguaje idioma)
        {
            switch (idioma.Nombre)
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
