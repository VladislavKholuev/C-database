namespace kursach
{
    partial class gass
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
            System.Windows.Forms.Label id_gasLabel;
            System.Windows.Forms.Label id_objectLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label thousand_m3Label;
            System.Windows.Forms.Label totalLabel;
            this.db_kursachDataSet = new kursach.db_kursachDataSet();
            this.gasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gasTableAdapter = new kursach.db_kursachDataSetTableAdapters.gasTableAdapter();
            this.tableAdapterManager = new kursach.db_kursachDataSetTableAdapters.TableAdapterManager();
            this.gasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_gasTextBox = new System.Windows.Forms.TextBox();
            this.id_objectTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.thousand_m3TextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            id_gasLabel = new System.Windows.Forms.Label();
            id_objectLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            thousand_m3Label = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_kursachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_gasLabel
            // 
            id_gasLabel.AutoSize = true;
            id_gasLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            id_gasLabel.Location = new System.Drawing.Point(606, 34);
            id_gasLabel.Name = "id_gasLabel";
            id_gasLabel.Size = new System.Drawing.Size(38, 13);
            id_gasLabel.TabIndex = 2;
            id_gasLabel.Text = "id gas:";
            // 
            // id_objectLabel
            // 
            id_objectLabel.AutoSize = true;
            id_objectLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            id_objectLabel.Location = new System.Drawing.Point(606, 60);
            id_objectLabel.Name = "id_objectLabel";
            id_objectLabel.Size = new System.Drawing.Size(50, 13);
            id_objectLabel.TabIndex = 4;
            id_objectLabel.Text = "id object:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataLabel.Location = new System.Drawing.Point(606, 87);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(31, 13);
            dataLabel.TabIndex = 6;
            dataLabel.Text = "data:";
            // 
            // thousand_m3Label
            // 
            thousand_m3Label.AutoSize = true;
            thousand_m3Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            thousand_m3Label.Location = new System.Drawing.Point(606, 112);
            thousand_m3Label.Name = "thousand_m3Label";
            thousand_m3Label.Size = new System.Drawing.Size(71, 13);
            thousand_m3Label.TabIndex = 8;
            thousand_m3Label.Text = "thousand m3:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            totalLabel.Location = new System.Drawing.Point(606, 138);
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
            this.tableAdapterManager.waterTableAdapter = null;
            // 
            // gasDataGridView
            // 
            this.gasDataGridView.AutoGenerateColumns = false;
            this.gasDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.gasDataGridView.DataSource = this.gasBindingSource;
            this.gasDataGridView.Location = new System.Drawing.Point(-2, -2);
            this.gasDataGridView.Name = "gasDataGridView";
            this.gasDataGridView.Size = new System.Drawing.Size(545, 308);
            this.gasDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_gas";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_gas";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "thousand_m3";
            this.dataGridViewTextBoxColumn4.HeaderText = "thousand_m3";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "total";
            this.dataGridViewTextBoxColumn5.HeaderText = "total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // id_gasTextBox
            // 
            this.id_gasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gasBindingSource, "id_gas", true));
            this.id_gasTextBox.Location = new System.Drawing.Point(683, 31);
            this.id_gasTextBox.Name = "id_gasTextBox";
            this.id_gasTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_gasTextBox.TabIndex = 3;
            // 
            // id_objectTextBox
            // 
            this.id_objectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gasBindingSource, "id_object", true));
            this.id_objectTextBox.Location = new System.Drawing.Point(683, 57);
            this.id_objectTextBox.Name = "id_objectTextBox";
            this.id_objectTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_objectTextBox.TabIndex = 5;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.gasBindingSource, "data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(683, 83);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataDateTimePicker.TabIndex = 7;
            // 
            // thousand_m3TextBox
            // 
            this.thousand_m3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gasBindingSource, "thousand_m3", true));
            this.thousand_m3TextBox.Location = new System.Drawing.Point(683, 109);
            this.thousand_m3TextBox.Name = "thousand_m3TextBox";
            this.thousand_m3TextBox.Size = new System.Drawing.Size(200, 20);
            this.thousand_m3TextBox.TabIndex = 9;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gasBindingSource, "total", true));
            this.totalTextBox.Location = new System.Drawing.Point(683, 135);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(200, 20);
            this.totalTextBox.TabIndex = 11;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(609, 193);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(103, 23);
            this.add.TabIndex = 12;
            this.add.Text = "добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(609, 223);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(103, 23);
            this.save.TabIndex = 13;
            this.save.Text = "сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(609, 253);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(103, 23);
            this.delete.TabIndex = 14;
            this.delete.Text = "удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(609, 283);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(103, 23);
            this.change.TabIndex = 15;
            this.change.Text = "изменить";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(879, -2);
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
            this.label2.Location = new System.Drawing.Point(549, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Газ";
            // 
            // gass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(899, 314);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.change);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.save);
            this.Controls.Add(this.add);
            this.Controls.Add(id_gasLabel);
            this.Controls.Add(this.id_gasTextBox);
            this.Controls.Add(id_objectLabel);
            this.Controls.Add(this.id_objectTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(thousand_m3Label);
            this.Controls.Add(this.thousand_m3TextBox);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.gasDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gass";
            this.Text = "gass";
            this.Load += new System.EventHandler(this.gass_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gass_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gass_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.db_kursachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_kursachDataSet db_kursachDataSet;
        private System.Windows.Forms.BindingSource gasBindingSource;
        private db_kursachDataSetTableAdapters.gasTableAdapter gasTableAdapter;
        private db_kursachDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView gasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox id_gasTextBox;
        private System.Windows.Forms.TextBox id_objectTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox thousand_m3TextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}