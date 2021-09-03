using Raiding.Contracts;
using Raiding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding
{
   public class StartUp
    {
       public static void Main(string[] args)
        {
            var raidGroup = new List<IBaseHero>();

            var raidMembers = int.Parse(Console.ReadLine());

            for (int i = 0; i < raidMembers; i++)
            {
                var heroName = Console.ReadLine();
                var heroType = Console.ReadLine();

                

                switch (heroType)
                {
                    case "Paladin":raidGroup.Add(CreatePaladin(heroName));break;
                    case "Warrior":raidGroup.Add(CreateWarrior(heroName));break;
                    case "Rougue":raidGroup.Add(CreateRougue(heroName));break;
                    case "Druid":raidGroup.Add(CreateDruid(heroName));break;
                    default: Console.WriteLine("Invalid Hero");break;
                }

                
            }

            var bossPower = int.Parse(Console.ReadLine());

            var totalRaidPower = 0;



            foreach (var hero in raidGroup)
            {
                Console.WriteLine(hero.CastAbility());
                totalRaidPower += hero.Power;
            }

            Console.WriteLine(totalRaidPower > bossPower? "Victory!" : "Defeat...");
        }

        public static IBaseHero CreatePaladin(string heroName) => new Paladin(heroName);

        public static IBaseHero CreateRougue(string heroName) => new Rougue(heroName);

        public static IBaseHero CreateWarrior(string heroName) => new Warrior(heroName);

        public static IBaseHero CreateDruid(string heroName) => new Druid(heroName);

        
    }
}
