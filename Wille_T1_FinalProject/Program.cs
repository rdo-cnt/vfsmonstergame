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
            int iPlayerMonsterAttack = 3;
            int iPlayerMonsterDefense = 3;
            int iPlayerMonsterSpeed = 3;
            int iTrinity = 0;
            int iBattleNumber;
            int iTruthValue;
            string sPlayerInput;
            int iPlayerInput;
            int iWins = 0;
            bool bPlayerLose = false;
            bool bValidNumber = false;

            while (bGameState = true)
            {
                //welcome the player to the stadium, give them a monster, and have them name the monster.
                Console.WriteLine("Welcome to the Stadium");
                Console.WriteLine("Before you begin battle you will need a monster");
                Console.WriteLine("We have three monsters for you to choose from.");
                Console.WriteLine("The First one is a Fire Monster, the Second is a Water Monster, and the Third is a Grass Monster");
                ///////////
                ////Give a choice of three monsters (Trinity)
                ///////////
                while (bValidNumber == false)
                {
                    Console.WriteLine("Please choose one of the three monsters");
                    Console.WriteLine("-------------");
                    Console.WriteLine("1.) Fire");
                    Console.WriteLine("2.) Water");
                    Console.WriteLine("3.) Grass");
                    Console.WriteLine("-------------");
                    Console.Write("Input the number of the corresponding monster type you would like: ");
                    sPlayerInput = Console.ReadLine();
                    //check to see if the players input can be parsed
                    if (int.TryParse(sPlayerInput, out iTruthValue) == true)
                    {
                        //parse sPlayerInput and set iPlayerInput equal to the value that the player has input (sPlayerInput) 
                        iPlayerInput = int.Parse(sPlayerInput);
                        //check to see if the number of attribute points being allotted is less than or equal to the number of attribute points that are available
                        if (iPlayerInput == 1 || iPlayerInput == 2 || iPlayerInput == 3)
                        {
                            //Monster attack is the first stat being assigned through player input, if the code has checked through thus far, assign the value of the input to the Players Monsters Attack
                            iTrinity = iPlayerInput;
                            //subtract the number of alloted attribute points by the number used by the player
                            bValidNumber = true;
                        }

                        //else statement to notify the player that the input was no within the alloted range of attribute points
                        else
                        {
                            Console.WriteLine("That is not a valid number, please input a number corresponsing to one of the three monster types");
                        }

                    }

                    //prompt the user to input a valid number if they didn't even input a number
                    else
                    {
                        Console.WriteLine("Please input a number");
                    }
                }
                //set valid number to false for the next loop
                bValidNumber = false;
                
                Console.WriteLine("Awesome Choice. Here you go, they're all yours now!");
                Console.WriteLine("What would you like to name this little guy?");
                sMonsterName = Console.ReadLine();
                Console.WriteLine(sMonsterName + " is a great name!");
                Console.WriteLine("Now that your Monster has a name, you need to allot their stats.");

                ///////////
                ///Alot Attack Points
                ///////////
                //check to see if the input of the player can actually be parsed, if so, run the code in the if statement
                while (bValidNumber == false)
                {
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine("Here are your current stats:");
                    Console.WriteLine("Attack: " + iPlayerMonsterAttack);
                    Console.WriteLine("Defense: " + iPlayerMonsterDefense);
                    Console.WriteLine("Speed: " + iPlayerMonsterSpeed);
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine("You have " + iAttributePoints + " Attribute points to distribute into these three stats.");
                    Console.Write("Please input the number of attribute points you would like to alot to Attack: ");
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
                            iPlayerMonsterAttack = iPlayerInput + iPlayerMonsterAttack;
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

                //prompt the user to distribute stats into the defense attribute
                Console.WriteLine("Alright! The Attack attribute of " + sMonsterName + " is " + iPlayerMonsterAttack);

                //////////
                //Allot Defense Points
                //////////
                //inform the user of the remaining attribute points and the next attribute that will be alloted
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine(sMonsterName + "'s current stats are:");
                Console.WriteLine("Attack: " + iPlayerMonsterAttack);
                Console.WriteLine("Defense: " + iPlayerMonsterDefense);
                Console.WriteLine("Speed: " + iPlayerMonsterSpeed);
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("You have " + iAttributePoints + " Attribute points left to spend on the Defense and Speed attributes");
                Console.WriteLine("Next let's put points into the defense attribute");

                //check to see if the input of the player can actually be parsed, if so, run the code in the if statement
                while (bValidNumber == false)
                {
                    Console.Write("Please input the number of attribute points you would like to allot to Defense: ");
                    sPlayerInput = Console.ReadLine();
                    //check to see if the players input can be parsed
                    if (int.TryParse(sPlayerInput, out iTruthValue) == true)
                    {
                        //parse sPlayerInput and set iPlayerInput equal to the value that the player has input (sPlayerInput) 
                        iPlayerInput = int.Parse(sPlayerInput);
                        //check to see if the number of attribute points being allotted is less than or equal to the number of attribute points that are available
                        if (iPlayerInput <= iAttributePoints)
                        {
                            //Monster attack is the first stat being assigned through player input, if the code has checked through thus far, assign the value of the input to the Players Monsters Defense
                            iPlayerMonsterDefense = iPlayerInput + iPlayerMonsterDefense;
                            //subtract the number of alloted attribute points by the number used by the player
                            iAttributePoints -= iPlayerInput;
                            bValidNumber = true;
                        }

                        //else statement to notify the player that the input was no within the alloted range of attribute points
                        else
                        {
                            Console.WriteLine("That is not a valid number, please input a number within the range of alotted attribute points (" + iAttributePoints + ")");
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

                //Display current stats and inform the player of the situation
                Console.WriteLine("--------------------------------------------------------:");
                Console.WriteLine("Perfect! " + sMonsterName + "'s current stats are:");
                Console.WriteLine("Attack: " + iPlayerMonsterAttack);
                Console.WriteLine("Defense: " + iPlayerMonsterDefense);
                Console.WriteLine("Speed: " + iPlayerMonsterSpeed);
                Console.WriteLine("--------------------------------------------------------:");
                Console.WriteLine("Now the only attribute left to put points into is Speed.");
                Console.WriteLine("You have " + iAttributePoints + " Attribute points left to spend on Speed");

                //check to see if the input of the player can actually be parsed, if so, run the code in the if statement
                while (bValidNumber == false)
                {
                    Console.Write("Please input the number of points you would like to put into Speed: ");
                    sPlayerInput = Console.ReadLine();
                    //check to see if the players input can be parsed
                    if (int.TryParse(sPlayerInput, out iTruthValue) == true)
                    {
                        //parse sPlayerInput and set iPlayerInput equal to the value that the player has input (sPlayerInput) 
                        iPlayerInput = int.Parse(sPlayerInput);
                        //check to see if the number of attribute points being allotted is less than or equal to the number of attribute points that are available
                        if (iPlayerInput <= iAttributePoints)
                        {
                            //Monster defense is the first stat being assigned through player input, if the code has checked through thus far, assign the value of the input to the Players Monsters Speed
                            iPlayerMonsterSpeed = iPlayerInput + iPlayerMonsterSpeed;
                            //subtract the number of alloted attribute points by the number used by the player
                            iAttributePoints -= iPlayerInput;
                            bValidNumber = true;
                        }

                        //else statement to notify the player that the input was no within the alloted range of attribute points
                        else
                        {
                            Console.WriteLine("That is not a valid number, please input a number within the range of alotted attribute points (" + iAttributePoints + ")");
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

                //Display current stats and inform the player of the situation
                Console.WriteLine("--------------------------------------------------------:");
                Console.WriteLine("Perfect! These are " + sMonsterName + "'s finalized stats:");
                Console.WriteLine("Attack: " + iPlayerMonsterAttack);
                Console.WriteLine("Defense: " + iPlayerMonsterDefense);
                Console.WriteLine("Speed: " + iPlayerMonsterSpeed);
                Console.WriteLine("--------------------------------------------------------:");

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
