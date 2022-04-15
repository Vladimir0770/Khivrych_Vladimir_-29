using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    public class File : Disk
    {
        public File(int size) : base(size)
        {
            this.type = "File";
        }

        public void writeDataInFile()
        {
            Console.WriteLine("Data is writing to the file");
        }
    }
}
