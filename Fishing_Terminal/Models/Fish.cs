using System;
using System.ComponentModel.Design.Serialization;
using System.Dynamic;

namespace Model
{
    class Fish
    {
        public string Name{get; private set;} = null!;
        public int Size{get; private set;} = 0;
        public int MinSize{get; private set;}
        public int MaxSize{get; private set;}
        public int Cost{get; private set;}
        public int Exp{get; private set;}
        public int Rarity{get; private set;}
        public int Region{get; private set;}

        public Fish(string name, int minsize, int maxsize, int cost, int exp, int rarity, int region)
        {
            this.Name = name;
            this.MinSize = minsize;
            this.MaxSize = maxsize;
            this.Cost = cost;
            this.Exp = exp;
            this.Rarity = rarity;
            this.Region = region;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} \nMinsize: {MinSize} \nMaxsize: {MaxSize} \nCost: {Cost} \nExp: {Exp} \nRarity: {Rarity} \nRegion: {Region}");
        }
        public void CaculatorSize(double power, double efficiency)
        {
            int size = Random.Shared.Next(MinSize, MaxSize + 1);
            size += (int)( MinSize*(power + efficiency));
            this.Size = size;
        }
        public int SellCost()
        {
            return (int)(Size * Cost);
        }
        public int SellExp()
        {
            return Size * Exp;
        }
    }
}
