using System;
using System.Collections.Generic;
using System.Linq;

namespace FindingVowel
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            const string word = "supercalifragilisticexpialidocious";
            var vowelsInWord = FindVowels(word);

            try
            {
                Console.Write($"[{vowelsInWord[0]}, ");
                for (int i = 1; i < vowelsInWord.Count-1; i++)
                {
                    Console.Write($"{vowelsInWord[i]}, ");
                }
                Console.WriteLine($"{vowelsInWord.Last()}]");
            }
            catch (Exception e)
            {
                // ignored
            }
        }

        private static List<int> FindVowels(string word){
            var vowels = "aeiouy";
            var aux = new List<int>();
        
            var wordChars = (word.ToLower()).ToCharArray();
        
            var index = 0;
            foreach(var i in wordChars){
                if(vowels.Contains(i)){
                    aux.Add(index+1);
                }
        
                ++index;
            }
        
            return aux;
        }
        
        // THIS FUNCTION IS FOR CODEWARS
        // private static int[] FindVowels(string word){
        //     var vowels = "aeiouy";
        //     var numberOfVowelsInSource = 0;
        //     
        //     foreach(var i in word.ToLower()){
        //         if(vowels.Contains(i))
        //         {
        //             numberOfVowelsInSource += 1;
        //         }
        //     }
        //
        //     if (numberOfVowelsInSource < 1)
        //     {
        //         return new int[]{};
        //     }
        //
        //     var indexOfVowelsInSource = new int[numberOfVowelsInSource];
        //     
        //     var charIndex = 0;
        //     var arrayIndex = 0;
        //     foreach(var i in word.ToLower()){
        //         if(vowels.Contains(i)){
        //             indexOfVowelsInSource[arrayIndex++] = charIndex+1;
        //         }
        //     
        //         charIndex += 1;
        //     }
        //
        //     return indexOfVowelsInSource;
        // }
    }
}

