using lab2._1.soldiers;
using lab2._1.weapons;
using System;
using System.Collections.Generic;

namespace lab2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Soldier> squad1 = new List<Soldier>();
            squad1.Add(new Ranker("Степан Степанов", "полк #1", "Разведчик", new Pistol()));
            squad1.Add(new Major("Иван Иванов", "полк #2", "Танкист", new MachineGun()));
            squad1.Add(new Lieutenant("Андрей Андреев", "полк #1", "Зенитчик", new Pistol()));
            squad1.Add(new General("Виктор Баранов", "полк #3", "Десантник", new MachineGun()));
            squad1.Add(new Ensign("Виталий Козлов", "полк #6", "Артиллерист", new Pistol()));
            squad1.Add(new Ensign("Сергей Матвиенко", "полк #6", "Танкист", new Pistol()));
            squad1.Add(new Ensign("Владимир Федорченко", "полк #6", "Танкист", new Pistol()));

            List<Soldier> squad2 = new List<Soldier>();
            squad2.Add(new Sergeant("Степан Бандера", "полк #1", "Артиллерист", new Pistol()));
            squad2.Add(new Major("Владимир Кличко", "полк #2", "Десантник", new MachineGun()));
            squad2.Add(new Lieutenant("Виталий Кличко", "полк #1", "Разведчик", new MachineGun()));
            squad2.Add(new General("Роман Нагорный", "полк #3", "Разведчик", new MachineGun()));
            squad2.Add(new Ensign("Александр Македонский", "полк #6", "Десантник", new Pistol()));
            squad2.Add(new Ensign("Иван Будько", "полк #6", "Зенитчик", new Pistol()));
            squad2.Add(new Ensign("Михаил Литвиносов", "полк #6", "Зенитчик", new Pistol()));

            // getting soldiers from first squad with the gun -> Pistol
            printSoldiersWithTheSameGun(squad1, new Pistol());

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            // getting soldiers from second squad with the gun -> MachineGun
            printSoldiersWithTheSameGun(squad2, new MachineGun());

            squad1 = getSortedSquadBySpeciality(squad1);

            foreach (Soldier soldier in squad1)
            {
                Console.WriteLine(soldier);
            }
        }
        public static void printSoldiersWithTheSameGun(List<Soldier> squad, Weapon weapon)
        {
            Console.WriteLine("Soldiers from squad with the gun -> " + weapon.getTypeOfWeapon());
            foreach (Soldier soldier in squad)
                if (soldier.getWeapon().getTypeOfWeapon().Equals(weapon.getTypeOfWeapon())) Console.WriteLine(soldier.getName());
        }

        // Сортировка происходит по военной специальности. Например: Вначале будет Артеллирист, а потом уже Десантник
        public static List<Soldier> getSortedSquadBySpeciality(List<Soldier> squad)
        {
            List<Soldier> sortedSquad = new List<Soldier>();

            SortedSet<string> specialities = new SortedSet<string>();

            foreach (Soldier soldier in squad)
            {
                specialities.Add(soldier.getSpeciality());
            }

            foreach (string specility in specialities)
            {
                foreach (Soldier soldier in squad)
                {
                    if (soldier.getSpeciality().Equals(specility))
                    {
                        sortedSquad.Add(soldier);
                    }
                }
            }
            return sortedSquad;
        }
    }
}
