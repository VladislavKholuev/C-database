namespace kursach
{
    partial class heats
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
            System.Windows.Forms.Label id_heatLabel;
            System.Windows.Forms.Label id_objectLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label gigacaloriesLabel;
            System.Windows.Forms.Label totalLabel;
            this.db_kursachDataSet = new kursach.db_kursachDataSet();
            this.heatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.heatTableAdapter = new kursach.db_kursachDataSetTableAdapters.heatTableAdapter();
            this.tableAdapterManager = new kursach.db_kursachDataSetTableAdapters.TableAdapterManager();
            this.heatDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_heatTextBox = new System.Windows.Forms.TextBox();
            this.id_objectTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.gigacaloriesTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            id_heatLabel = new System.Windows.Forms.Label();
            id_objectLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            gigacaloriesLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_kursachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_heatLabel
            // 
            id_heatLabel.AutoSize = true;
            id_heatLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            id_heatLabel.Location = new System.Drawing.Point(598, 36);
            id_heatLabel.Name = "id_heatLabel";
            id_heatLabel.Size = new System.Drawing.Size(42, 13);
            id_heatLabel.TabIndex = 2;
            id_heatLabel.Text = "id heat:";
            // 
            // id_objectLabel
            // 
            id_objectLabel.AutoSize = true;
            id_objectLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            id_objectLabel.Location = new System.Drawing.Point(598, 62);
            id_objectLabel.Name = "id_objectLabel";
            id_objectLabel.Size = new System.Drawing.Size(50, 13);
            id_objectLabel.TabIndex = 4;
            id_objectLabel.Text = "id object:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataLabel.Location = new System.Drawing.Point(598, 89);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(31, 13);
            dataLabel.TabIndex = 6;
            dataLabel.Text = "data:";
            // 
            // gigacaloriesLabel
            // 
            gigacaloriesLabel.AutoSize = true;
            gigacaloriesLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            gigacaloriesLabel.Location = new System.Drawing.Point(598, 114);
            gigacaloriesLabel.Name = "gigacaloriesLabel";
            gigacaloriesLabel.Size = new System.Drawing.Size(66, 13);
            gigacaloriesLabel.TabIndex = 8;
            gigacaloriesLabel.Text = "gigacalories:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            totalLabel.Location = new System.Drawing.Point(598, 140);
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
            // heatBindingSource
            // 
            this.heatBindingSource.DataMember = "heat";
            this.heatBindingSource.DataSource = this.db_kursachDataSet;
            // 
            // heatTableAdapter
            // 
            this.heatTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.gasTableAdapter = null;
            this.tableAdapterManager.heatTableAdapter = this.heatTableAdapter;
            this.tableAdapterManager.loginsTableAdapter = null;
            this.tableAdapterManager.ObjectsTableAdapter = null;
            this.tableAdapterManager.oil_productionTableAdapter = null;
            this.tableAdapterManager.personalTableAdapter = null;
            this.tableAdapterManager.spentElectryciteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = kursach.db_kursachDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.water_injectionTableAdapter = null;
            this.tableAdapterManager.waterTableAdapter = null;
            // 
            // heatDataGridView
            // 
            this.heatDataGridView.AutoGenerateColumns = false;
            this.heatDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.heatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.heatDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.heatDataGridView.DataSource = this.heatBindingSource;
            this.heatDataGridView.Location = new System.Drawing.Point(1, 1);
            this.heatDataGridView.Name = "heatDataGridView";
            this.heatDataGridView.Size = new System.Drawing.Size(548, 287);
            this.heatDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_heat";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_heat";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "gigacalories";
            this.dataGridViewTextBoxColumn4.HeaderText = "gigacalories";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "total";
            this.dataGridViewTextBoxColumn5.HeaderText = "total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // id_heatTextBox
            // 
            this.id_heatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heatBindingSource, "id_heat", true));
            this.id_heatTextBox.Location = new System.Drawing.Point(670, 33);
            this.id_heatTextBox.Name = "id_heatTextBox";
            this.id_heatTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_heatTextBox.TabIndex = 3;
            // 
            // id_objectTextBox
            // 
            this.id_objectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heatBindingSource, "id_object", true));
            this.id_objectTextBox.Location = new System.Drawing.Point(670, 59);
            this.id_objectTextBox.Name = "id_objectTextBox";
            this.id_objectTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_objectTextBox.TabIndex = 5;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.heatBindingSource, "data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(670, 85);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataDateTimePicker.TabIndex = 7;
            // 
            // gigacaloriesTextBox
            // 
            this.gigacaloriesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heatBindingSource, "gigacalories", true));
            this.gigacaloriesTextBox.Location = new System.Drawing.Point(670, 111);
            this.gigacaloriesTextBox.Name = "gigacaloriesTextBox";
            this.gigacaloriesTextBox.Size = new System.Drawing.Size(200, 20);
            this.gigacaloriesTextBox.TabIndex = 9;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.heatBindingSource, "total", true));
            this.totalTextBox.Location = new System.Drawing.Point(670, 137);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(200, 20);
            this.totalTextBox.TabIndex = 11;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(601, 177);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(103, 23);
            this.add.TabIndex = 12;
            this.add.Text = "добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(601, 206);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(103, 23);
            this.save.TabIndex = 13;
            this.save.Text = "сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(601, 235);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(103, 23);
            this.change.TabIndex = 14;
            this.change.Text = "изменить";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(601, 265);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(103, 23);
            this.delete.TabIndex = 15;
            this.delete.Text = "удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(876, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(556, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Тепло";
            // 
            // heats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(899, 300);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.change);
            this.Controls.Add(this.save);
            this.Controls.Add(this.add);
            this.Controls.Add(id_heatLabel);
            this.Controls.Add(this.id_heatTextBox);
            this.Controls.Add(id_objectLabel);
            this.Controls.Add(this.id_objectTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(gigacaloriesLabel);
            this.Controls.Add(this.gigacaloriesTextBox);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.heatDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "heats";
            this.Text = "heats";
            this.Load += new System.EventHandler(this.heats_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.heats_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.heats_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.db_kursachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_kursachDataSet db_kursachDataSet;
        private System.Windows.Forms.BindingSource heatBindingSource;
        private db_kursachDataSetTableAdapters.heatTableAdapter heatTableAdapter;
        private db_kursachDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView heatDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox id_heatTextBox;
        private System.Windows.Forms.TextBox id_objectTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox gigacaloriesTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}