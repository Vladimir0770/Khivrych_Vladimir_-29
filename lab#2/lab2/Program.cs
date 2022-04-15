using System;
using System.Collections.Generic;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Window> windows = new List<Window>();
            Window w1 = new Window(120, 60);
            Window w2 = new Window(140, 70);
            Window w3 = new Window(280, 140);
            Window w4 = new Window(140, 70);

            windows.Add(w1);
            windows.Add(w2);
            windows.Add(w3);
            windows.Add(w4);

            Console.WriteLine("First window equal the second one -> " + w1.Equals(w2));
            Console.WriteLine("First window's hashCode -> " + w1.GetHashCode());
            Console.WriteLine("Second window's hashCode -> " + w2.GetHashCode());
            Console.WriteLine("First window:\n" + w1);
            Console.WriteLine("Second window:\n" + w2);

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            Console.WriteLine("Second window equal the fourth one -> " + w2.Equals(w4));
            Console.WriteLine("Second window's hashCode -> " + w2.GetHashCode());
            Console.WriteLine("Fourth window's hashCode -> " + w4.GetHashCode());
            Console.WriteLine("Second window:\n" + w2);
            Console.WriteLine("Fourth window:\n" + w4);

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");


            List<Door> doors = new List<Door>();
            Door d1 = new Door(80, 190, true);
            Door d2 = new Door(80, 190, false);
            Door d3 = new Door(70, 140, true);
            Door d4 = new Door(80, 190, false);

            doors.Add(d1);
            doors.Add(d2);
            doors.Add(d3);
            doors.Add(d4);


            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            Console.WriteLine("First door equal the second one -> " + d1.Equals(d2));
            Console.WriteLine("First door's hashCode -> " + d1.GetHashCode());
            Console.WriteLine("Second door's hashCode -> " + d2.GetHashCode());
            Console.WriteLine("First door:\n" + d1);
            Console.WriteLine("Second door:\n" + d2);

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            Console.WriteLine("Second door equal the fourth one -> " + d2.Equals(d4));
            Console.WriteLine("Second door's hashCode -> " + d2.GetHashCode());
            Console.WriteLine("Fourth door's hashCode -> " + d4.GetHashCode());
            Console.WriteLine("Second door:\n" + d2);
            Console.WriteLine("Fourth door:\n" + d4);

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            House house = new House(windows, doors);

            House houseCopy = new House(windows, doors);

            Console.WriteLine("First house:\n" + house);
            Console.WriteLine("Second house:\n" + houseCopy);

            Console.WriteLine("First house equals to second one -> " + house.Equals(houseCopy));
            Console.WriteLine("First house's hashCode -> " + house.GetHashCode());
            Console.WriteLine("Second house's hashCode -> " + houseCopy.GetHashCode());

            Console.WriteLine("Amount of Windows in first house -> " + house.getAmountOfWindows()
                + "\nAmount of doors in first house -> " + house.getAmountOfDoors());
            Console.WriteLine("Close the first house -> " + house.closeHouse());
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            List<Door> anotherDoors = new List<Door>();
            Door do1 = new Door(80, 190, false);
            Door do2 = new Door(80, 350, false);
            Door do3 = new Door(70, 140, false);
            Door do4 = new Door(80, 190, false);

            anotherDoors.Add(do1);
            anotherDoors.Add(do2);
            anotherDoors.Add(do3);
            anotherDoors.Add(do4);


            House anotherHouse = new House(windows, anotherDoors);

            Console.WriteLine("First house:\n" + house);
            Console.WriteLine("Another house:\n" + anotherHouse);

            Console.WriteLine("First house equals to another one -> " + house.Equals(anotherHouse));
            Console.WriteLine("First house's hashCode -> " + house.GetHashCode());
            Console.WriteLine("Another house's hashCode -> " + anotherHouse.GetHashCode());
            Console.WriteLine("First house:\n" + house);
            Console.WriteLine("Second house(copy):\n" + houseCopy);

            // exactly this house doesn't have doors with keys, this way it isn't possible to close it
            Console.WriteLine("Another house:\n" + anotherHouse);
            Console.WriteLine("Close another house -> " + anotherHouse.closeHouse());
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        }
    }
}
