using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Equipment
{
    public class Necklace : IAccessories
    {
        public void ActivateAccesories(Character character)
        {
            character.HP = character.HP + 5;
            character.FinalDamage = character.FinalDamage + 1;
        }
    }
}
