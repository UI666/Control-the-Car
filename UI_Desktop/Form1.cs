using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;
using Entity;

namespace UI_Desktop
{
    public partial class UIlyear : Form
    {
        Dalaccessclass da = new Dalaccessclass();
        Car_Graphics cg = new Car_Graphics();
        Background bg = new Background();

        Graphics car;
        Graphics t1, t2, t3, t4;
        Graphics l1, l2, l3;
        Graphics pl;

        Char keyPress;


        public UIlyear()
        {
            InitializeComponent();
            int x = da.x;
            int y = da.y;
            keyPress = 'r';

        }

        public void ATstart()
        {
            car = car_panel.CreateGraphics();
            cg.carRight(car);

            t1 = tree1.CreateGraphics();
            t2 = tree2.CreateGraphics();
            t3 = tree3.CreateGraphics();
            t4 = treep.CreateGraphics();
            bg.drawtree(t1);
            bg.drawtree(t2);
            bg.drawtree(t3);
            bg.drawtree(t4);

            l1 = lamp1.CreateGraphics();
            l2 = lamp2.CreateGraphics();
            l3 = lamp3.CreateGraphics();
            bg.drawlamppost(l1);
            bg.drawlamppost(l2);
            bg.drawlamppost(l3);

            pl = panelroket.CreateGraphics();
            bg.drawRoket(pl);


        }

        private void start_button_Click(object sender, EventArgs e)
        {
            switch (keyPress)
            {
                case 'u':
                    cg.carUp(car);
                    break;
                case 'd':
                    cg.carDown(car);
                    break;
                case 'r':
                    cg.carRight(car);
                    break;
                case 'l':
                    cg.carLeft(car);
                    break;
            }
            notilabel.Text = null;
            int s = da.speedCalculation();
            if (s != 0 && !String.IsNullOrEmpty(speedbox.Text))
            {
                timer1.Interval = da.speedCalculation();
                timer1.Start();
            }
            else if(s==0)
            {
                MessageBox.Show("Please Enter speed into 100!!!");
            }
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            ATstart();
            Car c = new Car();
            try
            {
                c.speed = Convert.ToInt32(speedbox.Text);
                bool result = da.saveSpeed(c);
                notilabel.Text = "Now Press the Start Button";
            }
            catch
            {
                notilabel.Text = null;
                speedbox.Text = null;
                MessageBox.Show("Enter Only Integer!!!");       
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            da.changeAxes(keyPress);
            car_panel.Location = new Point(da.x, da.y);
            panelroket.Location = new Point(da.moveroket(), 3);
            
        }

        private void UIlyear_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                keyPress = 'u';
                car.Clear(Color.ForestGreen);
                cg.carUp(car);
            }
            else if (e.KeyCode == Keys.Down)
            {
                keyPress = 'd';
                car.Clear(Color.ForestGreen);
                cg.carDown(car);
            }
            else if (e.KeyCode == Keys.Left)
            {
                keyPress = 'l';
                car.Clear(Color.ForestGreen);
                cg.carLeft(car);
            }
            else if (e.KeyCode == Keys.Right)
            {
                keyPress = 'r';
                car.Clear(Color.ForestGreen);
                cg.carRight(car);
            }
        }

        private void battonholderpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UIlyear_Load(object sender, EventArgs e)
        {

        }

        private void car_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel68_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
