using System;

namespace Model
{
    class Rod
    {
        public string Name{get; private set;} = null!;
        public int Cost{get; private set;}
        public double Power{get; private set;}
        public int RareLevel{get; private set;}

        public Rod(string name, int cost, double power, int rarelevel)
        {
            this.Name = name;
            this.Cost = cost;
            this.Power = power;
            this.RareLevel = rarelevel;
        }
    }
}