namespace CatsAndShelves
{
    public class Shelve
    {
        private readonly int id;
        private bool isCatHere;
        public int Id => id;
        public bool IsCatHere => isCatHere;

        public Shelve(int id)
        {
            this.id = id;
            isCatHere = false;
        }
        
        public void CatArrive()
        {
            isCatHere = true;
        }

        public void CatDepart()
        {
            isCatHere = false;
        }
    }
}