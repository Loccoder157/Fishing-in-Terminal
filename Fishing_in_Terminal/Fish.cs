using System;

namespace Model
{
    class Fish
    {
        public string Name{get;}
        public int MaxSize{get;}
        public int  MinSize{get;}
        public int Level{get;}
        public int Region{get;}

        public Fish(string name, int minsize, int maxsize, int lv, int region)
        {
            this.Name = name;
            this.MaxSize = maxsize;
            this.MinSize = minsize;
            this.Level = lv;
            this.Region = region;
        }
        public void ShowInfo()
        {
            Console.WriteLine
            (
                $"Name: {Name} \nSize: {MinSize} - {MaxSize} \nLevel: {Level} \nRegion: {Region}"
            );
        }

    }
}