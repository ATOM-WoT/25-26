using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_26
{
    public partial class Marathon_skills_2016 : Form
    {
        public Marathon_skills_2016()
        {
            InitializeComponent();
        }

        private void roundBtn1_Click(object sender, EventArgs e)
        {
            Marathone_Skills_2016 AddInfo = new Marathone_Skills_2016();
            AddInfo.Owner = this;
            AddInfo.ShowDialog();
        }

        private void roundBtn2_Click_1(object sender, EventArgs e)
        {
            Time AddTime = new Time();
            AddTime.Owner = this;
            AddTime.ShowDialog();
        }

        private void roundBtn3_Click(object sender, EventArgs e)
        {
            BMI AddBMI = new BMI();
            AddBMI.Owner = this;
            AddBMI.ShowDialog();
        }

        private void roundBtn4_Click(object sender, EventArgs e)
        {
            BMR AddBMR = new BMR();
            AddBMR.Owner = this;
            AddBMR.ShowDialog();

        }

        private void Marathon_skills_2016_Load_1(object sender, EventArgs e)
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


     }
}

  

