using CatsAndShelves;

namespace CatsAndShelvesTest
{
    public class Tests
    {
        // [SetUp]
        // public void Setup()
        // {
        // }

        [Test]
        public void Test1()
        {
            Cat cat = new Cat();
            Shelve[] shelveTower = new Shelve[5];

            for (var i = 0; i < shelveTower.Length; i++)
            {
                shelveTower[i] = new Shelve(i);
            }
            Assert.AreEqual(2, cat.FindNumberOfJumps(shelveTower));
        }
        
        [Test]
        public void Test2()
        {
            Cat cat = new Cat();
            Shelve[] shelveTower = new Shelve[6];

            for (var i = 0; i < shelveTower.Length; i++)
            {
                shelveTower[i] = new Shelve(i);
            }
            Assert.AreEqual(3, cat.FindNumberOfJumps(shelveTower));
        }
    }
}