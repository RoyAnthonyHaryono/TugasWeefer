using ConsoleApp5.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Character
    {
        public Character(string name)
        {
            Name = name;
            EXP = 1;
        }
        public string Name { get; set; }
        public int HP { get; set; }
        public int MaxHP { get
            {
                return EXP * 5;
            } 
        }
        public int Damage { get
            {
                return Weapon.Damage;
            }
        }

        public int FinalDamage { get; set; }

        public int EXP { get; set; }
        public IWeapon Weapon { get; set; }

        public void Attack(Character enemy)
        {
            enemy.HP -= FinalDamage;
        }

        public IAccessories Accesories { get; set; }

        public void PrintStatus()
        {
            Console.WriteLine("HP : " + MaxHP);
            Console.WriteLine("EXP : " + EXP);
            Console.WriteLine("Damage : " + Damage);
        }

    }
}
