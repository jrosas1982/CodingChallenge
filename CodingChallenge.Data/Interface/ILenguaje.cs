using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Data.Interface
{
    public interface ILenguaje
    {
       string Nombre { get; }
       string Forma { get; }
       string Area { get; }
       string Perimetro { get; }
       string MsjListaVacia { get; }
       string MsjHeader { get; }
    }
}
