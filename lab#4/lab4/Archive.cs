using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    public class Archive : Disk
    {
        public Archive(int size) : base(size)
        {
            this.type = "Archive";
        }

        public File unzipArchive()
        {
            return new File(this.getSize() * 2);
        }
    }
}
