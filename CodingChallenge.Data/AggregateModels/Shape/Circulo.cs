using Core.Challange.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class Circulo : Shape
    {
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override decimal Width { get; set; }

        public override decimal GetArea() => (decimal)Math.PI * (Width / 2) * (Width / 2);
 
        public override decimal GetPerimeter() => (decimal)Math.PI * Width;

    }
}
