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

        static void showFightStats(Monster PlayerMonster, Monster EnemyMonster)
        {
            Console.WriteLine(" ____________________________                      {0}'s Stats" , EnemyMonster.GetName());
            Console.WriteLine("|         Name:{0}           |");
            Console.WriteLine("|                            |                     attack: {1}", EnemyMonster.GetAttack());
            Console.WriteLine("|        Health:{0}          |                    defence: {0}", EnemyMonster.GetDefense(), EnemyMonster.GetHealth());
            Console.WriteLine("|                            |                      Speed: {0}", EnemyMonster.GetSpeed());
            Console.WriteLine("|___________________________ |                    trinity: {0}", EnemyMonster.GetStringTrinity());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("          {0}'s stats                  ____________________________", EnemyMonster.GetName());
            Console.WriteLine("                                      |          Name:{0}          |", PlayerMonster.GetName());
            Console.WriteLine("          attack: {1}                 |                            |", PlayerMonster.GetAttack());
            Console.WriteLine("         defence: {1}                 |        Health:{2}          |", PlayerMonster.GetDefense(), PlayerMonster.GetHealth());
            Console.WriteLine("           Speed: {1}                 |                            |", PlayerMonster.GetSpeed());
            Console.WriteLine("         trinity: {0}                 | ___________________________|", PlayerMonster.GetStringTrinity());
        }

        static void Combat(Monster playerMonster, int iBattleNumber)
        {
            Monster enemyMonster = new Monster(iBattleNumber);
            showFightStats(playerMonster, enemyMonster, iBattleNumber);
            
            Console.ReadLine();
        }
    }
}
