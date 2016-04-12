using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic7
{
    class Program
    {
        static void Main(string[] args)
        {
            //T145588 h = new T145588(20);

            //WMPLib.WindowsMediaPlayer nhac = new WMPLib.WindowsMediaPlayer();
            //nhac.URL = "F:\\Git\\Visual Studio\\Topic7\\Topic7\\nhac.mp3";
            //nhac.controls.play();

            //mp3 h = new mp3();
            //h.Open("F:\\Git\\Visual Studio\\Topic7\\Topic7\\nhac.mp3");
            //h.Play();

            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:\\Users\\HuynhThanh\\Downloads\\abetterday.wav"; // Đường dẫn đến file cần chơi
            player.Play();

            //square s2 = new square(15,0, 25);
            //square s1 = new square(0, 0, 10);
            //s1.draw();
            //s2.draw();

        }
    }
}
