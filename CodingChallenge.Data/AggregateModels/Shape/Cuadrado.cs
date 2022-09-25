using Core.Challange.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : Shape
    {
        public override int Id { get; set ; }
        public override string Name { get; set; }
        public override decimal Width { get; set; }
        public Cuadrado(int id, string name, decimal width)
        {
            Id = id;
            Name = name;
            Width = width;
        }
        public Cuadrado()
        {

        }
        public override decimal GetArea() => Width * Width;
        public override decimal GetPerimeter() => Width * 4;
    }
}
