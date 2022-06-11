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


            Army army1 = new Army(squad1);
            Army army2 = new Army(squad2);

            // getting soldiers from first squad with the gun -> Pistol
            army1.printSoldiersWithTheSameGun(new Pistol());

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            // getting soldiers from second squad with the gun -> MachineGun
            army2.printSoldiersWithTheSameGun(new MachineGun());

            army1.getSortedSquadBySpeciality();

            army1.printSoldiers();
        }
    }
}
