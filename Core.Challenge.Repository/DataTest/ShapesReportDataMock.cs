using CodingChallenge.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Challenge.Repository.DataTest
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
        }
    }
}
