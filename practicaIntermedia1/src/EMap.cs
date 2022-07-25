using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace practicaIntermedia1.src
{
    //parte 5
    public static class EMap
    {
        public static T PrimerValor<T>(this Map<T> map) where T : Pair
        {
            return map.GetAt(0);
        }

        //parte 6
        public static bool ValidaTexto(this string cadena)
        {
            return Regex.IsMatch(cadena, @"^[A-Z]{1}[a-z]{3}[0-9]{4}$");
        }
    }
}
