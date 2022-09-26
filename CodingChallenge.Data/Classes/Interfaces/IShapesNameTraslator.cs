using CodingChallenge.Data.Classes.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Interfaces
{
    public interface IShapesNameTraslator
    {
         string GetShapeNametraslated(Idioma idioma);
    }
}
