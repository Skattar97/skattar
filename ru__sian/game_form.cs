using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ru__sian
{
    public partial class game_form : Form
    {
        public int chance = 0, load;
        public int Spined;

        shoot obj_shoot = new shoot();
        
        public game_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Loded_btn_Click(object sender, EventArgs e)
        {    // below code is for enableling and disableing the button
            Spined_btn .Enabled = true;
            Loded_btn.Enabled = false;
            pbox.Visible = true;
            obj_shoot.loaded = 1;
            //below code is for sound and gif
            pbox.Image = Image.FromFile(@"C:\Users\LENOVO\source\repos\skattar\res\load.gif");
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\LENOVO\Desktop\ru__sian\res\load.wav");


        }

        private void Spined_btn_Click(object sender, EventArgs e)
        {             //below code is for sound and gif

            Image img = Image.FromFile(@"C:\Users\LENOVO\source\repos\skattar\res\spin.gif");
            pbox.Image = img;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\LENOVO\source\repos\skattar\res\spin.wav");
            player.Play();
            shoot SpinObj = new shoot();
            obj_shoot.Spined = SpinObj.Spin_Chamber();
            // below code is for enableling and disableing the button
            Shooter_btn.Enabled = true;
            Spined_btn.Enabled = false;
        }

        private void Shooter_btn_Click(object sender, EventArgs e)
        {
            //below code is for sound and gif

            Image img = Image.FromFile(@"C:\Users\LENOVO\source\repos\skattar\res\shoot.gif");
            pbox.Image = img;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\LENOVO\source\repos\skattar\res\shoot.wav");
            player.Play();
            shoot ShotObj = new shoot();//this is the object of shoot class
            int points = ShotObj.shooterr(obj_shoot.loaded, obj_shoot.Spined);//this caliing the method from shooter class
            

            if (chance == 0 && points == 10)//this is a if else statement
            {
                MessageBox.Show("Winner and your score is " + points);//this is for the meesge pop up
                Shooter_btn .Enabled = false;
            }

            else if (chance == 1 && points == 5)
            {
                MessageBox.Show("Winner and your score is " + points);//this is for the meesge pop up
                Shooter_btn.Enabled = false;
            }
            if (chance == 1 && points == 0)
            {
                MessageBox.Show("You loose");//this is for the meesge pop up
                Shooter_btn.Enabled = false;
            }
            else
            {
                chance++;
                Spined = spinchamber(Spined);
            }
        }

        public int spinchamber(int sp)//this is the spin chamber method
        {
            if (sp == 6)
            {
                sp = 1;

            }
            else
            {
                sp++;

            }
            return sp;

        }

        private void game_form_Load(object sender, EventArgs e)
        {

        }

        private void pbox_Click(object sender, EventArgs e)
        {

        }

        private void retry_Click(object sender, EventArgs e)
        {
            (new game_form()).Show();
            this.Hide();
        }
    }
 }

