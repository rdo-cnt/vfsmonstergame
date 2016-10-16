using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Wille_T1_FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bGameState = true; //Gamestate for the game loop
            int iAttributePoints; //Attribute points allotted for the player
            string sMonsterName; //name of the monster
            int iPlayerMonsterAttack;
            int iPlayerMonsterDefense;
            int iPlayerMonsterSpeed;
            int iTrinity; //Trinity for the monster. 0 = fire, 1 = water, 2 = grass
            int iBattleNumber; //Correlates to the battles that the player will face
            int iTruthValue; //Used for TryParse
            string sPlayerInput;
            int iPlayerInput; //Players input converted to an int
            int iWins; //Number of battles the player has won
            bool bPlayerLose; //If the player has lost
            bool bValidNumber = false; //Check for valid number of attribute points.

            while (bGameState == true)
            {
                //Initial set up if the player restarts the game so they don't have the stats from last game.
                iAttributePoints = 10;
                iPlayerMonsterAttack = 3;
                iPlayerMonsterDefense = 3;
                iPlayerMonsterSpeed = 3;
                iWins = 0;
                bPlayerLose = false;

                //welcome the player to the stadium, give them a monster, and have them name the monster.
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Welcome to the Stadium");
                Thread.Sleep(1000);
                Console.WriteLine("Before you begin battle you will need a monster");
                Thread.Sleep(1000);
                Console.WriteLine("We have three monsters for you to choose from.");
                Thread.Sleep(1000);
                Console.WriteLine("The First one is a Fire Monster, the Second is a Water Monster, and the Third is a Grass Monster");
                Thread.Sleep(1000);
                ///////////
                ////Give a choice of three monsters (Trinity)
                ///////////
                while (bValidNumber == false)
                {
                    Thread.Sleep(3000);
                    Console.Clear();
                    Console.WriteLine("Please choose one of the three monsters");
                    Thread.Sleep(1000);
                    Console.WriteLine("-------------");
                    Thread.Sleep(1000);
                    Console.WriteLine("1.) Fire");
                    Thread.Sleep(1000);
                    Console.WriteLine("2.) Water");
                    Thread.Sleep(1000);
                    Console.WriteLine("3.) Grass");
                    Thread.Sleep(1000);
                    Console.WriteLine("-------------");
                    Thread.Sleep(1000);
                    Console.Write("Input the number of the corresponding monster type you would like: ");
                    sPlayerInput = Console.ReadLine();
                    Thread.Sleep(1000);
                    //check to see if the players input can be parsed
                    if (int.TryParse(sPlayerInput, out iTruthValue) == true)
                    {
                        //parse sPlayerInput and set iPlayerInput equal to the value that the player has input (sPlayerInput) 
                        iPlayerInput = int.Parse(sPlayerInput);
                        //check to see if the number of attribute points being allotted is less than or equal to the number of attribute points that are available
                        if (iPlayerInput == 1 || iPlayerInput == 2 || iPlayerInput == 3)
                        {
                            //Monster attack is the first stat being assigned through player input, if the code has checked through thus far, assign the value of the input to the Players Monsters Attack
                            iTrinity = iPlayerInput - 1;
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
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please input a number");
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                }
                //set valid number to false for the next loop
                bValidNumber = false;

                //Prompt the user to name their monster
                Console.WriteLine("Awesome Choice. Here you go, they're all yours now!");
                Thread.Sleep(1000);
                Console.WriteLine("What would you like to name this little guy?");
                Thread.Sleep(1000);
                sMonsterName = Console.ReadLine();
                Thread.Sleep(1000);
                Console.WriteLine(sMonsterName + " is a great name!");
                Thread.Sleep(1000);
                //Prompt the user to allocate their stats
                Console.WriteLine("Now that your Monster has a name, you need to allot their stats.");
                Thread.Sleep(1000);

                ///////////
                ///Alot Attack Points
                ///////////
                //check to see if the input of the player can actually be parsed, if so, run the code in the if statement
                while (bValidNumber == false)
                {
                    Thread.Sleep(3000);
                    Console.Clear();
                    Console.WriteLine("--------------------------------------------------------");
                    Thread.Sleep(1000);
                    Console.WriteLine("Here are your current stats:");
                    Thread.Sleep(1000);
                    Console.WriteLine("Attack: " + iPlayerMonsterAttack);
                    Thread.Sleep(1000);
                    Console.WriteLine("Defense: " + iPlayerMonsterDefense);
                    Thread.Sleep(1000);
                    Console.WriteLine("Speed: " + iPlayerMonsterSpeed);
                    Thread.Sleep(1000);
                    Console.WriteLine("--------------------------------------------------------");
                    Thread.Sleep(1000);
                    Console.WriteLine("You have " + iAttributePoints + " Attribute points to distribute into these three stats.");
                    Thread.Sleep(1000);
                    Console.Write("Please input the number of attribute points you would like to alot to Attack: ");
                    Thread.Sleep(1000);
                    sPlayerInput = Console.ReadLine();
                    Thread.Sleep(1000);
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
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please input a number");
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                }
                //once the while loop has been used, set bValidNumber to false so that the variable can be used again
                bValidNumber = false;

                //prompt the user to distribute stats into the defense attribute
                Console.WriteLine("Alright! The Attack attribute of " + sMonsterName + " is " + iPlayerMonsterAttack);
                Thread.Sleep(1000);

                //////////
                //Allot Defense Points
                //////////
                //inform the user of the remaining attribute points and the next attribute that will be alloted
                Console.WriteLine("--------------------------------------------------------");
                Thread.Sleep(1000);
                Console.WriteLine(sMonsterName + "'s current stats are:");
                Thread.Sleep(1000);
                Console.WriteLine("Attack: " + iPlayerMonsterAttack);
                Thread.Sleep(1000);
                Console.WriteLine("Defense: " + iPlayerMonsterDefense);
                Thread.Sleep(1000);
                Console.WriteLine("Speed: " + iPlayerMonsterSpeed);
                Thread.Sleep(1000);
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("You have " + iAttributePoints + " Attribute points left to spend on the Defense and Speed attributes");
                Thread.Sleep(1000);
                Console.WriteLine("Next let's put points into the defense attribute");
                Thread.Sleep(1000);

                //check to see if the input of the player can actually be parsed, if so, run the code in the if statement
                while (bValidNumber == false)
                {
                    Thread.Sleep(3000);
                    Console.Clear();
                    Console.Write("Please input the number of attribute points you would like to allot to Defense: ");
                    Thread.Sleep(1000);
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
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please input a number");
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                }

                //once the while loop has been used, set bValidNumber to false so that the variable can be used again
                bValidNumber = false;

                //Display current stats and inform the player of the situation
                Console.WriteLine("--------------------------------------------------------:");
                Thread.Sleep(1000);
                Console.WriteLine("Perfect! " + sMonsterName + "'s current stats are:");
                Thread.Sleep(1000);
                Console.WriteLine("Attack: " + iPlayerMonsterAttack);
                Thread.Sleep(1000);
                Console.WriteLine("Defense: " + iPlayerMonsterDefense);
                Thread.Sleep(1000);
                Console.WriteLine("Speed: " + iPlayerMonsterSpeed);
                Thread.Sleep(1000);
                Console.WriteLine("--------------------------------------------------------:");
                Thread.Sleep(1000);
                Console.WriteLine("Now the only attribute left to put points into is Speed.");
                Thread.Sleep(1000);
                Console.WriteLine("You have " + iAttributePoints + " Attribute points left to spend on Speed");
                Thread.Sleep(1000);

                //check to see if the input of the player can actually be parsed, if so, run the code in the if statement
                while (bValidNumber == false)
                {
                    Thread.Sleep(3000);
                    Console.Clear();
                    Console.Write("Please input the number of points you would like to put into Speed: ");
                    Thread.Sleep(1000);
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
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please input a number");
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                }

                //once the while loop has been used, set bValidNumber to false so that the variable can be used again
                bValidNumber = false;

                //Display current stats and inform the player of the situation
                Console.WriteLine("--------------------------------------------------------:");
                Thread.Sleep(1000);
                Console.WriteLine("Perfect! These are " + sMonsterName + "'s finalized stats:");
                Thread.Sleep(1000);
                Console.WriteLine("Attack: " + iPlayerMonsterAttack);
                Thread.Sleep(1000);
                Console.WriteLine("Defense: " + iPlayerMonsterDefense);
                Thread.Sleep(1000);
                Console.WriteLine("Speed: " + iPlayerMonsterSpeed);
                Thread.Sleep(1000);
                Console.WriteLine("--------------------------------------------------------:");
                Thread.Sleep(1000);

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

                    //If the playerMonster loses, end the game.
                    if (oPlayerMonster.GetHealth() == 0)
                    {
                        bPlayerLose = true;
                    }
                    //If the player wins their battle
                    else
                    {
                        //Add to the battle number for the next round.
                        iBattleNumber++;
                        //Add to the player wins
                        iWins++;
                        //Logic to continue the battles until the player wins 3 battles.
                        if (iBattleNumber > 2)
                        {
                            iBattleNumber = 0;
                        }
                    }
                }

                ///////
                ///deliver messages to the player dependant on how many battles they've won.
                //////
                //communicate that the player lost on the first monster
                if (iWins == 0)
                {
                    Console.WriteLine("Sorry you couldn't defeat the first Monster, better luck next time!");
                }
                //communicate that the player lost on the second monster
                if (iWins == 1)
                {
                    Console.WriteLine("Sorry you couldn't defeat the second Monster, better luck next time!");
                }

                //communicate that the player lost on the third monster
                if (iWins == 2)
                {
                    Console.WriteLine("Sorry you couldn't defeat the third Monster, better luck next time!");
                }
                //communicate that the player won against all three monsters
                if (iWins == 3)
                {
                    Console.WriteLine("Congratulations! You've defeated all three Monsters!");
                }
                //ask the player if they want to play again
                Console.Write("Would you like to try again? Y/N ");
                sPlayerInput = Console.ReadLine();

                // if "no" close the program;
                if (sPlayerInput == "no" || sPlayerInput == "n")
                {
                    //End the game loop
                    bGameState = false;
                }
                //If the message is not no then we restart the loop.
            }
            //Goodbye message
            Console.WriteLine("We are sorry to see you go!");
            Thread.Sleep(3000);

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
