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
    public partial class oilProduce : Form
    {

        public void objectsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            // MessageBox.Show("Ошибка ввода!");
            anError.ThrowException = false;
        }

        public oilProduce()
        {
            InitializeComponent();
            oil_productionDataGridView.DataError += new DataGridViewDataErrorEventHandler(objectsDataGridView_DataError);
            oil_productionDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            oil_productionDataGridView.AllowUserToAddRows = false;
            oil_productionDataGridView.ReadOnly = true;
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

        private void oil_productionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oil_productionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_kursachDataSet);

        }

        private void oilProduce_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_kursachDataSet.oil_production' table. You can move, or remove it, as needed.
            this.oil_productionTableAdapter.Fill(this.db_kursachDataSet.oil_production);

        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                oil_productionBindingSource.AddNew();
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
                oil_productionBindingSource.EndEdit();
                oil_productionTableAdapter.Update(db_kursachDataSet);
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
                SqlCommand command = new SqlCommand("updateOilProduce", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter idparam = new SqlParameter
                {
                    ParameterName = "@id_prod",
                    Value = Convert.ToInt32(id_produceTextBox.Text)
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
                    ParameterName = "@norm",
                    Value = Convert.ToInt32(normaTextBox.Text)
                };
                command.Parameters.Add(streetparam);
                SqlParameter buildparam = new SqlParameter
                {
                    ParameterName = "@plan",
                    Value = Convert.ToDecimal(plansTextBox.Text)
                };
                command.Parameters.Add(buildparam);

                SqlParameter factparam = new SqlParameter
                {
                    ParameterName = "@fact",
                    Value = Convert.ToDecimal(factTextBox.Text)
                };
                command.Parameters.Add(factparam);

                command.ExecuteNonQuery();
                try
                {
                    oil_productionTableAdapter.Update(db_kursachDataSet);
                }
                catch (Exception)
                {
                    MessageBox.Show("ошибка данных");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка в введенных данных");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in oil_productionDataGridView.SelectedRows)
            {
                oil_productionDataGridView.Rows.Remove(row);

            }
            try
            {
                oil_productionTableAdapter.Update(db_kursachDataSet);
            }catch(Exception)
            { }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        Point lastPoint;

        private void oilProduce_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void oilProduce_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
