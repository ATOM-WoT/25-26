using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_26
{
    public partial class Time : Form
    {
        public Time()
        {
            InitializeComponent();
            tabC_SAD.SelectedIndex = 1;
            picBox_object.Image = Properties.Resources.bus;
            lb_name.Text = "Автобус";
            lb_name.Left = 270;
            lb_object_info.Text = "Длина " + lb_name.Text + "а составляет " + 10 + " метров.\nЭто займёт " + 42000/10 + " из них,чтобы покрыть расстояние\nв 42 км. марафона.";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tabC_SAD_Click(object sender, EventArgs e)
        {
            if (tabC_SAD.SelectedIndex == 0)
            {
                picBox_object.Image = Properties.Resources.jaguar;
                lb_name.Left = 270;
                lb_name.Text = "Ягуар";
                lb_object_info.Text = "Максимальная скорость объекта " + lb_name.Text + "\nсоставляет " + 80 + " км/ч. Это займёт " + 42000 / (80000 / 3600) / 60 + " минут,\nчтобы завершить марафон в 42 км.";
            }
            if (tabC_SAD.SelectedIndex == 1)
            {
                picBox_object.Image = Properties.Resources.bus;
                lb_name.Left = 270;
                lb_name.Text = "Автобус";
                lb_object_info.Text = "Длина объекта " + lb_name.Text + " составляет " + 10 + " метров.\nЭто займёт " + 42000 / 10 + " из них,чтобы покрыть расстояние\nв 42 км. марафона.";
            }
        }

        private void btn_car_Click(object sender, EventArgs e)
        {
            picBox_object.Image = Properties.Resources.car;
            lb_name.Left = 270;
            lb_name.Text = "Машина";
            lb_object_info.Text = "Максимальная скорость объекта " + lb_name.Text + "\nсоставляет " + 345 + " км/ч. Это займёт " + 42000 / (345000 / 3600) / 60 + " минут,\nчтобы завершить марафон в 42 км.";
        }

        private void btn_worm_Click(object sender, EventArgs e)
        {
            picBox_object.Image = Properties.Resources.worm;
            lb_name.Left = 270;
            lb_name.Text = "Червь";
            lb_object_info.Text = "Максимальная скорость объекта " + lb_name.Text + "\nсоставляет " + Convert.ToDouble(0.03) + " км/ч. Это займёт " + Convert.ToDouble(42000) / (Convert.ToDouble(30) / Convert.ToDouble(3600)) / Convert.ToDouble(60) + " минут,\nчтобы завершить марафон в 42 км.";
        }

        private void btn_sloth_Click(object sender, EventArgs e)
        {
            picBox_object.Image = Properties.Resources.sloth;
            lb_name.Left = 270;
            lb_name.Text = "Ленивец";
            lb_object_info.Text = "Максимальная скорость объекта " + lb_name.Text + "\nсоставляет " + Convert.ToDouble(0.12) + " км/ч. Это займёт " + Convert.ToDouble(42000) / (Convert.ToDouble(120) / Convert.ToDouble(3600)) / Convert.ToDouble(60) + " минут,\nчтобы завершить марафон в 42 км.";
        }

        private void btn_capybara_Click(object sender, EventArgs e)
        {
            picBox_object.Image = Properties.Resources.capybara;
            lb_name.Left = 230;
            lb_name.Text = "Водосвинка";
            lb_object_info.Text = "Максимальная скорость объекта " + lb_name.Text + "\nсоставляет " + 35 + " км/ч. Это займёт " + 42000 / (35000 / 3600) / 60 + " минут,\nчтобы завершить марафон в 42 км.";
        }

        private void btn_jaguar_Click(object sender, EventArgs e)
        {
            picBox_object.Image = Properties.Resources.jaguar;
            lb_name.Left = 270;
            lb_name.Text = "Ягуар";
            lb_object_info.Text = "Максимальная скорость объекта " + lb_name.Text + "\nсоставляет " + 80 + " км/ч. Это займёт " + 42000 / (80000 / 3600) / 60 + " минут,\nчтобы завершить марафон в 42 км.";
        }

        private void btn_air_Click(object sender, EventArgs e)
        {
            picBox_object.Image = Properties.Resources.air;
            lb_name.Left = 270;
            lb_name.Text = "Самолёт";
            lb_object_info.Text = "Длина объекта " + lb_name.Text + " составляет " + 73 + " метров.\nЭто займёт " + 42000 / 73 + " из них,чтобы покрыть расстояние\nв 42 км. марафона";
        }

        private void btn_havai_Click(object sender, EventArgs e)
        {
            picBox_object.Image = Properties.Resources.havai;
            lb_name.Left = 220;
            lb_name.Text = "Пара гавайан";
            lb_object_info.Text = "Длина объекта " + lb_name.Text + " составляет " + Convert.ToDouble(0.245) + " метров.\nЭто займёт " + Convert.ToInt32(42000 / Convert.ToDouble(0.245)) + " из них,чтобы покрыть расстояние\nв 42 км. марафона";
        }

        private void btn_footbal_Click(object sender, EventArgs e)
        {
            picBox_object.Image = Properties.Resources.footbal;
            lb_name.Left = 170;
            lb_name.Text = "Футбольное поле";
            lb_object_info.Text = "Длина объекта " + lb_name.Text + " составляет " + 105 + " метров.\nЭто займёт " + 42000 / 105 + " из них,чтобы покрыть расстояние\nв 42 км. марафона";
        }

        private void btn_Ronaldo_Click(object sender, EventArgs e)
        {
            picBox_object.Image = Properties.Resources.Ronaldo;
            lb_name.Left = 270;
            lb_name.Text = "Роналдо";
            lb_object_info.Text = "Длина " + lb_name.Text + " составляет " + Convert.ToDouble(1.81) + " метров.\nЭто займёт " + Convert.ToInt32(42000 / Convert.ToDouble(1.81)) + " из них,чтобы покрыть расстояние\nв 42 км. марафона";
        }

        private void btn_bus_Click(object sender, EventArgs e)
        {
            picBox_object.Image = Properties.Resources.bus;
            lb_name.Left = 270;
            lb_name.Text = "Автобус";
            lb_object_info.Text = "Длина объекта " + lb_name.Text + " составляет " + 10 + " метров.\nЭто займёт " + 42000 / 10 + " из них,чтобы покрыть расстояние\nв 42 км. марафона.";
        }

        private void tabC_SAD_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Time_Load(object sender, EventArgs e)
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
