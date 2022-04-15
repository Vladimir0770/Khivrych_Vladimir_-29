using lab2._1.weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab2._1.soldiers
{
    // прапорщик
    public class Ensign : Soldier
    {
        public Ensign(string name, string regiment, string speciality, Weapon weapon) : base(name, regiment, speciality, weapon)
        { this.rank = "Ensign"; }

        public override void shoot()
        {
            throw new NotImplementedException();
        }
    }
}
