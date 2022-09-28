using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Interface;
using CodingChallenge.Data.Models.Formas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Challenge.Application.ViewModels
{
    public class ReportShapesViewModel
    {
       public ILenguaje Lenguaje { get; set; }
       public FiguraGeometrica Figura { get; set; }
       public int CantidadDeFormas { get; set; }
       public decimal SumaAreaForma { get; set; }
       public decimal SumaPerimetroForma { get; set; }

    }
}
