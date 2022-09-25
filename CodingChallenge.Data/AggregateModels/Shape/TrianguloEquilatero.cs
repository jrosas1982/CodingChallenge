using Core.Challange.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    internal class TrianguloEquilatero : Shape
    {
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override decimal Width { get; set; }

        public override decimal GetArea() => ((decimal)Math.Sqrt(3) / 4) * Width * Width;
        public override decimal GetPerimeter() => Width * 3;

    }
}
