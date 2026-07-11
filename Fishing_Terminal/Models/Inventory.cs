using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Model
{
    class Inventory
    {
        public List<Fish> PlayerFish{get; private set;}  = new List<Fish>();
        public void AddInventor(Fish fish)
        {
            this.PlayerFish.Add(fish);
        }
        public (int coin, int exp) SellAll()
        {
            int coin = 0;
            int exp = 0;
            foreach(Fish fish in PlayerFish)
            {
                coin += fish.SellCost();
                exp += fish.SellExp();
            }
            PlayerFish.Clear();
            return (coin, exp);
        }
    }
}