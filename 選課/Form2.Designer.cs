namespace 排課
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
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.classid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.roomid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.instructor = new System.Windows.Forms.TextBox();
            this.grade = new System.Windows.Forms.ComboBox();
            this.credit = new System.Windows.Forms.ComboBox();
            this.must = new System.Windows.Forms.RadioButton();
            this.select = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.week = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.beginSection = new System.Windows.Forms.ComboBox();
            this.endSection = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.room = new System.Windows.Forms.TextBox();
            this.reset = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.common = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.name.Location = new System.Drawing.Point(108, 5);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(108, 29);
            this.name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "*名稱：";
            // 
            // enter
            // 
            this.enter.AutoSize = true;
            this.enter.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.enter.Location = new System.Drawing.Point(237, 186);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(82, 31);
            this.enter.TabIndex = 2;
            this.enter.Text = "確定";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "科目代碼：";
            // 
            // classid
            // 
            this.classid.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.classid.Location = new System.Drawing.Point(108, 40);
            this.classid.Name = "classid";
            this.classid.Size = new System.Drawing.Size(108, 29);
            this.classid.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "班級代碼：";
            // 
            // roomid
            // 
            this.roomid.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.roomid.Location = new System.Drawing.Point(108, 75);
            this.roomid.Name = "roomid";
            this.roomid.Size = new System.Drawing.Size(108, 29);
            this.roomid.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(241, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "年級：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(241, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "學分：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(5, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "任課教師：";
            // 
            // instructor
            // 
            this.instructor.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.instructor.Location = new System.Drawing.Point(101, 146);
            this.instructor.Name = "instructor";
            this.instructor.Size = new System.Drawing.Size(108, 29);
            this.instructor.TabIndex = 11;
            // 
            // grade
            // 
            this.grade.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grade.FormattingEnabled = true;
            this.grade.Items.AddRange(new object[] {
            "一",
            "二",
            "三",
            "四"});
            this.grade.Location = new System.Drawing.Point(305, 6);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(43, 28);
            this.grade.TabIndex = 13;
            this.grade.Text = "三";
            // 
            // credit
            // 
            this.credit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.credit.FormattingEnabled = true;
            this.credit.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.credit.Location = new System.Drawing.Point(305, 40);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(43, 28);
            this.credit.TabIndex = 14;
            this.credit.Text = "3";
            // 
            // must
            // 
            this.must.AutoSize = true;
            this.must.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.must.Location = new System.Drawing.Point(225, 76);
            this.must.Name = "must";
            this.must.Size = new System.Drawing.Size(60, 25);
            this.must.TabIndex = 15;
            this.must.Text = "必修";
            this.must.UseVisualStyleBackColor = true;
            // 
            // select
            // 
            this.select.AutoSize = true;
            this.select.Checked = true;
            this.select.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.select.Location = new System.Drawing.Point(291, 76);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(60, 25);
            this.select.TabIndex = 16;
            this.select.TabStop = true;
            this.select.Text = "選修";
            this.select.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(12, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "星期";
            // 
            // week
            // 
            this.week.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.week.FormattingEnabled = true;
            this.week.Items.AddRange(new object[] {
            "一",
            "二",
            "三",
            "四",
            "五",
            "六"});
            this.week.Location = new System.Drawing.Point(60, 112);
            this.week.Name = "week";
            this.week.Size = new System.Drawing.Size(43, 28);
            this.week.TabIndex = 19;
            this.week.Text = "一";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(109, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 21);
            this.label8.TabIndex = 20;
            this.label8.Text = "起節次";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(222, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "終節次";
            // 
            // beginSection
            // 
            this.beginSection.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.beginSection.FormattingEnabled = true;
            this.beginSection.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "20",
            "5",
            "6",
            "7",
            "8",
            "9",
            "30",
            "40",
            "50",
            "60",
            "70"});
            this.beginSection.Location = new System.Drawing.Point(173, 112);
            this.beginSection.Name = "beginSection";
            this.beginSection.Size = new System.Drawing.Size(43, 28);
            this.beginSection.TabIndex = 22;
            this.beginSection.Text = "1";
            this.beginSection.SelectionChangeCommitted += new System.EventHandler(this.beginSecion_SelectionChangeCommitted);
            // 
            // endSection
            // 
            this.endSection.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.endSection.FormattingEnabled = true;
            this.endSection.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "20",
            "5",
            "6",
            "7",
            "8",
            "9",
            "30",
            "40",
            "50",
            "60",
            "70"});
            this.endSection.Location = new System.Drawing.Point(286, 112);
            this.endSection.Name = "endSection";
            this.endSection.Size = new System.Drawing.Size(43, 28);
            this.endSection.TabIndex = 23;
            this.endSection.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(215, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 21);
            this.label10.TabIndex = 25;
            this.label10.Text = "教室：";
            // 
            // room
            // 
            this.room.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.room.Location = new System.Drawing.Point(279, 146);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(108, 29);
            this.room.TabIndex = 24;
            // 
            // reset
            // 
            this.reset.AutoSize = true;
            this.reset.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.reset.Location = new System.Drawing.Point(9, 186);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(82, 31);
            this.reset.TabIndex = 26;
            this.reset.Text = "清空";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // cancel
            // 
            this.cancel.AutoSize = true;
            this.cancel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cancel.Location = new System.Drawing.Point(325, 186);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(82, 31);
            this.cancel.TabIndex = 27;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // common
            // 
            this.common.AutoSize = true;
            this.common.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.common.Location = new System.Drawing.Point(357, 76);
            this.common.Name = "common";
            this.common.Size = new System.Drawing.Size(60, 25);
            this.common.TabIndex = 28;
            this.common.Text = "通識";
            this.common.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 233);
            this.Controls.Add(this.common);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.room);
            this.Controls.Add(this.endSection);
            this.Controls.Add(this.beginSection);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.week);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.select);
            this.Controls.Add(this.must);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.instructor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roomid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.classid);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "課程資訊";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox classid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox roomid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox instructor;
        private System.Windows.Forms.ComboBox grade;
        private System.Windows.Forms.ComboBox credit;
        private System.Windows.Forms.RadioButton must;
        private System.Windows.Forms.RadioButton select;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox week;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox beginSection;
        private System.Windows.Forms.ComboBox endSection;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox room;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.RadioButton common;


    }
}