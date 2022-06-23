using System;
using System.Collections.Generic;

namespace IrreducibleSumOfRationals
{
    internal static class Program{

        public static void Main(){

            int[,] aux = {{1,5}, {1, 10}, {1, 65}};

            SumFracts(aux);
        }

        private static string SumFracts(int[,] l) 
        {
            List<int> denominator = new List<int>();
            List<int> numerator = new List<int>();

            var index = 2;
            foreach(var value in l){
                if(index++ % 2 == 0)
                    numerator.Add(value);
                else
                    denominator.Add(value);
            }

            

            /*
             * 1. Descobrir minimo multiplo comum
             * 2. Transformar denominadores
             * 3. Transformar numeradores
             * 4. Somar numeradores
             * 5. Retornar resposta
             */

            var leastCommonMultiple = Mmc(denominator);

            for(int i = 0; i < numerator.Count; i++){
                denominator[i] = leastCommonMultiple;
                numerator[i] = numerator[i] * (leastCommonMultiple/denominator[i]);
            }

            foreach(var d in denominator){
                Console.WriteLine(d);
            }
            
            foreach(var n in numerator){
                Console.WriteLine(n);
            }
            //var leastCommonMultiple = 

            return "";
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

    }
}
