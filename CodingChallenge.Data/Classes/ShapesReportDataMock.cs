using CodingChallenge.Data.Classes.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class ShapesReportDataMock
    {
        public List<ShapeBasic> GetConMasUnCuadrado()
        {
            var cuadrados = new List<ShapeBasic>
            {
                new Cuadrado(){ Id = 1,  Width =5},
                new Cuadrado(){ Id = 1,  Width =1},
                new Cuadrado(){ Id = 1,  Width =3}
            };
            return cuadrados;
        }

        public static List<ShapeBasic> GetDistintasFormas()
        {
            {
                var formas = new List<ShapeBasic>
            {
                new Cuadrado()              { Id=1,  Width =5},
                new Circulo()               { Id=3,  Width = 3},
                new TrianguloEquilatero()   { Id=2,  Width = 4  },
                new Cuadrado()              { Id=1,  Width =2},
                new TrianguloEquilatero()   { Id=2,  Width = 9  },
                new Circulo()               { Id=3,  Width = 2.75m},
                new TrianguloEquilatero()   { Id=2,  Width = 4.2m },

            };
                return formas;
            }
        }       public static List<ShapeBasic> GetDistintasFormasCompleta()
        {
            {
                var formas = new List<ShapeBasic>
            {
                new Cuadrado()              { Id=1,  Width =5},
                new Circulo()               { Id=3,  Width = 3},
                new TrianguloEquilatero()   { Id=2,  Width = 4  },
                new Cuadrado()              { Id=1,  Width =2},
                new TrianguloEquilatero()   { Id=2,  Width = 9  },
                new Circulo()               { Id=3,  Width = 2.75m},
                new TrianguloEquilatero()   { Id=2,  Width = 4.2m },
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
