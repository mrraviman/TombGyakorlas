namespace TombGyakorlas
{
    internal class Program
    {
        static int[] tomb = new int[5];
        static void feltoltes()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine("Kérem a(z) {0}. számot: ", i + 1);
                tomb[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void forditott()
        {
            for (int i = tomb.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(tomb[i]);
            }
        }
        static void Main(string[] args)
        {
           feltoltes();
           Console.WriteLine();
           forditott();
        }
    }
}
