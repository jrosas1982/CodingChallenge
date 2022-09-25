using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Challange.Domain
{
    public abstract class Shape
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public abstract decimal Width { get; set; }
        public abstract decimal GetArea();
        public abstract decimal GetPerimeter();

    }
}
