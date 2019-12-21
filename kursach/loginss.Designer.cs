namespace kursach
{
    partial class loginss
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
            System.Windows.Forms.Label id_perLabel;
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            this.db_kursachDataSet = new kursach.db_kursachDataSet();
            this.loginsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginsTableAdapter = new kursach.db_kursachDataSetTableAdapters.loginsTableAdapter();
            this.tableAdapterManager = new kursach.db_kursachDataSetTableAdapters.TableAdapterManager();
            this.loginsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_perTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            id_perLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_kursachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_perLabel
            // 
            id_perLabel.AutoSize = true;
            id_perLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            id_perLabel.Location = new System.Drawing.Point(381, 54);
            id_perLabel.Name = "id_perLabel";
            id_perLabel.Size = new System.Drawing.Size(36, 13);
            id_perLabel.TabIndex = 2;
            id_perLabel.Text = "id per:";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            loginLabel.Location = new System.Drawing.Point(381, 80);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(32, 13);
            loginLabel.TabIndex = 4;
            loginLabel.Text = "login:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            passwordLabel.Location = new System.Drawing.Point(381, 106);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(55, 13);
            passwordLabel.TabIndex = 6;
            passwordLabel.Text = "password:";
            // 
            // db_kursachDataSet
            // 
            this.db_kursachDataSet.DataSetName = "db_kursachDataSet";
            this.db_kursachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginsBindingSource
            // 
            this.loginsBindingSource.DataMember = "logins";
            this.loginsBindingSource.DataSource = this.db_kursachDataSet;
            // 
            // loginsTableAdapter
            // 
            this.loginsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.gasTableAdapter = null;
            this.tableAdapterManager.heatTableAdapter = null;
            this.tableAdapterManager.loginsTableAdapter = this.loginsTableAdapter;
            this.tableAdapterManager.ObjectsTableAdapter = null;
            this.tableAdapterManager.oil_productionTableAdapter = null;
            this.tableAdapterManager.personalTableAdapter = null;
            this.tableAdapterManager.spentElectryciteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = kursach.db_kursachDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.water_injectionTableAdapter = null;
            this.tableAdapterManager.waterTableAdapter = null;
            // 
            // loginsDataGridView
            // 
            this.loginsDataGridView.AutoGenerateColumns = false;
            this.loginsDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loginsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.loginsDataGridView.DataSource = this.loginsBindingSource;
            this.loginsDataGridView.Location = new System.Drawing.Point(-2, 0);
            this.loginsDataGridView.Name = "loginsDataGridView";
            this.loginsDataGridView.Size = new System.Drawing.Size(353, 285);
            this.loginsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_per";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_per";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "login";
            this.dataGridViewTextBoxColumn2.HeaderText = "login";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn3.HeaderText = "password";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // id_perTextBox
            // 
            this.id_perTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginsBindingSource, "id_per", true));
            this.id_perTextBox.Location = new System.Drawing.Point(442, 51);
            this.id_perTextBox.Name = "id_perTextBox";
            this.id_perTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_perTextBox.TabIndex = 3;
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginsBindingSource, "login", true));
            this.loginTextBox.Location = new System.Drawing.Point(442, 77);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginTextBox.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginsBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(442, 103);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(522, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(384, 139);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(102, 23);
            this.add.TabIndex = 9;
            this.add.Text = "добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(384, 169);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(102, 23);
            this.save.TabIndex = 10;
            this.save.Text = "сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(384, 199);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(102, 23);
            this.change.TabIndex = 11;
            this.change.Text = "изменить";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(384, 229);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(102, 23);
            this.delete.TabIndex = 12;
            this.delete.Text = "удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(358, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Логины и пароли";
            // 
            // loginss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(549, 285);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.change);
            this.Controls.Add(this.save);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label1);
            this.Controls.Add(id_perLabel);
            this.Controls.Add(this.id_perTextBox);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginss";
            this.Text = "loginss";
            this.Load += new System.EventHandler(this.loginss_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginss_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginss_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.db_kursachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_kursachDataSet db_kursachDataSet;
        private System.Windows.Forms.BindingSource loginsBindingSource;
        private db_kursachDataSetTableAdapters.loginsTableAdapter loginsTableAdapter;
        private db_kursachDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView loginsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox id_perTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label2;
    }
}