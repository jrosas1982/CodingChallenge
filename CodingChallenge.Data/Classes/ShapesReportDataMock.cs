using Core.Challange.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class ShapesReportDataMock
    {
        public List<Shape> GetConMasUnCuadrado()
        {
            var cuadrados = new List<Shape>
            {
                new Cuadrado(){ Id = 1, Name = "Cuadrado" , Width =5},
                new Cuadrado(){ Id = 1, Name = "Cuadrado" , Width =1},
                new Cuadrado(){ Id = 1, Name = "Cuadrado" , Width =3}
            };
            return cuadrados;
        }

        public static List<Shape> GetDistintasFormas()
        {
            {
                var formas = new List<Shape>
            {
                new Cuadrado()              { Id=1, Name = "Cuadrado" , Width =5},
                new Circulo()               { Id=3, Name = "Círculo", Width = 3},
                new TrianguloEquilatero()   { Id=2, Name = "Triángulo" , Width = 4  },
                new Cuadrado()              { Id=1, Name = "Cuadrado" , Width =2},
                new TrianguloEquilatero()   { Id=2, Name = "Triángulo" , Width = 9  },
                new Circulo()               { Id=3, Name = "Círculo", Width = 2.75m},
                new TrianguloEquilatero()   { Id=2, Name = "Triángulo" , Width = 4.2m },

            };
                return formas;
            }
        }
    }
}
