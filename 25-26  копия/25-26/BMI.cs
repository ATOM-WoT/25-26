using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_26
{
    public partial class BMI : Form
    {
        bool man;
        bool woman;
        public BMI()
        {
            InitializeComponent();
            Point[] points = new Point[3];
            points[0].X = 10; points[0].Y = 10;
            points[1].X = 50; points[1].Y = 10;
            points[2].X = 30; points[2].Y = 45;
            Bitmap bmp = new Bitmap(picBox_triangle.Width, picBox_triangle.Height);
            using (Graphics grfx = Graphics.FromImage(bmp))
            {
                grfx.Clear(Color.White);
                grfx.DrawPolygon(Pens.Black, points);
            }
            picBox_triangle.Image = bmp;
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_man_Click(object sender, EventArgs e)
        {
            man = true;
            woman = false;
            if(man)
            {
                btn_man.FlatStyle = FlatStyle.Flat;
                btn_woman.FlatStyle = FlatStyle.Standard;
            }
        }

        private void btn_woman_Click(object sender, EventArgs e)
        {
            man = false;
            woman = true;
            if (woman)
            {
                btn_woman.FlatStyle = FlatStyle.Flat;
                btn_man.FlatStyle = FlatStyle.Standard;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            if (man || woman)
            {
                picBox_triangle.Image = null;
                Point[] points = new Point[3];
                points[0].X = 10; points[0].Y = 10;
                points[1].X = 50; points[1].Y = 10;
                points[2].X = 30; points[2].Y = 45;
                double a = Convert.ToInt32(tBox_ves.Text);
                double b = Convert.ToDouble(tBox_rost.Text) / 100;
                double BMI = a / (b * b);
                if (BMI < Convert.ToDouble(18.5))
                {
                    picBox_BMI.Image = Properties.Resources.malovesa;
                    lb_BMI.Text = "Недостаточный";
                }
                if (BMI >= Convert.ToDouble(18.5) && BMI <= Convert.ToDouble(24.9))
                {
                    picBox_BMI.Image = Properties.Resources.normvesa;
                    lb_BMI.Text = "Здоровый";
                }
                if (BMI >= Convert.ToDouble(25) && BMI <= Convert.ToDouble(29.9))
                {
                    picBox_BMI.Image = Properties.Resources.mnogovesa;
                    lb_BMI.Text = "Избыточный";
                }
                if (BMI > Convert.ToDouble(29.9))
                {
                    picBox_BMI.Image = Properties.Resources.overmnogovesa;
                    lb_BMI.Text = "Ожирение";
                }
                lb_BMI2.Left = 613;
                lb_BMI2.Text = Convert.ToString(Math.Round(BMI, 1));
                for (int i = 0; i < Convert.ToInt32(BMI); i++)
                {
                    if (lb_BMI2.Left >= 613 && lb_BMI2.Left <= 735)
                    {
                        lb_BMI2.Left = lb_BMI2.Left + 6;
                        points[0].X = points[0].X + 6;
                        points[1].X = points[1].X + 6;
                        points[2].X = points[2].X + 6;
                    }
                    if (lb_BMI2.Left > 735 && lb_BMI2.Left <= 880)
                    {
                        lb_BMI2.Left = lb_BMI2.Left + 28;
                        points[0].X = points[0].X + 28;
                        points[1].X = points[1].X + 28;
                        points[2].X = points[2].X + 28;
                    }
                    if (lb_BMI2.Left > 880 && lb_BMI2.Left <= 1035)
                    {
                        lb_BMI2.Left = lb_BMI2.Left + 31;
                        points[0].X = points[0].X + 31;
                        points[1].X = points[1].X + 31;
                        points[2].X = points[2].X + 31;
                    }
                    if (lb_BMI2.Left > 1035 && lb_BMI2.Left < 1180)
                    {
                        lb_BMI2.Left = lb_BMI2.Left + 10;
                        points[0].X = points[0].X + 10;
                        points[1].X = points[1].X + 10;
                        points[2].X = points[2].X + 10;
                    }
                }
                Bitmap bmp = new Bitmap(picBox_triangle.Width, picBox_triangle.Height);
                using (Graphics grfx = Graphics.FromImage(bmp))
                {
                    grfx.Clear(Color.White);
                    grfx.DrawPolygon(Pens.Black, points);
                }
                picBox_triangle.Image = bmp;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BMI_Load(object sender, EventArgs e)
        {
            DateTime targetDate = new DateTime(2023, 6, 10, 8, 0, 0); // заданная дата
            TimeSpan remainingTime = targetDate - DateTime.Now; // расчет времени до заданной даты

            string timeLeft = String.Format("{0} дней {1} часов {2} минут {3} секунд: осталось, до начала марафона",
                remainingTime.Days, remainingTime.Hours, remainingTime.Minutes, remainingTime.Seconds); // форматирование текста

            lb_time.Text = timeLeft; // вывод текста в Label.

            Timer timer = new Timer();
            timer.Interval = 1000; // интервал таймера в сек
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime targetDate = new DateTime(2023, 6, 10, 8, 0, 0); // заданная дата
            TimeSpan remainingTime = targetDate - DateTime.Now; // расчет времени до заданной даты

            string timeLeft = String.Format("{0} дней {1} часов {2} минут {3} секунд: осталось, до начала марафона",
                remainingTime.Days, remainingTime.Hours, remainingTime.Minutes, remainingTime.Seconds); // форматирование текста

            lb_time.Text = timeLeft; // вывод текста в Label
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
