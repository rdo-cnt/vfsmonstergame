using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wille_T1_FinalProject
{
    public class Monster
    {
        //Defining some variables that describe our monster
        private string m_sName; //The monster's name
        private int m_iHealth; //The monster's health
        private int m_iAttack; //The monster's attack
        private int m_maxHealth; //The monster's maxHP
        private int m_iDefense; //The monster's defense
        private int m_iSpeed; //The monster's speed
        private string m_sTrinity; //For the fire/water/grass affinity
        private int m_iTrinity; //For simplification of special attacks. 0 = fire, 1 = water, 2 = grass

        /*Set of constructors for the player and opponent*/
        //Constructor for the player
        public Monster(string sName, int iAttack, int iDefense, int iSpeed, int iTrinity)
        {
            //Setting the monster variables to those inputed
            m_sName = sName;
            m_iHealth = 10;
            m_iAttack = iAttack;
            m_iDefense = iDefense;
            m_iSpeed = iSpeed;
            m_iTrinity = iTrinity;
            m_maxHealth = m_iHealth;

            //Switchcase to determine the Trinity name
            switch (iTrinity)
            {
                case 0:
                    m_sTrinity = "Fire";
                    break;
                case 1:
                    m_sTrinity = "Water";
                    break;
                case 2:
                    m_sTrinity = "Grass";
                    break;
            }
        }
        //Constructor for the monster opponents dependant on the battle number
        public Monster(int iBattleNumber)
        {
            //Create a specific monster based on the battle number
            switch (iBattleNumber)
            {
                case 0: //First monster opponent. Strong attack fire type
                    m_sName = "Charmander";
                    m_iHealth = 10;
                    m_iAttack = 6;
                    m_iDefense = 4;
                    m_iSpeed = 5;
                    m_sTrinity = "Fire";
                    m_maxHealth = m_iHealth;
                    m_iTrinity = 0; //0 = fire, 1 = water, 2 = grass
                    break;
                case 1: //Second monster opponent. Higher speed water type
                    m_sName = "Squirtle";
                    m_iHealth = 10;
                    m_iAttack = 4;
                    m_iDefense = 5;
                    m_iSpeed = 6;
                    m_sTrinity = "Water";
                    m_maxHealth = m_iHealth;
                    m_iTrinity = 1; //0 = fire, 1 = water, 2 = grass
                    break;
                case 2: //Third monster opponent. Tankier grass type
                    m_sName = "Bulbasaur";
                    m_iHealth = 10;
                    m_iAttack = 5;
                    m_iDefense = 6;
                    m_iSpeed = 4;
                    m_sTrinity = "Grass";
                    m_maxHealth = m_iHealth;
                    m_iTrinity = 2; //0 = fire, 1 = water, 2 = grass
                    break;
            }
        }

        /*Set of getters for the monster's stats*/
        //Getter for the monster's name
        public string GetName()
        {
            return m_sName;
        }
        //Getter for the monster's health
        public int GetHealth()
        {
            return m_iHealth;
        }
        //Getter for the monster's max health
        public int GetMaxHealth()
        {
            return m_maxHealth;
        }
        //Getter for the monster's attack
        public int GetAttack()
        {
            return m_iAttack;
        }
        //Getter for the monster's defense
        public int GetDefense()
        {
            return m_iDefense;
        }
        //Getter for the monster's speed
        public int GetSpeed()
        {
            return m_iSpeed;
        }
        //Getter for the monster's string trinity
        public string GetStringTrinity()
        {
            return m_sTrinity;
        }
        //Getter for the monsters int trinity
        public int GetIntegerTrinity()
        {
            return m_iTrinity;
        }

        //Monster loses health
        public void LoseHealth(int damage)
        {
            m_iHealth -= damage;
        }


        /* For attacking an opponent pass the monsters attack
         * The following comment would be an example of the user attacking charmander
         * playerMonster.RegularAttackHit(enemyMonster);*/
        //Function for attacking an opponent with a regular attack
        public void RegularAttackHit(Monster Enemy)
        {

            int ModifiedAtk = m_iAttack - Enemy.m_iDefense; //An monster's attack is reduced by the enemy's defense


            if (ModifiedAtk < 2) //The minimum damage that an opponent can deal is 2
            {
                ModifiedAtk = 2;
            }
            Enemy.LoseHealth(ModifiedAtk); //Reduce the enemy monster's health by the attack

            //Provide feedback to the player on how much damage was dealt
            Console.WriteLine(Enemy.GetName() + " received " + ModifiedAtk + " damage!");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue!");
            Console.ReadLine();
        }

        //Function for getting hit by a special attack. 0 = fire, 1 = water, 2 = grass
        public void SpecialAttackHit(Monster Enemy)
        {
            int fDamageMultiplier = 1;

            if (Enemy.GetIntegerTrinity() == 0) //The monster being hit is a fire type
            {
                switch (m_iTrinity)
                {
                    case 0: //If the attack is fire the multiplier stays the same
                        break;
                    case 1: //If the attack is water the multiplier doubles
                        fDamageMultiplier = 2;
                        //Feedback to the player on the attack being super effective
                        Console.WriteLine("It's super effective!");
                        break;
                    case 2: //If the attack is grass the multiplier halves
                        fDamageMultiplier = 0;
                        //Feedback to the player on the attack being not very effective
                        Console.WriteLine("It's not very effective...");
                        break;
                }
            }
            if (Enemy.GetIntegerTrinity() == 1) //The monster being hit is a water type
            {
                switch (m_iTrinity)
                {
                    case 0: //If the attack is fire the multiplier halves
                        fDamageMultiplier = 0;
                        //Feedback to the player on the attack being not very effective
                        Console.WriteLine("It's not very effective...");
                        break;
                    case 1: //If the attack is water the multiplier stays the same
                        break;
                    case 2: //If the attack is grass the multiplier doubles
                        fDamageMultiplier = 2;
                        //Feedback to the player on the attack being super effective
                        Console.WriteLine("It's super effective!");
                        break;
                }
            }
            if (Enemy.GetIntegerTrinity() == 2) //The monster being hit is a grass type
            {
                switch (m_iTrinity)
                {
                    case 0: //If the attack is fire the multiplier doubles
                        fDamageMultiplier = 2;
                        //Feedback to the player on the attack being super effective
                        Console.WriteLine("It's super effective!");
                        break;
                    case 1: //If the attack is water the multiplier halves
                        fDamageMultiplier = 0;
                        //Feedback to the player on the attack being not very effective
                        Console.WriteLine("It's not very effective...");
                        break;
                    case 2: //If the attack is grass the multiplier stays the same
                        break;
                }
            }

            int ModifiedAtk = m_iAttack;

            //Handling damage multiplier

            ModifiedAtk *= fDamageMultiplier; //Apply multiplier
            

            ModifiedAtk -= Enemy.GetDefense(); //An monster's attack is reduced by the enemy's defense
            
            //The minimum attack will still deal 2 damage
            if (ModifiedAtk < 2) 
            {
                ModifiedAtk = 2;
            }

            Enemy.LoseHealth(ModifiedAtk); //Reduce the enemy monster's health by the attack

            //Provide feedback to the player on how much damage was dealt
            Console.WriteLine(Enemy.GetName() + " received " + ModifiedAtk + " damage!");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue!");

            Console.ReadLine();
        }
        //Function for using a health potion
        public void HealthPotion()
        { 
            //Increase the monster's health by 5
            m_iHealth += 5;

            //The monster's health cannot go beyond 10, the max
            if (m_iHealth > 10)
            {
                m_iHealth = 10;
            }
            //Feedback for the user after using a potion
            Console.WriteLine(m_sName + " is healed!");

        }

        public bool ripInPepperonis()
        {
            if(m_iHealth <= 0)
            {
                Console.WriteLine(m_sName + " has been defeated!");
                Console.WriteLine();
                Console.WriteLine("Press enter to continue!");

                Console.ReadLine();
                return true;
            }
            return false;
            
        }
    }
}
