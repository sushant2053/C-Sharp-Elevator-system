using System;
using System.Windows.Forms;

namespace LiftSystem
{
    class Liftud
    {
        readonly DataBase datab = new DataBase();


        public void LiftGoUp(PictureBox pb, Timer muptimer, Timer uOpenTimer, PictureBox cshow, PictureBox ushow, PictureBox dshow, int up, Button buttonopen, Button buttonclose)
        {

            if (pb.Top > up)
            {
                pb.Top -= 1;
            }
            else
            {
                muptimer.Enabled = false;
                buttonopen.Enabled = true;
                buttonclose.Enabled = true;
                uOpenTimer.Start();
                cshow.Image = LiftSystem.Properties.Resources.F;
                ushow.Image = LiftSystem.Properties.Resources.F;
                dshow.Image = LiftSystem.Properties.Resources.F;
                datab.Insert("Lift is going upward");
            }
        }

        public void LiftGoDown(PictureBox pb, Timer mdowntimer, Timer dOpenTimer, PictureBox cshow, PictureBox ushow, PictureBox dshow, int down, Button buttonopen, Button buttonclose)
        {
            if (pb.Top < down)
            {
                pb.Top += 1;
            }
            else if (pb.Top == down)
            {
                mdowntimer.Enabled = false;
                buttonopen.Enabled = true;
                buttonclose.Enabled = true;
                dOpenTimer.Start();
                cshow.Image = LiftSystem.Properties.Resources.G;
               ushow.Image = LiftSystem.Properties.Resources.G;
               dshow.Image = LiftSystem.Properties.Resources.G;
                datab.Insert("Lift is going downward");
            }
        }
    }
}
