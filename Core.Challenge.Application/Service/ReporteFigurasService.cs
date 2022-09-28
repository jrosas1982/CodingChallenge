using CodingChallenge.Data.Classes.Utility;
using CodingChallenge.Data.Interface;
using CodingChallenge.Data.Models.Formas;
using CodingChallenge.Data.Models.Lenguajes;
using Core.Challenge.Application.Interface;
using Core.Challenge.Application.ViewModels;
using Core.Challenge.Repository.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Challenge.Application.Service
{
    public  class ReporteFigurasService :  IReporteFigurasService
    {
        public readonly IShapeRepository _shapeRepository;
        public readonly IReporting _reporting;

        public ReporteFigurasService(IShapeRepository shapeRepository, IReporting reporting)
        {
            _shapeRepository = shapeRepository;
            _reporting = reporting;
        }
        public ICollection<FiguraGeometrica> GetAll()
        {
           return _shapeRepository.GetAll();
        }
        public IEnumerable<ReporteFigura> GetReportes()
        {
            return GetShapeInformation(GetAll().ToList());
        }
        public string GetReporteImprimible()
        {
           return  Imprimir(GetAll().ToList(), new Frances());
        }
        private static IEnumerable<ReporteFigura> GetShapeInformation(List<FiguraGeometrica> formas)
        {
            var ShapeInfoList = new List<ReporteFigura>();

            foreach (var i in formas.GroupBy(x => x.Name).ToList())
            {
                var ShapeInfo = new ReporteFigura();
                var tipo = i.Key;
                ShapeInfo.Figura = i.OfType<FiguraGeometrica>().FirstOrDefault();
                ShapeInfo.CantidadDeFormas = i.Where(x => x.Name == tipo).Count();
                ShapeInfo.SumaAreaForma = i.Where(x => x.Name == tipo).Sum(x => x.GetArea());
                ShapeInfo.SumaPerimetroForma = i.Where(x => x.Name == tipo).Sum(x => x.GetPerimetro());

                ShapeInfoList.Add(ShapeInfo);
            }
            return ShapeInfoList;
        }
    
        public string Imprimir(List<FiguraGeometrica> formas, ILenguaje idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append($"<h1>{idioma.MsjListaVacia}</h1>");
            }
            else
            {
                // HEADER
                sb.Append($"<h1>{idioma.MsjHeader}</h1>");
                var detalles = GetShapeInformation(formas);
                decimal sumAreaTotal =0m;
                decimal sumPerimetroTotal = 0m;
                //Body
                foreach (var d in detalles) {
                    sb.Append(_reporting.GetBody(d.Figura, idioma , d.CantidadDeFormas, d.SumaAreaForma, d.SumaPerimetroForma));
                    sumAreaTotal += d.SumaAreaForma;
                    sumPerimetroTotal += d.SumaPerimetroForma;
                }
                //Footer
                sb.Append(_reporting.GetFooter(formas.Count(), idioma, sumPerimetroTotal, sumAreaTotal));
            }
            return sb.ToString();
        }
    }
}
