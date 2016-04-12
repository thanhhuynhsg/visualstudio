using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace T145588_Home02_040416
{
    class SpeakVietnamese
    {
        public static void speak(String s) 
        {
            String[] chuoi = s.Split(' ');

            for (int i = 0; i < chuoi.Length; i++)
            {
                if (chuoi[i] == "mot")
                {
                    using (SoundPlayer sound = new SoundPlayer(@"vietnamese\mot.wav"))
                    {
                        sound.PlaySync();
                    }
                }
                if (chuoi[i] == "hai")
                {
                    using (SoundPlayer sound = new SoundPlayer(@"vietnamese\hai.wav"))
                    {
                        sound.PlaySync();
                    }
                }
                if (chuoi[i] == "ba")
                {
                    using (SoundPlayer sound = new SoundPlayer(@"vietnamese\ba.wav"))
                    {
                        sound.PlaySync();
                    }
                }
                if (chuoi[i] == "bon")
                {
                    using (SoundPlayer sound = new SoundPlayer(@"vietnamese\bon.wav"))
                    {
                        sound.PlaySync();
                    }
                }
                if (chuoi[i] == "nam")
                {
                    using (SoundPlayer sound = new SoundPlayer(@"vietnamese\nam.wav"))
                    {
                        sound.PlaySync();
                    }
                }
                if (chuoi[i] == "sau")
                {
                    using (SoundPlayer sound = new SoundPlayer(@"vietnamese\sau.wav"))
                    {
                        sound.PlaySync();
                    }
                }
                if (chuoi[i] == "bay")
                {
                    using (SoundPlayer sound = new SoundPlayer(@"vietnamese\bay.wav"))
                    {
                        sound.PlaySync();
                    }
                }
                if (chuoi[i] == "tam")
                {
                    using (SoundPlayer sound = new SoundPlayer(@"vietnamese\tam.wav"))
                    {
                        sound.PlaySync();
                    }
                }
                if (chuoi[i] == "chin")
                {
                    using (SoundPlayer sound = new SoundPlayer(@"vietnamese\chin.wav"))
                    {
                        sound.PlaySync();
                    }
                }
                if (chuoi[i] == "muoi")
                {
                    using (SoundPlayer sound = new SoundPlayer(@"vietnamese\muoi.wav"))
                    {
                        sound.PlaySync();
                    }
                }
                if (chuoi[i] == "khong")
                {
                    using (SoundPlayer sound = new SoundPlayer(@"vietnamese\khong.wav"))
                    {
                        sound.PlaySync();
                    }
                }
                if (chuoi[i] == "ngan")
                {
                    using (SoundPlayer sound = new SoundPlayer(@"vietnamese\ngan.wav"))
                    {
                        sound.PlaySync();
                    }
                }
                if (chuoi[i] == "tram")
                {
                    using (SoundPlayer sound = new SoundPlayer(@"vietnamese\tram.wav"))
                    {
                        sound.PlaySync();
                    }
                }
                if (chuoi[i] == "trieu")
                {
                    using (SoundPlayer sound = new SoundPlayer(@"vietnamese\trieu.wav"))
                    {
                        sound.PlaySync();
                    }
                }
                if (chuoi[i] == "ty")
                {
                    using (SoundPlayer sound = new SoundPlayer(@"vietnamese\ty.wav"))
                    {
                        sound.PlaySync();
                    }
                }
                if (chuoi[i] == "muo'i")
                {
                    using (SoundPlayer sound = new SoundPlayer(@"vietnamese\muoi1.wav"))
                    {
                        sound.PlaySync();
                    }
                }
                if (chuoi[i] == "am")
                {
                    using (SoundPlayer sound = new SoundPlayer(@"vietnamese\am.wav"))
                    {
                        sound.PlaySync();
                    }
                }
            }
        }
    }
}
