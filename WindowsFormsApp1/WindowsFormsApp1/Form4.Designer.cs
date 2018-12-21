namespace WindowsFormsApp1
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bout = new System.Windows.Forms.Button();
            this.tcartype = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ttime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ttype = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bexit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "车牌号:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(71, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(184, 206);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bout
            // 
            this.bout.Location = new System.Drawing.Point(325, 214);
            this.bout.Name = "bout";
            this.bout.Size = new System.Drawing.Size(78, 28);
            this.bout.TabIndex = 20;
            this.bout.Text = "出场";
            this.bout.UseVisualStyleBackColor = true;
            this.bout.Click += new System.EventHandler(this.bout_Click);
            // 
            // tcartype
            // 
            this.tcartype.Location = new System.Drawing.Point(409, 43);
            this.tcartype.Name = "tcartype";
            this.tcartype.ReadOnly = true;
            this.tcartype.Size = new System.Drawing.Size(151, 21);
            this.tcartype.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 29;
            this.label6.Text = "车辆类型:";
            // 
            // ttime
            // 
            this.ttime.Location = new System.Drawing.Point(409, 139);
            this.ttime.Name = "ttime";
            this.ttime.ReadOnly = true;
            this.ttime.Size = new System.Drawing.Size(151, 21);
            this.ttime.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 26;
            this.label5.Text = "时长:";
            // 
            // ttype
            // 
            this.ttype.Location = new System.Drawing.Point(409, 91);
            this.ttype.Name = "ttype";
            this.ttype.ReadOnly = true;
            this.ttype.Size = new System.Drawing.Size(151, 21);
            this.ttype.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "停放类型:";
            // 
            // bexit
            // 
            this.bexit.Location = new System.Drawing.Point(531, 214);
            this.bexit.Name = "bexit";
            this.bexit.Size = new System.Drawing.Size(78, 28);
            this.bexit.TabIndex = 32;
            this.bexit.Text = "返回";
            this.bexit.UseVisualStyleBackColor = true;
            this.bexit.Click += new System.EventHandler(this.bexit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 28);
            this.button1.TabIndex = 33;
            this.button1.Text = "停车记录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.historyquery_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(651, 290);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bexit);
            this.Controls.Add(this.tcartype);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ttime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ttype);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bout);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "出场车辆管理";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bout;
        private System.Windows.Forms.TextBox tcartype;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ttime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ttype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bexit;
        private System.Windows.Forms.Button button1;
    }
}