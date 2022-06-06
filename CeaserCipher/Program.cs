namespace CeaserCipher{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Oi saudades";
            int displacement = 3;

            Console.WriteLine(CipherManager.EncipherMessage(message, displacement));
            Console.WriteLine(CipherManager.DecipherMessage(message, displacement));
        }
    }
}
