class Program{

    public static void Main(){

        int[] queue = new int[]{3, 2, 1};
        int tills = 1;

        Console.WriteLine(QueueTime(queue, tills));
    }

    public static long QueueTime(int[] customers, int n)
    {
        var time = 0;
        var tills = new int[n];

        for(int i = 0; i < n; i++){
            tills[i] = customers[i];
            customers[i] = -1;
        }

        while(customers[customers.Length-1] != -1){
            var smallerValueIndex = 0;

            for(int i = 0; i<n-1; i++){
                if(tills[i] < tills[i+1])
                    smallerValueIndex = i;
            }

            time += smallerValueIndex;

            for(int i = 0; i < n; i++){
                tills[i] -= tills[smallerValueIndex];
            }

            
        }


        return time;
    }

}