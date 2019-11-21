using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Walking_Man_Noah
{
    public partial class WalkingManForm : Form
    {
        public WalkingManForm()
        {
            InitializeComponent();
        }

      

        private void BtnStart_Click(object sender, EventArgs e)
        {
            const byte MAX_FRAMES = 10;
            int pictureFrameCounter = 1;

            while (pictureFrameCounter < MAX_FRAMES + 1)
            {
                if (pictureFrameCounter == 1)
                {
                    this.picWalkingMan.Image = Properties.Resources.walk1;
                }
                else if (pictureFrameCounter == 2)
                {
                    this.picWalkingMan.Image = Properties.Resources.walk2;
                }
                else if (pictureFrameCounter == 3)
                {
                    this.picWalkingMan.Image = Properties.Resources.walk3;
                }
                else if (pictureFrameCounter == 4)
                {
                    this.picWalkingMan.Image = Properties.Resources.walk4;
                }
                else if (pictureFrameCounter == 5)
                {
                    this.picWalkingMan.Image = Properties.Resources.walk5;
                }
                else if (pictureFrameCounter == 6)
                {
                    this.picWalkingMan.Image = Properties.Resources.walk6;
                }
                else if (pictureFrameCounter == 7)
                {
                    this.picWalkingMan.Image = Properties.Resources.walk7;
                }
                else if (pictureFrameCounter == 8)
                {
                    this.picWalkingMan.Image = Properties.Resources.walk8;
                }
                else if (pictureFrameCounter == 9)
                {
                    this.picWalkingMan.Image = Properties.Resources.walk9;
                }
                else
                {
                    this.picWalkingMan.Image = Properties.Resources.walk10;
                }
            }

            this.Refresh();

            pictureFrameCounter = pictureFrameCounter + 1;

            Thread.Sleep(100);
        }
    }
}
