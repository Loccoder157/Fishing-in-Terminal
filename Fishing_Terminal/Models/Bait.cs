using System;

namespace Model
{
    class Bait
    {
        public string Name{get; private set;} = null!;
        public int Cost{get; private set;}
        public double Luck{get; private set;}
        public Bait(string name, int cost, double luck)
        {
            this.Name = name;
            this.Cost = cost;
            this.Luck = luck;
        }
    }
}