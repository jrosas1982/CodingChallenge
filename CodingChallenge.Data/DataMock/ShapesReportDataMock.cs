using CodingChallenge.Data.Models.Formas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class ShapesReportDataMock
    {
        public List<FiguraGeometrica> GetFiguraConMasUnCuadrado()
        {
            var cuadrados = new List<FiguraGeometrica> { new Cuadrado() { Width = 5 }, new Cuadrado() { Width = 1 }, new Cuadrado() { Width = 3 } };
            return cuadrados;
        }

        public static List<FiguraGeometrica> GetDistintasFormas()
        {
            {
                var formas = new List<FiguraGeometrica>
            {
                new Cuadrado()              { Width =5},
                new Circulo()               { Width = 3},
                new TrianguloEquilatero()   { Width = 4  },
                new Cuadrado()              { Width =2},
                new TrianguloEquilatero()   { Width = 9  },
                new Circulo()               { Width = 2.75m},
                new TrianguloEquilatero()   { Width = 4.2m },

            };
                return formas;
            }
        }
        public static List<FiguraGeometrica> GetDistintasFormasCompleta()
        {
            {
                var formas = new List<FiguraGeometrica>
            {
                new Cuadrado()              { Width =5},
                new Circulo()               { Width = 3},
                new TrianguloEquilatero()   { Width = 4  },
                new Cuadrado()              { Width =2},
                new TrianguloEquilatero()   { Width = 9  },
                new Circulo()               { Width = 2.75m},
                new TrianguloEquilatero()   { Width = 4.2m },
                new Trapecio()              {Width_high = 9.5m , Width_low = 3.5m , Height = 4},
                new Trapecio()              {Width_high = 3 , Width_low = 5 , Height = 4},
                new Rectangulo()            { Height = 4 , Width = 2},
                new Rectangulo()            { Height = 7 , Width = 6}
            };
                return formas;
            }
        }
    }
}
