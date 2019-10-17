using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLCD
{
    public class LED
    {
        //Tipos de led
        public static readonly string _NONE = "   ";
        public static readonly string _LEFT = "  |";
        public static readonly string _MIDL = " _ ";
        public static readonly string _MDLT = " _|";
        public static readonly string _MDRT = "|_ ";
        public static readonly string _FULL = "|_|";
        public static readonly string _BOTH = "| |";

        private static readonly Dictionary<char, string[]> Digitos = new Dictionary<char, string[]>
        {
            {'0', new string[] { _MIDL, _BOTH, _FULL }},
            {'1', new string[] { _NONE, _LEFT, _LEFT }},
            {'2', new string[] { _MIDL, _MDLT, _MDRT }},
            {'3', new string[] { _MIDL, _MDLT, _MDLT }},
            {'4', new string[] { _NONE, _FULL, _LEFT }},
            {'5', new string[] { _MIDL, _MDRT, _MDLT }},
            {'6', new string[] { _MIDL, _MDRT, _FULL }},
            {'7', new string[] { _MIDL, _LEFT, _LEFT }},
            {'8', new string[] { _MIDL, _FULL, _MDLT }},
            {'9', new string[] { _MIDL, _BOTH, _FULL }}
        };


        //1era version de los cambios para las primeras pruebas
        //public string[] NumberToLCD(int number)
        //{
        //    if (number == 1)
        //    {
        //        return new string[] { _NONE, _LEFT, _LEFT };
        //    }

        //    if (number == 2)
        //    {
        //        return new string[] { _MIDL, _MDLT, _MDRT };
        //    }

        //    if (number == 3)
        //    {
        //        return new string[] { _MIDL, _MDLT, _MDLT };
        //    }

        //    return null;
        //}

        public string[] NumberToLCD(int number)
        {
            var n = Convert.ToChar(number.ToString());

            return Digitos[n];
        }

        public static string ToLCD(int number)
        {
            var n = Convert.ToChar(number.ToString());

            string result = string.Join("\n", Digitos[n]);

            return result;
        }
    }
}
