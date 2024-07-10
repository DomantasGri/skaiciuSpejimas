
namespace numberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next(1,10);
            int Spejimas;

            Console.WriteLine("Spekite skaičių iki 10");

            for (int i = 0; i <= 4; i++)
            {
                
                Spejimas = Int32.Parse(Console.ReadLine());
                if (Spejimas != num)
                {
                    Console.WriteLine("Jusu spejimas neteisingas turite dar {0} spėjimus",4-i);
                    if (Spejimas > num)
                    {
                        Console.WriteLine("Jūs spėjote per daug");
                    }
                    else
                    {
                        Console.WriteLine("Jūs spejote per mažai");
                    }
                }
                else {
                    Console.WriteLine("Laimėjote");
                    Console.ReadKey();
                }
            }
        }

    }

}