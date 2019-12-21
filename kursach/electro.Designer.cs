namespace kursach
{
    partial class electro
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
            System.Windows.Forms.Label id_sElectroLabel;
            System.Windows.Forms.Label id_objectLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label spentElectroLabel;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.db_kursachDataSet = new kursach.db_kursachDataSet();
            this.spentElectryciteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spentElectryciteTableAdapter = new kursach.db_kursachDataSetTableAdapters.spentElectryciteTableAdapter();
            this.tableAdapterManager = new kursach.db_kursachDataSetTableAdapters.TableAdapterManager();
            this.id_sElectroTextBox = new System.Windows.Forms.TextBox();
            this.id_objectTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.spentElectroTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.spentElectryciteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            id_sElectroLabel = new System.Windows.Forms.Label();
            id_objectLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            spentElectroLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_kursachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spentElectryciteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spentElectryciteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_sElectroLabel
            // 
            id_sElectroLabel.AutoSize = true;
            id_sElectroLabel.Location = new System.Drawing.Point(561, 46);
            id_sElectroLabel.Name = "id_sElectroLabel";
            id_sElectroLabel.Size = new System.Drawing.Size(62, 13);
            id_sElectroLabel.TabIndex = 2;
            id_sElectroLabel.Text = "id s Electro:";
            // 
            // id_objectLabel
            // 
            id_objectLabel.AutoSize = true;
            id_objectLabel.Location = new System.Drawing.Point(561, 72);
            id_objectLabel.Name = "id_objectLabel";
            id_objectLabel.Size = new System.Drawing.Size(50, 13);
            id_objectLabel.TabIndex = 4;
            id_objectLabel.Text = "id object:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(561, 99);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(31, 13);
            dataLabel.TabIndex = 6;
            dataLabel.Text = "data:";
            // 
            // spentElectroLabel
            // 
            spentElectroLabel.AutoSize = true;
            spentElectroLabel.Location = new System.Drawing.Point(561, 124);
            spentElectroLabel.Name = "spentElectroLabel";
            spentElectroLabel.Size = new System.Drawing.Size(72, 13);
            spentElectroLabel.TabIndex = 8;
            spentElectroLabel.Text = "spent Electro:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(561, 150);
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
            // spentElectryciteBindingSource
            // 
            this.spentElectryciteBindingSource.DataMember = "spentElectrycite";
            this.spentElectryciteBindingSource.DataSource = this.db_kursachDataSet;
            // 
            // spentElectryciteTableAdapter
            // 
            this.spentElectryciteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.gasTableAdapter = null;
            this.tableAdapterManager.heatTableAdapter = null;
            this.tableAdapterManager.loginsTableAdapter = null;
            this.tableAdapterManager.ObjectsTableAdapter = null;
            this.tableAdapterManager.oil_productionTableAdapter = null;
            this.tableAdapterManager.personalTableAdapter = null;
            this.tableAdapterManager.spentElectryciteTableAdapter = this.spentElectryciteTableAdapter;
            this.tableAdapterManager.UpdateOrder = kursach.db_kursachDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.water_injectionTableAdapter = null;
            this.tableAdapterManager.waterTableAdapter = null;
            // 
            // id_sElectroTextBox
            // 
            this.id_sElectroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spentElectryciteBindingSource, "id_sElectro", true));
            this.id_sElectroTextBox.Location = new System.Drawing.Point(639, 43);
            this.id_sElectroTextBox.Name = "id_sElectroTextBox";
            this.id_sElectroTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_sElectroTextBox.TabIndex = 3;
            // 
            // id_objectTextBox
            // 
            this.id_objectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spentElectryciteBindingSource, "id_object", true));
            this.id_objectTextBox.Location = new System.Drawing.Point(639, 69);
            this.id_objectTextBox.Name = "id_objectTextBox";
            this.id_objectTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_objectTextBox.TabIndex = 5;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.spentElectryciteBindingSource, "data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(639, 95);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataDateTimePicker.TabIndex = 7;
            // 
            // spentElectroTextBox
            // 
            this.spentElectroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spentElectryciteBindingSource, "spentElectro", true));
            this.spentElectroTextBox.Location = new System.Drawing.Point(639, 121);
            this.spentElectroTextBox.Name = "spentElectroTextBox";
            this.spentElectroTextBox.Size = new System.Drawing.Size(200, 20);
            this.spentElectroTextBox.TabIndex = 9;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spentElectryciteBindingSource, "total", true));
            this.totalTextBox.Location = new System.Drawing.Point(639, 147);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(200, 20);
            this.totalTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(819, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // add
            // 
            this.add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add.Location = new System.Drawing.Point(564, 207);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 14;
            this.add.Text = "добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // save
            // 
            this.save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.save.Location = new System.Drawing.Point(564, 237);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 15;
            this.save.Text = "сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // change
            // 
            this.change.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.change.Location = new System.Drawing.Point(564, 266);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(75, 23);
            this.change.TabIndex = 16;
            this.change.Text = "изменить";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // del
            // 
            this.del.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.del.Location = new System.Drawing.Point(564, 295);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 23);
            this.del.TabIndex = 17;
            this.del.Text = "удалить";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // spentElectryciteDataGridView
            // 
            this.spentElectryciteDataGridView.AutoGenerateColumns = false;
            this.spentElectryciteDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.spentElectryciteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spentElectryciteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.spentElectryciteDataGridView.DataSource = this.spentElectryciteBindingSource;
            this.spentElectryciteDataGridView.Location = new System.Drawing.Point(1, 4);
            this.spentElectryciteDataGridView.Name = "spentElectryciteDataGridView";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.spentElectryciteDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.spentElectryciteDataGridView.Size = new System.Drawing.Size(549, 343);
            this.spentElectryciteDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_sElectro";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_sElectro";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "spentElectro";
            this.dataGridViewTextBoxColumn4.HeaderText = "spentElectro";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "total";
            this.dataGridViewTextBoxColumn5.HeaderText = "total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(556, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Электричество";
            // 
            // electro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(852, 351);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spentElectryciteDataGridView);
            this.Controls.Add(this.del);
            this.Controls.Add(this.change);
            this.Controls.Add(this.save);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label1);
            this.Controls.Add(id_sElectroLabel);
            this.Controls.Add(this.id_sElectroTextBox);
            this.Controls.Add(id_objectLabel);
            this.Controls.Add(this.id_objectTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(spentElectroLabel);
            this.Controls.Add(this.spentElectroTextBox);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "electro";
            this.Text = "electro";
            this.Load += new System.EventHandler(this.electro_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.electro_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.electro_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.db_kursachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spentElectryciteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spentElectryciteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_kursachDataSet db_kursachDataSet;
        private System.Windows.Forms.BindingSource spentElectryciteBindingSource;
        private db_kursachDataSetTableAdapters.spentElectryciteTableAdapter spentElectryciteTableAdapter;
        private db_kursachDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox id_sElectroTextBox;
        private System.Windows.Forms.TextBox id_objectTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox spentElectroTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.DataGridView spentElectryciteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label2;
    }
}