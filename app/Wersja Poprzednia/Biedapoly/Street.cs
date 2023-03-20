using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biedapoly
{
    [Serializable]
    public class Street : Territory
    {
        int costToBuildHause;
        int costToBuildHotel;
        int costToBuy;
        int moneyFromPawn;
        int howMuchAreHauses = 0;
        Dictionary<int, int> costsForRent;

        public int CostToBuildHause { get => costToBuildHause; set => costToBuildHause = value; }
        public int CostToBuildHotel { get => costToBuildHotel; set => costToBuildHotel = value; }
        public int CostToBuy { get => costToBuy; set => costToBuy = value; }
        public int MoneyFromPawn { get => moneyFromPawn; set => moneyFromPawn = value; }
        public int HowMuchAreHauses { get => howMuchAreHauses; set => howMuchAreHauses = value; }
        public Dictionary<int, int> CostsForRent { get => costsForRent; set => costsForRent = value; }

        public Street() : base()
        { }
        public Street(int costToBuildHause, int costToBuildHotel, int costToBuy, int moneyFromPawn, Dictionary<int, int> costsForRent, string coordinates, Dictionary<string, string> bonusesOfTile, Player owner, int crosses, string name) : base(coordinates, bonusesOfTile, owner, crosses, name)
        {
            CostToBuildHause = costToBuildHause;
            CostToBuildHotel = costToBuildHotel;
            CostToBuy = costToBuy;
            MoneyFromPawn = moneyFromPawn;
            CostsForRent = costsForRent;
        }

        //PM buduje dom na ulicy
        /// <summary>
        /// Buduję dom na ulicy
        /// </summary>
        public void BuildHause()
        {
            string bonus = "";
            bool fake = Owner.PlayerBonuses.TryGetValue("BHA", out bonus);
            Owner.Money -= (int)Methods.ChangeValue(CostToBuildHause, bonus);
            HowMuchAreHauses++;
        }

        //PM Buduje hotel
        /// <summary>
        /// Buduję hotel na ulicy
        /// </summary>
        public void BuildHotel()
        {
            string bonus = "";
            bool fake = Owner.PlayerBonuses.TryGetValue("BHO", out bonus);
            Owner.Money -= (int)Methods.ChangeValue(CostToBuildHotel, bonus);
            HowMuchAreHauses++;
        }

    }
}
