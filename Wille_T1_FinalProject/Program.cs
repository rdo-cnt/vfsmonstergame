using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wille_T1_FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int iAttributePoints;
            string sMonsterName;
            int iPlayerMonsterHealth;
            int iPlayerMonsterAttack;
            int iPlayerMonsterDefense;
            int iPlayerMonsterSpeed;
            int iTrinity;
            string sTrinity;
            int iBattleNumber;
            int iTruthValue;
            string sPlayerInput;
        }

        //introduction for the player and setting up their Monster
        static void Start()
        {
            Console.WriteLine("Welcome to the Stadium");
            Console.WriteLine("Before you begin battle you will need a monster");
            Console.WriteLine("Here you go!");
            Console.WriteLine("What would you like to name this little guy?");
            Console.WriteLine("Now that your Monster has a name, you need to allot their stats");
            Console.WriteLine("");
            if (int.TryParse(sPlayerInput, out iTruthValue) == true)
            {
                // if you can parse the players input
            }
            Combat(oPlayerMonster, iBattleNumber);
        }
        static void Combat()
        {
            
        }
    }
}
