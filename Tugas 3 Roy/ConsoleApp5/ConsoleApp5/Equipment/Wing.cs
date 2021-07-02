using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Equipment
{
    public class Wing : IAccessories
    {
        public void ActivateAccesories(Character character)
        {
            character.HP = character.HP + 1;
            character.FinalDamage = character.FinalDamage + 2;
        }
    }
}
