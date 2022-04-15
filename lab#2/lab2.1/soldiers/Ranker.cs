using lab2._1.weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab2._1.soldiers
{
    // Рядовой солдат
    public class Ranker : Soldier
    {
        public Ranker(string name, string regiment, string speciality, Weapon weapon) : base(name, regiment, speciality, weapon)
        { this.rank = "Ranker"; }

        public override void shoot()
        {
            
        }
    }
}
