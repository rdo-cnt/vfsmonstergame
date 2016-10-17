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
            int iTrinity = 0; //Trinity for the monster. 0 = fire, 1 = water, 2 = grass
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
                Thread.Sleep(1500);
                Console.WriteLine("Before you begin battle you will need a monster");
                
                Console.WriteLine("We have three monsters for you to choose from.");
                Console.WriteLine();
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                                
                ///////////
                ////Give a choice of three monsters (Trinity)
                ///////////
                while (bValidNumber == false)
                {
                    Console.Clear();
                    Console.WriteLine("Please choose one of the three monsters");
                    
                    Console.WriteLine("-------------");
                    Console.WriteLine("1.) Fire");
                    Console.WriteLine("2.) Water");
                    Console.WriteLine("3.) Grass");
                    Console.WriteLine("-------------");
                    
                    Console.WriteLine();
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
                            iTrinity = iPlayerInput - 1;
                            //subtract the number of alloted attribute points by the number used by the player
                            bValidNumber = true;
                        }

                        //else statement to notify the player that the input was no within the alloted range of attribute points
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid number, please input a number corresponsing to one of the three monster types");
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            Console.BackgroundColor = ConsoleColor.Black;
                        }


                    }

                    //prompt the user to input a valid number if they didn't even input a number
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("That's not a number. Press enter to continue");
                        Console.ReadLine();
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                }
                //set valid number to false for the next loop
                bValidNumber = false;

                //Prompt the user to name their monster
                Console.WriteLine("Awesome Choice. Here you go, all yours now!");
                
                Console.WriteLine("What would you like to name this little guy?");
                sMonsterName = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine(sMonsterName + " is a great name!");

                //Prompt the user to allocate their stats
                Console.WriteLine("Now that your Monster has a name, you need to allot its stats.");
                Console.WriteLine();
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();

                ///////////
                ///Alot Attack Points
                ///////////
                //check to see if the input of the player can actually be parsed, if so, run the code in the if statement
                while (bValidNumber == false)
                {
                    Console.Clear();
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine("Here are your base stats:");
                    Console.WriteLine();
                    Console.WriteLine("Attack: " + iPlayerMonsterAttack);
                    Console.WriteLine("Defense: " + iPlayerMonsterDefense);
                    Console.WriteLine("Speed: " + iPlayerMonsterSpeed);
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("You have " + iAttributePoints + " extra attribute points to distribute into these three stats.");
                    Console.WriteLine();
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
                           
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid number, please input a number within the range of alotted attribute points (" + iAttributePoints + ")");
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            Console.BackgroundColor = ConsoleColor.Black;
                        }

                    }

                    //prompt the user to input a valid number if they didn't even input a number
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("That's not a number. Press enter to continue");
                        Console.ReadLine();
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                }
                               

                //prompt the user to distribute stats into the defense attribute
                Console.WriteLine();
                Console.WriteLine("Alright! The Attack attribute of " + sMonsterName + " is " + iPlayerMonsterAttack);
                Thread.Sleep(1000);

                Console.WriteLine();
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                Console.Clear();

                //once the while loop has been used, set bValidNumber to false so that the variable can be used again, ONLY if you have points left
                if (iAttributePoints > 0)
                {
                    bValidNumber = false;

                    //////////
                    //Allot Defense Points
                    //////////
                    //inform the user of the remaining attribute points and the next attribute that will be alloted
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine(sMonsterName + "'s current stats are:");
                    Console.WriteLine();
                    Console.WriteLine("Attack: " + iPlayerMonsterAttack);
                    Console.WriteLine("Defense: " + iPlayerMonsterDefense);

                    Console.WriteLine("Speed: " + iPlayerMonsterSpeed);
                    Console.WriteLine();
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine("You have " + iAttributePoints + " Attribute points left to spend on the Defense and Speed attributes");

                    Console.WriteLine("Next let's put points into the defense attribute");
                }


                
                

                //check to see if the input of the player can actually be parsed, if so, run the code in the if statement
                while (bValidNumber == false)
                {

                    Console.WriteLine();
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
                            
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid number, please input a number within the range of alotted attribute points (" + iAttributePoints + ")");
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            Console.BackgroundColor = ConsoleColor.Black;
                        }

                    }

                    //prompt the user to input a valid number if they didn't even input a number
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("That's not a number. Press enter to continue");
                        Console.ReadLine();
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                }

                //once the while loop has been used, set bValidNumber to false so that the variable can be used again
                bValidNumber = false;

                //Anounce defense stat
                Console.WriteLine();
                Console.WriteLine("Alright! The Defense attribute of " + sMonsterName + " is " + iPlayerMonsterDefense);
                

                Console.WriteLine();
                Console.WriteLine("The speed stat will use the remaining stat points, if any");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                Console.Clear();

                iPlayerMonsterSpeed += iAttributePoints;

               
                //once the while loop has been used, set bValidNumber to false so that the variable can be used again
                bValidNumber = false;

                Console.WriteLine();
                Console.Clear();
                //Display current stats and inform the player of the situation
                Console.WriteLine("--------------------------------------------------------:");
                Console.WriteLine();
                Console.WriteLine("Perfect! These are " + sMonsterName + "'s finalized stats:");
                
                Console.WriteLine("Attack: " + iPlayerMonsterAttack);
                
                Console.WriteLine("Defense: " + iPlayerMonsterDefense);
                
                Console.WriteLine("Speed: " + iPlayerMonsterSpeed);
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------------:");

                Console.WriteLine();
                Console.WriteLine("Press enter to begin fighting!");
                Console.ReadLine();
                Console.Clear();

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
                    //call the function combat, and pass oplayermonster from the class and ibattlenumber to the function. If you lose it will return a true, otherwise it will return a false
                    if (Combat(oPlayerMonster, iBattleNumber))
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
            Console.WriteLine("         ");
            Console.WriteLine("                                                Attack: {0}", oEnemyMonster.GetAttack());
            Console.WriteLine("      Health:{0}/{1}                            Defense: {2}", oEnemyMonster.GetHealth(), oEnemyMonster.GetMaxHealth(), oEnemyMonster.GetDefense());
            Console.WriteLine("                                                  Speed: {0}", oEnemyMonster.GetSpeed());
            Console.WriteLine("___________________________                     Trinity: {0}", oEnemyMonster.GetStringTrinity());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("          {0}'s stats                  ____________________________", oPlayerMonster.GetName());
            Console.WriteLine("                                                Name:{0}          ", oPlayerMonster.GetName());
            Console.WriteLine("          Attack: {0}                                             ", oPlayerMonster.GetAttack());
            Console.WriteLine("         Defense: {0}                        Health:{1}/{2}         ", oPlayerMonster.GetDefense(), oPlayerMonster.GetHealth(), oPlayerMonster.GetMaxHealth());
            Console.WriteLine("           Speed: {0}                                             ", oPlayerMonster.GetSpeed());
            Console.WriteLine("         Trinity: {0}                  ___________________________", oPlayerMonster.GetStringTrinity());
        }

        static bool Combat(Monster playerMonster, int iBattleNumber)
        {

            Random choiceDie = new Random();

            //create valid number boolean
            bool bValidNumber = false;

            //String and integer for int parse
            string sPlayerInput = "";
            int iPlayerInput = 0;

            //Store ability chosen by enemy when game starts
            int iChosenEnemyAction = 0;

            //Potion amount
            int iPotions = 2;
            int iEnemyPotion = 1;

            //iTruth value for parse
            int iTruthValue;

            //Create enemy monster for this battle
            Monster enemyMonster = new Monster(iBattleNumber);

            //Tell players the battle will start
            Console.WriteLine("Battle START!");
            Thread.Sleep(500);
            Console.Clear();
            Thread.Sleep(500);
            Console.WriteLine("Battle START!");
            Thread.Sleep(500);
            Console.Clear();
            Thread.Sleep(500);
            Console.WriteLine("Battle START!");
            Thread.Sleep(500);
            Console.Clear();    
            Thread.Sleep(500);

            
            

            //Combat cycle starts
            while (playerMonster.GetHealth() > 0 || enemyMonster.GetHealth() > 0)
            {
                
                
                //Start giving the player choices
                Console.WriteLine("Choose your action!");

                //Check if option is viable
                while (bValidNumber == false)
                {
                    Console.Clear();
                    ShowFightStats(playerMonster, enemyMonster);
                    Console.WriteLine();
                    Console.WriteLine("Please choose one of the options");

                    Console.WriteLine("-------------");
                    Console.WriteLine("1.) Regular Attack");
                    Console.WriteLine("2.) Special Attack");
                    Console.WriteLine("3.) Potion ({0} available)",iPotions);
                    Console.WriteLine("-------------");

                    Console.WriteLine();
                    Console.Write("Input the number of the corresponding monster type you would like: ");
                    sPlayerInput = Console.ReadLine();
                    //check to see if the players input can be parsed
                    if (int.TryParse(sPlayerInput, out iTruthValue) == true)
                    {
                        //parse sPlayerInput and set iPlayerInput equal to the value that the player has input (sPlayerInput) 
                        iPlayerInput = int.Parse(sPlayerInput);
                        //check to see if the number of attribute points being allotted is less than or equal to the number of attribute points that are available
                        if (iPlayerInput >=1  && iPlayerInput <=3)
                        {

                            if(iPlayerInput == 3 && iPotions <= 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("You don't have any more potions. Press enter to choose again.");
                                Console.ReadLine();
                                Console.BackgroundColor = ConsoleColor.Black;
                            }
                            else
                            {
                                //If the player uses a potion, remove it from their inventory
                                iPotions -= 1;
                                bValidNumber = true;
                            }
                            
                        }

                        //else statement to notify the player that the input was no within the alloted range of attribute points
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid number, please input a number corresponsing to one of the three monster types");
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            Console.BackgroundColor = ConsoleColor.Black;
                        }


                    }

                    //prompt the user to input a valid number if they didn't even input a number
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("That's not a number. Press enter to continue");
                        Console.ReadLine();
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                }
                bValidNumber = false;

                //Time for the enemey to choose

                //enemy could use a potion if he's weak
                if (((100*enemyMonster.GetHealth())/enemyMonster.GetMaxHealth()) < 20 && iEnemyPotion > 0)
                {
                    //chose action between 1 and 3
                    iChosenEnemyAction = choiceDie.Next(1, 4);
                    //if the enemy uses a potion remove it for them.
                    if (iChosenEnemyAction == 3)
                    {
                        iEnemyPotion -= 1;
                    }
                }
                else
                {
                    //chose action between 1 and 2
                    iChosenEnemyAction = choiceDie.Next(1, 3);
                }

                //Choice is over, time to FIGHT!

                //But before...
                //Heal player if they use a potion 
                if (iPlayerInput == 3)
                {
                    playerMonster.HealthPotion();
                }
                if (iChosenEnemyAction == 3)
                {
                    enemyMonster.HealthPotion();
                }
                //Ok now it stars
                if(playerMonster.GetSpeed() > enemyMonster.GetSpeed())
                {
                    CombatAction(iPlayerInput, playerMonster, enemyMonster);
                    if (enemyMonster.ripInPepperonis())
                        return false;
                    CombatAction(iChosenEnemyAction, enemyMonster, playerMonster);
                    if (playerMonster.ripInPepperonis())
                        return true;
                }
                else
                {
                    CombatAction(iChosenEnemyAction, enemyMonster, playerMonster);
                    if (playerMonster.ripInPepperonis())
                        return true;
                    CombatAction(iPlayerInput, playerMonster, enemyMonster);
                    if (enemyMonster.ripInPepperonis())
                        return false;
                    
                }




            }
            


            Console.ReadLine();

            return false;
        }

        static void CombatAction(int actionId, Monster MonsterUser, Monster MonsterReceiver)
        {
            switch(actionId)
            {
                case 1:
                    MonsterUser.RegularAttackHit(MonsterReceiver);
                    break;

                case 2:
                    MonsterUser.SpecialAttackHit(MonsterReceiver);
                    break;
            }
        }

    }
}
