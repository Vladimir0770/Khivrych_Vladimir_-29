using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    internal class Vinchester
    {
        List<Disk> Disks { get; set; }

        public Vinchester(List<Disk> disks) { Disks = disks; }

        public void addDisk(Disk disk) { Disks.Add(disk); }

        public void formatDisk(Disk disk)
        {
            if (Disks.Contains(disk))
            {
                Console.WriteLine("Введите новый размер диска: ");
                int size;
                string strSize = Console.ReadLine();
                if (int.TryParse(strSize, out size))
                {
                    size = int.Parse(strSize);
                }
                else
                {
                    Console.WriteLine("Введённый размер некорректный.");
                }


                for (int i = 0; i < Disks.Count; i++)
                {
                    if (Disks[i].Equals(disk))
                    {
                        Disks[i].setSize(size);
                    }
                }
            }
            else
            {
                Console.WriteLine("Такого диска не существует !");
            }
        }

        public void getAmountOfFilesInEveryDisk()
        {
            for (int i = 0; i < Disks.Count; i++)
            {
                int amount = 0;
                if (Disks[i] is Directory)
                {
                    Directory dir = (Directory)Disks[i];
                    amount += dir.getAmountOfFiles();

                    Console.WriteLine(dir + " amount of files(" + amount + ")");
                }
                else
                {
                    Console.WriteLine(Disks[i] + " amount of files(" + 1 + ")");
                }
            }
        }
    }
}
