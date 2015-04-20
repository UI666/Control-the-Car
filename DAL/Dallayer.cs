using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entity; 


namespace DAL
{
    public class Dallayer
    {
        public bool save(int speed)
        {
            try
            {
                StreamWriter w = new StreamWriter("D:\\Speed.txt");
                w.WriteLine(speed);
                w.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Car getData()
        {
            Car c = new Car();
            try
            {
                StreamReader read = new StreamReader("D:\\Speed.txt");
                c.speed = Convert.ToInt32(read.ReadLine());
                read.Close();
                return c;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
