using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace lab2
{
    class House
    {
        public List<Window> windows { get; }
        public List<Door> doors { get; }

        public House(List<Window> windows, List<Door> doors)
        {
            this.windows = windows;
            this.doors = doors;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            House h = obj as House;

            if (h as House == null) return false;

            return this.windows.SequenceEqual(h.windows) && this.doors.SequenceEqual(h.doors);
        }

        public override int GetHashCode()
        {
            int result = 31;

            foreach (Window window in windows)
            {
                result *= window.GetHashCode();
            }

            foreach (Door door in doors)
            {
                result *= door.GetHashCode();
            }

            return result;
        }

        public override string ToString() 
        {
            StringBuilder result = new StringBuilder("Windows:\n");

            int wCounter = 1;
            int dCounter = 1;

            foreach (Window window in windows)
            {
                result.Append("Window #").Append(wCounter).Append(window.ToString()).Append("\n");
                wCounter++;
            }

            result.Append("\n")
                .Append("Doors:\n");

            foreach (Door door in doors)
            {
                result.Append("Door #").Append(dCounter).Append(door.ToString()).Append("\n");
                dCounter++;
            }

            return result.ToString(); 
        }

        public string closeHouse()
        {
            bool hasKey = false;
            foreach (Door door in doors)
            {
                if (door.hasKey) hasKey = true;
            }

            if (hasKey)
                return "The house has been closed";
            else
                return "It is not possible to close the house";
        }

        public int getAmountOfWindows()
        {
            return windows.Count();
        }

        public int getAmountOfDoors()
        {
            return doors.Count();
        }
    }
}
