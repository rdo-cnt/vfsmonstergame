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
            int iWins = 0;
            bool bPlayerLose = false;

            Console.WriteLine("Welcome to the Stadium");
            Console.WriteLine("Before you begin battle you will need a monster");
            Console.WriteLine("Here you go!");
            Console.WriteLine("What would you like to name this little guy?");
            Console.WriteLine("Now that your Monster has a name, you need to allot their stats");
            Console.WriteLine("");

            //prompt the user for input for each of the monster stats (text, informing the user that they should distribute the stat points)

            //check to see if the player input is valid
            if (int.TryParse(sPlayerInput, out iTruthValue) == true)
            {
                // if you can parse the players input
            }

            //store players input if valid or prompt for valid input

            //repeat for each stat (attack, defense, speed)

            //have player choose the trinity of their monster

            //create player monster
            Monster oPlayerMonster = new Monster(sMonsterName, iPlayerMonsterAttack, iPlayerMonsterDefense, iPlayerMonsterSpeed, iTrinity);

            //determine first fight based on player monster choice (trinity). fire = 0, water = 1, grass = 2
            iBattleNumber = oPlayerMonster.GetIntegerTrinity() - 1;

            //If iTrinity is selected as number 0, the value of iBattleNumber is altered to 2 so that the player fights the weakest matchup first
            if (iBattleNumber == -1)
            {
                iBattleNumber = 2;
            }



            //start combat, and continue until the player wins or loses
            while (iWins < 3 && bPlayerLose == false)
            {
                //call the function combat, and pass oplayermonster from the class and ibattlenumber to the function
                Combat(oPlayerMonster, iBattleNumber);

                if (oPlayerMonster.GetHealth() == 0)
                {
                    bPlayerLose = true;
                }
                iBattleNumber++;
                if (iBattleNumber > 3)
                {
                    iBattleNumber = 0;
                }
            }
            //display the number of victories that the players monster acheived

            //ask the player if they want to play again


        }

        static void ShowFightStats(Monster oPlayerMonster, Monster oEnemyMonster)
        {
            Console.WriteLine(" ____________________________                      {0}'s Stats", oEnemyMonster.GetName());
            Console.WriteLine("|         Name:{0}           |");
            Console.WriteLine("|                            |                     attack: {1}", oEnemyMonster.GetAttack());
            Console.WriteLine("|        Health:{0}          |                    defence: {0}", oEnemyMonster.GetDefense(), oEnemyMonster.GetHealth());
            Console.WriteLine("|                            |                      Speed: {0}", oEnemyMonster.GetSpeed());
            Console.WriteLine("|___________________________ |                    trinity: {0}", oEnemyMonster.GetStringTrinity());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("          {0}'s stats                  ____________________________", oEnemyMonster.GetName());
            Console.WriteLine("                                      |          Name:{0}          |", oPlayerMonster.GetName());
            Console.WriteLine("          attack: {1}                 |                            |", oPlayerMonster.GetAttack());
            Console.WriteLine("         defence: {1}                 |        Health:{2}          |", oPlayerMonster.GetDefense(), oPlayerMonster.GetHealth());
            Console.WriteLine("           Speed: {1}                 |                            |", oPlayerMonster.GetSpeed());
            Console.WriteLine("         trinity: {0}                 | ___________________________|", oPlayerMonster.GetStringTrinity());
        }

        static void Combat(Monster playerMonster, int iBattleNumber)
        {
            Monster enemyMonster = new Monster(iBattleNumber);
            ShowFightStats(playerMonster, enemyMonster);

            Console.ReadLine();
        }
    }
}
