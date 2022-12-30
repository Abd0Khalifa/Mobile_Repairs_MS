
namespace Mobile_Repairs_MS
{
    partial class Repairs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Repairs));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.RepairsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.PhoneTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProblemTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DNameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RepDateTb = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.CustCb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ModelTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SpareCb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SpareCostTb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TotalTb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepairsList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(65, 650);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // RepairsList
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.RepairsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RepairsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.RepairsList.ColumnHeadersHeight = 4;
            this.RepairsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RepairsList.DefaultCellStyle = dataGridViewCellStyle18;
            this.RepairsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RepairsList.Location = new System.Drawing.Point(442, 100);
            this.RepairsList.Name = "RepairsList";
            this.RepairsList.RowHeadersVisible = false;
            this.RepairsList.Size = new System.Drawing.Size(613, 538);
            this.RepairsList.TabIndex = 27;
            this.RepairsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.RepairsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.RepairsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.RepairsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.RepairsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.RepairsList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.RepairsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RepairsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RepairsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RepairsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepairsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.RepairsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.RepairsList.ThemeStyle.HeaderStyle.Height = 4;
            this.RepairsList.ThemeStyle.ReadOnly = false;
            this.RepairsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.RepairsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RepairsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepairsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RepairsList.ThemeStyle.RowsStyle.Height = 22;
            this.RepairsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RepairsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel3.Location = new System.Drawing.Point(415, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 538);
            this.panel3.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(90, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 4);
            this.panel2.TabIndex = 25;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.DeleteBtn.Location = new System.Drawing.Point(232, 579);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(108, 34);
            this.DeleteBtn.TabIndex = 24;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Blue;
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.SaveBtn.Location = new System.Drawing.Point(118, 579);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(108, 34);
            this.SaveBtn.TabIndex = 22;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // PhoneTb
            // 
            this.PhoneTb.Font = new System.Drawing.Font("Trebuchet MS", 13F);
            this.PhoneTb.Location = new System.Drawing.Point(117, 224);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(222, 28);
            this.PhoneTb.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Phone Number";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ProblemTb
            // 
            this.ProblemTb.Font = new System.Drawing.Font("Trebuchet MS", 13F);
            this.ProblemTb.Location = new System.Drawing.Point(117, 392);
            this.ProblemTb.Name = "ProblemTb";
            this.ProblemTb.Size = new System.Drawing.Size(222, 28);
            this.ProblemTb.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Customer";
            // 
            // DNameTb
            // 
            this.DNameTb.Font = new System.Drawing.Font("Trebuchet MS", 13F);
            this.DNameTb.Location = new System.Drawing.Point(118, 280);
            this.DNameTb.Name = "DNameTb";
            this.DNameTb.Size = new System.Drawing.Size(222, 28);
            this.DNameTb.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Repair Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(86, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mobile Repair Management System";
            // 
            // RepDateTb
            // 
            this.RepDateTb.Checked = true;
            this.RepDateTb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RepDateTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RepDateTb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.RepDateTb.Location = new System.Drawing.Point(117, 102);
            this.RepDateTb.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.RepDateTb.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.RepDateTb.Name = "RepDateTb";
            this.RepDateTb.Size = new System.Drawing.Size(222, 36);
            this.RepDateTb.TabIndex = 28;
            this.RepDateTb.Value = new System.DateTime(2022, 12, 29, 21, 49, 37, 919);
            // 
            // CustCb
            // 
            this.CustCb.FormattingEnabled = true;
            this.CustCb.Location = new System.Drawing.Point(117, 166);
            this.CustCb.Name = "CustCb";
            this.CustCb.Size = new System.Drawing.Size(222, 30);
            this.CustCb.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 22);
            this.label5.TabIndex = 30;
            this.label5.Text = "Device Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 22);
            this.label6.TabIndex = 32;
            this.label6.Text = "Device Model";
            // 
            // ModelTb
            // 
            this.ModelTb.Font = new System.Drawing.Font("Trebuchet MS", 13F);
            this.ModelTb.Location = new System.Drawing.Point(118, 336);
            this.ModelTb.Name = "ModelTb";
            this.ModelTb.Size = new System.Drawing.Size(222, 28);
            this.ModelTb.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 22);
            this.label7.TabIndex = 33;
            this.label7.Text = "Problem";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // SpareCb
            // 
            this.SpareCb.FormattingEnabled = true;
            this.SpareCb.Location = new System.Drawing.Point(117, 448);
            this.SpareCb.Name = "SpareCb";
            this.SpareCb.Size = new System.Drawing.Size(222, 30);
            this.SpareCb.TabIndex = 35;
            this.SpareCb.SelectedIndexChanged += new System.EventHandler(this.SpareCb_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(113, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 22);
            this.label8.TabIndex = 34;
            this.label8.Text = "Spare";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 495);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 22);
            this.label9.TabIndex = 37;
            this.label9.Text = "Spare Cost ";
            // 
            // SpareCostTb
            // 
            this.SpareCostTb.Enabled = false;
            this.SpareCostTb.Font = new System.Drawing.Font("Trebuchet MS", 13F);
            this.SpareCostTb.Location = new System.Drawing.Point(117, 520);
            this.SpareCostTb.Name = "SpareCostTb";
            this.SpareCostTb.Size = new System.Drawing.Size(109, 28);
            this.SpareCostTb.TabIndex = 36;
            this.SpareCostTb.TextChanged += new System.EventHandler(this.SpareCostTb_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(223, 495);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 22);
            this.label10.TabIndex = 39;
            this.label10.Text = "Repair Cost ";
            // 
            // TotalTb
            // 
            this.TotalTb.Font = new System.Drawing.Font("Trebuchet MS", 13F);
            this.TotalTb.Location = new System.Drawing.Point(227, 520);
            this.TotalTb.Name = "TotalTb";
            this.TotalTb.Size = new System.Drawing.Size(109, 28);
            this.TotalTb.TabIndex = 38;
            // 
            // Repairs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1070, 650);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TotalTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SpareCostTb);
            this.Controls.Add(this.SpareCb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ModelTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CustCb);
            this.Controls.Add(this.RepDateTb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RepairsList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProblemTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DNameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Repairs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repairs";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepairsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DataGridView RepairsList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox PhoneTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProblemTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DNameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ModelTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CustCb;
        private Guna.UI2.WinForms.Guna2DateTimePicker RepDateTb;
        private System.Windows.Forms.ComboBox SpareCb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TotalTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SpareCostTb;
    }
}