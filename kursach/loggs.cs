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
    public partial class loggs : Form
    {
        public void objectsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            // MessageBox.Show("Ошибка ввода!");
            anError.ThrowException = false;
        }

        public loggs()
        {
            InitializeComponent();
            logsDataGridView.DataError += new DataGridViewDataErrorEventHandler(objectsDataGridView_DataError);
            logsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            logsDataGridView.AllowUserToAddRows = false;
            logsDataGridView.ReadOnly = true;
        }

        private void loggs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_kursachDataSet1.logs' table. You can move, or remove it, as needed.
            this.logsTableAdapter.Fill(this.db_kursachDataSet1.logs);

        }


        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        Point lastPoint;

        private void loggs_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void loggs_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        SqlConnection conn;
        SqlConnectionStringBuilder connStrBuilder;

        void ConnectTo()
        {
            connStrBuilder = new SqlConnectionStringBuilder();
            connStrBuilder.DataSource = "VLAD\\SQLEXPRESS";
            connStrBuilder.InitialCatalog = "db_kursach";
            connStrBuilder.IntegratedSecurity = true;

            conn = new SqlConnection(connStrBuilder.ToString());

        }

        private void del_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectTo();
                conn.Open();
                SqlCommand command = new SqlCommand("deletelogs", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.ExecuteNonQuery();

                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка в удалении");
            }
        }
    }
}
