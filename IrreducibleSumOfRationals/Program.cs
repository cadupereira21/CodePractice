using System;
using System.Collections.Generic;

namespace IrreducibleSumOfRationals
{
    internal static class Program{

        public static void Main(){

            int[,] aux = {{1,2}, {2,9}, {3,18}, {4,24}, {6,48}};

            Console.WriteLine(SumFracts(aux));
        }

        private static string SumFracts(int[,] l) 
        {
            if(l.Length == 0){
                return "null";
            }

            List<int> denominator = new List<int>();
            List<int> numerator = new List<int>();

            var index = 2;
            foreach(var value in l){
                if(index++ % 2 == 0)
                    numerator.Add(value);
                else
                    denominator.Add(value);
            }

            

            /* [TODO]
             * 1. Descobrir minimo multiplo comum
             * 2. Transformar denominadores
             * 3. Transformar numeradores
             * 4. Somar numeradores
             * 5. Retornar resposta
             */

            var auxList = CloneList(denominator);
            var leastCommonMultiple = Mmc(denominator);

            for(int i = 0; i < numerator.Count; i++){
                numerator[i] = numerator[i] * (leastCommonMultiple/auxList[i]);
            }

            var numeratorSum = numerator.Sum();

            if(numeratorSum%leastCommonMultiple == 0){
                return (numeratorSum/leastCommonMultiple).ToString();
            }

            return "[" + numeratorSum + ", " + leastCommonMultiple + "]";
        }
        
        private static int Mdc(int a, int b){
            while(b != 0){
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
        
        private static int Mmc(int a, int b){
            return a * (b / Mdc(a, b));
        }

        private static int Mmc(List<int> denominator)
        { 
            var leastCommonMultiple = Mmc(denominator[0], denominator[1]);
            denominator.Remove(denominator[0]);
            denominator.Remove(denominator[0]);
            denominator.Add(leastCommonMultiple);

            if(denominator.Count < 2){
                return leastCommonMultiple;
            }

            return Mmc(denominator);
        }

        private static List<int> CloneList(List<int> toBeCloned){
            List<int> target = new List<int>();
            foreach(var obj in toBeCloned){
                target.Add(obj);
            }

            return target;
        }

    }
}
