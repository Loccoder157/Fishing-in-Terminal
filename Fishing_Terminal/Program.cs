using System;
using Model;


namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Fish fish = new Fish("test", 5, 10, 20, 5, 0, 0);
            Console.WriteLine(fish.Size);
            fish.CaculatorSize(0, 0);
            Console.WriteLine(fish.Size);
            Console.WriteLine(fish.SellCost());
            Console.WriteLine(fish.SellExp());
        }
    }
}