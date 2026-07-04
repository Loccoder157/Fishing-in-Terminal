using System;
using System.IO;
using Model;
namespace Game
{
    class Save
    {
        public static string[] Lines = File.ReadAllLines("Fish.txt");
        public static void LoadFish()
        {
            foreach(string line in Lines)
            {
                string[] data = line.Split(",");
                Fish fish = new Fish(data[0], int.Parse(data[1]), int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]));
                fish.ShowInfo();
                Console.WriteLine();
            }
        }
    }
}