using lab2._1.weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab2._1.soldiers
{
    internal class Army
    {
        List<Soldier> Squad { get; set; }

        public Army(List<Soldier> squad)
        {
            Squad = squad;
        }

        public void printSoldiersWithTheSameGun(Weapon weapon)
        {
            Console.WriteLine("Soldiers from squad with the gun -> " + weapon.getTypeOfWeapon());
            foreach (Soldier soldier in Squad)
                if (soldier.getWeapon().getTypeOfWeapon().Equals(weapon.getTypeOfWeapon())) Console.WriteLine(soldier.getName());
        }

        // Сортировка происходит по военной специальности. Например: Вначале будет Артеллирист, а потом уже Десантник
        public List<Soldier> getSortedSquadBySpeciality()
        {
            List<Soldier> sortedSquad = new List<Soldier>();

            SortedSet<string> specialities = new SortedSet<string>();

            foreach (Soldier soldier in Squad)
            {
                specialities.Add(soldier.getSpeciality());
            }

            foreach (string specility in specialities)
            {
                foreach (Soldier soldier in Squad)
                {
                    if (soldier.getSpeciality().Equals(specility))
                    {
                        sortedSquad.Add(soldier);
                    }
                }
            }
            return sortedSquad;
        }

        public void printSoldiers()
        {
            foreach (Soldier soldier in Squad)
                Console.WriteLine(soldier);
        }
    }
}
