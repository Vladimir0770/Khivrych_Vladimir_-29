using System;
using System.Collections.Generic;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Disk> data = new List<Disk>();
            data.Add(new Archive(10));
            File file = new File(20);
            data.Add(file);
            data.Add(new MP3(300, "Middle of the night"));
            data.Add(new MP3(500, "Ride it"));
            data.Add(new MP3(400, "Rolling in the deep"));
            data.Add(new MP3(100, "Blinding lights"));

            Directory dir = new Directory(0, data);

            dir.whichTypesOfDataIsStored();
            dir.showDataStoredInDir();
            Console.WriteLine("Total size of dir -> " + dir.getTotalSizeOfDir());
            Console.WriteLine("Amount of mP3 files in dir -> " + dir.getAmountOfMP3Files());

            File txt = new File(123);
            txt.writeDataInFile();

            MP3 mP3 = new MP3(999, "Umbrella");
            mP3.playSong();

            Archive archive = new Archive(100);
            Console.WriteLine("Size of archive file -> " + archive.getSize());
            File unzippedArchive = archive.unzipArchive();
            Console.WriteLine("Size of unzipped archive file -> " + unzippedArchive.getSize());

            Vinchester vinchester = new Vinchester(data);

            vinchester.addDisk(dir);
            vinchester.formatDisk(file);
            vinchester.getAmountOfFilesInEveryDisk();
        }
    }
}
