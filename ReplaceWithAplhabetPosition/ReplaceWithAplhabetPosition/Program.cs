using System;
using System.Linq;

namespace ReplaceWithAplhabetPosition
{
    internal static class Program
    {
        static void Main()
        {
            Console.WriteLine(AlphabetPosition("("));
        }

        private static string AlphabetPosition(string text)
        {
            if (string.IsNullOrEmpty(text)) { return string.Empty; }
            /*
             * Para cada char do texto transformado em minusculo
             * se o valor ASCII do char estiver entre 97 e 122
             * subtrair o valor por 96
             * Concatenar valor em uma string
             */
            string alphabetPosition = null!;
            var textToChar = text.ToLower().ToCharArray();

            //alphabetPosition += textToChar[0] - 96;

            for (int i = 0; i < textToChar.Length; i++)
            {
                if (!(textToChar[i] <= 122 && textToChar[i] >= 97)) continue;
                if (alphabetPosition != null) { alphabetPosition += " "; }
                alphabetPosition += $"{textToChar[i] - 96}";
            }

            if (alphabetPosition == null) { return string.Empty; }
            
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