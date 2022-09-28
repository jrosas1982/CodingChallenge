using CodingChallenge.Data.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Data.Models.Lenguajes
{
    public class Frances : ILenguaje
    {
        public string Nombre => "Frances";
        public string Forma => "formes";
        public string Area => "Région";
        public string Perimetro => "Périmètre";
        public string MsjListaVacia => "Liste vide!";
        public string MsjHeader => "Rapport sur les formes géométriques";
    }
}