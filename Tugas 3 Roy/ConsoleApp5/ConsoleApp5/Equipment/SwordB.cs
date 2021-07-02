using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Equipment
{
    public class SwordB : IWeapon
    {
        public SwordB()
        {
            Damage = 3;
        }
        public int Damage { get; set; }
        public void Attack()
        {

        }
    }
}
