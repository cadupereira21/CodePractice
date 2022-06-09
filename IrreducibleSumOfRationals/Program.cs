using System.Collections;
class Program{

    public static void Main(){

        int[,] aux = {{1,2}, {1, 3}, {1, 4}};

        SumFracts(aux);
    }

    public static string SumFracts(int[,] l) 
    {
        List<int> denominator = new List<int>();
        List<int> numerator = new List<int>();

        int index = 2;
        foreach(var value in l){
            if(index++ % 2 == 0)
                numerator.Add(value);
            else
                denominator.Add(value);
        }



        return "";
    }

}
