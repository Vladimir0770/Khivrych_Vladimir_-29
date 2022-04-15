using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    public class MP3 : Disk
    {
        private string nameOfSong;
        public MP3(int size, string nameOfSong) : base(size)
        {
            this.nameOfSong = nameOfSong;
            this.type = "MP3";
        }

        public void playSong()
        {
            Console.WriteLine(nameOfSong + " is playing now...");
        }
    }
}
