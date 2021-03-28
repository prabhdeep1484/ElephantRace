using System;

namespace ElephantRace
{
    public class Bet
    {
        public int Amount;
        public int ElephantNum;
        public Punter Bettor;

        public Bet(int Amount, int ElephantNum, Punter Bettor)
        {
            this.Amount = Amount;
            this.ElephantNum = ElephantNum;
            this.Bettor = Bettor;
        }

        public string GetDescription()
        {
            string description = "";

            if (Amount > 0)
            {
                description = String.Format("{0} bets {1} on Elephant #{2}",
                    Bettor.Name, Amount, ElephantNum);
            }
            else
            {
                description = String.Format("{0} hasn't placed any bets",
                    Bettor.Name);
            }
            return description;
        }

        public int Pay(int Winner)
        {
            if (ElephantNum == Winner)
            {
                return Amount;
            }
            return -Amount;
        }
    }
}
