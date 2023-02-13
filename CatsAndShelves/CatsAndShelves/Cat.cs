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

        public void JumpToShelve(Shelve fromShelve, Shelve toShelve)
        {
            if (fromShelve.Id != 0) fromShelve.CatDepart();
            toShelve.CatArrive();
            SetCatPosition(toShelve.Id);
            
            Console.WriteLine($"\n>>> LOG: Cat jumped from shelve {fromShelve.Id} to shelve {toShelve.Id} <<<\n");
        }
    }
}