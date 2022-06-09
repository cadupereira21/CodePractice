class Program{

    public static void Main(){

        int[] queue = new int[]{5, 3, 4};
        int tills = 1;

        Console.WriteLine(QueueTime(queue, tills));
    }

    public static long QueueTime(int[] customers, int n)
    {
        List<int> auxCustomers = customers.ToList();
        var time = 0;
        List<int> tills = new List<int>();

        for(int i = 0; i < n; i++){
            tills.Add(auxCustomers[i]);
            auxCustomers.Remove(auxCustomers[i]);
        }

       while(auxCustomers.Count != 0){
           time += tills.Min();

           for(int i = 0; i < tills.Count; i++){
               tills[i] -= tills.Min();

               if(tills[i] == 0){
                    tills[i] = auxCustomers.First();
                    auxCustomers.RemoveAt(0);
               }
           }  
       }

        while(tills.Sum() > 0){
            time += tills.Min();
            tills.Remove(tills.Min());
        }


        return time;
    }

}