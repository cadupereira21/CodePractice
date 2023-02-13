using System;

namespace CatsAndShelves
{
    public class Cat
    {
        private int position;
        public int Position => position;

        public Cat()
        {
            position = 0;
        }

        private void SetCatPosition(int newPosition) { position = newPosition; }

        private void JumpToShelve(Shelve fromShelve, Shelve toShelve)
        {
            if (fromShelve.Id != 0) fromShelve.CatDepart();
            toShelve.CatArrive();
            SetCatPosition(toShelve.Id);
            
            Console.WriteLine($"\n>>> LOG: Cat jumped from shelve {fromShelve.Id} to shelve {toShelve.Id} <<<\n");
        }
        
        public int FindNumberOfJumps(Shelve[] shelve)
        {
            var numberOfJumps = 0;
            JumpToShelve(shelve[0], shelve[0]);
    
            // Console.WriteLine($"Cat Position: {cat.Position}");
            // foreach (var s in shelve)
            // {
            //     Console.WriteLine($"Is cat here? {s.IsCatHere}");
            // }

            while (!shelve[^1].IsCatHere)
            {
                try
                {
                    JumpToShelve(shelve[Position], shelve[Position+3]);
                }
                catch (IndexOutOfRangeException e)
                {
                    JumpToShelve(shelve[Position], shelve[Position + 1]);
                }

                numberOfJumps += 1;
            }
    
            return numberOfJumps;
        }
    }
}