using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Equipment
{
    public class SwordA : IWeapon
    {
        public SwordA()
        {
            Damage = 1;
        }
        public int Damage { get; set; }
        public void Attack()
        {
            
        }
    }
}
