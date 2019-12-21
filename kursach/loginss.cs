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
    public partial class loginss : Form
    {

        public void objectsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            // MessageBox.Show("Ошибка ввода!");
            anError.ThrowException = false;
        }

        public loginss()
        {
            InitializeComponent();
            loginsDataGridView.DataError += new DataGridViewDataErrorEventHandler(objectsDataGridView_DataError);
            loginsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            loginsDataGridView.AllowUserToAddRows = false;
            loginsDataGridView.ReadOnly = true;
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

        private void loginsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_kursachDataSet);

        }

        private void loginss_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_kursachDataSet.logins' table. You can move, or remove it, as needed.
            this.loginsTableAdapter.Fill(this.db_kursachDataSet.logins);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                loginsBindingSource.AddNew();
            }
            catch (Exception)
            {
                MessageBox.Show("что-то не так");
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                loginsBindingSource.EndEdit();
                loginsTableAdapter.Update(db_kursachDataSet);
            }
            catch (Exception)
            {
                MessageBox.Show("нет данных");
            }
        }

        private void change_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectTo();
                conn.Open();
                SqlCommand command = new SqlCommand("updateLogins", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter idparam = new SqlParameter
                {
                    ParameterName = "@id_sElectro",
                    Value = Convert.ToInt32(id_perTextBox.Text)
                };
                command.Parameters.Add(idparam);
                SqlParameter nameparam = new SqlParameter
                {
                    ParameterName = "@log",
                    Value = loginTextBox.Text
                };
                command.Parameters.Add(nameparam);


                SqlParameter streetparam = new SqlParameter
                {
                    ParameterName = "@energyres",
                    Value = passwordTextBox.Text
                };
                command.Parameters.Add(streetparam);


                command.ExecuteNonQuery();
                try
                {
                    loginsTableAdapter.Update(db_kursachDataSet);
                }
                catch (Exception)
                {
                    MessageBox.Show("ошибка данных");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Неккоректный ввод");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in loginsDataGridView.SelectedRows)
                {
                    loginsDataGridView.Rows.Remove(row);

                }
                loginsTableAdapter.Update(db_kursachDataSet);
            }
            catch (Exception)
            {
                MessageBox.Show("Плохое удаление");
            }
        }

        Point lastPoint;

        private void loginss_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void loginss_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
