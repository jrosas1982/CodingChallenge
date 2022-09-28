using CodingChallenge.Data.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Challenge.Application.Interface
{
    public interface IReporting
    {
         string GetFormaTraducida(ILenguaje lenguaje);
         string GetEmptyResult(ILenguaje lenguaje);
         string GetHeader(ILenguaje lenguaje);
         string GetBody(ITraductorFiguras Forma, ILenguaje lenguaje, int cantidad, decimal area, decimal perimetro);
         string GetFooter(int TotalShapes, ILenguaje idioma, decimal totalPerimeters, decimal totalAreas);

    }
}
