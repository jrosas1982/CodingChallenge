using CodingChallenge.Data.Classes;
using Core.Challange.Domain;
using Core.Challenge.Application.Service;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class ApplicationTests
    {

        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                ShapesReportService.GetShapesReport(new List<FormaGeometrica>(), 1));
        }
        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<Shape> { new Cuadrado( 1,"Cuadrado",5) };

            var resumen = ShapesReportService.Imprimir(cuadrados, new Idioma() {Id = 1});

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }  
        [TestCase]
        public void GetDistintasFormas()
        {
            var cuadrados = ShapesReportDataMock.GetDistintasFormas();

            var resumen = ShapesReportService.Imprimir(cuadrados, new Idioma() {Id = 1});

            Assert.AreEqual(
            "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
            resumen);
            //Assert.AreEqual(
            //    "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
            //    resumen);
        }
    }
}
