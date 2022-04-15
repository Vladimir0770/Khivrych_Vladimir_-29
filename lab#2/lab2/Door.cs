using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Door
    {
        public int width { get; }
        public int height { get; }

        public bool hasKey { get; set; }

        public Door(int width, int height, bool hasKey)
        {
            this.width = width;
            this.height = height;
            this.hasKey = hasKey;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            Door d = obj as Door;

            if (d as Door == null) return false;

            return this.width == d.width && this.height == d.height && this.hasKey == d.hasKey;
        }

        public override int GetHashCode()
        {
            int key;

            if (hasKey)
                key = 17;
            else
                key = 37;

            return 31 * width * height * key; 
        }

        public override string ToString() { return "{ Width - " + width + "; Height - " + height + "; Has key - " + hasKey + " }"; }
    }
}
