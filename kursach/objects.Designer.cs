namespace kursach
{
    partial class objects
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label streetLabel;
            System.Windows.Forms.Label buildingLabel;
            this.db_kursachDataSet = new kursach.db_kursachDataSet();
            this.gasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gasTableAdapter = new kursach.db_kursachDataSetTableAdapters.gasTableAdapter();
            this.tableAdapterManager = new kursach.db_kursachDataSetTableAdapters.TableAdapterManager();
            this.objectsTableAdapter = new kursach.db_kursachDataSetTableAdapters.ObjectsTableAdapter();
            this.oil_productionTableAdapter = new kursach.db_kursachDataSetTableAdapters.oil_productionTableAdapter();
            this.objectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.objectsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_objectTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.buildingTextBox = new System.Windows.Forms.TextBox();
            this.oil_productionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addbut = new System.Windows.Forms.Button();
            this.updatebut = new System.Windows.Forms.Button();
            this.delbut = new System.Windows.Forms.Button();
            this.rec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            id_objectLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            buildingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_kursachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oil_productionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_objectLabel
            // 
            id_objectLabel.AutoSize = true;
            id_objectLabel.ForeColor = System.Drawing.Color.White;
            id_objectLabel.Location = new System.Drawing.Point(609, 37);
            id_objectLabel.Name = "id_objectLabel";
            id_objectLabel.Size = new System.Drawing.Size(51, 13);
            id_objectLabel.TabIndex = 1;
            id_objectLabel.Text = "Id object:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.ForeColor = System.Drawing.Color.White;
            nameLabel.Location = new System.Drawing.Point(609, 63);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(36, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "name:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.ForeColor = System.Drawing.Color.White;
            locationLabel.Location = new System.Drawing.Point(609, 89);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(47, 13);
            locationLabel.TabIndex = 5;
            locationLabel.Text = "location:";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.ForeColor = System.Drawing.Color.White;
            streetLabel.Location = new System.Drawing.Point(609, 115);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(36, 13);
            streetLabel.TabIndex = 7;
            streetLabel.Text = "street:";
            // 
            // buildingLabel
            // 
            buildingLabel.AutoSize = true;
            buildingLabel.ForeColor = System.Drawing.Color.White;
            buildingLabel.Location = new System.Drawing.Point(609, 141);
            buildingLabel.Name = "buildingLabel";
            buildingLabel.Size = new System.Drawing.Size(46, 13);
            buildingLabel.TabIndex = 9;
            buildingLabel.Text = "building:";
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
            this.tableAdapterManager.ObjectsTableAdapter = this.objectsTableAdapter;
            this.tableAdapterManager.oil_productionTableAdapter = this.oil_productionTableAdapter;
            this.tableAdapterManager.personalTableAdapter = null;
            this.tableAdapterManager.spentElectryciteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = kursach.db_kursachDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.water_injectionTableAdapter = null;
            this.tableAdapterManager.waterTableAdapter = null;
            // 
            // objectsTableAdapter
            // 
            this.objectsTableAdapter.ClearBeforeFill = true;
            // 
            // oil_productionTableAdapter
            // 
            this.oil_productionTableAdapter.ClearBeforeFill = true;
            // 
            // objectsBindingSource
            // 
            this.objectsBindingSource.DataMember = "Objects";
            this.objectsBindingSource.DataSource = this.db_kursachDataSet;
            // 
            // objectsDataGridView
            // 
            this.objectsDataGridView.AutoGenerateColumns = false;
            this.objectsDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.objectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.objectsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.objectsDataGridView.DataSource = this.objectsBindingSource;
            this.objectsDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.objectsDataGridView.Location = new System.Drawing.Point(-1, 2);
            this.objectsDataGridView.Name = "objectsDataGridView";
            this.objectsDataGridView.Size = new System.Drawing.Size(546, 301);
            this.objectsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_object";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_object";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "location";
            this.dataGridViewTextBoxColumn3.HeaderText = "location";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "street";
            this.dataGridViewTextBoxColumn4.HeaderText = "street";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "building";
            this.dataGridViewTextBoxColumn5.HeaderText = "building";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // id_objectTextBox
            // 
            this.id_objectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objectsBindingSource, "Id_object", true));
            this.id_objectTextBox.Location = new System.Drawing.Point(666, 34);
            this.id_objectTextBox.Name = "id_objectTextBox";
            this.id_objectTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_objectTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objectsBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(666, 60);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objectsBindingSource, "location", true));
            this.locationTextBox.Location = new System.Drawing.Point(666, 86);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(100, 20);
            this.locationTextBox.TabIndex = 6;
            // 
            // streetTextBox
            // 
            this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objectsBindingSource, "street", true));
            this.streetTextBox.Location = new System.Drawing.Point(666, 112);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(100, 20);
            this.streetTextBox.TabIndex = 8;
            // 
            // buildingTextBox
            // 
            this.buildingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objectsBindingSource, "building", true));
            this.buildingTextBox.Location = new System.Drawing.Point(666, 138);
            this.buildingTextBox.Name = "buildingTextBox";
            this.buildingTextBox.Size = new System.Drawing.Size(100, 20);
            this.buildingTextBox.TabIndex = 10;
            // 
            // oil_productionBindingSource
            // 
            this.oil_productionBindingSource.DataMember = "oil_production";
            this.oil_productionBindingSource.DataSource = this.db_kursachDataSet;
            // 
            // addbut
            // 
            this.addbut.Location = new System.Drawing.Point(612, 170);
            this.addbut.Name = "addbut";
            this.addbut.Size = new System.Drawing.Size(75, 23);
            this.addbut.TabIndex = 12;
            this.addbut.Text = "добавить";
            this.addbut.UseVisualStyleBackColor = true;
            this.addbut.Click += new System.EventHandler(this.addbut_Click);
            // 
            // updatebut
            // 
            this.updatebut.Location = new System.Drawing.Point(612, 228);
            this.updatebut.Name = "updatebut";
            this.updatebut.Size = new System.Drawing.Size(75, 23);
            this.updatebut.TabIndex = 13;
            this.updatebut.Text = "изменить";
            this.updatebut.UseVisualStyleBackColor = true;
            this.updatebut.Click += new System.EventHandler(this.updatebut_Click);
            // 
            // delbut
            // 
            this.delbut.Location = new System.Drawing.Point(612, 257);
            this.delbut.Name = "delbut";
            this.delbut.Size = new System.Drawing.Size(75, 23);
            this.delbut.TabIndex = 14;
            this.delbut.Text = "удалить";
            this.delbut.UseVisualStyleBackColor = true;
            this.delbut.Click += new System.EventHandler(this.delbut_Click);
            // 
            // rec
            // 
            this.rec.Location = new System.Drawing.Point(612, 199);
            this.rec.Name = "rec";
            this.rec.Size = new System.Drawing.Size(75, 23);
            this.rec.TabIndex = 15;
            this.rec.Text = "сохранить";
            this.rec.UseVisualStyleBackColor = true;
            this.rec.Click += new System.EventHandler(this.rec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(746, 2);
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
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(551, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Объекты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "label3";
            // 
            // objects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(770, 306);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rec);
            this.Controls.Add(this.delbut);
            this.Controls.Add(this.updatebut);
            this.Controls.Add(this.addbut);
            this.Controls.Add(id_objectLabel);
            this.Controls.Add(this.id_objectTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(locationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(streetLabel);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(buildingLabel);
            this.Controls.Add(this.buildingTextBox);
            this.Controls.Add(this.objectsDataGridView);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "objects";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.objects_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.objects_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.db_kursachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oil_productionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_kursachDataSet db_kursachDataSet;
        private System.Windows.Forms.BindingSource gasBindingSource;
        private db_kursachDataSetTableAdapters.gasTableAdapter gasTableAdapter;
        private db_kursachDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private db_kursachDataSetTableAdapters.ObjectsTableAdapter objectsTableAdapter;
        private System.Windows.Forms.BindingSource objectsBindingSource;
        private System.Windows.Forms.DataGridView objectsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox id_objectTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox buildingTextBox;
        private db_kursachDataSetTableAdapters.oil_productionTableAdapter oil_productionTableAdapter;
        private System.Windows.Forms.BindingSource oil_productionBindingSource;
        private System.Windows.Forms.Button addbut;
        private System.Windows.Forms.Button updatebut;
        private System.Windows.Forms.Button delbut;
        private System.Windows.Forms.Button rec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

