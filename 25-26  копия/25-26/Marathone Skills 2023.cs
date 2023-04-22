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
    public partial class Marathone_Skills_2016 : Form
    {
        public Marathone_Skills_2016()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_map_Click(object sender, EventArgs e)
        {
            Ineractive_map AddMap = new Ineractive_map();
            AddMap.Owner = this;
            AddMap.ShowDialog();
        }

        private void lb_info2_Click(object sender, EventArgs e)
        {

        }

        private void picBox_photo2_Click(object sender, EventArgs e)
        {

        }

        private void Marathone_Skills_2016_Load(object sender, EventArgs e)
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
