using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UEH_EVENT.GUI.Mario;

namespace UEH_EVENT.BL
{
    internal class Collision
    {
        frmPlayMario form;
        /*public Collision(frmPlayMario form)
        {
            this.form = form;
        }
        public Boolean InAirNoCollision(PictureBox tar)
        {
            if (!form.OutsideWorldFrame(tar))
            {
                foreach (PictureBox Obj in form.WorldObjects)
                {
                    if (!tar.Bounds.IntersectsWith(Obj.Bounds))
                    {
                        if (tar.Location.Y < form.WorldFrame.Width)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }


        public Boolean Collision_Top(PictureBox tar)
        {
            foreach (PictureBox ob in form.WorldObjects)
            {
                if (ob != null)
                {
                    PictureBox temp1 = new PictureBox();
                    temp1.Bounds = ob.Bounds;
                    temp1.SetBounds(temp1.Location.X - 3, temp1.Location.Y - 1, temp1.Width + 6, 1);
                    if (tar.Bounds.IntersectsWith(temp1.Bounds))
                        return true;
                }
            }
            return false;
        }

        public Boolean Collision_Bottom(PictureBox tar)
        {
            foreach (PictureBox ob in form.WorldObjects)
            {
                if (ob != null)
                {
                    PictureBox temp1 = new PictureBox();
                    temp1.Bounds = ob.Bounds;
                    temp1.SetBounds(temp1.Location.X, temp1.Location.Y + temp1.Height, temp1.Width, 1);
                    if (tar.Bounds.IntersectsWith(temp1.Bounds))
                        return true;
                }
            }
            return false;
        }

        public Boolean Collision_Left(PictureBox tar)
        {
            foreach (PictureBox ob in form.WorldObjects)
            {
                if (ob != null)
                {
                    PictureBox temp1 = new PictureBox();
                    temp1.Bounds = ob.Bounds;
                    temp1.SetBounds(temp1.Location.X - 1, temp1.Location.Y + 1, 1, temp1.Height - 1);
                    if (tar.Bounds.IntersectsWith(temp1.Bounds))
                        return true;
                }
            }
            return false;
        }
        public Boolean Collision_Right(PictureBox tar)
        {
            foreach (PictureBox ob in form.WorldObjects)
            {
                if (ob != null)
                {
                    PictureBox temp2 = new PictureBox();
                    temp2.Bounds = ob.Bounds;
                    temp2.SetBounds(temp2.Location.X + temp2.Width, temp2.Location.Y + 1, 1, temp2.Height - 1);
                    if (tar.Bounds.IntersectsWith(temp2.Bounds))
                        return true;
                }
            }
            return false;
        }*/
    }
}
