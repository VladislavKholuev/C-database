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
    public partial class waater : Form
    {
        public void objectsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            // MessageBox.Show("Ошибка ввода!");
            anError.ThrowException = false;
        }

        public waater()
        {
            InitializeComponent();
            waterDataGridView.DataError += new DataGridViewDataErrorEventHandler(objectsDataGridView_DataError);
            waterDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            waterDataGridView.AllowUserToAddRows = false;
            waterDataGridView.ReadOnly = true;
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

        private void gasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_kursachDataSet);

        }

        private void waater_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_kursachDataSet.water' table. You can move, or remove it, as needed.
            this.waterTableAdapter.Fill(this.db_kursachDataSet.water);
            // TODO: This line of code loads data into the 'db_kursachDataSet.gas' table. You can move, or remove it, as needed.
            this.gasTableAdapter.Fill(this.db_kursachDataSet.gas);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                waterBindingSource.EndEdit();
                waterTableAdapter.Update(db_kursachDataSet);
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
                SqlCommand command = new SqlCommand("updateWaterAdmin", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter idparam = new SqlParameter
                {
                    ParameterName = "@id_sElectro",
                    Value = Convert.ToInt32(id_waterTextBox.Text)
                };
                command.Parameters.Add(idparam);
                SqlParameter nameparam = new SqlParameter
                {
                    ParameterName = "@id_object",
                    Value = Convert.ToInt32(id_objectTextBox.Text)
                };
                command.Parameters.Add(nameparam);

                SqlParameter locparam = new SqlParameter
                {
                    ParameterName = "@dat",
                    Value = dataDateTimePicker.Value.ToString("yyyyMMdd")

                };
                command.Parameters.Add(locparam);

                SqlParameter streetparam = new SqlParameter
                {
                    ParameterName = "@energyres",
                    Value = Convert.ToInt32(m3TextBox.Text)
                };
                command.Parameters.Add(streetparam);
                SqlParameter buildparam = new SqlParameter
                {
                    ParameterName = "@total",
                    Value = Convert.ToDecimal(totalTextBox.Text)
                };
                command.Parameters.Add(buildparam);

                command.ExecuteNonQuery();

                waterTableAdapter.Update(db_kursachDataSet);
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка данных");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in waterDataGridView.SelectedRows)
            {
                waterDataGridView.Rows.Remove(row);

            }
            try
            {
                waterTableAdapter.Update(db_kursachDataSet);
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка данных");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                waterBindingSource.AddNew();
            }
            catch (Exception)
            {
                MessageBox.Show("что-то не так");
            }
        }

        Point lastPoint;

        private void waater_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void waater_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
