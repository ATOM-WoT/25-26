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
    public partial class BMR : Form
    {
        bool man;
        bool woman;
        public BMR()
        {
            InitializeComponent();
            picBox_info.Visible = false;
            lb_120.Visible = false;
            lb_137.Visible = false;
            lb_155.Visible = false;
            lb_172.Visible = false;
            lb_190.Visible = false;  
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            if (man)
            {
                double BMR = Convert.ToDouble(88.362) + (Convert.ToDouble(13.397) * Convert.ToDouble(tBox_ves.Text)) + (Convert.ToDouble(4.799) * Convert.ToDouble(tBox_rost.Text)) - (Convert.ToDouble(5.677) * Convert.ToDouble(tBox_year.Text));
                lb_BMR.Text = Convert.ToString(Math.Round(BMR, 0));
                lb_BMR.Left = 900;
                lb_noactiv2.Text = Convert.ToString(Math.Round(BMR, 0) / 100 * 120);
                lb_maloactiv2.Text = Convert.ToString(Math.Round(BMR, 0) / 100 * 137);
                lb_normactiv2.Text = Convert.ToString(Math.Round(BMR, 0) / 100 * 155);
                lb_mnogoactiv2.Text = Convert.ToString(Math.Round(BMR, 0) / 100 * 172);
                lb_overmnogoactiv2.Text = Convert.ToString(Math.Round(BMR, 0) / 100 * 190);
            }
            if (woman)
            {
                double BMR = Convert.ToDouble(447.593) + (Convert.ToDouble(9.247) * Convert.ToDouble(tBox_ves.Text)) + (Convert.ToDouble(3.098) * Convert.ToDouble(tBox_rost.Text)) - (Convert.ToDouble(4.330) * Convert.ToDouble(tBox_year.Text));
                lb_BMR.Text = Convert.ToString(Math.Round(BMR, 0));
                lb_BMR.Left = 900;
                lb_noactiv2.Text = Convert.ToString(Math.Round(BMR, 0) / 100 * 120);
                lb_maloactiv2.Text = Convert.ToString(Math.Round(BMR, 0) / 100 * 137);
                lb_normactiv2.Text = Convert.ToString(Math.Round(BMR, 0) / 100 * 155);
                lb_mnogoactiv2.Text = Convert.ToString(Math.Round(BMR, 0) / 100 * 172);
                lb_overmnogoactiv2.Text = Convert.ToString(Math.Round(BMR, 0) / 100 * 190);
            }
        }

        private void btn_man_Click(object sender, EventArgs e)
        {
            man = true;
            woman = false;
            if (man)
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

        private void BMR_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void btn_info_MouseHover(object sender, EventArgs e)
        {
            lb_120.Visible = true;
            lb_137.Visible = true;
            lb_155.Visible = true;
            lb_172.Visible = true;
            lb_190.Visible = true;
            picBox_info.Visible = true;
        }

        private void btn_info_MouseLeave(object sender, EventArgs e)
        {
            picBox_info.Visible = false;
            lb_120.Visible = false;
            lb_137.Visible = false;
            lb_155.Visible = false;
            lb_172.Visible = false;
            lb_190.Visible = false;
        }

        private void lb_yourBMR_Click(object sender, EventArgs e)
        {

        }

        private void lb_everyday_Click(object sender, EventArgs e)
        {

        }

        private void lb_BMRcalc_Click(object sender, EventArgs e)
        {

        }

        private void BMR_Load(object sender, EventArgs e)
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
