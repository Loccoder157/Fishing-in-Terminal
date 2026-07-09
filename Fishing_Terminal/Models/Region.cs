using System;

namespace Model
{
    class Region
    {
        public string Name{get; private set;} = null!;
        public int ID{get; private set;}
        public int Level {get; private set;}
        public string Descriptions{get; private set;} = null!;  
        
        public Region(string name, int id, string descriptions, int level)
        {
            this.Name = name;
            this.ID = id;
            this.Descriptions = descriptions;
            this.Level = level;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} \nID: {ID} \nDescriptions: {Descriptions}\nLevel: {Level}");
        }
    }
}