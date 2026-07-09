using System;
using System.ComponentModel.DataAnnotations;
using Model;

namespace Data
{
    class BaitData
    {
        public List<Bait> LoadBait()
        {
            List<Bait> ListBait = new List<Bait>();
            string[] LinesData = File.ReadAllLines("Saves/Bait.txt");
            foreach (string Line in LinesData)
            {
                string[] Data = Line.Split(";"); 
                Bait bait = new Bait(Data[0], int.Parse(Data[1]), Double.Parse(Data[2]));
                ListBait.Add(bait);
            }
            return ListBait;
        }
    }
}