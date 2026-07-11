using System;

namespace Model
{
    class Player
    {
        public string Name{get; private set;} = null!;
        public int Coin{get; private set;}
        public int Level{get; private set;}
        public int Exp{get; private set;}
        public Rod Rod{get; private set;} = null!;
        public Bait Bait{get; private set;} = null!;
        public int RegionId{get; private set;}
        public Player(string name, int coin, int level, int exp, int regionid)
        {
            this.Name = name;
            this.Coin = coin;
            this.Level = level;
            this.Exp = exp;
            this.RegionId = regionid;
        }
        public void AddCoin(int value)
        {
            if(value > 0)
            {
                this.Coin += value;
            }
        }
        public bool WithdrawCoin(int value)
        {
            if (value > 0 && this.Coin - value >= 0)
            {
                this.Coin -= value;
                return true;
            }
            else
            {
                Console.WriteLine("Số coin không đủ");
                return false;
            }
        }
        public void SetRod(Rod rod)
        {
            this.Rod = rod;
        }
        public void SetBait(Bait bait)
        {
            this.Bait = bait;
        }
        public void SetRegionId(int id)
        {
            this.RegionId = id;
        }
    }
}