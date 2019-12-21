using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kursach
{
    public partial class login : Form
    {
        //Data Source=VLAD\SQLEXPRESS;Initial Catalog=db_kursach;Integrated Security=True
        SqlConnection conn;
        SqlConnectionStringBuilder connStrBuilder;

        public login()
        {
            InitializeComponent();
        }


        void ConnectTo()
        {
            connStrBuilder = new SqlConnectionStringBuilder();
            connStrBuilder.DataSource = "VLAD\\SQLEXPRESS";
            connStrBuilder.InitialCatalog = "db_kursach";
            connStrBuilder.IntegratedSecurity = true;

            conn = new SqlConnection(connStrBuilder.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Application.Run(new Form1());
                //new Form1.ShowDialog();
                ConnectTo();
                conn.Open();
                SqlCommand command = new SqlCommand("Select dbo.go_Into(@log,@pas)", conn);
                command.Parameters.AddWithValue("@log", log.Text);
                command.Parameters.AddWithValue("@pas", pass.Text);

                String loginUser = log.Text;
                String passUser = pass.Text;

                int reader = (int)command.ExecuteScalar();
                int per = 0;
                per = reader;
                if (per > 0) {
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ошибка входа");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Подключение не состоялось");
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
              
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        Point lastPoint;

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
