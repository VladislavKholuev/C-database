namespace kursach
{
    partial class personal
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
            System.Windows.Forms.Label id_objectLabel;
            System.Windows.Forms.Label id_perLabel;
            System.Windows.Forms.Label priorityLabel;
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label patronymicLabel;
            System.Windows.Forms.Label salaryLabel;
            System.Windows.Forms.Label phoneLabel;
            this.db_kursachDataSet = new kursach.db_kursachDataSet();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalTableAdapter = new kursach.db_kursachDataSetTableAdapters.personalTableAdapter();
            this.tableAdapterManager = new kursach.db_kursachDataSetTableAdapters.TableAdapterManager();
            this.personalDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_objectTextBox = new System.Windows.Forms.TextBox();
            this.id_perTextBox = new System.Windows.Forms.TextBox();
            this.priorityTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            id_objectLabel = new System.Windows.Forms.Label();
            id_perLabel = new System.Windows.Forms.Label();
            priorityLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            patronymicLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_kursachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_objectLabel
            // 
            id_objectLabel.AutoSize = true;
            id_objectLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            id_objectLabel.Location = new System.Drawing.Point(198, 421);
            id_objectLabel.Name = "id_objectLabel";
            id_objectLabel.Size = new System.Drawing.Size(51, 13);
            id_objectLabel.TabIndex = 2;
            id_objectLabel.Text = "Id object:";
            // 
            // id_perLabel
            // 
            id_perLabel.AutoSize = true;
            id_perLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            id_perLabel.Location = new System.Drawing.Point(198, 447);
            id_perLabel.Name = "id_perLabel";
            id_perLabel.Size = new System.Drawing.Size(37, 13);
            id_perLabel.TabIndex = 4;
            id_perLabel.Text = "Id per:";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            priorityLabel.Location = new System.Drawing.Point(198, 473);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new System.Drawing.Size(40, 13);
            priorityLabel.TabIndex = 6;
            priorityLabel.Text = "priority:";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            positionLabel.Location = new System.Drawing.Point(410, 421);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(46, 13);
            positionLabel.TabIndex = 8;
            positionLabel.Text = "position:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            surnameLabel.Location = new System.Drawing.Point(410, 447);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(50, 13);
            surnameLabel.TabIndex = 10;
            surnameLabel.Text = "surname:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            nameLabel.Location = new System.Drawing.Point(410, 473);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(36, 13);
            nameLabel.TabIndex = 12;
            nameLabel.Text = "name:";
            // 
            // patronymicLabel
            // 
            patronymicLabel.AutoSize = true;
            patronymicLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            patronymicLabel.Location = new System.Drawing.Point(625, 417);
            patronymicLabel.Name = "patronymicLabel";
            patronymicLabel.Size = new System.Drawing.Size(61, 13);
            patronymicLabel.TabIndex = 14;
            patronymicLabel.Text = "patronymic:";
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            salaryLabel.Location = new System.Drawing.Point(625, 443);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(37, 13);
            salaryLabel.TabIndex = 16;
            salaryLabel.Text = "salary:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            phoneLabel.Location = new System.Drawing.Point(625, 469);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(40, 13);
            phoneLabel.TabIndex = 18;
            phoneLabel.Text = "phone:";
            // 
            // db_kursachDataSet
            // 
            this.db_kursachDataSet.DataSetName = "db_kursachDataSet";
            this.db_kursachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataMember = "personal";
            this.personalBindingSource.DataSource = this.db_kursachDataSet;
            // 
            // personalTableAdapter
            // 
            this.personalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.gasTableAdapter = null;
            this.tableAdapterManager.heatTableAdapter = null;
            this.tableAdapterManager.loginsTableAdapter = null;
            this.tableAdapterManager.ObjectsTableAdapter = null;
            this.tableAdapterManager.oil_productionTableAdapter = null;
            this.tableAdapterManager.personalTableAdapter = this.personalTableAdapter;
            this.tableAdapterManager.spentElectryciteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = kursach.db_kursachDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.water_injectionTableAdapter = null;
            this.tableAdapterManager.waterTableAdapter = null;
            // 
            // personalDataGridView
            // 
            this.personalDataGridView.AutoGenerateColumns = false;
            this.personalDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.personalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.personalDataGridView.DataSource = this.personalBindingSource;
            this.personalDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.personalDataGridView.Location = new System.Drawing.Point(1, 2);
            this.personalDataGridView.Name = "personalDataGridView";
            this.personalDataGridView.Size = new System.Drawing.Size(947, 406);
            this.personalDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_object";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_object";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id_per";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id_per";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "priority";
            this.dataGridViewTextBoxColumn3.HeaderText = "priority";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "position";
            this.dataGridViewTextBoxColumn4.HeaderText = "position";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "surname";
            this.dataGridViewTextBoxColumn5.HeaderText = "surname";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn6.HeaderText = "name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "patronymic";
            this.dataGridViewTextBoxColumn7.HeaderText = "patronymic";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "salary";
            this.dataGridViewTextBoxColumn8.HeaderText = "salary";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn9.HeaderText = "phone";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // id_objectTextBox
            // 
            this.id_objectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Id_object", true));
            this.id_objectTextBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.id_objectTextBox.Location = new System.Drawing.Point(265, 418);
            this.id_objectTextBox.Name = "id_objectTextBox";
            this.id_objectTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_objectTextBox.TabIndex = 3;
            // 
            // id_perTextBox
            // 
            this.id_perTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Id_per", true));
            this.id_perTextBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.id_perTextBox.Location = new System.Drawing.Point(265, 444);
            this.id_perTextBox.Name = "id_perTextBox";
            this.id_perTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_perTextBox.TabIndex = 5;
            // 
            // priorityTextBox
            // 
            this.priorityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "priority", true));
            this.priorityTextBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.priorityTextBox.Location = new System.Drawing.Point(265, 470);
            this.priorityTextBox.Name = "priorityTextBox";
            this.priorityTextBox.Size = new System.Drawing.Size(100, 20);
            this.priorityTextBox.TabIndex = 7;
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "position", true));
            this.positionTextBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.positionTextBox.Location = new System.Drawing.Point(477, 418);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(100, 20);
            this.positionTextBox.TabIndex = 9;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "surname", true));
            this.surnameTextBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.surnameTextBox.Location = new System.Drawing.Point(477, 444);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.surnameTextBox.TabIndex = 11;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "name", true));
            this.nameTextBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nameTextBox.Location = new System.Drawing.Point(477, 470);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 13;
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "patronymic", true));
            this.patronymicTextBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.patronymicTextBox.Location = new System.Drawing.Point(692, 414);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(100, 20);
            this.patronymicTextBox.TabIndex = 15;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "salary", true));
            this.salaryTextBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.salaryTextBox.Location = new System.Drawing.Point(692, 440);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.salaryTextBox.TabIndex = 17;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "phone", true));
            this.phoneTextBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.phoneTextBox.Location = new System.Drawing.Point(692, 466);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 19;
            // 
            // add
            // 
            this.add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add.Location = new System.Drawing.Point(218, 526);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(133, 23);
            this.add.TabIndex = 20;
            this.add.Text = "добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // save
            // 
            this.save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.save.Location = new System.Drawing.Point(357, 526);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(141, 23);
            this.save.TabIndex = 21;
            this.save.Text = "сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.button2_Click);
            // 
            // change
            // 
            this.change.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.change.Location = new System.Drawing.Point(504, 526);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(141, 23);
            this.change.TabIndex = 22;
            this.change.Text = "изменить";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.button3_Click);
            // 
            // delete
            // 
            this.delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.delete.Location = new System.Drawing.Point(651, 526);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(141, 23);
            this.delete.TabIndex = 23;
            this.delete.Text = "удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(954, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "Персонал";
            // 
            // personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(976, 582);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.change);
            this.Controls.Add(this.save);
            this.Controls.Add(this.add);
            this.Controls.Add(id_objectLabel);
            this.Controls.Add(this.id_objectTextBox);
            this.Controls.Add(id_perLabel);
            this.Controls.Add(this.id_perTextBox);
            this.Controls.Add(priorityLabel);
            this.Controls.Add(this.priorityTextBox);
            this.Controls.Add(positionLabel);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(patronymicLabel);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(salaryLabel);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.personalDataGridView);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "personal";
            this.Text = "personal";
            this.Load += new System.EventHandler(this.personal_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.personal_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.personal_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.db_kursachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_kursachDataSet db_kursachDataSet;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private db_kursachDataSetTableAdapters.personalTableAdapter personalTableAdapter;
        private db_kursachDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView personalDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox id_objectTextBox;
        private System.Windows.Forms.TextBox id_perTextBox;
        private System.Windows.Forms.TextBox priorityTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}