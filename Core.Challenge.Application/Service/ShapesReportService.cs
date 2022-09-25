using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodingChallenge.Data.Classes;
using Core.Challange.Domain;
using Core.Challenge.Application.Interface;
using Core.Challenge.Repository;

namespace Core.Challenge.Application.Service
{
    public class ShapesReportService : IShapesReportService
    {
        Shape _shape;
        public ShapesReportService(Shape shape )
        {
            _shape = shape;
        }
        public static string GetShapesReport(List<FormaGeometrica> formas, int idioma) => FormaGeometrica.Imprimir(formas, idioma);
        public static string GetAllShapesReport() => ShapeRepository.GetAllShapesString();
        public static List<Shape> GetShapes() => ShapeRepository.GetAllShapes();
        public static string Imprimir(List<Shape> formas, Idioma idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                if (idioma.Id == 1)
                    sb.Append("<h1>Lista vacía de formas!</h1>");
                else
                    sb.Append("<h1>Empty list of shapes!</h1>");
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                if (idioma.Id == 1)
                    sb.Append("<h1>Reporte de Formas</h1>");
                else
                    // default es inglés
                    sb.Append("<h1>Shapes report</h1>");

                var formasDistintas = formas.GroupBy(x => x.Name).ToList();

                Dictionary<string, int> cantidades      = new Dictionary<string, int>();
                Dictionary<string, decimal> areas       = new Dictionary<string, decimal>();
                Dictionary<string, decimal> perimetros  = new Dictionary<string, decimal>();

         
                foreach (var i in formasDistintas)
                {
                    var tipo = i.Key;
                    //Cuenta la cantidad de formas Distintas que recibe de la lista de la función y la agrea a un Diccionario de cantidades
                    cantidades.Add(key: i.Key, value: i.Where(x => x.Name == tipo).Count());
                    //Calcula el **Area para cada forma Distinta que recibe la función y la agrea a un Diccionario de areas
                    areas.Add(key: i.Key, value: i.Where(x => x.Name == tipo).Sum(x => x.GetArea()));
                    //Calcula el **Perimetro para cada forma Distinta que recibe la función y la agrea a un Diccionario de perimetros
                    perimetros.Add(key: i.Key, value: i.Where(x => x.Name == tipo).Sum(x => x.GetPerimeter()));


                   var cant = cantidades.Where(x => x.Key == tipo).FirstOrDefault().Value;
                    var are = areas.Where(x => x.Key == tipo).FirstOrDefault().Value;
                   var peri = perimetros.Where(x => x.Key == tipo).FirstOrDefault().Value;

                    sb.Append(GenerateBoby(cant,are,peri,tipo,1));

                }
             
                //1) obtener todos los valores distintos por *nombre* de la lista dada OK
                //2) para cada uno de ellos contar la *cantidad de objetos distintos* ok
                //3) *Calcular el Perimietro* para cada Uno de los objetos ok 
                //4) *Calcular el Area* para cada objeto ok

                // FOOTER
                sb.Append("TOTAL:<br/>");
                sb.Append(formas.Count() + " " + (idioma.Id == 1 ? "formas" : "shapes") + " ");
                sb.Append((idioma.Id == 1 ? "Perimetro " : "Perimeter ") + (perimetros.Sum(x => x.Value)).ToString("#.##") + " ");
                sb.Append("Area " + (areas.Sum(x=> x.Value)).ToString("#.##"));
            }

            return sb.ToString();
        }

        private static string GenerateBoby(int cant, decimal are, decimal peri, string tipo, int idioma) {

          return  ObtenerNuevaLinea(cant, are, peri, tipo, idioma);
        } 

        private static string ObtenerNuevaLinea(int cantidad, decimal area, decimal perimetro, string tipo, int idioma)
        {
            if (cantidad > 0)
            {
                if (idioma == 1)
                    return $"{cantidad} {GetShapeName(tipo, cantidad, idioma)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";

                return $"{cantidad} {GetShapeName(tipo, cantidad, idioma)} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";
            }
            return string.Empty;
        }

        private static string GetShapeName(string tipo, int cantidad, int idioma)
        {

            if (cantidad > 1)
            {
                return string.Concat(tipo, "s");
            }
            else {
                return tipo;
            }
        }
    }
}
