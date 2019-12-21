namespace kursach
{
    partial class Form2
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
            this.objbut = new System.Windows.Forms.Button();
            this.personalbut = new System.Windows.Forms.Button();
            this.logbut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.watInjectbut = new System.Windows.Forms.Button();
            this.dobychabut = new System.Windows.Forms.Button();
            this.waterbut = new System.Windows.Forms.Button();
            this.gasbut = new System.Windows.Forms.Button();
            this.heatbut = new System.Windows.Forms.Button();
            this.electrobut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logg = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // objbut
            // 
            this.objbut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.objbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.objbut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.objbut.Location = new System.Drawing.Point(3, 3);
            this.objbut.Name = "objbut";
            this.objbut.Size = new System.Drawing.Size(133, 26);
            this.objbut.TabIndex = 0;
            this.objbut.Text = "объекты";
            this.objbut.UseVisualStyleBackColor = false;
            this.objbut.Click += new System.EventHandler(this.objbut_Click);
            // 
            // personalbut
            // 
            this.personalbut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.personalbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personalbut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.personalbut.Location = new System.Drawing.Point(3, 32);
            this.personalbut.Name = "personalbut";
            this.personalbut.Size = new System.Drawing.Size(133, 26);
            this.personalbut.TabIndex = 1;
            this.personalbut.Text = "персонал";
            this.personalbut.UseVisualStyleBackColor = false;
            this.personalbut.Click += new System.EventHandler(this.personalbut_Click);
            // 
            // logbut
            // 
            this.logbut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logbut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logbut.Location = new System.Drawing.Point(3, 61);
            this.logbut.Name = "logbut";
            this.logbut.Size = new System.Drawing.Size(133, 26);
            this.logbut.TabIndex = 2;
            this.logbut.Text = "логины";
            this.logbut.UseVisualStyleBackColor = false;
            this.logbut.Click += new System.EventHandler(this.logbut_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.logg);
            this.panel1.Controls.Add(this.watInjectbut);
            this.panel1.Controls.Add(this.dobychabut);
            this.panel1.Controls.Add(this.waterbut);
            this.panel1.Controls.Add(this.gasbut);
            this.panel1.Controls.Add(this.heatbut);
            this.panel1.Controls.Add(this.electrobut);
            this.panel1.Controls.Add(this.objbut);
            this.panel1.Controls.Add(this.logbut);
            this.panel1.Controls.Add(this.personalbut);
            this.panel1.Location = new System.Drawing.Point(75, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 307);
            this.panel1.TabIndex = 3;
            // 
            // watInjectbut
            // 
            this.watInjectbut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.watInjectbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.watInjectbut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.watInjectbut.Location = new System.Drawing.Point(3, 241);
            this.watInjectbut.Name = "watInjectbut";
            this.watInjectbut.Size = new System.Drawing.Size(133, 26);
            this.watInjectbut.TabIndex = 8;
            this.watInjectbut.Text = "закачка воды";
            this.watInjectbut.UseVisualStyleBackColor = false;
            this.watInjectbut.Click += new System.EventHandler(this.watInjectbut_Click);
            // 
            // dobychabut
            // 
            this.dobychabut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dobychabut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dobychabut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dobychabut.Location = new System.Drawing.Point(3, 211);
            this.dobychabut.Name = "dobychabut";
            this.dobychabut.Size = new System.Drawing.Size(133, 26);
            this.dobychabut.TabIndex = 7;
            this.dobychabut.Text = "добыча";
            this.dobychabut.UseVisualStyleBackColor = false;
            this.dobychabut.Click += new System.EventHandler(this.dobychabut_Click);
            // 
            // waterbut
            // 
            this.waterbut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.waterbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waterbut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.waterbut.Location = new System.Drawing.Point(3, 181);
            this.waterbut.Name = "waterbut";
            this.waterbut.Size = new System.Drawing.Size(133, 26);
            this.waterbut.TabIndex = 6;
            this.waterbut.Text = "вода";
            this.waterbut.UseVisualStyleBackColor = false;
            this.waterbut.Click += new System.EventHandler(this.waterbut_Click);
            // 
            // gasbut
            // 
            this.gasbut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gasbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gasbut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gasbut.Location = new System.Drawing.Point(3, 151);
            this.gasbut.Name = "gasbut";
            this.gasbut.Size = new System.Drawing.Size(133, 26);
            this.gasbut.TabIndex = 5;
            this.gasbut.Text = "газ";
            this.gasbut.UseVisualStyleBackColor = false;
            this.gasbut.Click += new System.EventHandler(this.gasbut_Click);
            // 
            // heatbut
            // 
            this.heatbut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.heatbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heatbut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.heatbut.Location = new System.Drawing.Point(3, 121);
            this.heatbut.Name = "heatbut";
            this.heatbut.Size = new System.Drawing.Size(133, 26);
            this.heatbut.TabIndex = 4;
            this.heatbut.Text = "тепло";
            this.heatbut.UseVisualStyleBackColor = false;
            this.heatbut.Click += new System.EventHandler(this.heatbut_Click);
            // 
            // electrobut
            // 
            this.electrobut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.electrobut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.electrobut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.electrobut.Location = new System.Drawing.Point(3, 91);
            this.electrobut.Name = "electrobut";
            this.electrobut.Size = new System.Drawing.Size(133, 26);
            this.electrobut.TabIndex = 3;
            this.electrobut.Text = "электричество";
            this.electrobut.UseVisualStyleBackColor = false;
            this.electrobut.Click += new System.EventHandler(this.electrobut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(262, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // logg
            // 
            this.logg.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logg.Location = new System.Drawing.Point(4, 274);
            this.logg.Name = "logg";
            this.logg.Size = new System.Drawing.Size(135, 26);
            this.logg.TabIndex = 9;
            this.logg.Text = "Логи";
            this.logg.UseVisualStyleBackColor = false;
            this.logg.Click += new System.EventHandler(this.logg_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 346);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button dobychabut;
        public System.Windows.Forms.Button waterbut;
        public System.Windows.Forms.Button gasbut;
        public System.Windows.Forms.Button heatbut;
        public System.Windows.Forms.Button electrobut;
        public System.Windows.Forms.Button watInjectbut;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button objbut;
        public System.Windows.Forms.Button personalbut;
        public System.Windows.Forms.Button logbut;
        private System.Windows.Forms.Button logg;
    }
}