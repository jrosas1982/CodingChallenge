using CodingChallenge.Data.Classes.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Languages
{
    public class Castellano : Idioma
    {
        public Castellano()
        {
        }

        public override int Id { get; set; }
        public override string Name => "Castellano"; 

        public override string ShapeName => "formas";

        public override string GetAreaName() => "Area";

        public override string GetBody(ShapeBasic shape, int cantidad , decimal area , decimal perimetro)
        {
            return $"{cantidad} {Helper.GetPluralString(shape.GetShapeNametraslated(this), cantidad)} | {GetAreaName()} {area:#.##} | {GetPerimeterName()} {perimetro:#.##} <br/>";
        }

        public override string GetEmptyResult() => "Lista vacía de formas!";

        public override string GetFooter(int TotalShapes, Idioma idioma, decimal totalPerimeters, decimal totalAreas)
        {
            return $"TOTAL:<br/>{TotalShapes} {idioma.ShapeName} {idioma.GetPerimeterName()} {totalPerimeters.ToString("#.##")} {idioma.GetAreaName()} {totalAreas.ToString("#.##")}";
        }

        public override string GetHeader() => "Reporte de Formas";

        public override string GetPerimeterName() => "Perimetro";

    }
}
