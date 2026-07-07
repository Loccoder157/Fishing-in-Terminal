using System;
using Model;

namespace Data
{
    class FishData
    {
        public List<Fish> LoadFish()
        {
            List<Fish> ListFish = new List<Fish>();
            string[] LinesData = File.ReadAllLines("Saves/Fish.txt");
            foreach (string Line in LinesData)
            {
                string[] Data = Line.Split(";"); 
                Fish fish = new Fish(Data[0], int.Parse(Data[1]), int.Parse(Data[2]), 
                int.Parse(Data[3]), int.Parse(Data[4]), int.Parse(Data[5]), int.Parse(Data[6]));
                ListFish.Add(fish);
            }
            return ListFish;
        }
    }
}