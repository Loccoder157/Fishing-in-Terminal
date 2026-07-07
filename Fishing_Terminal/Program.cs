using System;
using Model;
using Data;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            FishData fishData = new FishData();
            List<Fish> ListFish = fishData.LoadFish();
            foreach (Fish f in ListFish)
            {
                f.ShowInfo();
                Console.WriteLine();
            }
        }
    }
}