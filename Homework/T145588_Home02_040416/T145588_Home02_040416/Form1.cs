using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T145588_Home02_040416
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            number = Convert.ToInt32(textBox1.Text);
            number = int.Parse(textBox1.Text);

            String s1 = spell.SpellNumber(number);
            string[] A = s1.Split(' ');

            //System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            for(int i =0; i < A.Length; i++)
            {
                if (A[i] == "one")
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    player.SoundLocation = @"english\one.wav"; //path to the sound file
                    player.PlaySync();
                    
                    //using (var soundPlayer = new SoundPlayer(@"english\one.wav")) {
                    //soundPlayer.Play();
                }
                if (A[i] == "two")
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    player.SoundLocation = @"english\two.wav"; //path to the sound file
                    player.PlaySync();
                }
                if (A[i] == "three")
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    player.SoundLocation = @"english\three.wav"; //path to the sound file
                    player.PlaySync();
                }


            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int number;
            number = Convert.ToInt32(textBox1.Text);
            number = int.Parse(textBox1.Text);

            String s1 = spell.SpellNumber(number);
            Console.WriteLine(s1);
        }

        
    }
}
