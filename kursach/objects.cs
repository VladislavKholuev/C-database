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
    public partial class objects : Form
    {
        public void objectsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
           // MessageBox.Show("Ошибка ввода!");
            anError.ThrowException = false;
        }

        public objects()
        {
            InitializeComponent();
            objectsDataGridView.DataError += new DataGridViewDataErrorEventHandler(objectsDataGridView_DataError);
            objectsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            objectsDataGridView.AllowUserToAddRows = false;
            objectsDataGridView.ReadOnly = true;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_kursachDataSet.oil_production' table. You can move, or remove it, as needed.
            this.oil_productionTableAdapter.Fill(this.db_kursachDataSet.oil_production);
            // TODO: This line of code loads data into the 'db_kursachDataSet.Objects' table. You can move, or remove it, as needed.
            this.objectsTableAdapter.Fill(this.db_kursachDataSet.Objects);
            // TODO: This line of code loads data into the 'db_kursachDataSet.gas' table. You can move, or remove it, as needed
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void gasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_kursachDataSet);

        }

        private void addbut_Click(object sender, EventArgs e)
        {
            try
            {
                objectsBindingSource.AddNew();
            }
            catch (Exception)
            {
                MessageBox.Show("что-то не так");
            }
        }

        private void rec_Click(object sender, EventArgs e)
        {
            try
            {    
                objectsBindingSource.EndEdit();
                objectsTableAdapter.Update(db_kursachDataSet);
            }
            catch (Exception)
            {
                MessageBox.Show("нет данных, обязательно укажите name и location");
            }
            
        }

        private void updatebut_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectTo();
                conn.Open();
                SqlCommand command = new SqlCommand("updateObj", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter idparam = new SqlParameter
                {
                    ParameterName = "@id",
                    Value = Convert.ToInt32(id_objectTextBox.Text)
                };
                command.Parameters.Add(idparam);
                SqlParameter nameparam = new SqlParameter
                {
                    ParameterName = "@name",
                    Value = nameTextBox.Text
                };
                command.Parameters.Add(nameparam);
                SqlParameter locparam = new SqlParameter
                {
                    ParameterName = "@location",
                    Value = locationTextBox.Text
                };
                command.Parameters.Add(locparam);

                SqlParameter streetparam = new SqlParameter
                {
                    ParameterName = "@street",
                    Value = streetTextBox.Text
                };
                command.Parameters.Add(streetparam);
                SqlParameter buildparam = new SqlParameter
                {
                    ParameterName = "@build",
                    Value = Convert.ToInt32(buildingTextBox.Text)
                };
                command.Parameters.Add(buildparam);

                command.ExecuteNonQuery();
                objectsTableAdapter.Update(db_kursachDataSet);
            }
            catch (Exception)
            {
                MessageBox.Show("Вы ввели некорректные данные");
            }
    }

        private void delbut_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in objectsDataGridView.SelectedRows)
            {
                objectsDataGridView.Rows.Remove(row);

            }
            try
            {
                objectsTableAdapter.Update(db_kursachDataSet);
            }
            catch (Exception)
            {
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        Point lastPoint;

        private void objects_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void objects_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
