using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UndericalLoaders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }


        Color bila = Color.FromArgb(255, 255, 255);
        Color blek = Color.FromArgb(10, 10, 10);
        Color sedinka = Color.FromArgb(43, 42, 43);
        Color seda = Color.FromArgb(128, 128, 128);
        Color gg = Color.FromArgb(19, 19, 19);
        Color top = Color.FromArgb(222, 134, 142);
        Color zaklad = Color.FromArgb(19, 20, 30);
        Color fialova = Color.FromArgb(118, 78, 229);
        Color pryc = Color.FromArgb(13, 14, 21);


        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            FormWindowState windowState = FormWindowState.Minimized;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Button1.ForeColor = Color.FromArgb(132, 86, 255);
            guna2Button1.FillColor = Color.FromArgb(26, 27, 42);
            guna2Button2.FillColor = Color.FromArgb(23, 23, 36);
            guna2Button3.FillColor = Color.FromArgb(23, 23, 36);
            guna2Button1.Image = UndericalLoaders.Properties.Resources.Nový_projekt__11_;
            guna2Button3.Image = UndericalLoaders.Properties.Resources.Nový_projekt__14_;
            guna2Button2.Image = UndericalLoaders.Properties.Resources.csgo;
            guna2Button3.ForeColor = Color.FromArgb(138, 137, 164);
            guna2Button2.ForeColor = Color.FromArgb(138, 137, 164);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2Button1.ForeColor = Color.FromArgb(138, 137, 164);
            guna2Button3.ForeColor = Color.FromArgb(132, 86, 255);
            guna2Button2.ForeColor = Color.FromArgb(138, 137, 164);
            guna2Button3.FillColor = Color.FromArgb(26, 27, 42);
            guna2Button1.FillColor = Color.FromArgb(23, 23, 36);
            guna2Button2.FillColor = Color.FromArgb(23, 23, 36);
            guna2Button1.Image = UndericalLoaders.Properties.Resources.Nový_projekt__12_;
            guna2Button3.Image = UndericalLoaders.Properties.Resources.Nový_projekt__15_;
            guna2Button2.Image = UndericalLoaders.Properties.Resources.csgo;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2Button3.Image = UndericalLoaders.Properties.Resources.Nový_projekt__14_;
            guna2Button3.ForeColor = Color.FromArgb(138, 137, 164);
            guna2Button2.FillColor = Color.FromArgb(26, 27, 42);
            guna2Button1.FillColor = Color.FromArgb(23, 23, 36);
            guna2Button3.FillColor = Color.FromArgb(23, 23, 36);
            guna2Button1.ForeColor = Color.FromArgb(138, 137, 164);
            guna2Button1.Image = UndericalLoaders.Properties.Resources.Nový_projekt__12_;
            guna2Button2.Image = UndericalLoaders.Properties.Resources.csgo2;
            guna2Button2.ForeColor = Color.FromArgb(132, 86, 255);
        }

        private void guna2Button6_MouseHover(object sender, EventArgs e)
        {
            label8.BackColor = Color.FromArgb(26, 27, 42);
            guna2Panel3.BackColor = Color.FromArgb(26, 27, 42);
            guna2PictureBox4.BackColor = Color.FromArgb(26, 27, 42);
            guna2Panel4.BackColor = Color.FromArgb(26, 27, 42);
        }



        private void guna2Button6_Click(object sender, EventArgs e)
        {
            guna2Button6.BorderColor = Color.FromArgb(35, 35, 51);
            guna2Button6.FillColor = Color.FromArgb(26, 27, 42);
            label8.BackColor = Color.FromArgb(26, 27, 42);
            guna2PictureBox4.BackColor = Color.FromArgb(26, 27, 42);
            guna2Panel3.BackColor = Color.FromArgb(26, 27, 42);
            guna2Panel4.BackColor = Color.FromArgb(26, 27, 42);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            WebClient client = new WebClient();
        
            guna2Button1.ForeColor = Color.FromArgb(132, 86, 255);
            guna2Button1.FillColor = Color.FromArgb(26, 27, 42);
            guna2Button2.FillColor = Color.FromArgb(23, 23, 36);
            guna2Button3.FillColor = Color.FromArgb(23, 23, 36);
            guna2Button1.Image = UndericalLoaders.Properties.Resources.Nový_projekt__11_;
            guna2Button3.Image = UndericalLoaders.Properties.Resources.Nový_projekt__14_;
            guna2Button2.Image = UndericalLoaders.Properties.Resources.csgo;
            guna2Button3.ForeColor = Color.FromArgb(138, 137, 164);
            guna2Button2.ForeColor = Color.FromArgb(138, 137, 164);
           
        }

        private async void injectbttn_Click(object sender, EventArgs e)
        {
            hornipryc.Start();
            button1pryc.Start();
            button1fore.Start();
            button1backcolor.Start();
            button1fillcolor.Start();
            button1image.Start();

            button2pryc.Start();
            button2fore.Start();
            button2backcolor.Start();
            button2fillcolor.Start();
            button2image.Start();

            button3pryc.Start();
            button3fore.Start();
            button3backcolor.Start();
            button3fillcolor.Start();
            button3image.Start();

            guna2panel.Start();

            button4pryc.Start();
            button4fore.Start();
            button4backcolor.Start();
            button4fillcolor.Start();
            button4image.Start();

            button5pryc.Start();
            button5fore.Start();
            button5backcolor.Start();
            button5fillcolor.Start();
            button5image.Start();

            button6pryc.Start();
            button6fore.Start();
            button6backcolor.Start();
            button6fillcolor.Start();
            button6image.Start();

            sub1fore.Start();
            sub1back.Start();
            sub1fill.Start();
            sub1fore2.Start();
            sub1back2.Start();
            sub1fill2.Start();

            sub2fore.Start();
            sub2back.Start();
            sub2fill.Start();
            sub2fore2.Start();
            sub2back2.Start();
            sub2fill2.Start();

            sub3fore.Start();
            sub3back.Start();
            sub3fill.Start();
            sub3fore3.Start();
            sub3back3.Start();
            sub3fill3.Start();

            backcolorsub3.Start();
            backcolorsub4.Start();

            injectback.Start();
            injectfore.Start();
            guna2Panel2.Hide();
            guna2Panel1.Hide();
            await Task.Delay(100);
            size.Start();

            label3.Visible = true;
            barvalabel3.Start();
            await Task.Delay(400);
            guna2PictureBox5.Visible = true;
            await Task.Delay(900);
            Process.Start("steam://rungameid/730");
            await Task.Delay(7000);
            Application.Exit();

        }

        private async void hornipryc_Tick(object sender, EventArgs e)
        {
            hornipryc.Stop();


            if (guna2Panel1.FillColor == pryc)
            {

            }
            else
            {

                guna2Panel1.FillColor = Color.FromArgb(19, 20, 30);
                await Task.Delay(10);
                guna2Panel1.FillColor = Color.FromArgb(17, 18, 28);
                await Task.Delay(10);
                guna2Panel1.FillColor = Color.FromArgb(15, 16, 26);
                await Task.Delay(10);
                guna2Panel1.FillColor = Color.FromArgb(13, 14, 21);


            }
        }

        private async void horniborder_Tick(object sender, EventArgs e)
        {
            button1pryc.Stop();


            if (guna2Button1.BorderColor == pryc)
            {

            }
            else
            {

                guna2Button1.BorderColor = Color.FromArgb(27, 27, 42);
                await Task.Delay(10);
                guna2Button1.BorderColor = Color.FromArgb(25, 25, 21);
                await Task.Delay(10);
                guna2Button1.BorderColor = Color.FromArgb(20, 16, 21);
                await Task.Delay(10);
                guna2Button1.BorderColor = Color.FromArgb(15, 15, 21);
                await Task.Delay(10);
                guna2Button1.BorderColor = Color.FromArgb(13, 14, 21);


            }
        }

        private async void button1fore_Tick(object sender, EventArgs e)
        {
            button1fore.Stop();


            if (guna2Button1.ForeColor == pryc)
            {

            }
            else
            {

                guna2Button1.ForeColor = Color.FromArgb(132, 86, 255);
                await Task.Delay(10);
                guna2Button1.ForeColor = Color.FromArgb(123, 80, 238);
                await Task.Delay(10);
                guna2Button1.ForeColor = Color.FromArgb(109, 71, 211);
                await Task.Delay(10);
                guna2Button1.ForeColor = Color.FromArgb(92, 60, 180);
                await Task.Delay(10);
                guna2Button1.ForeColor = Color.FromArgb(75, 47, 149);
                await Task.Delay(10);
                guna2Button1.ForeColor = Color.FromArgb(63, 39, 127);
                await Task.Delay(10);
                guna2Button1.ForeColor = Color.FromArgb(46, 28, 93);
                await Task.Delay(10);
                guna2Button1.ForeColor = Color.FromArgb(30, 18, 61);
                await Task.Delay(10);
                guna2Button1.ForeColor = Color.FromArgb(19, 15, 21);
                await Task.Delay(10);
                guna2Button1.ForeColor = Color.FromArgb(13, 14, 21);


            }
        }

        private async void button1backcolor_Tick(object sender, EventArgs e)
        {
            button1backcolor.Stop();


            if (guna2Button1.BackColor == pryc)
            {

            }
            else
            {

                guna2Button1.BackColor = Color.FromArgb(19, 20, 30);
                await Task.Delay(10);
                guna2Button1.BackColor = Color.FromArgb(17, 18, 28);
                await Task.Delay(10);
                guna2Button1.BackColor = Color.FromArgb(15, 16, 26);
                await Task.Delay(10);
                guna2Button1.BackColor = Color.FromArgb(13, 14, 21);


            }
        }

        private async void button1fillcolor_Tick(object sender, EventArgs e)
        {
            button1fillcolor.Stop();


            if (guna2Button1.FillColor == pryc)
            {

            }
            else
            {

                guna2Button1.FillColor = Color.FromArgb(19, 20, 30);
                await Task.Delay(10);
                guna2Button1.FillColor = Color.FromArgb(17, 18, 28);
                await Task.Delay(10);
                guna2Button1.FillColor = Color.FromArgb(15, 16, 26);
                await Task.Delay(10);
                guna2Button1.FillColor = Color.FromArgb(13, 14, 21);


            }
        }

        private async void button1image_Tick(object sender, EventArgs e)
        {
            button1image.Stop();

            await Task.Delay(10);
            guna2Button1.Hide();
        }

        private async void button2pryc_Tick(object sender, EventArgs e)
        {
            button2pryc.Stop();


            if (guna2Button2.BorderColor == pryc)
            {

            }
            else
            {

                guna2Button2.BorderColor = Color.FromArgb(27, 27, 42);
                await Task.Delay(10);
                guna2Button2.BorderColor = Color.FromArgb(25, 25, 21);
                await Task.Delay(10);
                guna2Button2.BorderColor = Color.FromArgb(20, 16, 21);
                await Task.Delay(10);
                guna2Button2.BorderColor = Color.FromArgb(15, 15, 21);
                await Task.Delay(10);
                guna2Button2.BorderColor = Color.FromArgb(13, 14, 21);


            }
        }

        private async void button2fore_Tick(object sender, EventArgs e)
        {
            button2fore.Stop();


            if (guna2Button2.ForeColor == pryc)
            {

            }
            else
            {

                guna2Button2.ForeColor = Color.FromArgb(132, 86, 255);
                await Task.Delay(10);
                guna2Button2.ForeColor = Color.FromArgb(123, 80, 238);
                await Task.Delay(10);
                guna2Button2.ForeColor = Color.FromArgb(109, 71, 211);
                await Task.Delay(10);
                guna2Button2.ForeColor = Color.FromArgb(92, 60, 180);
                await Task.Delay(10);
                guna2Button2.ForeColor = Color.FromArgb(75, 47, 149);
                await Task.Delay(10);
                guna2Button2.ForeColor = Color.FromArgb(63, 39, 127);
                await Task.Delay(10);
                guna2Button2.ForeColor = Color.FromArgb(46, 28, 93);
                await Task.Delay(10);
                guna2Button2.ForeColor = Color.FromArgb(30, 18, 61);
                await Task.Delay(10);
                guna2Button2.ForeColor = Color.FromArgb(19, 15, 21);
                await Task.Delay(10);
                guna2Button2.ForeColor = Color.FromArgb(13, 14, 21);


            }
        }

        private async void button2backcolor_Tick(object sender, EventArgs e)
        {
            button2backcolor.Stop();


            if (guna2Button2.BackColor == pryc)
            {

            }
            else
            {

                guna2Button2.BackColor = Color.FromArgb(19, 20, 30);
                await Task.Delay(10);
                guna2Button2.BackColor = Color.FromArgb(17, 18, 28);
                await Task.Delay(10);
                guna2Button2.BackColor = Color.FromArgb(15, 16, 26);
                await Task.Delay(10);
                guna2Button2.BackColor = Color.FromArgb(13, 14, 21);


            }
        }

        private async void button2fillcolor_Tick(object sender, EventArgs e)
        {
            button2fillcolor.Stop();


            if (guna2Button2.FillColor == pryc)
            {

            }
            else
            {

                guna2Button2.FillColor = Color.FromArgb(19, 20, 30);
                await Task.Delay(10);
                guna2Button2.FillColor = Color.FromArgb(17, 18, 28);
                await Task.Delay(10);
                guna2Button2.FillColor = Color.FromArgb(15, 16, 26);
                await Task.Delay(10);
                guna2Button2.FillColor = Color.FromArgb(13, 14, 21);


            }
        }

        private async void button2image_Tick(object sender, EventArgs e)
        {
            button2image.Stop();

            await Task.Delay(10);
            guna2Button2.Hide();
        }

        private async void button3pryc_Tick(object sender, EventArgs e)
        {
            button3pryc.Stop();


            if (guna2Button3.BorderColor == pryc)
            {

            }
            else
            {

                guna2Button3.BorderColor = Color.FromArgb(27, 27, 42);
                await Task.Delay(10);
                guna2Button3.BorderColor = Color.FromArgb(25, 25, 21);
                await Task.Delay(10);
                guna2Button3.BorderColor = Color.FromArgb(20, 16, 21);
                await Task.Delay(10);
                guna2Button3.BorderColor = Color.FromArgb(15, 15, 21);
                await Task.Delay(10);
                guna2Button3.BorderColor = Color.FromArgb(13, 14, 21);


            }
        }

        private async void button3fore_Tick(object sender, EventArgs e)
        {
            button3fore.Stop();


            if (guna2Button3.ForeColor == pryc)
            {

            }
            else
            {

                guna2Button3.ForeColor = Color.FromArgb(132, 86, 255);
                await Task.Delay(10);
                guna2Button3.ForeColor = Color.FromArgb(123, 80, 238);
                await Task.Delay(10);
                guna2Button3.ForeColor = Color.FromArgb(109, 71, 211);
                await Task.Delay(10);
                guna2Button3.ForeColor = Color.FromArgb(92, 60, 180);
                await Task.Delay(10);
                guna2Button3.ForeColor = Color.FromArgb(75, 47, 149);
                await Task.Delay(10);
                guna2Button3.ForeColor = Color.FromArgb(63, 39, 127);
                await Task.Delay(10);
                guna2Button3.ForeColor = Color.FromArgb(46, 28, 93);
                await Task.Delay(10);
                guna2Button3.ForeColor = Color.FromArgb(30, 18, 61);
                await Task.Delay(10);
                guna2Button3.ForeColor = Color.FromArgb(19, 15, 21);
                await Task.Delay(10);
                guna2Button3.ForeColor = Color.FromArgb(13, 14, 21);


            }
        }

        private async void button3backcolor_Tick(object sender, EventArgs e)
        {
            button3backcolor.Stop();


            if (guna2Button3.BackColor == pryc)
            {

            }
            else
            {

                guna2Button3.BackColor = Color.FromArgb(19, 20, 30);
                await Task.Delay(10);
                guna2Button3.BackColor = Color.FromArgb(17, 18, 28);
                await Task.Delay(10);
                guna2Button3.BackColor = Color.FromArgb(15, 16, 26);
                await Task.Delay(10);
                guna2Button3.BackColor = Color.FromArgb(13, 14, 21);


            }
        }

        private async void button3fillcolor_Tick(object sender, EventArgs e)
        {
            button3fillcolor.Stop();


            if (guna2Button3.FillColor == pryc)
            {

            }
            else
            {

                guna2Button3.FillColor = Color.FromArgb(19, 20, 30);
                await Task.Delay(10);
                guna2Button3.FillColor = Color.FromArgb(17, 18, 28);
                await Task.Delay(10);
                guna2Button3.FillColor = Color.FromArgb(15, 16, 26);
                await Task.Delay(10);
                guna2Button3.FillColor = Color.FromArgb(13, 14, 21);


            }
        }

        private async void button3image_Tick(object sender, EventArgs e)
        {
            button3image.Stop();

            await Task.Delay(10);
            guna2Button3.Hide();
            await Task.Delay(10);
            guna2PictureBox3.Hide();
        }

        private async void guna2panel_Tick(object sender, EventArgs e)
        {
            guna2panel.Stop();


            if (guna2Panel2.FillColor == pryc)
            {

            }
            else
            {

                guna2Panel2.FillColor = Color.FromArgb(19, 20, 30);
                await Task.Delay(10);
                guna2Panel2.FillColor = Color.FromArgb(17, 18, 28);
                await Task.Delay(10);
                guna2Panel2.FillColor = Color.FromArgb(15, 16, 26);
                await Task.Delay(10);
                guna2Panel2.FillColor = Color.FromArgb(13, 14, 21);


            }
        }

        private async void button4pryc_Tick(object sender, EventArgs e)
        {
            button4pryc.Stop();


            if (guna2Button4.BorderColor == pryc)
            {

            }
            else
            {

                guna2Button4.BorderColor = Color.FromArgb(23, 23, 36);
                await Task.Delay(10);
                guna2Button4.BorderColor = Color.FromArgb(21, 21, 21);
                await Task.Delay(10);
                guna2Button4.BorderColor = Color.FromArgb(20, 16, 21);
                await Task.Delay(10);
                guna2Button4.BorderColor = Color.FromArgb(15, 15, 21);
                await Task.Delay(10);
                guna2Button4.BorderColor = Color.FromArgb(13, 14, 21);


            }
        }

        private async void button4fillcolor_Tick(object sender, EventArgs e)
        {
            button4fillcolor.Stop();


            if (guna2Button4.FillColor == pryc)
            {

            }
            else
            {

                guna2Button4.FillColor = Color.FromArgb(23, 23, 36);
                await Task.Delay(10);
                guna2Button4.FillColor = Color.FromArgb(21, 21, 21);
                await Task.Delay(10);
                guna2Button4.FillColor = Color.FromArgb(20, 16, 21);
                await Task.Delay(10);
                guna2Button4.FillColor = Color.FromArgb(15, 15, 21);
                await Task.Delay(10);
                guna2Button4.FillColor = Color.FromArgb(13, 14, 21);


            }
        }

        private async void button4image_Tick(object sender, EventArgs e)
        {
            button4image.Stop();

            await Task.Delay(10);
            guna2Button4.Hide();
            await Task.Delay(10);
            guna2PictureBox2.Hide();
        }

        private async void button4fore_Tick(object sender, EventArgs e)
        {
            button4fore.Stop();


            if (label2.ForeColor == pryc)
            {

            }
            else
            {

                label2.ForeColor = Color.FromArgb(212, 210, 227);
                await Task.Delay(10);
                label2.ForeColor = Color.FromArgb(194, 192, 208);
                await Task.Delay(10);
                label2.ForeColor = Color.FromArgb(163, 161, 177);
                await Task.Delay(10);
                label2.ForeColor = Color.FromArgb(143, 141, 156);
                await Task.Delay(10);
                label2.ForeColor = Color.FromArgb(123, 122, 135);
                await Task.Delay(10);
                label2.ForeColor = Color.FromArgb(100, 99, 109);
                await Task.Delay(10);
                label2.ForeColor = Color.FromArgb(67, 66, 75);
                await Task.Delay(10);
                label2.ForeColor = Color.FromArgb(36, 36, 40);
                await Task.Delay(10);
                label2.ForeColor = Color.FromArgb(19, 15, 21);
                await Task.Delay(10);
                label2.ForeColor = Color.FromArgb(13, 14, 21);


            }
        }

        private async void button5pryc_Tick(object sender, EventArgs e)
        {
            button5pryc.Stop();


            if (guna2Button5.BorderColor == pryc)
            {

            }
            else
            {

                guna2Button5.BorderColor = Color.FromArgb(23, 23, 36);
                await Task.Delay(10);
                guna2Button5.BorderColor = Color.FromArgb(21, 21, 21);
                await Task.Delay(10);
                guna2Button5.BorderColor = Color.FromArgb(20, 16, 21);
                await Task.Delay(10);
                guna2Button5.BorderColor = Color.FromArgb(15, 15, 21);
                await Task.Delay(10);
                guna2Button5.BorderColor = Color.FromArgb(13, 14, 21);


            }
        }

        private async void button5fillcolor_Tick(object sender, EventArgs e)
        {
            button5fillcolor.Stop();


            if (guna2Button5.FillColor == pryc)
            {

            }
            else
            {

                guna2Button5.FillColor = Color.FromArgb(23, 23, 36);
                await Task.Delay(10);
                guna2Button5.FillColor = Color.FromArgb(21, 21, 21);
                await Task.Delay(10);
                guna2Button5.FillColor = Color.FromArgb(20, 16, 21);
                await Task.Delay(10);
                guna2Button5.FillColor = Color.FromArgb(15, 15, 21);
                await Task.Delay(10);
                guna2Button5.FillColor = Color.FromArgb(13, 14, 21);


            }
        }

        private async void button5image_Tick(object sender, EventArgs e)
        {
            button5image.Stop();

            await Task.Delay(10);
            guna2Button5.Hide();
            await Task.Delay(10);
            guna2PictureBox3.Hide();
        }

        private async void button5fore_Tick(object sender, EventArgs e)
        {
            button5fore.Stop();


            if (label7.ForeColor == pryc)
            {

            }
            else
            {

                label7.ForeColor = Color.FromArgb(212, 210, 227);
                await Task.Delay(10);
                label7.ForeColor = Color.FromArgb(194, 192, 208);
                await Task.Delay(10);
                label7.ForeColor = Color.FromArgb(163, 161, 177);
                await Task.Delay(10);
                label7.ForeColor = Color.FromArgb(143, 141, 156);
                await Task.Delay(10);
                label7.ForeColor = Color.FromArgb(123, 122, 135);
                await Task.Delay(10);
                label7.ForeColor = Color.FromArgb(100, 99, 109);
                await Task.Delay(10);
                label7.ForeColor = Color.FromArgb(67, 66, 75);
                await Task.Delay(10);
                label7.ForeColor = Color.FromArgb(36, 36, 40);
                await Task.Delay(10);
                label7.ForeColor = Color.FromArgb(19, 15, 21);
                await Task.Delay(10);
                label7.ForeColor = Color.FromArgb(13, 14, 21);


            }
        }

        private async void button6pryc_Tick(object sender, EventArgs e)
        {
            button6pryc.Stop();


            if (guna2Button6.BorderColor == pryc)
            {

            }
            else
            {

                guna2Button6.BorderColor = Color.FromArgb(23, 23, 36);
                await Task.Delay(10);
                guna2Button6.BorderColor = Color.FromArgb(21, 21, 21);
                await Task.Delay(10);
                guna2Button6.BorderColor = Color.FromArgb(20, 16, 21);
                await Task.Delay(10);
                guna2Button6.BorderColor = Color.FromArgb(15, 15, 21);
                await Task.Delay(10);
                guna2Button6.BorderColor = Color.FromArgb(13, 14, 21);


            }
        }

        private async void button6fillcolor_Tick(object sender, EventArgs e)
        {
            button6fillcolor.Stop();


            if (guna2Button6.FillColor == pryc)
            {

            }
            else
            {
                guna2Button6.FillColor = Color.FromArgb(26, 27, 42);
                await Task.Delay(10);
                guna2Button6.FillColor = Color.FromArgb(23, 23, 36);
                await Task.Delay(10);
                guna2Button6.FillColor = Color.FromArgb(21, 21, 21);
                await Task.Delay(10);
                guna2Button6.FillColor = Color.FromArgb(20, 16, 21);
                await Task.Delay(10);
                guna2Button6.FillColor = Color.FromArgb(15, 15, 21);
                await Task.Delay(10);
                guna2Button6.FillColor = Color.FromArgb(13, 14, 21);


            }
        }

        private async void button6image_Tick(object sender, EventArgs e)
        {
            button6image.Stop();

            await Task.Delay(10);
            guna2Button6.Hide();
            await Task.Delay(10);
            guna2PictureBox4.Hide();
        }

        private async void button6fore_Tick(object sender, EventArgs e)
        {
            button6fore.Stop();


            if (label8.ForeColor == pryc)
            {

            }
            else
            {

                label8.ForeColor = Color.FromArgb(212, 210, 227);
                await Task.Delay(10);
                label8.ForeColor = Color.FromArgb(194, 192, 208);
                await Task.Delay(10);
                label8.ForeColor = Color.FromArgb(163, 161, 177);
                await Task.Delay(10);
                label8.ForeColor = Color.FromArgb(143, 141, 156);
                await Task.Delay(10);
                label8.ForeColor = Color.FromArgb(123, 122, 135);
                await Task.Delay(10);
                label8.ForeColor = Color.FromArgb(100, 99, 109);
                await Task.Delay(10);
                label8.ForeColor = Color.FromArgb(67, 66, 75);
                await Task.Delay(10);
                label8.ForeColor = Color.FromArgb(36, 36, 40);
                await Task.Delay(10);
                label8.ForeColor = Color.FromArgb(19, 15, 21);
                await Task.Delay(10);
                label8.ForeColor = Color.FromArgb(13, 14, 21);

                label8.Hide();

            }
        }

        private async void button4backcolor_Tick(object sender, EventArgs e)
        {
            button4backcolor.Stop();


            if (label2.BackColor == pryc)
            {

            }
            else
            {

                label2.BackColor = Color.FromArgb(23, 23, 36);
                await Task.Delay(10);
                label2.BackColor = Color.FromArgb(21, 21, 21);
                await Task.Delay(10);
                label2.BackColor = Color.FromArgb(20, 16, 21);
                await Task.Delay(10);
                label2.BackColor = Color.FromArgb(15, 15, 21);
                await Task.Delay(10);
                label2.BackColor = Color.FromArgb(13, 14, 21);

                label2.Hide();

            }
        }

        private async void button5backcolor_Tick(object sender, EventArgs e)
        {
            button5backcolor.Stop();


            if (label7.BackColor == pryc)
            {

            }
            else
            {

                label7.BackColor = Color.FromArgb(23, 23, 36);
                await Task.Delay(10);
                label7.BackColor = Color.FromArgb(21, 21, 21);
                await Task.Delay(10);
                label7.BackColor = Color.FromArgb(20, 16, 21);
                await Task.Delay(10);
                label7.BackColor = Color.FromArgb(15, 15, 21);
                await Task.Delay(10);
                label7.BackColor = Color.FromArgb(13, 14, 21);

                label7.Hide();
            }
        }

        private async void button6backcolor_Tick(object sender, EventArgs e)
        {
            button6backcolor.Stop();


            if (label8.BackColor == pryc)
            {

            }
            else
            {

                label8.BackColor = Color.FromArgb(23, 23, 36);
                await Task.Delay(10);
                label8.BackColor = Color.FromArgb(21, 21, 21);
                await Task.Delay(10);
                label8.BackColor = Color.FromArgb(20, 16, 21);
                await Task.Delay(10);
                label8.BackColor = Color.FromArgb(15, 15, 21);
                await Task.Delay(10);
                label8.BackColor = Color.FromArgb(13, 14, 21);

                label8.Hide();

            }
        }

        private async void sub1back_Tick(object sender, EventArgs e)
        {
            sub1back.Stop();


            if (guna2Panel8.BorderColor == pryc)
            {

            }
            else
            {

                guna2Panel8.BorderColor = Color.FromArgb(23, 23, 36);
                await Task.Delay(10);
                guna2Panel8.BorderColor = Color.FromArgb(21, 21, 21);
                await Task.Delay(10);
                guna2Panel8.BorderColor = Color.FromArgb(20, 16, 21);
                await Task.Delay(10);
                guna2Panel8.BorderColor = Color.FromArgb(15, 15, 21);
                await Task.Delay(10);
                guna2Panel8.BorderColor = Color.FromArgb(13, 14, 21);


            }
        }

        private async void sub1fore_Tick(object sender, EventArgs e)
        {
            sub1fore.Stop();


            if (guna2HtmlLabel6.ForeColor == pryc)
            {

            }
            else
            {

                guna2HtmlLabel6.ForeColor = Color.FromArgb(222, 134, 142);
                await Task.Delay(10);
                guna2HtmlLabel6.ForeColor = Color.FromArgb(196, 117, 124);
                await Task.Delay(10);
                guna2HtmlLabel6.ForeColor = Color.FromArgb(171, 101, 107);
                await Task.Delay(10);
                guna2HtmlLabel6.ForeColor = Color.FromArgb(147, 86, 92);
                await Task.Delay(10);
                guna2HtmlLabel6.ForeColor = Color.FromArgb(117, 67, 71);
                await Task.Delay(10);
                guna2HtmlLabel6.ForeColor = Color.FromArgb(89, 51, 54);
                await Task.Delay(10);
                guna2HtmlLabel6.ForeColor = Color.FromArgb(69, 40, 42);
                await Task.Delay(10);
                guna2HtmlLabel6.ForeColor = Color.FromArgb(50, 29, 31);
                await Task.Delay(10);
                guna2HtmlLabel6.ForeColor = Color.FromArgb(28, 16, 17);
                await Task.Delay(10);
                guna2HtmlLabel6.ForeColor = Color.FromArgb(13, 14, 21);

                guna2HtmlLabel6.Hide();
            }
        }

        private async void sub1fill_Tick(object sender, EventArgs e)
        {
            sub1fill.Stop();


            if (guna2Panel8.FillColor == pryc)
            {

            }
            else
            {
                guna2Panel8.FillColor = Color.FromArgb(46, 38, 52);
                await Task.Delay(10);
                guna2Panel8.FillColor = Color.FromArgb(36, 30, 40);
                await Task.Delay(10);
                guna2Panel8.FillColor = Color.FromArgb(23, 19, 26);
                await Task.Delay(10);
                guna2Panel8.FillColor = Color.FromArgb(19, 20, 30);
                await Task.Delay(10);
                guna2Panel8.FillColor = Color.FromArgb(17, 18, 28);
                await Task.Delay(10);
                guna2Panel8.FillColor = Color.FromArgb(15, 16, 26);
                await Task.Delay(10);
                guna2Panel8.FillColor = Color.FromArgb(13, 14, 21);

                guna2Panel8.Hide();
            }
        }

        private async void sub1fore2_Tick(object sender, EventArgs e)
        {
            sub1fore2.Stop();


            if (guna2HtmlLabel5.ForeColor == pryc)
            {

            }
            else
            {

                guna2HtmlLabel5.ForeColor = Color.FromArgb(108, 107, 131);
                await Task.Delay(10);
                guna2HtmlLabel5.ForeColor = Color.FromArgb(91, 90, 110);
                await Task.Delay(10);
                guna2HtmlLabel5.ForeColor = Color.FromArgb(60, 59, 73);
                await Task.Delay(10);
                guna2HtmlLabel5.ForeColor = Color.FromArgb(43, 43, 53);
                await Task.Delay(10);
                guna2HtmlLabel5.ForeColor = Color.FromArgb(30, 30, 37);
                await Task.Delay(10);
                guna2HtmlLabel5.ForeColor = Color.FromArgb(13, 14, 21);

                guna2HtmlLabel5.Hide();
            }
        }

        private async void sub1back2_Tick(object sender, EventArgs e)
        {
            sub1back2.Stop();


            if (guna2Panel7.BorderColor == pryc)
            {

            }
            else
            {

                guna2Panel7.BorderColor = Color.FromArgb(23, 23, 36);
                await Task.Delay(10);
                guna2Panel7.BorderColor = Color.FromArgb(21, 21, 21);
                await Task.Delay(10);
                guna2Panel7.BorderColor = Color.FromArgb(20, 16, 21);
                await Task.Delay(10);
                guna2Panel7.BorderColor = Color.FromArgb(15, 15, 21);
                await Task.Delay(10);
                guna2Panel7.BorderColor = Color.FromArgb(13, 14, 21);


            }
        }

        private async void sub1fill2_Tick(object sender, EventArgs e)
        {
            sub1fill2.Stop();


            if (guna2Panel7.FillColor == pryc)
            {

            }
            else
            {

                guna2Panel7.FillColor = Color.FromArgb(33, 33, 48);
                await Task.Delay(10);
                guna2Panel7.FillColor = Color.FromArgb(26, 26, 37);
                await Task.Delay(10);
                guna2Panel7.FillColor = Color.FromArgb(18, 18, 26);
                await Task.Delay(10);
                guna2Panel7.FillColor = Color.FromArgb(14, 14, 20);
                await Task.Delay(10);
                guna2Panel7.FillColor = Color.FromArgb(13, 14, 21);

                guna2Panel7.Hide();
            }
        }

        private async void sub2fore_Tick(object sender, EventArgs e)
        {
            sub2fore.Stop();


            if (guna2HtmlLabel4.ForeColor == pryc)
            {

            }
            else
            {

                guna2HtmlLabel4.ForeColor = Color.FromArgb(222, 134, 142);
                await Task.Delay(10);
                guna2HtmlLabel4.ForeColor = Color.FromArgb(196, 117, 124);
                await Task.Delay(10);
                guna2HtmlLabel4.ForeColor = Color.FromArgb(171, 101, 107);
                await Task.Delay(10);
                guna2HtmlLabel4.ForeColor = Color.FromArgb(147, 86, 92);
                await Task.Delay(10);
                guna2HtmlLabel4.ForeColor = Color.FromArgb(117, 67, 71);
                await Task.Delay(10);
                guna2HtmlLabel4.ForeColor = Color.FromArgb(89, 51, 54);
                await Task.Delay(10);
                guna2HtmlLabel4.ForeColor = Color.FromArgb(69, 40, 42);
                await Task.Delay(10);
                guna2HtmlLabel4.ForeColor = Color.FromArgb(50, 29, 31);
                await Task.Delay(10);
                guna2HtmlLabel4.ForeColor = Color.FromArgb(28, 16, 17);
                await Task.Delay(10);
                guna2HtmlLabel4.ForeColor = Color.FromArgb(13, 14, 21);

                guna2HtmlLabel4.Hide();
            }
        }

        private async void sub2back_Tick(object sender, EventArgs e)
        {
            sub2back.Stop();


            if (guna2Panel6.BorderColor == pryc)
            {

            }
            else
            {

                guna2Panel6.BorderColor = Color.FromArgb(23, 23, 36);
                await Task.Delay(10);
                guna2Panel6.BorderColor = Color.FromArgb(21, 21, 21);
                await Task.Delay(10);
                guna2Panel6.BorderColor = Color.FromArgb(20, 16, 21);
                await Task.Delay(10);
                guna2Panel6.BorderColor = Color.FromArgb(15, 15, 21);
                await Task.Delay(10);
                guna2Panel6.BorderColor = Color.FromArgb(13, 14, 21);


            }
        }

        private async void sub2fill_Tick(object sender, EventArgs e)
        {
            sub2fill.Stop();


            if (guna2Panel6.FillColor == pryc)
            {

            }
            else
            {
                guna2Panel6.FillColor = Color.FromArgb(46, 38, 52);
                await Task.Delay(10);
                guna2Panel6.FillColor = Color.FromArgb(36, 30, 40);
                await Task.Delay(10);
                guna2Panel6.FillColor = Color.FromArgb(23, 19, 26);
                await Task.Delay(10);
                guna2Panel6.FillColor = Color.FromArgb(19, 20, 30);
                await Task.Delay(10);
                guna2Panel6.FillColor = Color.FromArgb(17, 18, 28);
                await Task.Delay(10);
                guna2Panel6.FillColor = Color.FromArgb(15, 16, 26);
                await Task.Delay(10);
                guna2Panel6.FillColor = Color.FromArgb(13, 14, 21);

                guna2Panel6.Hide();
            }
        }

        private async void sub2fore2_Tick(object sender, EventArgs e)
        {
            sub2fore2.Stop();


            if (guna2HtmlLabel3.ForeColor == pryc)
            {

            }
            else
            {

                guna2HtmlLabel3.ForeColor = Color.FromArgb(108, 107, 131);
                await Task.Delay(10);
                guna2HtmlLabel3.ForeColor = Color.FromArgb(91, 90, 110);
                await Task.Delay(10);
                guna2HtmlLabel3.ForeColor = Color.FromArgb(60, 59, 73);
                await Task.Delay(10);
                guna2HtmlLabel3.ForeColor = Color.FromArgb(43, 43, 53);
                await Task.Delay(10);
                guna2HtmlLabel3.ForeColor = Color.FromArgb(30, 30, 37);
                await Task.Delay(10);
                guna2HtmlLabel3.ForeColor = Color.FromArgb(13, 14, 21);

                guna2HtmlLabel3.Hide();
            }
        }

        private async void sub2back2_Tick(object sender, EventArgs e)
        {
            sub2back2.Stop();


            if (guna2Panel5.BorderColor == pryc)
            {

            }
            else
            {

                guna2Panel5.BorderColor = Color.FromArgb(23, 23, 36);
                await Task.Delay(10);
                guna2Panel5.BorderColor = Color.FromArgb(21, 21, 21);
                await Task.Delay(10);
                guna2Panel5.BorderColor = Color.FromArgb(20, 16, 21);
                await Task.Delay(10);
                guna2Panel5.BorderColor = Color.FromArgb(15, 15, 21);
                await Task.Delay(10);
                guna2Panel5.BorderColor = Color.FromArgb(13, 14, 21);


            }
        }

        private async void sub2fill2_Tick(object sender, EventArgs e)
        {
            sub2fill2.Stop();


            if (guna2Panel5.FillColor == pryc)
            {

            }
            else
            {

                guna2Panel5.FillColor = Color.FromArgb(33, 33, 48);
                await Task.Delay(10);
                guna2Panel5.FillColor = Color.FromArgb(26, 26, 37);
                await Task.Delay(10);
                guna2Panel5.FillColor = Color.FromArgb(18, 18, 26);
                await Task.Delay(10);
                guna2Panel5.FillColor = Color.FromArgb(14, 14, 20);
                await Task.Delay(10);
                guna2Panel5.FillColor = Color.FromArgb(13, 14, 21);
            }
        }

        private async void sub3fore_Tick(object sender, EventArgs e)
        {
            sub3fore.Stop();


            if (guna2HtmlLabel1.ForeColor == pryc)
            {

            }
            else
            {

                guna2HtmlLabel1.ForeColor = Color.FromArgb(112, 194, 129);
                await Task.Delay(10);
                guna2HtmlLabel1.ForeColor = Color.FromArgb(99, 174, 114);
                await Task.Delay(10);
                guna2HtmlLabel1.ForeColor = Color.FromArgb(80, 139, 92);
                await Task.Delay(10);
                guna2HtmlLabel1.ForeColor = Color.FromArgb(62, 109, 72);
                await Task.Delay(10);
                guna2HtmlLabel1.ForeColor = Color.FromArgb(46, 83, 53);
                await Task.Delay(10);
                guna2HtmlLabel1.ForeColor = Color.FromArgb(22, 40, 26);
                await Task.Delay(10);
                guna2HtmlLabel1.ForeColor = Color.FromArgb(13, 14, 21);

                guna2HtmlLabel1.Hide();

            }
        }

        private async void sub3back_Tick(object sender, EventArgs e)
        {
            sub3back.Stop();


            if (guna2Panel3.BorderColor == pryc)
            {

            }
            else
            {

                guna2Panel3.BorderColor = Color.FromArgb(23, 23, 36);
                await Task.Delay(10);
                guna2Panel3.BorderColor = Color.FromArgb(21, 21, 21);
                await Task.Delay(10);
                guna2Panel3.BorderColor = Color.FromArgb(20, 16, 21);
                await Task.Delay(10);
                guna2Panel3.BorderColor = Color.FromArgb(15, 15, 21);
                await Task.Delay(10);
                guna2Panel3.BorderColor = Color.FromArgb(13, 14, 21);


            }
        }

        private async void sub3fill_Tick(object sender, EventArgs e)
        {
            sub3fill.Stop();


            if (guna2Panel3.FillColor == pryc)
            {

            }
            else
            {
                guna2Panel3.FillColor = Color.FromArgb(26, 27, 42);
                await Task.Delay(10);
                guna2Panel3.FillColor = Color.FromArgb(23, 23, 36);
                await Task.Delay(10);
                guna2Panel3.FillColor = Color.FromArgb(21, 21, 21);
                await Task.Delay(10);
                guna2Panel3.FillColor = Color.FromArgb(20, 16, 21);
                await Task.Delay(10);
                guna2Panel3.FillColor = Color.FromArgb(15, 15, 21);
                await Task.Delay(10);
                guna2Panel3.FillColor = Color.FromArgb(13, 14, 21);
            }
        }

        private async void sub3fore3_Tick(object sender, EventArgs e)
        {
            sub3fore3.Stop();


            if (guna2HtmlLabel2.ForeColor == pryc)
            {

            }
            else
            {

                guna2HtmlLabel2.ForeColor = Color.FromArgb(108, 107, 131);
                await Task.Delay(10);
                guna2HtmlLabel2.ForeColor = Color.FromArgb(91, 90, 110);
                await Task.Delay(10);
                guna2HtmlLabel2.ForeColor = Color.FromArgb(60, 59, 73);
                await Task.Delay(10);
                guna2HtmlLabel2.ForeColor = Color.FromArgb(43, 43, 53);
                await Task.Delay(10);
                guna2HtmlLabel2.ForeColor = Color.FromArgb(30, 30, 37);
                await Task.Delay(10);
                guna2HtmlLabel2.ForeColor = Color.FromArgb(13, 14, 21);

                guna2HtmlLabel2.Hide();


            }
        }

        private async void sub3back3_Tick(object sender, EventArgs e)
        {
            sub3back3.Stop();


            if (guna2Panel4.BorderColor == pryc)
            {

            }
            else
            {

                guna2Panel4.BorderColor = Color.FromArgb(23, 23, 36);
                await Task.Delay(10);
                guna2Panel4.BorderColor = Color.FromArgb(21, 21, 21);
                await Task.Delay(10);
                guna2Panel4.BorderColor = Color.FromArgb(20, 16, 21);
                await Task.Delay(10);
                guna2Panel4.BorderColor = Color.FromArgb(15, 15, 21);
                await Task.Delay(10);
                guna2Panel4.BorderColor = Color.FromArgb(13, 14, 21);


            }
        }

        private async void sub3fill3_Tick(object sender, EventArgs e)
        {
            sub3fill3.Stop();


            if (guna2Panel4.FillColor == pryc)
            {

            }
            else
            {

                guna2Panel4.FillColor = Color.FromArgb(26, 27, 42);
                await Task.Delay(10);
                guna2Panel4.FillColor = Color.FromArgb(23, 23, 36);
                await Task.Delay(10);
                guna2Panel4.FillColor = Color.FromArgb(21, 21, 21);
                await Task.Delay(10);
                guna2Panel4.FillColor = Color.FromArgb(20, 16, 21);
                await Task.Delay(10);
                guna2Panel4.FillColor = Color.FromArgb(15, 15, 21);
                await Task.Delay(10);
                guna2Panel4.FillColor = Color.FromArgb(13, 14, 21);
            }
        }

        private async void backcolorsub3_Tick(object sender, EventArgs e)
        {
            backcolorsub3.Stop();


            if (guna2Panel4.BackColor == pryc)
            {

            }
            else
            {

                guna2Panel4.BackColor = Color.FromArgb(26, 27, 42);
                await Task.Delay(10);
                guna2Panel4.BackColor = Color.FromArgb(23, 23, 36);
                await Task.Delay(10);
                guna2Panel4.BackColor = Color.FromArgb(21, 21, 21);
                await Task.Delay(10);
                guna2Panel4.BackColor = Color.FromArgb(20, 16, 21);
                await Task.Delay(10);
                guna2Panel4.BackColor = Color.FromArgb(15, 15, 21);
                await Task.Delay(10);
                guna2Panel4.BackColor = Color.FromArgb(13, 14, 21);

                guna2Panel4.Hide();
            }
        }

        private async void backcolorsub4_Tick(object sender, EventArgs e)
        {
            backcolorsub4.Stop();


            if (guna2Panel3.BackColor == pryc)
            {

            }
            else
            {

                guna2Panel3.BackColor = Color.FromArgb(26, 27, 42);
                await Task.Delay(10);
                guna2Panel3.BackColor = Color.FromArgb(23, 23, 36);
                await Task.Delay(10);
                guna2Panel3.BackColor = Color.FromArgb(21, 21, 21);
                await Task.Delay(10);
                guna2Panel3.BackColor = Color.FromArgb(20, 16, 21);
                await Task.Delay(10);
                guna2Panel3.BackColor = Color.FromArgb(15, 15, 21);
                await Task.Delay(10);
                guna2Panel3.BackColor = Color.FromArgb(13, 14, 21);

                guna2Panel3.Hide();
            }
        }

        private async void injectback_Tick(object sender, EventArgs e)
        {
            injectback.Stop();


            if (injectbttn.FillColor == pryc)
            {

            }
            else
            {

         
             
                injectbttn.FillColor = Color.FromArgb(118, 78, 229);
                await Task.Delay(10);
                injectbttn.FillColor = Color.FromArgb(94, 62, 183);
                await Task.Delay(10);
                injectbttn.FillColor = Color.FromArgb(78, 51, 150);
                await Task.Delay(10);
                injectbttn.FillColor = Color.FromArgb(66, 44, 127);
                await Task.Delay(10);
                injectbttn.FillColor = Color.FromArgb(58, 39, 110);
                await Task.Delay(10);
                injectbttn.FillColor = Color.FromArgb(43, 29, 83);
                await Task.Delay(10);
                injectbttn.FillColor = Color.FromArgb(29, 19, 58);
                await Task.Delay(10);
                injectbttn.FillColor = Color.FromArgb(19, 15, 21);
                await Task.Delay(10);
                injectbttn.FillColor = Color.FromArgb(13, 14, 21);


            }
        }

        private async void injectfore_Tick(object sender, EventArgs e)
        {
            injectfore.Stop();


            if (injectbttn.FillColor == pryc)
            {

            }
            else
            {



                injectbttn.ForeColor = Color.FromArgb(255, 255, 255);
                await Task.Delay(10);
                injectbttn.ForeColor = Color.FromArgb(222, 222, 222);
                await Task.Delay(10);
                injectbttn.ForeColor = Color.FromArgb(185, 185, 185);
                await Task.Delay(10);
                injectbttn.ForeColor = Color.FromArgb(144, 145, 146);
                await Task.Delay(10);
                injectbttn.ForeColor = Color.FromArgb(111, 111, 111);
                await Task.Delay(10);
                injectbttn.ForeColor = Color.FromArgb(29, 19, 58);
                await Task.Delay(10);
                injectbttn.ForeColor = Color.FromArgb(19, 15, 21);
                await Task.Delay(10);
                injectbttn.ForeColor = Color.FromArgb(13, 14, 21);

                injectbttn.Hide();
            }
        }

        private async void size_Tick(object sender, EventArgs e)
        {
            size.Stop();


           
            this.Size = new Size(324, 433);
            await Task.Delay(1);
            this.Size = new Size(334, 433);
            await Task.Delay(1);
            this.Size = new Size(344, 433);
            await Task.Delay(1);
            this.Size = new Size(354, 433);
            await Task.Delay(1);
            this.Size = new Size(362, 433);
            await Task.Delay(1);
            this.Size = new Size(372, 433);
            await Task.Delay(1);
            this.Size = new Size(382, 433);
            await Task.Delay(1);
            this.Size = new Size(392, 433);
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {

            barvalabel3.Stop();


            if (label3.ForeColor == top)
            {

            }
            else
            {

                label3.ForeColor = Color.FromArgb(13, 14, 21); 
                await Task.Delay(30);
                label3.ForeColor = Color.FromArgb(26, 26, 29); 
                await Task.Delay(30);
                label3.ForeColor = Color.FromArgb(51, 51, 57); 
                await Task.Delay(30);
                label3.ForeColor = Color.FromArgb(64, 63, 71); 
                await Task.Delay(30);
                label3.ForeColor = Color.FromArgb(79, 78, 88); 
                await Task.Delay(30);
                label3.ForeColor = Color.FromArgb(124, 123, 136);
                await Task.Delay(30);
                label3.ForeColor = Color.FromArgb(147, 146, 160);
                await Task.Delay(30);
                label3.ForeColor = Color.FromArgb(171, 169, 186); 
                await Task.Delay(30);
                label3.ForeColor = Color.FromArgb(193, 191, 209);
                await Task.Delay(30);
                label3.ForeColor = Color.FromArgb(212, 210, 227); 
            }


        }

        

    }



}
