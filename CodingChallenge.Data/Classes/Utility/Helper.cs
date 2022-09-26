using CodingChallenge.Data.Classes.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Utility
{
    public static class Helper
    {

        public static string GetPluralString(string tipo, int cantidad)
        {

            if (cantidad > 1)
            {
                return string.Concat(tipo, "s");
            }
            else
            {
                return tipo;
            }
        }
    }
}
