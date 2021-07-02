using System;
using System.Collections.Generic;
using ConsoleApp5.Equipment;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name warrior ?");
            Character character = new Character(Console.ReadLine());
            character.Weapon = new SwordA();
            string[] inventory = new string[5];

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please select an action to do :");
                Console.WriteLine("1. Check Status");
                Console.WriteLine("2. Change Equipment");
                Console.WriteLine("3. Change Accessories");
                Console.WriteLine("4. Hunting");
                int action = int.Parse(Console.ReadLine());
                Console.Clear();
                if (action == 1)
                {
                    Console.WriteLine("Your character statuses :");
                    character.PrintStatus();
                    Console.WriteLine("=================== PRESS ANY KEY TO CONTINUE ==========================");
                    Console.ReadLine();
                }
                else if (action == 2)
                {
                    Console.WriteLine("Your current equipment is : " + character.Weapon.GetType().Name);
                    Console.WriteLine("Please set a new weapon :");
                    Console.WriteLine("1. SwordA - Damage 1");
                    Console.WriteLine("2. SwordB - Damage 2");

                    Console.WriteLine("=================== PRESS WHICH WEAPON NUMBER YOU WANT TO USE TO CONTINUE ==========================");
                    int weaponNum = int.Parse(Console.ReadLine());
                    if (weaponNum == 1)
                    {
                        character.Weapon = new SwordA();
                    }
                    else if (weaponNum == 2)
                    {
                        character.Weapon = new SwordB();
                    }
                }
                else if (action == 3)
                {
                    Console.WriteLine("Owned Accesories");
                    //string accname;
                    if (inventory[0] == "Bracelet")
                    {
                        Console.WriteLine("1: Bracelet ");
                    }
                    else if (inventory[0] == null)
                    {
                        Console.WriteLine("1: - ");
                    }
                    if (inventory[1] == "Necklace")
                    {
                        Console.WriteLine("2: Necklace ");
                    }
                    else if (inventory[1] == null)
                    {
                        Console.WriteLine("2: - ");
                    }
                    if (inventory[2] == "Ring")
                    {
                        Console.WriteLine("3: Ring ");
                    }
                    else if (inventory[2] == null)
                    {
                        Console.WriteLine("3: - ");
                    }
                    if (inventory[3] == "Wing")
                    {
                        Console.WriteLine("4: Wing ");
                    }
                    else if (inventory[3] == null)
                    {
                        Console.WriteLine("4: - ");
                    }
                    if (inventory[4] == null)
                    {
                        Console.WriteLine("5: Remove acc ");
                    }
                    Console.WriteLine("=================== PRESS WHICH ACC NUMBER YOU WANT TO USE TO CONTINUE ==========================");
                    int accessoriesNum = int.Parse(Console.ReadLine());
                    if (accessoriesNum == 1 & inventory[0] != null)
                    {
                        character.Accesories = new Bracelet();
                    }
                    if (accessoriesNum == 2 & inventory[1] != null)
                    {
                        character.Accesories = new Necklace();
                    }
                    if (accessoriesNum == 3 & inventory[2] != null)
                    {
                        character.Accesories = new Ring();
                    }
                    if (accessoriesNum == 4 & inventory[3] != null)
                    {
                        character.Accesories = new Wing();
                    }
                    if (accessoriesNum == 5 )
                    {
                        character.Accesories = null;
                    }
                }
                else if (action == 4)
                {
                    character.HP = character.MaxHP;
                    character.FinalDamage = character.Damage;
                    Character monster = new Character("monster");
                    monster.Weapon = new SwordA();
                    Random random = new Random();
                    int randomNumber = random.Next(1, 4);
                    int randomExpDifference = random.Next(1, 3);

                    if (randomNumber == 1)
                    {
                        monster.EXP = (character.EXP - randomExpDifference);
                    }
                    else if (randomNumber == 2)
                    {
                        monster.EXP = (character.EXP);
                    }
                    else
                    {
                        monster.EXP = character.EXP + randomExpDifference;
                    }
                    monster.HP = monster.MaxHP;
                    monster.FinalDamage = monster.Damage;
                    if (character.Accesories != null)
                    {
                        character.Accesories.ActivateAccesories(character);
                    }

                    Console.WriteLine("Enemy encountered :");
                    monster.PrintStatus();

                    Console.Write("Do you want to engage (1. yes, 2. no) ?");
                    int decision = int.Parse(Console.ReadLine());
                    Console.WriteLine("================== BATTLE START ==========================");
                    if (decision == 1)
                    {
                        bool bothStillAlive = true;
                        bool isHeroTurn = true;
                        while (bothStillAlive)
                        {
                            System.Threading.Thread.Sleep(100);
                            if (isHeroTurn)
                            {
                                Console.WriteLine(character.Name + " deal " + character.FinalDamage + " amount of damage to enemy");
                                character.Attack(monster);
                                Console.WriteLine(character.Name + " : " + character.HP + ", enemy : " + monster.HP);
                                if (monster.HP <= 0)
                                {
                                    Console.WriteLine(character.Name + " has defeated the enemy");
                                    character.EXP += 1;
                                    int randomdrop = random.Next(1, 8);
                                    if (randomdrop == 1)
                                    {
                                        inventory[0] = "Bracelet";
                                        Console.WriteLine("You have obtained 'Bracelet'");
                                    }
                                    if (randomdrop == 2)
                                    {
                                        inventory[1] = "Necklace";
                                        Console.WriteLine("You have obtained 'Necklace'");
                                    }
                                    if (randomdrop == 3)
                                    {
                                        inventory[2] = "Ring";
                                        Console.WriteLine("You have obtained 'Ring'");
                                    }
                                    if (randomdrop == 4)
                                    {
                                        inventory[3] = "Wing";
                                        Console.WriteLine("You have obtained 'Wing'");
                                    }
                                    if (randomdrop > 4)
                                    {
                                        Console.WriteLine("This Monster didn't drop anything");
                                    }
                                    bothStillAlive = false;
                                }
                            }
                            else
                            {
                                Console.WriteLine("enemy deal " + monster.FinalDamage + " amount of damage to " + character.Name);
                                monster.Attack(character);
                                Console.WriteLine(character.Name + " : " + character.HP + ", enemy : " + monster.HP);
                                if (character.HP <= 0)
                                {
                                    
                                    Console.WriteLine("Enemy has defeated " + character.Name);
                                    character.EXP -= 1;
                                    if (character.EXP <= 0)
                                    {
                                        character.EXP = 1;
                                    }
                                    bothStillAlive = false;
                                }
                            }
                            isHeroTurn = !isHeroTurn;
                        }

                        Console.WriteLine("=================== PRESS ANY KEY TO CONTINUE ==========================");
                        Console.ReadLine();
                    }
                }
            }
            

        }
    }


}
