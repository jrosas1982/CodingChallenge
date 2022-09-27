using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Classes.Languages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Challenge.Application.ViewModels
{
    public class ReportShapesViewModel
    {
       public Idioma Idioma { get; set; }
       public ShapeBasic Forma { get; set; }
       public int CantidadDeFormas { get; set; }
       public decimal SumaAreaForma { get; set; }
       public decimal SumaPerimetroForma { get; set; }

    }
}
