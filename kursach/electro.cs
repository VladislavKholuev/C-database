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
    public partial class electro : Form
    {
        public void objectsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            // MessageBox.Show("Ошибка ввода!");
            anError.ThrowException = false;
        }

        public electro()
        {
            InitializeComponent();
            spentElectryciteDataGridView.DataError += new DataGridViewDataErrorEventHandler(objectsDataGridView_DataError);
            spentElectryciteDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            spentElectryciteDataGridView.AllowUserToAddRows = false;
            spentElectryciteDataGridView.ReadOnly = true;
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

        private void spentElectryciteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.spentElectryciteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_kursachDataSet);

        }

        private void electro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_kursachDataSet.spentElectrycite' table. You can move, or remove it, as needed.
            this.spentElectryciteTableAdapter.Fill(this.db_kursachDataSet.spentElectrycite);

        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                spentElectryciteBindingSource.AddNew();
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
                spentElectryciteBindingSource.EndEdit();
                spentElectryciteTableAdapter.Update(db_kursachDataSet);
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
                SqlCommand command = new SqlCommand("updateElectroAdmin", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter idparam = new SqlParameter
                {
                    ParameterName = "@id_sElectro",
                    Value = Convert.ToInt32(id_sElectroTextBox.Text)
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
                    Value = Convert.ToInt32(spentElectroTextBox.Text)
                };
                command.Parameters.Add(streetparam);
                SqlParameter buildparam = new SqlParameter
                {
                    ParameterName = "@total",
                    Value = Convert.ToDecimal(totalTextBox.Text)
                };
                command.Parameters.Add(buildparam);

                command.ExecuteNonQuery();
                try
                {
                    spentElectryciteTableAdapter.Update(db_kursachDataSet);
                }
                catch (Exception)
                {
                    MessageBox.Show("ошибка данных");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка данных");
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in spentElectryciteDataGridView.SelectedRows)
            {
                spentElectryciteDataGridView.Rows.Remove(row);

            }
            try
            {
                spentElectryciteTableAdapter.Update(db_kursachDataSet);
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка в удалении");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        Point lastPoint;

        private void electro_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void electro_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
