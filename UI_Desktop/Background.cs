using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace UI_Desktop
{
    public class Background
    {
        public void drawtree(Graphics tree)
        {
            Pen p = new Pen(Color.DarkOliveGreen, 2);
            tree.FillEllipse(Brushes.Green, 35, 70, 25, 20);
            tree.DrawLine(p, 46, 137, 50, 50);
            tree.DrawLine(p, 55, 137, 51, 50);
            tree.FillRectangle(Brushes.DarkOliveGreen, 46, 115, 8, 22);
            tree.FillRectangle(Brushes.DarkOliveGreen, 48, 94, 6, 21);
            tree.FillRectangle(Brushes.DarkOliveGreen, 50, 72, 4, 22);
            tree.DrawLine(p, 48, 90, 20, 70);
            tree.DrawLine(p, 50, 90, 77, 76);
            tree.FillEllipse(Brushes.Green, 10, 70, 30, 20);
            tree.FillEllipse(Brushes.Green, 20, 60, 30, 20);
            tree.FillEllipse(Brushes.Green, 70, 65, 28, 20);
            tree.FillEllipse(Brushes.Green, 68, 80, 20, 10);
            tree.FillEllipse(Brushes.Green, 55, 70, 25, 10);
            tree.FillEllipse(Brushes.Green, 35, 10, 40, 50);
            tree.FillEllipse(Brushes.Green, 30, 15, 50, 50);
            tree.FillEllipse(Brushes.Green, 55, 28, 30, 40);
            tree.FillEllipse(Brushes.Green, 20, 40, 25, 20);
        }

        public void drawlamppost(Graphics lamppost)
        {
            lamppost.FillEllipse(Brushes.DarkSlateBlue, 1, 72, 15, 12);
            lamppost.FillRectangle(Brushes.DarkSlateBlue, 5, 25, 8, 50);
            lamppost.FillEllipse(Brushes.DarkOrange, 0, 20, 18, 5);
            lamppost.FillEllipse(Brushes.Orange, 2, 8, 13, 13);

        }

        public void drawsortlamppost(Graphics lamppost)
        {
            lamppost.FillEllipse(Brushes.DarkSlateBlue, 1, 25, 15, 12);
            lamppost.FillRectangle(Brushes.DarkSlateBlue, 5, 17, 8, 14);
            lamppost.FillEllipse(Brushes.DarkOrange, 0, 12, 18, 5);
            lamppost.FillEllipse(Brushes.Orange, 2, 2, 13, 13);

        }

        public void drawRoket(Graphics Roket)
        {
            Pen p = new Pen(Color.Indigo, 2);
            Roket.FillEllipse(Brushes.Indigo, 2, 5, 15, 7);
            Roket.FillRectangle(Brushes.Indigo, 17, 9, 5, 2);
            Roket.FillRectangle(Brushes.Wheat, 6, 8, 2, 2);
            Roket.FillRectangle(Brushes.Wheat, 10, 8, 2, 2);
            Roket.DrawLine(p, 25, 6, 21, 10);
            Roket.DrawLine(p, 21, 10, 23, 12);
            Roket.DrawLine(p, 7, 3, 13, 3);
            Roket.DrawLine(p, 10, 3, 10, 6);
        }
    }
}
