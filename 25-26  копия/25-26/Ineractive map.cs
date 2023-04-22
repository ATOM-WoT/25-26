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
    public partial class Ineractive_map : Form
    {
        public Ineractive_map()
        {
            InitializeComponent();
            btn_exit.Visible = false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_item1_Click(object sender, EventArgs e)
        {
            picBox_info.BorderStyle = BorderStyle.FixedSingle;
            picBox_info.BackColor = Color.LightGray;
            lb_check.Text = "Остановка 1";
            lb_check.BackColor = Color.LightGray;
            lb_landmark.Text = "Ориентир:";
            lb_landmark.BackColor = Color.LightGray;
            lb_name.Text = "Парк Ибирапуэры";
            lb_name.BackColor = Color.LightGray;
            lb_services.Text = "Предоставляемые услуги:";
            lb_services.BackColor = Color.LightGray;
            lb_serv1.Text = "Медпункт";
            lb_serv1.BackColor = Color.LightGray;
            picBox_icon1.Image = Properties.Resources.medical;
            lb_serv2.Text = "Напитки";
            lb_serv2.BackColor = Color.LightGray;
            picBox_icon2.Image = Properties.Resources.drinks;
            lb_serv3.Text = "Туалеты";
            lb_serv3.BackColor = Color.LightGray;
            picBox_icon3.Image = Properties.Resources.toilets;
            btn_exit.Visible = true;
        }

        private void btn_item2_Click(object sender, EventArgs e)
        {
            picBox_info.BorderStyle = BorderStyle.FixedSingle;
            picBox_info.BackColor = Color.LightGray;
            lb_check.Text = "Остановка 2";
            lb_check.BackColor = Color.LightGray;
            lb_landmark.Text = "Ориентир:";
            lb_landmark.BackColor = Color.LightGray;
            lb_name.Text = "Авенида Паулиста";
            lb_name.BackColor = Color.LightGray;
            lb_services.Text = "Предоставляемые услуги:";
            lb_services.BackColor = Color.LightGray;
            lb_serv1.Text = "Медпункт";
            lb_serv1.BackColor = Color.LightGray;
            picBox_icon1.Image = Properties.Resources.medical;
            lb_serv2.Text = "Энергетики";
            lb_serv2.BackColor = Color.LightGray;
            picBox_icon2.Image = Properties.Resources.energy;
            lb_serv3.Text = "Информация";
            lb_serv3.BackColor = Color.LightGray;
            picBox_icon3.Image = Properties.Resources.info;
            btn_exit.Visible = true;
        }

        private void btn_item3_Click(object sender, EventArgs e)
        {
            picBox_info.BorderStyle = BorderStyle.FixedSingle;
            picBox_info.BackColor = Color.LightGray;
            lb_check.Text = "Остановка 3";
            lb_check.BackColor = Color.LightGray;
            lb_landmark.Text = "Ориентир:";
            lb_landmark.BackColor = Color.LightGray;
            lb_name.Text = "Музей футбола";
            lb_name.BackColor = Color.LightGray;
            lb_services.Text = "Предоставляемые услуги:";
            lb_services.BackColor = Color.LightGray;
            lb_serv1.Text = "Туалеты";
            lb_serv1.BackColor = Color.LightGray;
            picBox_icon1.Image = Properties.Resources.toilets;
            lb_serv2.Text = "Напитки";
            lb_serv2.BackColor = Color.LightGray;
            picBox_icon2.Image = Properties.Resources.drinks;
            lb_serv3.Text = "Информация";
            lb_serv3.BackColor = Color.LightGray;
            picBox_icon3.Image = Properties.Resources.info;
            btn_exit.Visible = true;
        }

        private void btn_item4_Click(object sender, EventArgs e)
        {
            picBox_info.BorderStyle = BorderStyle.FixedSingle;
            picBox_info.BackColor = Color.LightGray;
            lb_check.Text = "Остановка 4";
            lb_check.BackColor = Color.LightGray;
            lb_landmark.Text = "Ориентир:";
            lb_landmark.BackColor = Color.LightGray;
            lb_name.Text = "Музей португальского языка";
            lb_name.BackColor = Color.LightGray;
            lb_services.Text = "Предоставляемые услуги:";
            lb_services.BackColor = Color.LightGray;
            lb_serv1.Text = "Медпункт";
            lb_serv1.BackColor = Color.LightGray;
            picBox_icon1.Image = Properties.Resources.medical;
            lb_serv2.Text = "Энергетики";
            lb_serv2.BackColor = Color.LightGray;
            picBox_icon2.Image = Properties.Resources.energy;
            lb_serv3.Text = "Туалеты";
            lb_serv3.BackColor = Color.LightGray;
            picBox_icon3.Image = Properties.Resources.toilets;
            btn_exit.Visible = true;
        }

        private void btn_item5_Click(object sender, EventArgs e)
        {
            picBox_info.BorderStyle = BorderStyle.FixedSingle;
            picBox_info.BackColor = Color.LightGray;
            lb_check.Text = "Остановка 5";
            lb_check.BackColor = Color.LightGray;
            lb_landmark.Text = "Ориентир:";
            lb_landmark.BackColor = Color.LightGray;
            lb_name.Text = "Пинакотека Сан-Паулу";
            lb_name.BackColor = Color.LightGray;
            lb_services.Text = "Предоставляемые услуги:";
            lb_services.BackColor = Color.LightGray;
            lb_serv1.Text = "Напитки";
            lb_serv1.BackColor = Color.LightGray;
            picBox_icon1.Image = Properties.Resources.drinks;
            lb_serv2.Text = "Энергетики";
            lb_serv2.BackColor = Color.LightGray;
            picBox_icon2.Image = Properties.Resources.energy;
            lb_serv3.Text = "Туалеты";
            lb_serv3.BackColor = Color.LightGray;
            picBox_icon3.Image = Properties.Resources.toilets;
            btn_exit.Visible = true;
        }

        private void btn_item6_Click(object sender, EventArgs e)
        {
            picBox_info.BorderStyle = BorderStyle.FixedSingle;
            picBox_info.BackColor = Color.LightGray;
            lb_check.Text = "Остановка 6";
            lb_check.BackColor = Color.LightGray;
            lb_landmark.Text = "Ориентир:";
            lb_landmark.BackColor = Color.LightGray;
            lb_name.Text = "Стадион Parque Allianz";
            lb_name.BackColor = Color.LightGray;
            lb_services.Text = "Предоставляемые услуги:";
            lb_services.BackColor = Color.LightGray;
            lb_serv1.Text = "Медпункт";
            lb_serv1.BackColor = Color.LightGray;
            picBox_icon1.Image = Properties.Resources.medical;
            lb_serv2.Text = "Информация";
            lb_serv2.BackColor = Color.LightGray;
            picBox_icon2.Image = Properties.Resources.info;
            lb_serv3.Text = "Туалеты";
            lb_serv3.BackColor = Color.LightGray;
            picBox_icon3.Image = Properties.Resources.toilets;
            btn_exit.Visible = true;
        }

        private void btn_item7_Click(object sender, EventArgs e)
        {
            picBox_info.BorderStyle = BorderStyle.FixedSingle;
            picBox_info.BackColor = Color.LightGray;
            lb_check.Text = "Остановка 7";
            lb_check.BackColor = Color.LightGray;
            lb_landmark.Text = "Ориентир:";
            lb_landmark.BackColor = Color.LightGray;
            lb_name.Text = "Museu Catavento";
            lb_name.BackColor = Color.LightGray;
            lb_services.Text = "Предоставляемые услуги:";
            lb_services.BackColor = Color.LightGray;
            lb_serv1.Text = "Энергетики";
            lb_serv1.BackColor = Color.LightGray;
            picBox_icon1.Image = Properties.Resources.energy;
            lb_serv2.Text = "Информация";
            lb_serv2.BackColor = Color.LightGray;
            picBox_icon2.Image = Properties.Resources.info;
            lb_serv3.Text = "Туалеты";
            lb_serv3.BackColor = Color.LightGray;
            picBox_icon3.Image = Properties.Resources.toilets;
            btn_exit.Visible = true;
        }

        private void btn_item8_Click(object sender, EventArgs e)
        {
            picBox_info.BorderStyle = BorderStyle.FixedSingle;
            picBox_info.BackColor = Color.LightGray;
            lb_check.Text = "Остановка 8";
            lb_check.BackColor = Color.LightGray;
            lb_landmark.Text = "Ориентир:";
            lb_landmark.BackColor = Color.LightGray;
            lb_name.Text = "Аллея Бэтмена";
            lb_name.BackColor = Color.LightGray;
            lb_services.Text = "Предоставляемые услуги:";
            lb_services.BackColor = Color.LightGray;
            lb_serv1.Text = "Медпункт";
            lb_serv1.BackColor = Color.LightGray;
            picBox_icon1.Image = Properties.Resources.medical;
            lb_serv2.Text = "Информация";
            lb_serv2.BackColor = Color.LightGray;
            picBox_icon2.Image = Properties.Resources.info;
            lb_serv3.Text = "Напитки";
            lb_serv3.BackColor = Color.LightGray;
            picBox_icon3.Image = Properties.Resources.drinks;
            btn_exit.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            picBox_info.BorderStyle = BorderStyle.None;
            picBox_info.BackColor = Color.White;
            lb_check.Text = "";
            lb_check.BackColor = Color.White;
            lb_landmark.Text = "";
            lb_landmark.BackColor = Color.White;
            lb_name.Text = "";
            lb_name.BackColor = Color.LightGray;
            lb_services.Text = "";
            lb_services.BackColor = Color.White;
            lb_serv1.Text = "";
            lb_serv1.BackColor = Color.White;
            picBox_icon1.Image = null; ;
            lb_serv2.Text = "";
            lb_serv2.BackColor = Color.White;
            picBox_icon2.Image = null;
            lb_serv3.Text = "";
            lb_serv3.BackColor = Color.White;
            picBox_icon3.Image = null;
            btn_exit.Visible = false;
        }

        private void btn_start1_Click(object sender, EventArgs e)
        {
            picBox_info.BorderStyle = BorderStyle.FixedSingle;
            picBox_info.BackColor = Color.LightGray;
            lb_check.Text = "Старт";
            lb_check.BackColor = Color.LightGray;
            lb_landmark.Text = "Полный марафон самбы";
            lb_landmark.BackColor = Color.LightGray;
            lb_name.Text = "";
            lb_name.BackColor = Color.White;
            lb_services.Text = "";
            lb_services.BackColor = Color.White;
            lb_serv1.Text = "Медпункт";
            lb_serv1.BackColor = Color.LightGray;
            picBox_icon1.Image = Properties.Resources.medical;
            lb_serv2.Text = "Информация";
            lb_serv2.BackColor = Color.LightGray;
            picBox_icon2.Image = Properties.Resources.info;
            lb_serv3.Text = "Туалет";
            lb_serv3.BackColor = Color.LightGray;
            picBox_icon3.Image = Properties.Resources.toilets;
            btn_exit.Visible = true;
        }

        private void btn_start2_Click(object sender, EventArgs e)
        {
            picBox_info.BorderStyle = BorderStyle.FixedSingle;
            picBox_info.BackColor = Color.LightGray;
            lb_check.Text = "Старт";
            lb_check.BackColor = Color.LightGray;
            lb_landmark.Text = "Полумарафон Джонго";
            lb_landmark.BackColor = Color.LightGray;
            lb_name.Text = "";
            lb_name.BackColor = Color.White;
            lb_services.Text = "";
            lb_services.BackColor = Color.White;
            lb_serv1.Text = "Медпункт";
            lb_serv1.BackColor = Color.LightGray;
            picBox_icon1.Image = Properties.Resources.medical;
            lb_serv2.Text = "Информация";
            lb_serv2.BackColor = Color.LightGray;
            picBox_icon2.Image = Properties.Resources.info;
            lb_serv3.Text = "Туалет";
            lb_serv3.BackColor = Color.LightGray;
            picBox_icon3.Image = Properties.Resources.toilets;
            btn_exit.Visible = true;
        }

        private void btn_start3_Click(object sender, EventArgs e)
        {
            picBox_info.BorderStyle = BorderStyle.FixedSingle;
            picBox_info.BackColor = Color.LightGray;
            lb_check.Text = "Старт";
            lb_check.BackColor = Color.LightGray;
            lb_landmark.Text = "Веселый марафон\nКапойеры";
            lb_landmark.BackColor = Color.LightGray;
            lb_name.Text = "";
            lb_name.BackColor = Color.White;
            lb_services.Text = "";
            lb_services.BackColor = Color.White;
            lb_serv1.Text = "Медпункт";
            lb_serv1.BackColor = Color.LightGray;
            picBox_icon1.Image = Properties.Resources.medical;
            lb_serv2.Text = "Информация";
            lb_serv2.BackColor = Color.LightGray;
            picBox_icon2.Image = Properties.Resources.info;
            lb_serv3.Text = "Туалет";
            lb_serv3.BackColor = Color.LightGray;
            picBox_icon3.Image = Properties.Resources.toilets;
            btn_exit.Visible = true;
        }

        private void picBox_map_Click(object sender, EventArgs e)
        {

        }

        private void lb_Marathone_Click(object sender, EventArgs e)
        {

        }
    }
}
