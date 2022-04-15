using lab2._1.weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab2._1.soldiers
{
    public abstract class Soldier
    {
        protected string name, rank, regiment, speciality;
        protected Weapon weapon;

        public Soldier(string name, string regiment, string speciality, Weapon weapon)
        {
            this.name = name; 
            this.regiment = regiment; 
            this.speciality = speciality; 
            this.weapon = weapon; 
        }

        public void greatColleague(Soldier soldier) { Console.WriteLine("I wish you well, comrade " + soldier.getRank()); }

        public abstract void shoot();

        // ToString(), Equals(), HashCode()

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Soldier s = obj as Soldier;

            if (s == null) return false;

            return getName() == s.getName() && getRank() == s.getRank() && getRegimant() == s.getRegimant() 
                && getSpeciality() == s.getSpeciality() && getWeapon().Equals(s.getWeapon());
        }

        public override int GetHashCode()
        {
            return 31 * getWeapon().getId();
        }

        public override string ToString()
        {
            return getRank() + ": { " + getName() + ", " + getRegimant() + ", " + getSpeciality() + ", " + getWeapon() + " }";
        }

        // getters and setters
        public string getName() { return this.name; }
        public string getRank() { return this.rank; }
        public string getRegimant() { return this.regiment; }
        public string getSpeciality() { return this.speciality; }
        public Weapon getWeapon() { return this.weapon; }

       public void setRank(string rank)
        {
            if (rank.Length == 0 || rank == null)
            {
                Console.WriteLine("length of the rank cannot be zero.");
                return;
            }
            else
            { 
                this.rank = rank;
            }
        }

        public void setRegiment(string regiment)
        {

            if (regiment.Length == 0 || regiment == null)
            {
                Console.WriteLine("length of the regiment cannot be zero.");
                return;
            }
            else
            { 
                this.regiment = regiment;
            }
        }
        
        public void setSpeciality(string speciality)
        {
            if (speciality.Length == 0 || speciality == null)
            {
                Console.WriteLine("length of the speciality cannot be zero.");
                return;
            }
            else
            {
                this.speciality = speciality;
            }
        }

        public void setWeapon(Weapon weapon)
        {
            if (weapon == null)
            {
                Console.WriteLine("Weapon cannot be null");
                return;
            }
            else
            { 
                this.weapon = weapon;
            }
        }

    }
}
