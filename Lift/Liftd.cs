using System;
using System.Windows.Forms;

namespace LiftSystem
{
    class Liftd
    {
        DataBase datab = new DataBase();

        public void DownDoorClose(PictureBox ldown, PictureBox rdown, Timer dclosetimer, Timer muptimer, Button Sbutton)
        {

            if (ldown.Left <= 77 && rdown.Left >= 161)
            {
                ldown.Left += 1;
                rdown.Left -= 1;
            }
            else
            {
                dclosetimer.Stop();
                Sbutton.Enabled = true;
                datab.Insert("Ground floor door is closing");
            }
        }

        public void UpDoorClose(PictureBox lup, PictureBox rup, Timer uclosetimer, Timer mdowntimer, Button Fbutton)
        {
            if (lup.Left <= 77 && rup.Left >= 161)
            {
                lup.Left += 1;
                rup.Left -= 1;
            }
            else
            {
                uclosetimer.Stop();
                Fbutton.Enabled = true;
                datab.Insert("First floor door is closing");
            }
        }

        public void UpDoorOpen(PictureBox lup, PictureBox rup, Timer uOpenTimer, Timer autotime, Button Fbutton, Button Sbutton, Button buttonS, Button buttonF)
        {
            if (lup.Left >= 3 && rup.Left <= 230)
            {
                lup.Left -= 1;
                rup.Left += 1;
            }
            else
            {
                Fbutton.Enabled = false;
                Sbutton.Enabled = false;
                buttonS.Enabled = false;
                buttonF.Enabled = false;
                uOpenTimer.Stop();
                autotime.Start();
                datab.Insert("First floor door is opening");
            }
        }

        public void DownDoorOpen(PictureBox ldown, PictureBox rdown, Timer dOpenTimer, Timer autotime, Button Fbutton, Button Sbutton, Button buttonS, Button buttonF)
        {
            if (ldown.Left >= 3 && rdown.Left <= 230)
            {
                ldown.Left -= 1;
                rdown.Left += 1;
            }
            else
            {
                Sbutton.Enabled = false;
                Fbutton.Enabled = false;
                buttonF.Enabled = false;
                buttonS.Enabled = false;
                dOpenTimer.Stop();
                autotime.Start();
                datab.Insert("Ground floor door is opening");
            }
        }
    }
}
