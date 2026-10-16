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
        static void Masodik()
        {
           
            for(int i = 1;  i < tomb.Length; i += 2)
            {
                Console.WriteLine($"Az {i+1}. szám: {tomb[i]}");
            }
        }
        static void Megadott()
        {
            Console.WriteLine("Kérem a számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i < tomb.Length && tomb[i] != tomb[szam-1])
            {
                i++;
            }
            if (i < tomb.Length)
                {
                    Console.WriteLine($"A szám a(z) {i+1}. helyen található, a szám: {tomb[i]}");
                    
                }
            else
            {
                Console.WriteLine("A szám nem található a tömbben.");
            }
            
            
        }
        static void KitalaltTomb()
        {
            Console.WriteLine("Kérem a tömb elemének a számát: ");
            int N = Convert.ToInt32(Console.ReadLine());
        }
        
        static void Main(string[] args)
        {
           feltoltes();
           Console.WriteLine();
           forditott();
           Console.WriteLine();
           Masodik();
           Megadott();
           KitalaltTomb();
        }
    }
}
