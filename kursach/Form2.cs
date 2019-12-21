using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//обернуть все в try catch
namespace kursach
{
    public partial class Form2 : Form
    {
        objects ob = new objects();
        personal per = new personal();
        loginss log = new loginss();
        electro electro = new electro();
        heats heat = new heats();
        gass gas = new gass();
        waater water = new waater();
        oilProduce oilProduce = new oilProduce();
        waterInjection waterInjection = new waterInjection();
        login login = new login();
        

        public Form2()
        {
            InitializeComponent();
            login.Owner = this;
            login.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void objbut_Click(object sender, EventArgs e)
        {
            ob.Show();
        }

        private void personalbut_Click(object sender, EventArgs e)
        {
            per.Show();
        }

        private void logbut_Click(object sender, EventArgs e)
        {
            log.Show();
        }

        private void electrobut_Click(object sender, EventArgs e)
        {
            electro.Show();
        }

        private void heatbut_Click(object sender, EventArgs e)
        {
            heat.Show();
        }

        private void gasbut_Click(object sender, EventArgs e)
        {

            gas.Show();
        }

        private void waterbut_Click(object sender, EventArgs e)
        {

            water.Show(); 
        }

        private void dobychabut_Click(object sender, EventArgs e)
        {
            oilProduce.Show();
        }

        private void watInjectbut_Click(object sender, EventArgs e)
        {
            waterInjection.Show();
        }
        Point lastPoint;
        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void logg_Click(object sender, EventArgs e)
        {
            loggs loggs = new loggs();
            loggs.Show();
        }
    }
}
