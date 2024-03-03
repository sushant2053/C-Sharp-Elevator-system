using System;
using System.Windows.Forms;

namespace LiftSystem
{
    class Lifta
    {
        DataBase datab = new DataBase();


        public void Autot(PictureBox pb, Timer tautodown, Timer tautoup, Button buttonS, Button buttonF, Button Sbutton, Button Fbutton, int up, int down)
        {
            if (pb.Top > up)
            {
                tautodown.Start();
                buttonS.Enabled = false;
                buttonF.Enabled = false;
                Fbutton.Enabled = false;
                Sbutton.Enabled = false;
            }
            else if (pb.Top < down)
            {
                tautoup.Start();
                buttonF.Enabled = false;
                buttonS.Enabled = false;
                Sbutton.Enabled = false;
                Fbutton.Enabled = false;
            }
        }

        public void AutotUp(PictureBox lup, PictureBox rup, Timer tautoup, Timer tauto, Button buttonF, Button buttonS, Button Fbutton)
        {
            if (lup.Left <= 77 && rup.Left >= 161)
            {
                lup.Left += 1;
                rup.Left -= 1;
            }
            else
            {
                tautoup.Stop();
                tauto.Stop();
                buttonF.Enabled = true;
                buttonS.Enabled = true;
                Fbutton.Enabled = true;
                datab.Insert("First floor door is closing");
            }
        }

        public void AutotDown(PictureBox ldown, PictureBox rdown, Timer tautodown, Timer tauto, Button buttonF, Button buttonS, Button Sbutton)
        {
            if (ldown.Left <= 77 && rdown.Left >= 161)
            {
                ldown.Left += 1;
                rdown.Left -= 1;
            }
            else
            {
                tautodown.Stop();
                tauto.Stop();
                buttonS.Enabled = true;
                buttonF.Enabled = true;
                Sbutton.Enabled = true;
                datab.Insert("Ground floor door is closing");
            }
        }
    }
}

