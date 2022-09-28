//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using CodingChallenge.Data.Classes;
//using Core.Challenge.Application.Interface;
//using Core.Challenge.Application.ViewModels;
//using Core.Challenge.Repository.Shapes;

//namespace Core.Challenge.Application.Service
//{
//    public class ShapesReportService : IShapesReportService
//    {
//        public readonly IShapeRepository _shapeRepository;

//        public ShapesReportService(IShapeRepository shapeRepository)
//        {
//            _shapeRepository = shapeRepository; 
//        }
//        public ICollection<ShapeBasic> GetShapes()
//        {
//           return _shapeRepository.GetAllShapes();
//        }
//        public IEnumerable<ReportShapesViewModel> GetReportsShapesViewModel() {

//            return GetShapeInformation(_shapeRepository.GetAllShapes().ToList());
//        }
//        private IEnumerable<ReportShapesViewModel> GetShapeInformation(List<ShapeBasic> formas) {
//            var ShapeInfoList = new List<ReportShapesViewModel>();

//            foreach (var i in formas.GroupBy(x => x.Name).ToList())
//            {
//                var ShapeInfo = new ReportShapesViewModel();
//                var tipo = i.Key;
//                ShapeInfo.Forma = i.OfType<ShapeBasic>().FirstOrDefault();
//                ShapeInfo.CantidadDeFormas= i.Where(x => x.Name == tipo).Count();
//                ShapeInfo.SumaAreaForma = i.Where(x => x.Name == tipo).Sum(x => x.GetArea());
//                ShapeInfo.SumaPerimetroForma = i.Where(x => x.Name == tipo).Sum(x => x.GetPerimeter());

//                ShapeInfoList.Add(ShapeInfo);
//             }
//            return ShapeInfoList;
//            }
//        public string GetShapesPrinted()
//        {
//           return Imprimir((List<ShapeBasic>)_shapeRepository.GetAllShapes(), new Ingles());
//        }

//        public static string Imprimir(List<ShapeBasic> formas, Idioma idioma)
//        {
//            var sb = new StringBuilder();

//            if (!formas.Any())
//            {
//                sb.Append($"<h1>{idioma.GetEmptyResult()}</h1>");
//            }
//            else
//            {
//                // Hay por lo menos una forma
//                // HEADER
//                sb.Append($"<h1>{idioma.GetHeader()}</h1>");

//                Dictionary<string, int> cantidades = new Dictionary<string, int>();
//                Dictionary<string, decimal> areas = new Dictionary<string, decimal>();
//                Dictionary<string, decimal> perimetros = new Dictionary<string, decimal>();
//                //Crea lineas de reporte para cada forma enviada por parametro
//                //BODY 
//                foreach (var i in formas.GroupBy(x => x.Name).ToList())
//                {
//                    var tipo = i.Key;
//                    var TipoDeForma = i.OfType<ShapeBasic>().FirstOrDefault();
//                    //Cuenta la cantidad de formas Distintas que recibe de la lista de la función y la agrea a un Diccionario de cantidades
//                    cantidades.Add(key: i.Key, value: i.Where(x => x.Name == tipo).Count());
//                    //Calcula el **Area para cada forma Distinta que recibe la función y la agrea a un Diccionario de areas
//                    areas.Add(key: i.Key, value: i.Where(x => x.Name == tipo).Sum(x => x.GetArea()));
//                    //Calcula el **Perimetro para cada forma Distinta que recibe la función y la agrea a un Diccionario de perimetros
//                    perimetros.Add(key: i.Key, value: i.Where(x => x.Name == tipo).Sum(x => x.GetPerimeter()));

//                    var CantidadPorForma = cantidades.Where(x => x.Key == tipo).FirstOrDefault().Value;
//                    var AreaTotalPorForma = areas.Where(x => x.Key == tipo).FirstOrDefault().Value;
//                    var PerimetroTotalPorForma = perimetros.Where(x => x.Key == tipo).FirstOrDefault().Value;

//                    sb.Append(idioma.GetBody(TipoDeForma, CantidadPorForma, AreaTotalPorForma, PerimetroTotalPorForma));
//                }
//                //FOOTER
//                sb.Append(idioma.GetFooter(formas.Count(), idioma, perimetros.Sum(x => x.Value), areas.Sum(x => x.Value)));
//            }
//            return sb.ToString();
//            //public static string Imprimir(List<ShapeBasic> formas, Idioma idioma)
//            //{
//            //    var sb = new StringBuilder();

//            //    if (!formas.Any())
//            //    {
//            //        sb.Append($"<h1>{idioma.GetEmptyResult()}</h1>");
//            //    }
//            //    else
//            //    {
//            //        // Hay por lo menos una forma
//            //        // HEADER
//            //        sb.Append($"<h1>{idioma.GetHeader()}</h1>");

//            //        Dictionary<string, int> cantidades = new Dictionary<string, int>();
//            //        Dictionary<string, decimal> areas = new Dictionary<string, decimal>();
//            //        Dictionary<string, decimal> perimetros = new Dictionary<string, decimal>();
//            //        //Crea lineas de reporte para cada forma enviada por parametro
//            //        //BODY 
//            //        foreach (var i in formas.GroupBy(x => x.Name).ToList())
//            //        {
//            //            var tipo = i.Key;
//            //            var TipoDeForma = i.OfType<ShapeBasic>().FirstOrDefault();
//            //            //Cuenta la cantidad de formas Distintas que recibe de la lista de la función y la agrea a un Diccionario de cantidades
//            //            cantidades.Add(key: i.Key, value: i.Where(x => x.Name == tipo).Count());
//            //            //Calcula el **Area para cada forma Distinta que recibe la función y la agrea a un Diccionario de areas
//            //            areas.Add(key: i.Key, value: i.Where(x => x.Name == tipo).Sum(x => x.GetArea()));
//            //            //Calcula el **Perimetro para cada forma Distinta que recibe la función y la agrea a un Diccionario de perimetros
//            //            perimetros.Add(key: i.Key, value: i.Where(x => x.Name == tipo).Sum(x => x.GetPerimeter()));

//            //            var CantidadPorForma = cantidades.Where(x => x.Key == tipo).FirstOrDefault().Value;
//            //            var AreaTotalPorForma = areas.Where(x => x.Key == tipo).FirstOrDefault().Value;
//            //            var PerimetroTotalPorForma = perimetros.Where(x => x.Key == tipo).FirstOrDefault().Value;

//            //            sb.Append(idioma.GetBody(TipoDeForma, CantidadPorForma, AreaTotalPorForma, PerimetroTotalPorForma));
//            //        }
//            //        //FOOTER
//            //        sb.Append(idioma.GetFooter(formas.Count(),idioma, perimetros.Sum(x => x.Value), areas.Sum(x => x.Value)));
//            //    }
//            //    return sb.ToString();
//        }
//    }
//}
