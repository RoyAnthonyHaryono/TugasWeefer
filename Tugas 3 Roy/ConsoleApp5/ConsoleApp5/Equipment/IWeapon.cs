﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Equipment
{
    public interface IWeapon
    {
        int Damage { get; set; }
        void Attack();
    }
}
