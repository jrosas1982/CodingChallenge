using CodingChallenge.Data.Classes.Interfaces;
using CodingChallenge.Data.Classes.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Shapes
{
    public abstract class ShapeComplex  : ShapeBasic
    {
        public abstract decimal Width_high { get; set; }
        public abstract decimal Width_low { get; set; }
        public abstract decimal Height { get; set; }
        public abstract decimal Side_left { get; set; }
        public abstract decimal Side_Rigth { get; set; }
    }
}
