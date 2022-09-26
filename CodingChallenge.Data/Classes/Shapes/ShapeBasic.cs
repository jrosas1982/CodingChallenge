using CodingChallenge.Data.Classes.Interfaces;
using CodingChallenge.Data.Classes.Languages;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public abstract class ShapeBasic : IShapesNameTraslator , IShapesBasicOperation
    {
        public abstract int Id { get; set; }
        public abstract string Name { get;}
        public abstract decimal Width { get; set; }
        public abstract decimal GetArea();
        public abstract decimal GetPerimeter();
        public abstract string GetShapeNametraslated(Idioma idioma);

    }
}
