using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace lab4
{
    public abstract class Disk
    {
        private int size;
        protected string type;

        protected Disk(int size)
        {
            this.size = size;
        }

        public int getSize() { return size; }

        public string getType() { return type; }

        public override string ToString()
        {
            return "{ " + getType() + ", size -> " + size + " MB}";
        }

    }
}
