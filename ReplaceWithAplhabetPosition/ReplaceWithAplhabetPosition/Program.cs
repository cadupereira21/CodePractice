using System;
using System.Linq;

namespace ReplaceWithAplhabetPosition
{
    internal static class Program
    {
        static void Main()
        {
            Console.WriteLine(AlphabetPosition("The sunset sets at twelve o' clock."));
        }

        private static string AlphabetPosition(string text)
        {
            /*
             * Para cada char do texto transformado em minusculo
             * se o valor ASCII do char estiver entre 97 e 122
             * subtrair o valor por 96
             * Concatenar valor em uma string
             */
            string alphabetPosition = null!;
            var textToChar = text.ToLower().ToCharArray();

            alphabetPosition += textToChar[0] - 96;

            for (int i = 1; i < textToChar.Length; i++)
            {
                if (!(textToChar[i] <= 122 && textToChar[i] >= 97)) continue;
                alphabetPosition += $" {textToChar[i] - 96}";
            }
            
            return alphabetPosition;
        }

        // private static int[] ConvertToAscii(string text)
        // {
        //     var aux = new int[text.Length];
        //
        //     var index = 0;
        //     foreach (var c in text)
        //     {
        //         aux[index++] = c;
        //     }
        //     
        //     return aux;
        // }
    }
}