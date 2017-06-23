using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 排課
{
    public partial class Form2 : Form
    {
        string[] section = new string[] { "1", "2", "3", "4", "20", "5", "6", "7", "8", "9", "30", "40", "50", "60", "70" };
        string[] weeks = new string[] { "一", "二", "三", "四", "五", "六" };
        public Form2()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, EventArgs e)
        {            
            if (name.Text == string.Empty) { MessageBox.Show("名稱呢?", "未輸入值", MessageBoxButtons.OK, MessageBoxIcon.Warning); name.Focus(); }
            else this.DialogResult = DialogResult.OK;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            DialogResult result=MessageBox.Show("你認真?","重置",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.OK:
                    name.Text = ""; classid.Text=""; roomid.Text=""; instructor.Text=""; room.Text="";
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        public Course form2Value
        {
            set 
            {
                Course f1v = new Course(); f1v = value;
                beginSection.SelectedIndex = Array.IndexOf(section, f1v.beginSection);
                if (f1v.classid.Equals("?")) classid.Text = string.Empty;
                else classid.Text = f1v.classid;
                credit.Text = f1v.credit.ToString();
                endSection.SelectedIndex = Array.IndexOf(section, f1v.endSection);
                grade.Text = f1v.grade;
                instructor.Text = f1v.instructor;
                switch (f1v.mustselectcommon)
                {
                    case "必修":
                        must.Checked = true; select.Checked=false; common.Checked=false;
                        break;
                    case "選修":
                        must.Checked = false; select.Checked = true; common.Checked = false;
                        break;
                    case "通識":
                        must.Checked = false; select.Checked = false; common.Checked = true;
                        break;
                }
                //if (f1v.mustselect.Equals(must.Text)) { must.Checked = true; select.Checked = false; }
                //else { must.Checked = false; select.Checked = true; }
                name.Text = f1v.name;
                room.Text = f1v.room;
                if (f1v.roomid.Equals("?")) roomid.Text = string.Empty;
                else roomid.Text = f1v.roomid;
                week.Text = weeks[f1v.week];
            }
            get 
            {
                Course f2v = new Course();
                f2v.beginSection = beginSection.Text;
                if (classid.Text == string.Empty) f2v.classid = "?";
                else f2v.classid = classid.Text;
                f2v.credit = credit.SelectedIndex;
                f2v.endSection = endSection.Text;
                f2v.grade = grade.Text;
                f2v.instructor = instructor.Text;
                if(must.Checked) f2v.mustselectcommon=must.Text;
                else if(select.Checked) f2v.mustselectcommon=select.Text;
                else f2v.mustselectcommon=common.Text;
                f2v.name = name.Text;
                f2v.room = room.Text;
                if (roomid.Text == string.Empty) f2v.roomid = "?";
                else f2v.roomid = roomid.Text;
                f2v.week = week.SelectedIndex;
                return f2v;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void beginSecion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            endSection.Items.Clear();
            int index = beginSection.SelectedIndex;
            for (int i = index; i < section.Length; i++) endSection.Items.Add(section[i]);
            endSection.Text = section[index];
        }
        
    }
}
