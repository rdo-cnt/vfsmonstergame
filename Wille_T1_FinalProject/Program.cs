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
            bool bGameState = true;
            int iAttributePoints = 10;
            string sMonsterName;
            int iPlayerMonsterHealth;
            int iPlayerMonsterAttack;
            int iPlayerMonsterDefense;
            int iPlayerMonsterSpeed;
            int iTrinity;
            int iBattleNumber;
            int iTruthValue;
            string sPlayerInput;
            int iPlayerInput;
            int iWins = 0;
            bool bPlayerLose = false;
            bool bValidNumber = false;

            while (bGameState = true)
            {
                Console.WriteLine("Welcome to the Stadium");
                Console.WriteLine("Before you begin battle you will need a monster");
                Console.WriteLine("Here you go!");
                Console.WriteLine("What would you like to name this little guy?");
                Console.WriteLine("Now that your Monster has a name, you need to allot their stats");
                Console.WriteLine("");

                //prompt the user for input for each of the monster stats (text, informing the user that they should distribute the stat points)
                Console.WriteLine(iAttributePoints + " is how many attribute points you have to alot to your Monster.");
                Console.WriteLine("You must distribute these attribute points between the Attack, Defense, and Speed Attributes of your monster.");
                Console.WriteLine("Each attribute has a starting value of 3");
                Console.WriteLine("The first stat you must alot points into is Attack.");

                //check to see if the input of the player can actually be parsed, if so, run the code in the if statement
                while (bValidNumber == false)
                {
                    Console.Write("please input the number of attribute points you would like to alot to Attack: ");
                    sPlayerInput = Console.ReadLine();
                    //check to see if the players input can be parsed
                    if (int.TryParse(sPlayerInput, out iTruthValue) == true)
                    {
                        //parse sPlayerInput and set iPlayerInput equal to the value that the player has input (sPlayerInput) 
                        iPlayerInput = int.Parse(sPlayerInput);
                        //check to see if the number of attribute points being allotted is less than or equal to the number of attribute points that are available
                        if (iPlayerInput <= iAttributePoints)
                        {
                            //Monster attack is the first stat being assigned through player input, if the code has checked through thus far, assign the value of the input to the Players Monsters Attack
                            iPlayerMonsterAttack = iPlayerInput;
                            //subtract the number of alloted attribute points by the number used by the player
                            iAttributePoints -= iPlayerInput;
                            bValidNumber = true;
                        }

                        //else statement to notify the player that the input was no within the alloted range of attribute points
                        else
                        {
                            Console.WriteLine("That is not a valid number, please input a number within the range of alotted attribute points");
                        }

                    }

                    //prompt the user to input a valid number if they didn't even input a number
                    else
                    {
                        Console.WriteLine("Please input a number");
                    }
                }
                //once the whilte loop has been used, set bValidNumber to false so that the variable can be used again
                bValidNumber = false;

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
                // if no bGameState = false;

            }
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
