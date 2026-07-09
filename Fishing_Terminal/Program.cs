using System;
using Model;
using Data;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            BaitData regionData = new BaitData();
            List<Bait> regions = new List<Bait>();
            regions = regionData.LoadBait();
            foreach(Bait r in regions)
            {
                r.ShowInfo();
                Console.WriteLine();
            }
        }
    }
}