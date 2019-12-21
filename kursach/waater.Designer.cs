namespace kursach
{
    partial class waater
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_waterLabel;
            System.Windows.Forms.Label id_objectLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label m3Label;
            System.Windows.Forms.Label totalLabel;
            this.db_kursachDataSet = new kursach.db_kursachDataSet();
            this.gasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gasTableAdapter = new kursach.db_kursachDataSetTableAdapters.gasTableAdapter();
            this.tableAdapterManager = new kursach.db_kursachDataSetTableAdapters.TableAdapterManager();
            this.waterTableAdapter = new kursach.db_kursachDataSetTableAdapters.waterTableAdapter();
            this.waterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.waterDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_waterTextBox = new System.Windows.Forms.TextBox();
            this.id_objectTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.m3TextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            id_waterLabel = new System.Windows.Forms.Label();
            id_objectLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            m3Label = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_kursachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_waterLabel
            // 
            id_waterLabel.AutoSize = true;
            id_waterLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            id_waterLabel.Location = new System.Drawing.Point(614, 30);
            id_waterLabel.Name = "id_waterLabel";
            id_waterLabel.Size = new System.Drawing.Size(47, 13);
            id_waterLabel.TabIndex = 2;
            id_waterLabel.Text = "id water:";
            // 
            // id_objectLabel
            // 
            id_objectLabel.AutoSize = true;
            id_objectLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            id_objectLabel.Location = new System.Drawing.Point(614, 56);
            id_objectLabel.Name = "id_objectLabel";
            id_objectLabel.Size = new System.Drawing.Size(50, 13);
            id_objectLabel.TabIndex = 4;
            id_objectLabel.Text = "id object:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataLabel.Location = new System.Drawing.Point(614, 83);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(31, 13);
            dataLabel.TabIndex = 6;
            dataLabel.Text = "data:";
            // 
            // m3Label
            // 
            m3Label.AutoSize = true;
            m3Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            m3Label.Location = new System.Drawing.Point(614, 108);
            m3Label.Name = "m3Label";
            m3Label.Size = new System.Drawing.Size(25, 13);
            m3Label.TabIndex = 8;
            m3Label.Text = "M3:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            totalLabel.Location = new System.Drawing.Point(614, 134);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(30, 13);
            totalLabel.TabIndex = 10;
            totalLabel.Text = "total:";
            // 
            // db_kursachDataSet
            // 
            this.db_kursachDataSet.DataSetName = "db_kursachDataSet";
            this.db_kursachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gasBindingSource
            // 
            this.gasBindingSource.DataMember = "gas";
            this.gasBindingSource.DataSource = this.db_kursachDataSet;
            // 
            // gasTableAdapter
            // 
            this.gasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.gasTableAdapter = this.gasTableAdapter;
            this.tableAdapterManager.heatTableAdapter = null;
            this.tableAdapterManager.loginsTableAdapter = null;
            this.tableAdapterManager.ObjectsTableAdapter = null;
            this.tableAdapterManager.oil_productionTableAdapter = null;
            this.tableAdapterManager.personalTableAdapter = null;
            this.tableAdapterManager.spentElectryciteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = kursach.db_kursachDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.water_injectionTableAdapter = null;
            this.tableAdapterManager.waterTableAdapter = this.waterTableAdapter;
            // 
            // waterTableAdapter
            // 
            this.waterTableAdapter.ClearBeforeFill = true;
            // 
            // waterBindingSource
            // 
            this.waterBindingSource.DataMember = "water";
            this.waterBindingSource.DataSource = this.db_kursachDataSet;
            // 
            // waterDataGridView
            // 
            this.waterDataGridView.AutoGenerateColumns = false;
            this.waterDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.waterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.waterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.waterDataGridView.DataSource = this.waterBindingSource;
            this.waterDataGridView.Location = new System.Drawing.Point(2, 0);
            this.waterDataGridView.Name = "waterDataGridView";
            this.waterDataGridView.Size = new System.Drawing.Size(546, 280);
            this.waterDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_water";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_water";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_object";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_object";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "data";
            this.dataGridViewTextBoxColumn3.HeaderText = "data";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "M3";
            this.dataGridViewTextBoxColumn4.HeaderText = "M3";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "total";
            this.dataGridViewTextBoxColumn5.HeaderText = "total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // id_waterTextBox
            // 
            this.id_waterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.waterBindingSource, "id_water", true));
            this.id_waterTextBox.Location = new System.Drawing.Point(670, 27);
            this.id_waterTextBox.Name = "id_waterTextBox";
            this.id_waterTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_waterTextBox.TabIndex = 3;
            // 
            // id_objectTextBox
            // 
            this.id_objectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.waterBindingSource, "id_object", true));
            this.id_objectTextBox.Location = new System.Drawing.Point(670, 53);
            this.id_objectTextBox.Name = "id_objectTextBox";
            this.id_objectTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_objectTextBox.TabIndex = 5;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.waterBindingSource, "data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(670, 79);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataDateTimePicker.TabIndex = 7;
            // 
            // m3TextBox
            // 
            this.m3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.waterBindingSource, "M3", true));
            this.m3TextBox.Location = new System.Drawing.Point(670, 105);
            this.m3TextBox.Name = "m3TextBox";
            this.m3TextBox.Size = new System.Drawing.Size(200, 20);
            this.m3TextBox.TabIndex = 9;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.waterBindingSource, "total", true));
            this.totalTextBox.Location = new System.Drawing.Point(670, 131);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(200, 20);
            this.totalTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(872, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(617, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(617, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(617, 257);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(555, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Вода";
            // 
            // waater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(894, 295);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(id_waterLabel);
            this.Controls.Add(this.id_waterTextBox);
            this.Controls.Add(id_objectLabel);
            this.Controls.Add(this.id_objectTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(m3Label);
            this.Controls.Add(this.m3TextBox);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.waterDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "waater";
            this.Text = "waater";
            this.Load += new System.EventHandler(this.waater_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.waater_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.waater_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.db_kursachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_kursachDataSet db_kursachDataSet;
        private System.Windows.Forms.BindingSource gasBindingSource;
        private db_kursachDataSetTableAdapters.gasTableAdapter gasTableAdapter;
        private db_kursachDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private db_kursachDataSetTableAdapters.waterTableAdapter waterTableAdapter;
        private System.Windows.Forms.BindingSource waterBindingSource;
        private System.Windows.Forms.DataGridView waterDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox id_waterTextBox;
        private System.Windows.Forms.TextBox id_objectTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox m3TextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
    }
}