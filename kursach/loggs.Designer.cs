namespace kursach
{
    partial class loggs
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
            this.db_kursachDataSet1 = new kursach.db_kursachDataSet1();
            this.logsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logsTableAdapter = new kursach.db_kursachDataSet1TableAdapters.logsTableAdapter();
            this.tableAdapterManager = new kursach.db_kursachDataSet1TableAdapters.TableAdapterManager();
            this.logsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.loggsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.db_kursachDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loggsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // db_kursachDataSet1
            // 
            this.db_kursachDataSet1.DataSetName = "db_kursachDataSet1";
            this.db_kursachDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logsBindingSource
            // 
            this.logsBindingSource.DataMember = "logs";
            this.logsBindingSource.DataSource = this.db_kursachDataSet1;
            // 
            // logsTableAdapter
            // 
            this.logsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.logsTableAdapter = this.logsTableAdapter;
            this.tableAdapterManager.UpdateOrder = kursach.db_kursachDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // logsDataGridView
            // 
            this.logsDataGridView.AutoGenerateColumns = false;
            this.logsDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.logsDataGridView.DataSource = this.logsBindingSource;
            this.logsDataGridView.Location = new System.Drawing.Point(0, -2);
            this.logsDataGridView.Name = "logsDataGridView";
            this.logsDataGridView.Size = new System.Drawing.Size(536, 236);
            this.logsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_log";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_log";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "data";
            this.dataGridViewTextBoxColumn2.HeaderText = "data";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "text";
            this.dataGridViewTextBoxColumn3.HeaderText = "text";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(568, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // loggsBindingSource
            // 
            this.loggsBindingSource.DataSource = typeof(kursach.loggs);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(542, 87);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 36);
            this.del.TabIndex = 11;
            this.del.Text = "удалить логи";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // loggs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(624, 235);
            this.Controls.Add(this.del);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loggs";
            this.Text = "loggs";
            this.Load += new System.EventHandler(this.loggs_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loggs_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loggs_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.db_kursachDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loggsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource loggsBindingSource;
        private db_kursachDataSet1 db_kursachDataSet1;
        private System.Windows.Forms.BindingSource logsBindingSource;
        private db_kursachDataSet1TableAdapters.logsTableAdapter logsTableAdapter;
        private db_kursachDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView logsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button del;
    }
}