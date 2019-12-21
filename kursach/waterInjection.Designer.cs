namespace kursach
{
    partial class waterInjection
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
            System.Windows.Forms.Label id_injectionLabel;
            System.Windows.Forms.Label id_objectLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label normaLabel;
            System.Windows.Forms.Label plansLabel;
            System.Windows.Forms.Label factLabel;
            this.db_kursachDataSet = new kursach.db_kursachDataSet();
            this.water_injectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.water_injectionTableAdapter = new kursach.db_kursachDataSetTableAdapters.water_injectionTableAdapter();
            this.tableAdapterManager = new kursach.db_kursachDataSetTableAdapters.TableAdapterManager();
            this.water_injectionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_injectionTextBox = new System.Windows.Forms.TextBox();
            this.id_objectTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.normaTextBox = new System.Windows.Forms.TextBox();
            this.plansTextBox = new System.Windows.Forms.TextBox();
            this.factTextBox = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            id_injectionLabel = new System.Windows.Forms.Label();
            id_objectLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            normaLabel = new System.Windows.Forms.Label();
            plansLabel = new System.Windows.Forms.Label();
            factLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_kursachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.water_injectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.water_injectionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_injectionLabel
            // 
            id_injectionLabel.AutoSize = true;
            id_injectionLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            id_injectionLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            id_injectionLabel.Location = new System.Drawing.Point(684, 55);
            id_injectionLabel.Name = "id_injectionLabel";
            id_injectionLabel.Size = new System.Drawing.Size(60, 13);
            id_injectionLabel.TabIndex = 2;
            id_injectionLabel.Text = "id injection:";
            // 
            // id_objectLabel
            // 
            id_objectLabel.AutoSize = true;
            id_objectLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            id_objectLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            id_objectLabel.Location = new System.Drawing.Point(684, 81);
            id_objectLabel.Name = "id_objectLabel";
            id_objectLabel.Size = new System.Drawing.Size(50, 13);
            id_objectLabel.TabIndex = 4;
            id_objectLabel.Text = "id object:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataLabel.Location = new System.Drawing.Point(684, 108);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(31, 13);
            dataLabel.TabIndex = 6;
            dataLabel.Text = "data:";
            // 
            // normaLabel
            // 
            normaLabel.AutoSize = true;
            normaLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            normaLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            normaLabel.Location = new System.Drawing.Point(684, 133);
            normaLabel.Name = "normaLabel";
            normaLabel.Size = new System.Drawing.Size(39, 13);
            normaLabel.TabIndex = 8;
            normaLabel.Text = "norma:";
            // 
            // plansLabel
            // 
            plansLabel.AutoSize = true;
            plansLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            plansLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            plansLabel.Location = new System.Drawing.Point(684, 159);
            plansLabel.Name = "plansLabel";
            plansLabel.Size = new System.Drawing.Size(35, 13);
            plansLabel.TabIndex = 10;
            plansLabel.Text = "plans:";
            // 
            // factLabel
            // 
            factLabel.AutoSize = true;
            factLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            factLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            factLabel.Location = new System.Drawing.Point(684, 185);
            factLabel.Name = "factLabel";
            factLabel.Size = new System.Drawing.Size(28, 13);
            factLabel.TabIndex = 12;
            factLabel.Text = "fact:";
            // 
            // db_kursachDataSet
            // 
            this.db_kursachDataSet.DataSetName = "db_kursachDataSet";
            this.db_kursachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // water_injectionBindingSource
            // 
            this.water_injectionBindingSource.DataMember = "water_injection";
            this.water_injectionBindingSource.DataSource = this.db_kursachDataSet;
            // 
            // water_injectionTableAdapter
            // 
            this.water_injectionTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.spentElectryciteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = kursach.db_kursachDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.water_injectionTableAdapter = this.water_injectionTableAdapter;
            this.tableAdapterManager.waterTableAdapter = null;
            // 
            // water_injectionDataGridView
            // 
            this.water_injectionDataGridView.AutoGenerateColumns = false;
            this.water_injectionDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.water_injectionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.water_injectionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.water_injectionDataGridView.DataSource = this.water_injectionBindingSource;
            this.water_injectionDataGridView.Location = new System.Drawing.Point(3, -1);
            this.water_injectionDataGridView.Name = "water_injectionDataGridView";
            this.water_injectionDataGridView.Size = new System.Drawing.Size(651, 333);
            this.water_injectionDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_injection";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_injection";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "norma";
            this.dataGridViewTextBoxColumn4.HeaderText = "norma";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "plans";
            this.dataGridViewTextBoxColumn5.HeaderText = "plans";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "fact";
            this.dataGridViewTextBoxColumn6.HeaderText = "fact";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // id_injectionTextBox
            // 
            this.id_injectionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.water_injectionBindingSource, "id_injection", true));
            this.id_injectionTextBox.Location = new System.Drawing.Point(750, 52);
            this.id_injectionTextBox.Name = "id_injectionTextBox";
            this.id_injectionTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_injectionTextBox.TabIndex = 3;
            // 
            // id_objectTextBox
            // 
            this.id_objectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.water_injectionBindingSource, "id_object", true));
            this.id_objectTextBox.Location = new System.Drawing.Point(750, 78);
            this.id_objectTextBox.Name = "id_objectTextBox";
            this.id_objectTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_objectTextBox.TabIndex = 5;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.water_injectionBindingSource, "data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(750, 104);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataDateTimePicker.TabIndex = 7;
            // 
            // normaTextBox
            // 
            this.normaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.water_injectionBindingSource, "norma", true));
            this.normaTextBox.Location = new System.Drawing.Point(750, 130);
            this.normaTextBox.Name = "normaTextBox";
            this.normaTextBox.Size = new System.Drawing.Size(200, 20);
            this.normaTextBox.TabIndex = 9;
            // 
            // plansTextBox
            // 
            this.plansTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.water_injectionBindingSource, "plans", true));
            this.plansTextBox.Location = new System.Drawing.Point(750, 156);
            this.plansTextBox.Name = "plansTextBox";
            this.plansTextBox.Size = new System.Drawing.Size(200, 20);
            this.plansTextBox.TabIndex = 11;
            // 
            // factTextBox
            // 
            this.factTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.water_injectionBindingSource, "fact", true));
            this.factTextBox.Location = new System.Drawing.Point(750, 182);
            this.factTextBox.Name = "factTextBox";
            this.factTextBox.Size = new System.Drawing.Size(200, 20);
            this.factTextBox.TabIndex = 13;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(687, 221);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(109, 23);
            this.add.TabIndex = 14;
            this.add.Text = "добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(687, 250);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(109, 23);
            this.save.TabIndex = 15;
            this.save.Text = "сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(687, 279);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(109, 23);
            this.change.TabIndex = 16;
            this.change.Text = "изменить";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(687, 309);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(109, 23);
            this.delete.TabIndex = 17;
            this.delete.Text = "удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(930, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(682, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 26);
            this.label2.TabIndex = 19;
            this.label2.Text = "Закачка воды";
            // 
            // waterInjection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(956, 345);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.change);
            this.Controls.Add(this.save);
            this.Controls.Add(this.add);
            this.Controls.Add(id_injectionLabel);
            this.Controls.Add(this.id_injectionTextBox);
            this.Controls.Add(id_objectLabel);
            this.Controls.Add(this.id_objectTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(normaLabel);
            this.Controls.Add(this.normaTextBox);
            this.Controls.Add(plansLabel);
            this.Controls.Add(this.plansTextBox);
            this.Controls.Add(factLabel);
            this.Controls.Add(this.factTextBox);
            this.Controls.Add(this.water_injectionDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "waterInjection";
            this.Text = "waterInjection";
            this.Load += new System.EventHandler(this.waterInjection_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.waterInjection_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.waterInjection_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.db_kursachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.water_injectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.water_injectionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_kursachDataSet db_kursachDataSet;
        private System.Windows.Forms.BindingSource water_injectionBindingSource;
        private db_kursachDataSetTableAdapters.water_injectionTableAdapter water_injectionTableAdapter;
        private db_kursachDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView water_injectionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox id_injectionTextBox;
        private System.Windows.Forms.TextBox id_objectTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox normaTextBox;
        private System.Windows.Forms.TextBox plansTextBox;
        private System.Windows.Forms.TextBox factTextBox;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}