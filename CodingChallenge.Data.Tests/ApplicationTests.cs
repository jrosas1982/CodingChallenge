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
    }
}
