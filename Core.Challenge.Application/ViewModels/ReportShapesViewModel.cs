using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Classes.Languages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Challenge.Application.ViewModels
{
    public class ReportShapesViewModel
    {
       public Idioma idioma { get; set; }
       public List<ShapeBasic> formas { get; set; }
       public Dictionary<string, int> Cantidades { get; set; }
       public Dictionary<string, decimal> Areas { get; set; }
       public Dictionary<string, decimal> Perimetros { get; set; }
    }
}
