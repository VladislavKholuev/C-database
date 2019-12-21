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
    public partial class personal : Form
    {
        public void objectsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            // MessageBox.Show("Ошибка ввода!");
            anError.ThrowException = false;
        }

        public personal()
        {
            InitializeComponent();
            personalDataGridView.DataError += new DataGridViewDataErrorEventHandler(objectsDataGridView_DataError);
            personalDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            personalDataGridView.AllowUserToAddRows = false;
            personalDataGridView.ReadOnly = true;
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

        private void personalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_kursachDataSet);

        }

        private void personal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_kursachDataSet.personal' table. You can move, or remove it, as needed.
            this.personalTableAdapter.Fill(this.db_kursachDataSet.personal);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                personalBindingSource.AddNew();
            }
            catch (Exception)
            {
                MessageBox.Show("что-то не так");
            }
        }

        Point lastPoint;

        private void personal_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void personal_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                personalBindingSource.EndEdit();
                personalTableAdapter.Update(db_kursachDataSet);
            }
            catch (Exception)
            {
                MessageBox.Show("нет данных");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectTo();
            conn.Open();
            SqlCommand command = new SqlCommand("updatePersonal", conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter idparam = new SqlParameter
            {
                ParameterName = "@id_prod",
                Value = Convert.ToInt32(id_perTextBox.Text)
            };//1
            command.Parameters.Add(idparam);
            SqlParameter nameparam = new SqlParameter
            {
                ParameterName = "@id_object",
                Value = Convert.ToInt32(id_objectTextBox.Text)
            };//2
            command.Parameters.Add(nameparam);

            SqlParameter locparam = new SqlParameter
            {
                ParameterName = "@prior",
                Value = Convert.ToInt32(priorityTextBox.Text)

            };//3
            command.Parameters.Add(locparam);

            SqlParameter streetparam = new SqlParameter
            {
                ParameterName = "@position",
                Value = positionTextBox.Text
            };//4
            command.Parameters.Add(streetparam);
            SqlParameter buildparam = new SqlParameter
            {
                ParameterName = "@surname",
                Value = surnameTextBox.Text
            };//5
            command.Parameters.Add(buildparam);

            SqlParameter factparam = new SqlParameter
            {
                ParameterName = "@name",
                Value = nameTextBox.Text
            };//6
            command.Parameters.Add(factparam);

            SqlParameter patronym = new SqlParameter
            {
                ParameterName = "@patronymic",
                Value = patronymicTextBox.Text
            };//7
            command.Parameters.Add(patronym);

            SqlParameter salar = new SqlParameter
            {
                ParameterName = "@salary",
                Value = Convert.ToDecimal(salaryTextBox.Text)
            };//8
            command.Parameters.Add(salar);

            SqlParameter phone = new SqlParameter
            {
                ParameterName = "@phone",
                Value = patronymicTextBox.Text
            };//9
            command.Parameters.Add(phone);

            command.ExecuteNonQuery();
            
                personalTableAdapter.Update(db_kursachDataSet);
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка введенных данных");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in personalDataGridView.SelectedRows)
            {
                personalDataGridView.Rows.Remove(row);

            }
            try
            {
                personalTableAdapter.Update(db_kursachDataSet);
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка данных");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
