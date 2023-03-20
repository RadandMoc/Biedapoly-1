using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biedapoly
{
    [Serializable]
    public class Heroes
    {
        string heroname;
        Dictionary<string, string> heroesBonuses = new Dictionary<string, string>();
        int hero_pocket; 
        //proponuje, zeby to byla roznica poczatkowych pieniedzy jakie daje heros. np moze byc heros gorszy od normalnego ale z wieksza gotowka i na odwrot

        public string Heroname { get => heroname; set => heroname = value; }
        public int Hero_pocket { get => hero_pocket; set => hero_pocket = value; }
        public Dictionary<string, string> HeroesBonuses { get => heroesBonuses; set => heroesBonuses = value; }

        public Heroes() { }

        public Heroes(string name_of_hero, int hero_Pocket, Dictionary<string,string> BonusesOfHero)
        {
            Heroname= name_of_hero;
            Hero_pocket= hero_Pocket;
            HeroesBonuses= BonusesOfHero;
        }


        public virtual List<int> move(List<int> lastcoordinates, int randomnumber)
        {
            lastcoordinates[0] = (lastcoordinates[0] + randomnumber) % 63;
            return lastcoordinates;
        }



        public void buy()
        {

        }




        public void pay(Heroes hero, int amount_of_money)
        {
            hero.hero_pocket += amount_of_money;
            this.hero_pocket -= amount_of_money;
        }
    }
}
