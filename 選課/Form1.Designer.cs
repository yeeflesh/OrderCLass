namespace 排課
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.data = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mustselectcommon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.week = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beginSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.schedule = new System.Windows.Forms.DataGridView();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedule)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.schedule);
            this.splitContainer1.Size = new System.Drawing.Size(1279, 772);
            this.splitContainer1.SplitterDistance = 676;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.data);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.clear);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.output);
            this.splitContainer2.Panel2.Controls.Add(this.delete);
            this.splitContainer2.Panel2.Controls.Add(this.edit);
            this.splitContainer2.Panel2.Controls.Add(this.add);
            this.splitContainer2.Panel2.Click += new System.EventHandler(this.splitContainer2_Panel2_Click);
            this.splitContainer2.Size = new System.Drawing.Size(676, 772);
            this.splitContainer2.SplitterDistance = 33;
            this.splitContainer2.TabIndex = 0;
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.classid,
            this.roomid,
            this.credit,
            this.mustselectcommon,
            this.instructor,
            this.grade,
            this.room,
            this.week,
            this.beginSection,
            this.endSection});
            this.data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data.Location = new System.Drawing.Point(0, 0);
            this.data.Name = "data";
            this.data.RowTemplate.Height = 24;
            this.data.Size = new System.Drawing.Size(676, 33);
            this.data.TabIndex = 1;
            this.data.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.data_CellMouseDown);
            this.data.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.data_CellMouseMove);
            this.data.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.data_CellMouseUp);
            this.data.MouseLeave += new System.EventHandler(this.data_MouseLeave);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.name.DefaultCellStyle = dataGridViewCellStyle1;
            this.name.FillWeight = 125F;
            this.name.HeaderText = "名稱";
            this.name.MinimumWidth = 20;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // classid
            // 
            this.classid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.classid.DefaultCellStyle = dataGridViewCellStyle2;
            this.classid.HeaderText = "科目代碼";
            this.classid.Name = "classid";
            this.classid.ReadOnly = true;
            this.classid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // roomid
            // 
            this.roomid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.roomid.DefaultCellStyle = dataGridViewCellStyle3;
            this.roomid.HeaderText = "班級代碼";
            this.roomid.Name = "roomid";
            this.roomid.ReadOnly = true;
            this.roomid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // credit
            // 
            this.credit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.credit.DefaultCellStyle = dataGridViewCellStyle4;
            this.credit.FillWeight = 45F;
            this.credit.HeaderText = "學分";
            this.credit.MinimumWidth = 2;
            this.credit.Name = "credit";
            this.credit.ReadOnly = true;
            // 
            // mustselectcommon
            // 
            this.mustselectcommon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.mustselectcommon.DefaultCellStyle = dataGridViewCellStyle5;
            this.mustselectcommon.FillWeight = 45F;
            this.mustselectcommon.HeaderText = "選別";
            this.mustselectcommon.MinimumWidth = 2;
            this.mustselectcommon.Name = "mustselectcommon";
            this.mustselectcommon.ReadOnly = true;
            // 
            // instructor
            // 
            this.instructor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.instructor.DefaultCellStyle = dataGridViewCellStyle6;
            this.instructor.FillWeight = 70F;
            this.instructor.HeaderText = "教師";
            this.instructor.Name = "instructor";
            this.instructor.ReadOnly = true;
            this.instructor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // grade
            // 
            this.grade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grade.DefaultCellStyle = dataGridViewCellStyle7;
            this.grade.FillWeight = 45F;
            this.grade.HeaderText = "年級";
            this.grade.MinimumWidth = 2;
            this.grade.Name = "grade";
            this.grade.ReadOnly = true;
            // 
            // room
            // 
            this.room.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.room.DefaultCellStyle = dataGridViewCellStyle8;
            this.room.FillWeight = 65F;
            this.room.HeaderText = "教室";
            this.room.Name = "room";
            this.room.ReadOnly = true;
            this.room.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // week
            // 
            this.week.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.week.DefaultCellStyle = dataGridViewCellStyle9;
            this.week.FillWeight = 45F;
            this.week.HeaderText = "星期";
            this.week.MinimumWidth = 2;
            this.week.Name = "week";
            this.week.ReadOnly = true;
            // 
            // beginSection
            // 
            this.beginSection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.beginSection.DefaultCellStyle = dataGridViewCellStyle10;
            this.beginSection.FillWeight = 80F;
            this.beginSection.HeaderText = "起節次";
            this.beginSection.MinimumWidth = 2;
            this.beginSection.Name = "beginSection";
            this.beginSection.ReadOnly = true;
            this.beginSection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // endSection
            // 
            this.endSection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.endSection.DefaultCellStyle = dataGridViewCellStyle11;
            this.endSection.FillWeight = 80F;
            this.endSection.HeaderText = "終節次";
            this.endSection.MinimumWidth = 2;
            this.endSection.Name = "endSection";
            this.endSection.ReadOnly = true;
            this.endSection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clear
            // 
            this.clear.AutoSize = true;
            this.clear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clear.Location = new System.Drawing.Point(470, 3);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(82, 31);
            this.clear.TabIndex = 8;
            this.clear.Text = "清空";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(29, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "學分";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "0";
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.output.Location = new System.Drawing.Point(591, 3);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(82, 31);
            this.output.TabIndex = 3;
            this.output.Text = "匯出";
            this.output.UseVisualStyleBackColor = true;
            this.output.Click += new System.EventHandler(this.output_Click);
            // 
            // delete
            // 
            this.delete.AutoSize = true;
            this.delete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.delete.Location = new System.Drawing.Point(354, 3);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(82, 31);
            this.delete.TabIndex = 2;
            this.delete.Text = "刪除";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.AutoSize = true;
            this.edit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.edit.Location = new System.Drawing.Point(266, 3);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(82, 31);
            this.edit.TabIndex = 1;
            this.edit.Text = "修改";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.add.Location = new System.Drawing.Point(178, 3);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(82, 31);
            this.add.TabIndex = 0;
            this.add.Text = "新增";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // schedule
            // 
            this.schedule.AllowUserToAddRows = false;
            this.schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.time,
            this.monday,
            this.tuesday,
            this.wednesday,
            this.thursday,
            this.friday,
            this.saturday});
            this.schedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedule.Location = new System.Drawing.Point(0, 0);
            this.schedule.Name = "schedule";
            this.schedule.ReadOnly = true;
            this.schedule.RowTemplate.Height = 24;
            this.schedule.Size = new System.Drawing.Size(599, 772);
            this.schedule.TabIndex = 1;
            this.schedule.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.schedule_CellMouseDown);
            this.schedule.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.schedule_CellMouseUp);
            // 
            // time
            // 
            this.time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.time.DefaultCellStyle = dataGridViewCellStyle12;
            this.time.FillWeight = 70F;
            this.time.HeaderText = "";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // monday
            // 
            this.monday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.monday.DefaultCellStyle = dataGridViewCellStyle13;
            this.monday.HeaderText = "一";
            this.monday.Name = "monday";
            this.monday.ReadOnly = true;
            this.monday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tuesday
            // 
            this.tuesday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tuesday.DefaultCellStyle = dataGridViewCellStyle14;
            this.tuesday.HeaderText = "二";
            this.tuesday.Name = "tuesday";
            this.tuesday.ReadOnly = true;
            this.tuesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // wednesday
            // 
            this.wednesday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.wednesday.DefaultCellStyle = dataGridViewCellStyle15;
            this.wednesday.HeaderText = "三";
            this.wednesday.Name = "wednesday";
            this.wednesday.ReadOnly = true;
            this.wednesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // thursday
            // 
            this.thursday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.thursday.DefaultCellStyle = dataGridViewCellStyle16;
            this.thursday.HeaderText = "四";
            this.thursday.Name = "thursday";
            this.thursday.ReadOnly = true;
            this.thursday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // friday
            // 
            this.friday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.friday.DefaultCellStyle = dataGridViewCellStyle17;
            this.friday.HeaderText = "五";
            this.friday.Name = "friday";
            this.friday.ReadOnly = true;
            this.friday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // saturday
            // 
            this.saturday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.saturday.DefaultCellStyle = dataGridViewCellStyle18;
            this.saturday.HeaderText = "六";
            this.saturday.Name = "saturday";
            this.saturday.ReadOnly = true;
            this.saturday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 772);
            this.Controls.Add(this.splitContainer1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "排課";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView schedule;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn friday;
        private System.Windows.Forms.DataGridViewTextBoxColumn saturday;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn classid;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomid;
        private System.Windows.Forms.DataGridViewTextBoxColumn credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn mustselectcommon;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructor;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn room;
        private System.Windows.Forms.DataGridViewTextBoxColumn week;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn endSection;


    }
}

