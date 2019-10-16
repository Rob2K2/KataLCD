using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLCD
{
    public class LCD
    {
        // Diccionario que define los diferentes símbolos para pintar los números.
        private static readonly Dictionary<int, string> Leds =
            new Dictionary<int, string>
               {
                   {0, "   "},
                   {1, " _ "},
                   {2, "| |"},
                   {3, "|_|"},
                   {5, " _|"},
                   {6, "|_ "},
                   {7, "  |"},
                   {8, "|  "},
               };

        // Diccionario que define los diferentes dígitos disponibles.
        private static readonly Dictionary<char, LCD> Digitos =
            new Dictionary<char, LCD>
               {
                   {'0', new LCD(1, 2, 3)},
                   {'1', new LCD(0, 7, 7)},
                   {'2', new LCD(1, 5, 6)},
                   {'3', new LCD(1, 5, 5)},
                   {'4', new LCD(0, 3, 7)},
                   {'5', new LCD(1, 6, 5)},
                   {'6', new LCD(1, 6, 3)},
                   {'7', new LCD(1, 7, 7)},
                   {'8', new LCD(1, 3, 3)},
                   {'9', new LCD(1, 3, 5)}
               };

        // Arreglo que contiene la representación de cadena del dígito.
        private readonly string[] filas;

        private LCD(int top, int mid, int bot) :
            this(new[] { Leds[top], Leds[mid], Leds[bot] })
        { }

        private LCD(string[] filas)
        {
            this.filas = filas;
        }

        public LCD()
        {
            filas = new[] { "", "", "" };
        }

        public override string ToString()
        {
            return string.Join("\n", filas);
        }

        public static LCD operator +(LCD a, LCD b)
        {
            return new LCD(a.filas.Select((t, i) => t + b.filas[i]).ToArray());
        }

        public static string ToLCD(int numero)
        {
            var result = new LCD();
            foreach (var digito in numero.ToString())
            {
                result += Digitos[digito];
            }
            return result.ToString();
        }
    }
}
