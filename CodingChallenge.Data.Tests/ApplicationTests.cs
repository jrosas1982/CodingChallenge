using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Models.Formas;
using CodingChallenge.Data.Models.Lenguajes;
using Core.Challenge.Application.Interface;
using Core.Challenge.Application.Service;
using Core.Challenge.Repository.Shapes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class ApplicationTests 
    {
        public  IReporteFigurasService _reporteFigurasService;

        [TestFixtureSetUp]
        public void TestSetup()
        {
            _reporteFigurasService = new ReporteFigurasService(new ShapeRepository(), new Reporting());

        }
        [TestCase]
        public void TestResumenListaVacia()
        {
            _reporteFigurasService.Imprimir(new List<FiguraGeometrica>(), new Castellano());
        }
        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FiguraGeometrica> { new Cuadrado() { Width = 5 } };

            var resumen = _reporteFigurasService.Imprimir(cuadrados, new Castellano());

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }
        [TestCase]
        public void GetDistintasFormasES()
        {
            var cuadrados = ShapesReportDataMock.GetDistintasFormas();

            var resumen = _reporteFigurasService.Imprimir(cuadrados, new Castellano());

            Assert.AreEqual(
            "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
            resumen);
        }
        [TestCase]
        public void GetDistintasFormasEN()
        {
            var cuadrados = ShapesReportDataMock.GetDistintasFormas();

            var resumen = _reporteFigurasService.Imprimir(cuadrados, new Ingles());

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }
        [TestCase]
        public void GetDistintasFormasFR()
        {
            var cuadrados = ShapesReportDataMock.GetDistintasFormas();

            var resumen = _reporteFigurasService.Imprimir(cuadrados, new Frances());

            Assert.AreEqual(
                "<h1>Rapport sur les formes géométriques</h1>2 Carrés | Région 29 | Périmètre 28 <br/>2 Cercles | Région 13,01 | Périmètre 18,06 <br/>3 Triangles | Région 49,64 | Périmètre 51,6 <br/>TOTAL:<br/>7 formes Périmètre 97,66 Région 91,65",
                resumen);
        }
        //----- Perimetro -----
        [TestCase]
        public void CalcularPerimetroCirculo()
        {
            var perimetroCirculo = new List<FiguraGeometrica>() { new Circulo() { Width = 5 } };
            var Perimetro = perimetroCirculo.FirstOrDefault().GetPerimetro();
            Assert.AreEqual("15,71", Perimetro.ToString("#.##"));
        }
        [TestCase]
        public void CalcularPerimetroCuadrado()
        {
            var perimetroCuadrado = new List<FiguraGeometrica>() { new Cuadrado() { Width = 5} };
            var Perimetro = perimetroCuadrado.FirstOrDefault().GetPerimetro();
            Assert.AreEqual(20, Perimetro);
        }

        [TestCase]
        public void CalcularPerimetroRectangulo()
        {
            var perimetroRectangulo = new List<FiguraGeometrica>() { new Rectangulo() { Width = 5 , Height = 2} };
            var Perimetro = perimetroRectangulo.FirstOrDefault().GetPerimetro();
            Assert.AreEqual(14, Perimetro);
        }
        [TestCase]
        public void CalcularPerimetroTrapecio()
        {
            var perimetroTrapecio = new List<FiguraGeometrica>() { new Trapecio() { Width_high = 5 , Width_low = 3 , Side_left = 3 , Side_Rigth = 3 , Height = 4} };
            var Perimetro = perimetroTrapecio.FirstOrDefault().GetPerimetro();
            Assert.AreEqual(14, Perimetro);
        }
        [TestCase]
        public void CalcularPerimetroTriangulo()
        {
            var perimetroTrianguloEquilatero = new List<FiguraGeometrica>() { new TrianguloEquilatero() { Width = 5 } };
            var Perimetro = perimetroTrianguloEquilatero.FirstOrDefault().GetPerimetro();
            Assert.AreEqual(15, Perimetro);
        }
        //----- Area -----
        [TestCase]
        public void CalcularAreaCirculo()
        {
            var areaCirculo = new List<FiguraGeometrica>() { new Circulo() { Width = 10 } };
            var area = areaCirculo.FirstOrDefault().GetArea();
            Assert.AreEqual("78,54", area.ToString("#.##"));
        }
        [TestCase]
        public void CalcularAreaCuadrado()
        {
            var areaCuadrado = new List<FiguraGeometrica>() { new Cuadrado() { Width = 5 } };
            var area = areaCuadrado.FirstOrDefault().GetArea();
            Assert.AreEqual(25, area);
        }

        [TestCase]
        public void CalcularAreaRectangulo()
        {
            var areaRectangulo = new List<FiguraGeometrica>() { new Rectangulo() { Width = 5, Height = 2 } };
            var area = areaRectangulo.FirstOrDefault().GetArea();
            Assert.AreEqual(10, area);
        }
        [TestCase]
        public void CalcularAreaTrapecio()
        {
            var areaTrapecio = new List<FiguraGeometrica>() { new Trapecio() { Width_high = 5, Width_low = 3, Side_left = 3, Side_Rigth = 3 , Height = 4} };
            var area = areaTrapecio.FirstOrDefault().GetArea();
            Assert.AreEqual(16, area);
        }
        [TestCase]
        public void CalcularAreaTriangulo()
        {
            var areaTrianguloEquilatero = new List<FiguraGeometrica>() { new TrianguloEquilatero() { Width = 5 } };
            var area = areaTrianguloEquilatero.FirstOrDefault().GetArea();
            Assert.AreEqual("10,83", area.ToString("#.##"));
        }
    }
}
