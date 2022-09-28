using CodingChallenge.Data.Interface;
using CodingChallenge.Data.Models.Formas;
using Core.Challenge.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Challenge.Application.Interface
{
    public interface IReporteFigurasService
    {
        IEnumerable<ReporteFigura> GetReportes(ILenguaje idioma);
        ICollection<FiguraGeometrica> GetAll();
        string GetReporteImprimible(ILenguaje idioma);
        string Imprimir(List<FiguraGeometrica> formas, ILenguaje idioma);

    }
}
