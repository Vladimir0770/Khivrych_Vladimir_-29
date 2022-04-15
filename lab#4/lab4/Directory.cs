using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    public class Directory : Disk
    {
        private List<Disk> data;
        public Directory(int size, List<Disk> data) : base(size)
        {
            this.data = data;
            this.type = "Directory";
        }

        public void showDataStoredInDir()
        {
            Console.WriteLine("Data stored in Dir:");
            foreach (Disk item in data)
            {
                Console.WriteLine(item);
            }
        }

        public void whichTypesOfDataIsStored()
        {
            HashSet<string> set = new HashSet<string>();
            Console.WriteLine("Type of data stored in the dir:");
            foreach (Disk item in data)
            {
                set.Add(item.getType());
            }

            foreach (string item in set)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public string getTotalSizeOfDir()
        {
            int total = 0;

            foreach (Disk item in data)
                total += item.getSize();

            return total + "MB";
        }

        public int getAmountOfMP3Files()
        {
            List<Disk> MP3list = new List<Disk>();

            foreach (Disk item in data)
            {
                if (item.getType().Equals("MP3"))
                {
                    MP3list.Add(item);
                }
            }

            return MP3list.Count;
        }
    }
}
