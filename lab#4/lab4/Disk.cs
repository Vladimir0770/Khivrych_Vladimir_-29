using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace lab4
{
    public abstract class Disk
    {
        private int size { get; set; }
        protected string type;

        protected Disk(int size)
        {
            this.size = size;
        }

        public int getSize() { return size; }

        public void setSize(int size)
        {
            if (size > 0)
                this.size = size;
        }

        public string getType() { return type; }

        public override string ToString()
        {
            return "{ " + getType() + ", size -> " + size + " MB}";
        }

    }
}
