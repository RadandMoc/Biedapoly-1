using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biedapoly
{
    [Serializable]
    public class Station: Territory
    {
        int costToBuy;
        int moneyFromPawn;
        Dictionary<int, int> costsForRent;

        public int CostToBuy { get => costToBuy; set => costToBuy = value; }
        public int MoneyFromPawn { get => moneyFromPawn; set => moneyFromPawn = value; }
        public Dictionary<int, int> CostsForRent { get => costsForRent; set => costsForRent = value; }

        public Station(int costToBuy, int moneyFromPawn, Dictionary<int, int> costsForRent, string coordinates, Dictionary<string, string> bonusesOfTile, Player owner, int crosses, string name) : base(coordinates, bonusesOfTile, owner, crosses, name)
        {
            CostToBuy = costToBuy;
            MoneyFromPawn = moneyFromPawn;
            CostsForRent = costsForRent;
            Name = name;
        }
    }
}
