using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;


namespace BO
{
    public class Dalaccessclass
    {
        Dallayer d = new Dallayer();
        public int x = 7;
        public int y = 3;
        public int Rposition = 970;
        public char key = 'r';
        public bool saveSpeed(Car c)
        {
            return d.save(c.speed);
        }
        public int speedCalculation()
        {
            Car c = d.getData();
            if (c.speed > 0 && c.speed <= 10)
                return 60;
            else if (c.speed > 10 && c.speed <= 20)
                return 50;
            else if (c.speed > 20 && c.speed <= 30)
                return 40;
            else if (c.speed > 30 && c.speed <= 40)
                return 30;
            else if (c.speed > 40 && c.speed <= 50)
                return 25;
            else if (c.speed > 50 && c.speed <= 60)
                return 20;
            else if (c.speed > 60 && c.speed <= 70)
                return 15;
            else if (c.speed > 70 && c.speed <= 80)
                return 10;
            else if (c.speed > 80 && c.speed <= 90)
                return 5;
            else if (c.speed > 90 && c.speed <= 100)
                return 1;
            else
                return 0;
  
        }
        public int getData()
        {
            Car c = d.getData();
            int speed = c.speed;
            return speed;
        }
        public void changeAxes(char key)
        {
            if (key == 'u')
            {
                if ((y>=0 && y<=1) && (x >= 1 && x <= 1037))
                    y = y + 0;
                else if((y==271) && ((x>=56 && x<=425) || (x>=491 && x<=860)))
                    y = y + 0; 
                else
                    y = y - 2;
            }
            else if (key == 'd')
            {
                if ((y == 325) && (x >= 1 && x <= 1037))
                    y = y + 0;
                else if ((y == 31) && ((x >= 56 && x <= 425) || (x >= 491 && x <= 860)))
                    y = y + 0;
                else
                    y = y + 2;
            }
            else if (key == 'l')
            {
                if ((x >= 0 && x <= 1) && (y >=1 && y <= 425))
                    x = x + 0;
                else if ((x == 417) && (y >= 33 && y <= 273))
                    x = x + 0;
                else if ((x == 855) && (y >= 33 && y <= 273))
                    x = x + 0;
                else
                    x = x - 2;
            }
            else if (key == 'r')
            {
                if ((x ==925) && (y >= 1 && y <= 425))
                    x = x + 0;
                else if ((x == 51) && (y >= 33 && y <= 273))
                    x = x + 0;
                else if ((x == 491) && (y >= 33 && y <= 273))
                    x = x + 0;
                else
                    x = x + 2;
            }
        }
        public void setKey(char c)
        {
            key = 'c';
        }
        public char getKey()
        {
            return key;
        }

        public int moveroket()
        {
            if (Rposition == 0)
                return (Rposition= 970);
            else
               return (Rposition--);
        }
    }
}
