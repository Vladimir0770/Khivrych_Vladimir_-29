using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Window
    {
        public int width { get; }
        public int height { get; }

       public Window(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            Window w = obj as Window;

            if (w as Window == null) return false;

            return this.width == w.width && this.height == w.height;
        }

        public override int GetHashCode() { return 31 * width * height; }

        public override string ToString()
        {
            return "{ Width - " + width + "; Height - " + height + " }"; 
        }
    }
}
