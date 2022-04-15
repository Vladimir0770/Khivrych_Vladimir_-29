using System;
using System.Collections.Generic;
using System.Text;

namespace lab2._1.weapons
{
    public abstract class Weapon
    {
        private static int generalIdNumber = 1;
        protected int id;
        protected string type;

        public Weapon() { this.id = generalIdNumber++; }

        public void makeShot()
        {
            Console.WriteLine("Weapon \"" + type + "\" is shooting.");
        }
        // getters and setters

        public int getId() { return id; }

        public string getTypeOfWeapon()
        {
            return type;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            Weapon w = obj as Weapon;
            if (w == null) return false;

            return type == w.type && id == w.id;
        }

        public override int GetHashCode()
        {
            return id;
        }

        public override string ToString()
        {
            return "Weapon: { " + type + ", id number -> " + id + " }";
        }
    }
}
