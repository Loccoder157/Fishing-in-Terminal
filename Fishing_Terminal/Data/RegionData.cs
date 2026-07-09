using System;
using System.ComponentModel.DataAnnotations;
using Model;

namespace Data
{
    class RegionData
    {
        public List<Region> LoadRegion()
        {
            List<Region> ListRegion = new List<Region>();
            string[] LinesData = File.ReadAllLines("Saves/Region.txt");
            foreach (string Line in LinesData)
            {
                string[] Data = Line.Split(";"); 
                Region region = new Region(Data[0], int.Parse(Data[1]), Data[2], int.Parse(Data[3]));
                ListRegion.Add(region);
            }
            return ListRegion;
        }
    }
}