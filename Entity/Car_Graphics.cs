using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Entity
{
    public class Car_Graphics
    {
        public void carRight(Graphics car)
        {
            Pen p = new Pen(Color.Black, 2);
            Pen p1 = new Pen(Color.Navy, 2);

            car.FillEllipse(Brushes.Black, 8, 37, 17, 15);                 // tayar
            car.FillEllipse(Brushes.Black, 53, 37, 17, 15);

            car.FillRectangle(Brushes.Navy, 10, 8, 80, 40);               // main body
            car.DrawLine(p1, 10, 8, 9, 9);                              // back up
            car.DrawLine(p1, 9, 9, 9, 47);                              // back back
            car.DrawLine(p1, 9, 47, 10, 47);                            // back down
            car.FillRectangle(Brushes.Navy, 85, 13, 10, 35);            // front down
            car.FillEllipse(Brushes.Navy, 85, 7, 10, 10);              // front
            car.DrawLine(p1, 9, 47, 5, 44);
            car.DrawLine(p1, 5, 44, 4, 43);
            car.DrawLine(p1, 4, 43, 4, 5);
            car.DrawLine(p1, 4, 5, 5, 4);
            car.DrawLine(p1, 5, 4, 90, 4);
            car.DrawLine(p1, 90, 4, 94, 10);
            car.DrawLine(p1, 4, 5, 10,8);

            car.DrawLine(p, 85, 9, 86, 10);             // light
            car.DrawLine(p, 86, 10, 95, 15);
            car.DrawLine(p, 95, 15, 96, 14);
            car.DrawLine(p, 96, 14, 97, 13);
            car.DrawLine(p, 97, 13, 98, 12);
            car.FillEllipse(Brushes.Orange, 97, 8, 8, 6);

            car.DrawRectangle(p, 15, 15, 10, 12);          // windows fram
            car.DrawRectangle(p, 30, 15, 10, 12);
            car.DrawRectangle(p, 45, 15, 10, 12);
            car.DrawRectangle(p, 60, 15, 10, 12);
            car.DrawRectangle(p, 75, 15, 10, 12);

            car.FillRectangle(Brushes.DarkOrange, 15, 15, 10, 12);          // windows
            car.FillRectangle(Brushes.DarkOrange, 30, 15, 10, 12);
            car.FillRectangle(Brushes.DarkOrange, 45, 15, 10, 12);
            car.FillRectangle(Brushes.DarkOrange, 60, 15, 10, 12);
            car.FillRectangle(Brushes.DarkOrange, 75, 15, 10, 12);

            car.FillEllipse(Brushes.Black, 76, 15, 7,7);                    // human
            car.FillRectangle(Brushes.DarkRed, 76, 25, 8, 2);
            car.FillEllipse(Brushes.DarkRed, 76, 20, 7,7);
            car.DrawLine(p, 78, 22, 84, 25);

            car.FillEllipse(Brushes.Black, 20, 40, 17, 15);                 // tayar
            car.FillEllipse(Brushes.DarkSlateGray, 25, 44, 7, 7);
            car.FillEllipse(Brushes.Black, 65, 40, 17, 15);
            car.FillEllipse(Brushes.DarkSlateGray, 70, 44, 7, 7);
        }
        public void carLeft(Graphics car)
        {
            Pen p = new Pen(Color.Black, 2);
            Pen p1 = new Pen(Color.Navy, 2);
            Pen p2 = new Pen(Color.SteelBlue, 1);

            car.FillEllipse(Brushes.Black, 32, 37, 17, 15);                 // tayar
            car.FillEllipse(Brushes.Black, 77, 37, 17, 15);

            car.FillRectangle(Brushes.Navy, 10, 8, 80, 40);               // main body
            car.DrawLine(p1, 10, 8, 9, 9);                              // back up
            car.DrawLine(p1, 9, 9, 9, 47);                              // back back
            car.DrawLine(p1, 9, 47, 10, 47);                            // back down
            car.FillRectangle(Brushes.Navy, 85, 8, 10, 40);            // front down
            car.DrawLine(p1, 95, 47, 96, 47);
            car.DrawLine(p1, 96, 47, 100, 44);
            car.DrawLine(p1, 100, 44, 100, 4);
            car.DrawLine(p1, 100, 4, 99, 4);
            car.DrawLine(p1, 99, 4, 14, 4);
            car.DrawLine(p1, 14, 4, 13, 5);
            car.DrawLine(p1, 13, 5, 10, 8);
            car.DrawLine(p1, 100, 4, 95, 8);

            car.FillEllipse(Brushes.Orange, 0, 8, 8, 6);               // light
            car.DrawLine(p, 17, 10, 12, 16);
            car.DrawLine(p, 12, 16, 11, 15);
            car.DrawLine(p, 11, 15, 8, 12);

            car.DrawRectangle(p, 17, 15, 10, 12);      //windwos fram
            car.DrawRectangle(p, 32, 15, 10, 12);
            car.DrawRectangle(p, 47, 15, 10, 12);
            car.DrawRectangle(p, 62, 15, 10, 12);
            car.DrawRectangle(p, 77, 15, 10, 12); 
            
            car.FillRectangle(Brushes.DarkOrange, 17, 15, 10, 12);      //windwos 
            car.FillRectangle(Brushes.DarkOrange, 32, 15, 10, 12);
            car.FillRectangle(Brushes.DarkOrange, 47, 15, 10, 12);
            car.FillRectangle(Brushes.DarkOrange, 62, 15, 10, 12);
            car.FillRectangle(Brushes.DarkOrange, 77, 15, 10, 12);

            car.FillRectangle(Brushes.DarkRed, 18, 25, 8, 2);           // human
            car.FillEllipse(Brushes.DarkRed, 18, 20, 7, 7);
            car.FillEllipse(Brushes.Black, 18, 15, 7, 7);
            car.DrawLine(p, 23, 22, 16, 25);

            car.FillEllipse(Brushes.Black, 20, 40, 17, 15);             // tayar
            car.FillEllipse(Brushes.DarkSlateGray, 25, 44, 7, 7);
            car.FillEllipse(Brushes.Black, 65, 40, 17, 15);
            car.FillEllipse(Brushes.DarkSlateGray, 70, 44, 7, 7);

        }
        public void carUp(Graphics car)
        {
            Pen p = new Pen(Color.Navy, 2);
            Pen p1 = new Pen(Color.Black, 2);
            Pen p2 = new Pen(Color.Black, 1);
            Pen p3 = new Pen(Color.Orange, 1);

            car.FillRectangle(Brushes.Navy, 8, 12, 8, 70);
            car.FillRectangle(Brushes.DarkSlateGray, 16, 12, 25, 70);
            car.DrawRectangle(p2, 18, 16, 14, 62);
            car.DrawLine(p2, 18, 22, 32, 22);
            car.DrawLine(p2, 18, 29, 32, 29);
            car.DrawLine(p2, 18, 36, 32, 36);
            car.DrawLine(p2, 18, 43, 32, 43);
            car.DrawLine(p2, 18, 50, 32, 50);
            car.DrawLine(p2, 18, 57, 32, 57);
            car.DrawLine(p2, 18, 64, 32, 64);
            car.DrawLine(p2, 18, 71, 32, 71);
            car.FillRectangle(Brushes.Navy, 35, 12, 8, 70);
           

            car.DrawLine(p, 9, 12, 9, 10);
            car.DrawLine(p, 9, 10, 10, 9);
            car.DrawLine(p, 10, 9, 11, 8);
            car.DrawLine(p, 11, 8, 39, 8);
            car.DrawLine(p, 39, 8, 40, 9);
            car.DrawLine(p, 40, 9, 41, 10);
            car.DrawLine(p, 41, 10, 42, 11);
            car.DrawLine(p, 42, 13, 42, 13);

            car.DrawLine(p, 14, 12, 38, 12);

            car.DrawLine(p, 9, 80, 9, 84);
            car.DrawLine(p, 9, 84, 10, 85);
            car.DrawLine(p, 10, 85, 11, 86);
            car.DrawLine(p, 11, 86, 39, 86);
            car.DrawLine(p, 39, 86, 40, 85);
            car.DrawLine(p, 40, 85, 41, 84);
            car.DrawLine(p, 41, 84, 42, 83);
            car.DrawLine(p, 42, 83, 42, 80);

            car.DrawLine(p, 14, 82, 38, 82);

            car.DrawEllipse(p3, 4, 3, 2, 6);
            car.DrawLine(p1, 5, 10, 5, 12);
            car.DrawLine(p1, 5, 12, 8, 17);

            car.DrawEllipse(p3, 44, 2, 2, 6);
            car.DrawLine(p1, 45, 9, 45, 11);
            car.DrawLine(p1, 45, 11, 42, 17);
            


        }
        public void carDown(Graphics car)
        {

            Pen p = new Pen(Color.Navy, 2);
            Pen p1 = new Pen(Color.Black, 2);
            Pen p2 = new Pen(Color.Black, 1);
            Pen p3 = new Pen(Color.Orange, 1);

            car.FillRectangle(Brushes.Navy, 8, 12, 8, 70);
            car.FillRectangle(Brushes.DarkSlateGray, 16, 12, 25, 70);
            car.DrawRectangle(p2, 18, 16, 14, 62);
            car.DrawLine(p2, 18, 22, 32, 22);
            car.DrawLine(p2, 18, 29, 32, 29);
            car.DrawLine(p2, 18, 36, 32, 36);
            car.DrawLine(p2, 18, 43, 32, 43);
            car.DrawLine(p2, 18, 50, 32, 50);
            car.DrawLine(p2, 18, 57, 32, 57);
            car.DrawLine(p2, 18, 64, 32, 64);
            car.DrawLine(p2, 18, 71, 32, 71);
            car.FillRectangle(Brushes.Navy, 35, 12, 8, 70);


            car.DrawLine(p, 9, 12, 9, 10);
            car.DrawLine(p, 9, 10, 10, 9);
            car.DrawLine(p, 10, 9, 11, 8);
            car.DrawLine(p, 11, 8, 39, 8);
            car.DrawLine(p, 39, 8, 40, 9);
            car.DrawLine(p, 40, 9, 41, 10);
            car.DrawLine(p, 41, 10, 42, 11);
            car.DrawLine(p, 42, 13, 42, 13);

            car.DrawLine(p, 14, 12, 38, 12);

            car.DrawLine(p, 9, 80, 9, 84);
            car.DrawLine(p, 9, 84, 10, 85);
            car.DrawLine(p, 10, 85, 11, 86);
            car.DrawLine(p, 11, 86, 39, 86);
            car.DrawLine(p, 39, 86, 40, 85);
            car.DrawLine(p, 40, 85, 41, 84);
            car.DrawLine(p, 41, 84, 42, 83);
            car.DrawLine(p, 42, 83, 42, 80);

            car.DrawLine(p, 14, 82, 38, 82);

            car.DrawEllipse(p3, 4, 80, 2, 6);
            car.DrawLine(p1, 5, 80, 5, 78);
            car.DrawLine(p1, 5, 78, 8, 74);

            car.DrawEllipse(p3, 45, 80, 2, 6);
            car.DrawLine(p1, 45, 80, 45, 78);
            car.DrawLine(p1, 45, 78, 42, 74);
        }
    }
}
