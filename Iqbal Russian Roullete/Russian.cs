using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iqbal_russian
{
    public partial class Russian : Form
    {
        public Russian()
        {
            InitializeComponent();
        }
        GameRoullete roulleteclasssobj = new GameRoullete();
        Random randbullete = new Random();

        private void btnshoot_Click(object sender, EventArgs e)
        {
            loderimage.Image = Iqbal_Russian_Roullete.Properties.Resources.shoot;
            System.IO.Stream str = Iqbal_Russian_Roullete.Properties.Resources.Shotgun;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();


            if (roulleteclasssobj.leftchamber > 0 && roulleteclasssobj.spinstr == 1)
            {
                //loose message is shown

                MessageBox.Show("You Loose");

                btnload .Enabled = false;
                btnshoot .Enabled = false;//buttons diable
                btnst .Enabled = false;
                btnspin.Enabled = false;



            }
            else if (roulleteclasssobj.leftchamber > 0 && roulleteclasssobj.spinstr != 1)
            {
                roulleteclasssobj.leftchamber = roulleteclasssobj.leftchamber - 1;
                if (roulleteclasssobj.spinstr == 6)
                {
                    roulleteclasssobj.spinstr = 1;
                }
                else
                {
                    roulleteclasssobj.spinstr++;
                }
                
                MessageBox.Show("Saved missed");//save meesage is shown 

            }
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            loderimage.Image = Iqbal_Russian_Roullete.Properties.Resources.load;



            btnspin.Enabled = true;
            btnload.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnspin_Click(object sender, EventArgs e)
        {
            loderimage.Image = Iqbal_Russian_Roullete.Properties.Resources.spin;

            roulleteclasssobj.spinstr = randbullete.Next(1, 6);

            btnshoot .Enabled = true;
            btnspin.Enabled = false;
        }

        private void btnst_Click(object sender, EventArgs e)
        {
            int result = roulleteclasssobj.AwaybulleteMissed();
            System.IO.Stream str = Iqbal_Russian_Roullete.Properties.Resources.Shotgun;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            if (result == 10)
            {
                MessageBox.Show("won score 200");//points are shown
                btnload.Enabled = false;
                btnshoot.Enabled = false;
                btnst.Enabled = false;//buttons are disable
                btnspin.Enabled = false;

            }
            if (result == 5)
            {
                MessageBox.Show("won score 100");//points are shown
                btnload.Enabled = false;
                btnshoot.Enabled = false;//buttons are disable
                btnst.Enabled = false;
                btnspin.Enabled = false;
            }
            if (result == 0)
            {

                MessageBox.Show("missed");//missed message is shown
                

            }
            if (roulleteclasssobj.leftchamber == 0)
            {

                MessageBox.Show("You lost");//lost message is shown
                btnst.Enabled = false;


            }

        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            (new Russian()).Show();
            this.Hide();
        }
    }
}
