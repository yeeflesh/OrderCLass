using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System.Security.AccessControl;

namespace 排課
{
    public partial class Form1 : Form
    {
        static string[] section = new string[] { "1", "2", "3", "4", "20", "5", "6", "7", "8", "9", "30", "40", "50", "60","70"};
        static string[] weeks = new string[] { "一", "二", "三", "四", "五", "六" };
        public Form1()
        {
            InitializeComponent();
            //Form功能表建立
            MainMenu mnuFileMenu = new MainMenu();
            this.Menu = mnuFileMenu;
            /*MenuItem myMenuItemFile = new MenuItem("&檔案");
            mnuFileMenu.MenuItems.Add(myMenuItemFile);*/
            MenuItem myMenuItemNew = new MenuItem("&開啟新課表(N)");
            MenuItem myMenuItemOld = new MenuItem("&讀取舊課表(O)");
            MenuItem myMenuItemSave = new MenuItem("&儲存檔案(S)");
            MenuItem myMenuItemSaveAs = new MenuItem("&另存新檔");
            MenuItem myMenuItemHelp = new MenuItem("&說明");
            mnuFileMenu.MenuItems.Add(myMenuItemNew);
            mnuFileMenu.MenuItems.Add(myMenuItemOld);
            mnuFileMenu.MenuItems.Add(myMenuItemSave);
            mnuFileMenu.MenuItems.Add(myMenuItemSaveAs);
            mnuFileMenu.MenuItems.Add(myMenuItemHelp);
            myMenuItemNew.Click += new System.EventHandler(this.myMenuItemNew_Click);
            myMenuItemOld.Click += new System.EventHandler(this.myMenuItemOld_Click);
            myMenuItemSave.Click += new System.EventHandler(this.myMenuItemSave_Click);
            myMenuItemSaveAs.Click += new System.EventHandler(this.myMenuItemSaveAs_Click);
            myMenuItemHelp.Click += new System.EventHandler(this.myMenuItemHelp_Click);
            //data左上角方框停用
            data.RowHeadersVisible = false;
            //表格標題填色
            data.EnableHeadersVisualStyles = false;
            data.ColumnHeadersDefaultCellStyle.BackColor = Color.Azure;
            data.RowHeadersDefaultCellStyle.BackColor = Color.Azure;
            //CLICK CELL選取ROW
            data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //一次只能選擇一列
            data.MultiSelect = false;
            schedule.MultiSelect = false;
            //不讓使用者拉動分割
            splitContainer1.IsSplitterFixed = true;
            splitContainer2.IsSplitterFixed = true;
            //讓儲存格換行
            schedule.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //標題及內容置中
            foreach (DataGridViewColumn col in schedule.Columns) { col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; col.Resizable = DataGridViewTriState.False;  }
            foreach (DataGridViewColumn col in data.Columns) { col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; col.Resizable = DataGridViewTriState.False; }
            //不讓使用者互動
            //schedule.Enabled = false;
            drawEmptyScehdule();          
            //schedule.ReadOnly = true;
            //schedule[0, 0].Value = "華人力屎\r\n王大明\r\nEE303";                 
        }
        private Course getData(DataGridViewRow r)
        {
            Course cd = new Course();
            cd.name = r.Cells[name.Name].Value.ToString();
            cd.classid = r.Cells[classid.Name].Value.ToString();
            cd.roomid = r.Cells[roomid.Name].Value.ToString();
            cd.credit = int.Parse(r.Cells[credit.Name].Value.ToString());
            cd.mustselectcommon = r.Cells[mustselectcommon.Name].Value.ToString();
            cd.instructor = r.Cells[instructor.Name].Value.ToString();
            cd.grade = r.Cells[grade.Name].Value.ToString();
            cd.room = r.Cells[room.Name].Value.ToString();
            cd.week = Array.IndexOf(weeks, r.Cells[week.Name].Value.ToString());
            cd.beginSection = r.Cells[beginSection.Name].Value.ToString();
            cd.endSection = r.Cells[endSection.Name].Value.ToString();  
            return cd;
        }
        private void drawEmptyScehdule()
        {
            //清空課表
            schedule.Rows.Clear();
            //data左上角方框停用
            schedule.RowHeadersVisible = false;
            //表格標題填色
            schedule.EnableHeadersVisualStyles = false;
            schedule.ColumnHeadersDefaultCellStyle.BackColor = Color.OldLace;
            //schedule.RowHeadersDefaultCellStyle.BackColor = Color.OldLace;
            //格子大小均分
            for (int i = 0; i < section.Length; i++)
            {                
                //schedule.Rows[i].Cells[0].Value = section[i];
                schedule.Rows.Add(new object[] { section[i], null, null, null, null, null, null });
                schedule.Rows[i].Cells[time.Name].Style.BackColor = Color.OldLace;
                schedule.Rows[i].Height = (schedule.Height -15) / (section.Length);
                schedule.RowHeadersWidth = 50;
                //schedule.
                schedule.Rows[i].Resizable = DataGridViewTriState.False;
            }
            //讓選取反白消失
            schedule.DefaultCellStyle.SelectionBackColor = Color.OldLace;
            schedule.DefaultCellStyle.SelectionForeColor = schedule.DefaultCellStyle.ForeColor;
            //清除所選範圍的highlight
            schedule.CurrentCell = schedule[0, 0];
            //schedule.CurrentCell.Selected = false;
            schedule.ClearSelection();
            schedule.CurrentCell = null;          
        }
        private void drawSchedule()
        {
            //先清空課表
            drawEmptyScehdule();
            //data左上角方框停用
            schedule.RowHeadersVisible = false;
            for (int r = 0; r < data.RowCount; r++)
            {
                Course cd=getData(data.Rows[r]);
                int beginSection = Array.IndexOf(section, cd.beginSection);
                int endSection = Array.IndexOf(section, cd.endSection);
                for (int i = beginSection; i <= endSection; i++)
                {
                    DataGridViewCell sc = schedule[cd.week + 1, i];
                    if (cd.room == string.Empty) sc.Value = cd.name;
                    else sc.Value = cd.name + "\r\n" + cd.room;
                    switch (cd.mustselectcommon)
                    {
                        case "必修":
                            sc.Style.BackColor = Color.SkyBlue;
                            break;
                        case "選修":
                            sc.Style.BackColor = Color.LimeGreen;
                            break;
                        case "通識":
                            sc.Style.BackColor = Color.PeachPuff;
                            break;
                    }
                }
            }            
            //讓選取反白消失
            schedule.DefaultCellStyle.SelectionBackColor = schedule.DefaultCellStyle.BackColor;
            schedule.DefaultCellStyle.SelectionForeColor = schedule.DefaultCellStyle.ForeColor;
            //清除所選範圍的FOCUS
            schedule.CurrentCell = schedule[0, 0];
            schedule.ClearSelection();
            schedule.CurrentCell = null;
        }
        private void insertData(ref Course f2v)
        {
            //新增課程資料
            DataGridViewRowCollection rows = data.Rows;
            rows.Add(new Object[] { f2v.name, f2v.classid, f2v.roomid, f2v.credit, f2v.mustselectcommon, f2v.instructor, 
                f2v.grade, f2v.room, weeks[f2v.week], f2v.beginSection, f2v.endSection });
            //重要資料表格填色
            switch (f2v.mustselectcommon)
            {
                case "必修":
                    rows[data.RowCount - 1].Cells[mustselectcommon.Name].Style.BackColor = Color.SkyBlue;
                    break;
                case "選修":
                    rows[data.RowCount - 1].Cells[mustselectcommon.Name].Style.BackColor = Color.LimeGreen;
                    break;
                case "通識":
                    rows[data.RowCount - 1].Cells[mustselectcommon.Name].Style.BackColor = Color.PeachPuff;
                    break;
            }
            //for (int i = 0; i < 8; i++) if (i != 4) rows[data.RowCount - 1].Cells[i].Style.BackColor = Color.BlanchedAlmond;
            for (int i = 8; i <= 10; i++) rows[data.RowCount - 1].Cells[i].Style.BackColor = Color.OldLace;
            //選取整列
            data.ClearSelection();
            data.Rows[data.RowCount - 1].Selected = true;
            data.CurrentCell = data.Rows[data.RowCount - 1].Cells[0]; 
            //不讓使用者變更大小
            data.Rows[data.RowCount - 1].Resizable = DataGridViewTriState.False;
            //排序
            dataSort();
        }
        private int measureCredit()
        {
            int mc=0;
            for (int r = 0; r < data.RowCount; r++)
                mc += int.Parse(data.Rows[r].Cells[credit.Name].Value.ToString());
            return mc;
        }

        private class TimeComparar : System.Collections.IComparer
        {
            private static int sortOrderModifier = 1;

            public TimeComparar(SortOrder sortOrder)
            {
                if (sortOrder == SortOrder.Descending)
                {
                    sortOrderModifier = -1;
                }
                else if (sortOrder == SortOrder.Ascending)
                {
                    sortOrderModifier = 1;
                }
            }

            public int Compare(object x, object y)
            {
                DataGridViewRow rx = (DataGridViewRow)x;
                DataGridViewRow ry = (DataGridViewRow)y;
                int indexOfx = Array.IndexOf(weeks, rx.Cells[8].Value.ToString());
                int indexOfy = Array.IndexOf(weeks, ry.Cells[8].Value.ToString());
                int result = indexOfx - indexOfy;
                if (result == 0)
                {
                    int sectionIndexOfx = Array.IndexOf(section, rx.Cells[9].Value.ToString());
                    int sectionIndexOfy = Array.IndexOf(section, ry.Cells[9].Value.ToString());
                    result = sectionIndexOfx - sectionIndexOfy;
                }
                return result * sortOrderModifier;
                throw new NotImplementedException();
            }
        }
        private void dataSort()
        {
            //Console.WriteLine("123");
            //data.Sort(new SectionComparar(SortOrder.Ascending));
            data.Sort(new TimeComparar(SortOrder.Ascending));
        }
        private void saveSign(bool b)
        {
            if (b)
            {
                //未存檔符號
                if (this.Text.Substring(this.Text.Length - 1).Equals("*") != true) this.Text += "*";
            }
            else
            {
                //刪除未存檔符號
                this.Text = this.Text.Substring(0, this.Text.Length - 1);
            }
        }
        private void add_Click(object sender, EventArgs e)
        {      
            Form2 f2 = new Form2();            
            //f2.ShowDialog(this);
            if (f2.ShowDialog(this) == DialogResult.OK)
            {
                //Form2資料傳送給Form1
                Course f2v = f2.form2Value;
                //新增資料
                insertData(ref f2v);
                //修改分割的上下距離
                splitContainer2.SplitterDistance += data.Rows[0].Height;
                //畫課表
                drawSchedule();               
                //計算學分
                label1.Text = measureCredit().ToString();
                //未存檔符號
                saveSign(true);
            }
            //this.Hide();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (data.RowCount != 0 && data.CurrentCell != null)
            {
                //取得選取列
                int select = data.CurrentRow.Index;
                DataGridViewRow r = data.Rows[select];
                //取出資料
                Course cd = getData(r);
                //開啟Form2
                Form2 f2 = new Form2();
                //Form1資料傳送給Form2
                f2.form2Value = cd;
                if (f2.ShowDialog(this) == DialogResult.OK)
                {
                    //刪除列
                    data.Rows.Remove(data.Rows[select]);
                    //Form2資料傳送給Form1
                    cd = f2.form2Value;
                    //新增資料
                    insertData(ref cd);
                    //畫課表
                    drawSchedule();
                    //計算學分
                    label1.Text = measureCredit().ToString();
                    //未存檔符號
                    saveSign(true);
                }
            }
        }
        private void delete_Click(object sender, EventArgs e)
        {
            if (data.RowCount != 0 && data.CurrentCell != null)
            {
                DialogResult result = MessageBox.Show("確定?", "刪除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                switch (result)
                {
                    case DialogResult.OK:
                        //取得選取列
                        int select = data.CurrentRow.Index;
                        //修改分割的上下距離
                        splitContainer2.SplitterDistance -= data.Rows[select].Height;
                        //刪除
                        data.Rows.Remove(data.Rows[select]);
                        //計算學分
                        label1.Text = measureCredit().ToString();
                        //畫課表
                        drawSchedule();
                        //未存檔符號
                        saveSign(true);
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            if (data.RowCount != 0)
            {
                DialogResult result = MessageBox.Show("確定?", "清除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                switch (result)
                {
                    case DialogResult.OK:
                        label1.Text = "0";
                        for (int i = 0; i < data.RowCount; i++)
                            splitContainer2.SplitterDistance -= data.Rows[i].Height;
                        data.Rows.Clear();
                        schedule.Rows.Clear();
                        drawEmptyScehdule();
                        //未存檔符號
                        saveSign(true);
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
        }

        private void data_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    int select = e.RowIndex;
                    data.Rows[select].Selected = true;
                }
            }
            catch (Exception x)
            {
                x.GetBaseException();
            }        
        }               
        private void splitContainer2_Panel2_Click(object sender, EventArgs e)
        {
            data.ClearSelection();
            data.CurrentCell = null;
        }
        
        private void output_Click(object sender, EventArgs e)
        {
            if (data.RowCount != 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                DirectoryInfo dir = new DirectoryInfo(System.Windows.Forms.Application.StartupPath);
                sfd.InitialDirectory = dir.FullName; // 檔案對話方框開啟的預設資料夾
                sfd.FileName = "選課單";
                sfd.AddExtension = true;
                sfd.RestoreDirectory = true;
                sfd.Filter = "Text Files (*.txt)|*.txt"; // 設定可以選擇的檔案類型
                sfd.DefaultExt = "txt";
                sfd.Title = "匯出課表";
                sfd.CheckFileExists = false;             // 若檔案/路徑 不存在是否顯示錯誤訊息
                sfd.CheckPathExists = false;
                DialogResult result = sfd.ShowDialog();     // 顯示檔案對話方框並回傳狀態（DialogResult.OK、DialogResult.Cancel）
                if (result == DialogResult.OK)
                {
                    if (sfd.FileName != string.Empty)
                    {
                        System.IO.Stream fileStream = sfd.OpenFile();
                        System.IO.StreamWriter sw = new System.IO.StreamWriter(fileStream);
                        for (int w = 0; w < 6; w++)
                        {
                            string myWeek = weeks[w];
                            string myData=string.Empty;
                            for (int i = 0; i < data.RowCount; i++)
                            {
                                DataGridViewRow r=data.Rows[i];
                                if (!r.Cells[classid.Name].Value.ToString().Equals("?") && !r.Cells[roomid.Name].Value.ToString().Equals("?"))
                                {
                                    if (r.Cells[week.Name].Value.ToString().Equals(myWeek))
                                    {
                                        string mySection = "";
                                        int myBeginSection = Array.IndexOf(section, r.Cells[beginSection.Name].Value.ToString());
                                        int myEndSection = Array.IndexOf(section, r.Cells[endSection.Name].Value.ToString());
                                        mySection += section[myBeginSection];
                                        for (int s = myBeginSection + 1; s <= myEndSection; s++)
                                        {
                                            mySection += "," + section[s];
                                        }
                                        myData += string.Format("{0}-{1}節-{2}學分\r\n班-{3}\r\n科-{4}\r\n\r\n",
                                             r.Cells[name.Name].Value.ToString(),
                                             mySection,
                                             r.Cells[credit.Name].Value.ToString(),
                                             r.Cells[roomid.Name].Value.ToString(),
                                             r.Cells[classid.Name].Value.ToString());
                                    }
                                }
                            }
                            if (myData != string.Empty)
                            {
                                sw.Write("週" + myWeek + "\r\n" + myData + "--------------------------------------------\r\n");
                            }
                            sw.Flush();
                        }
                        sw.Close();
                    }
                }
            }

        }
        public static bool IsFileLocked(string file)
        {
            try
            {
                using (File.Open(file, FileMode.Open, FileAccess.Write, FileShare.None))
                {
                    return false;
                }
            }
            catch (IOException exception)
            {
                Console.WriteLine(exception.ToString());
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void defaultLoad()
        {
            DirectoryInfo dir = new DirectoryInfo(System.Windows.Forms.Application.StartupPath);
            string defaultFileName="Default.bin";
            if (Directory.Exists(dir + @"\Default"))//資料夾存在
            {

                if (File.Exists(dir + @"\Default\" + defaultFileName))//檔案存在
                {

                    FileInfo fi = new FileInfo(dir + @"\Default\" + defaultFileName);
                    if (fi.Length != 0)
                    {
                        readFile(dir + @"\Default\" + defaultFileName);
                    }
                }
                else
                {
                    using (new FileStream(dir + @"\Default\" + defaultFileName, FileMode.Create, FileAccess.ReadWrite)) { };
                }
            }
            else
            {
                //新增資料夾
                Directory.CreateDirectory(dir + @"\Default");
                using (new FileStream(dir + @"\Default\" + defaultFileName, FileMode.Create, FileAccess.ReadWrite)) { };
                //File.Create(dir + @"\Default\" + defaultFileName);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            defaultLoad();
            data.ClearSelection();
            data.CurrentCell = null;
        }
        private bool noSave()
        {
            if (this.Text.Substring(this.Text.Length - 1).Equals("*")) return true;
            else return false;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (noSave())
            {
                Form3 f3 = new Form3();
                switch (f3.ShowDialog(this))
                {
                    case DialogResult.Yes:
                        myMenuItemSave_Click(this, null);
                        break;
                    case DialogResult.No:
                        //刪除未存檔符號
                        saveSign(false);
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }
        private void myMenuItemNew_Click(object sender, System.EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void readFile(string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            //Stream input = File.OpenRead(fileName);
            FileStream input = File.Open(fileName, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            Course[] obj = (Course[])formatter.Deserialize(input);
            for (int i = 0; i < obj.Length; i++)
            {
                insertData(ref obj[i]);
                //修改分割的上下距離
                splitContainer2.SplitterDistance += data.Rows[i].Height;
            }
            input.Close();
            label1.Text = measureCredit().ToString();//計算學分
            if (data.RowCount != 0) drawSchedule();
            oldFileName = fileName;
            data.CurrentCell = null;
            data.ClearSelection();
        }
        private void myMenuItemOld_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DirectoryInfo dir = new DirectoryInfo(System.Windows.Forms.Application.StartupPath);
            if (!Directory.Exists(dir + @"\Save")) Directory.CreateDirectory(dir + @"\Save");
            ofd.InitialDirectory = dir.FullName + @"\Save\"; // 檔案對話方框開啟的預設資料夾
            ofd.AddExtension = true;
            ofd.RestoreDirectory = true;
            ofd.Filter = "Binary Files (*.bin)|*.bin"; // 設定可以選擇的檔案類型
            ofd.DefaultExt = "bin";
            ofd.CheckFileExists = true;             // 若檔案/路徑 不存在是否顯示錯誤訊息
            ofd.CheckPathExists = false;
            DialogResult result = ofd.ShowDialog();     // 顯示檔案對話方框並回傳狀態（DialogResult.OK、DialogResult.Cancel）
            if (result == DialogResult.OK)
            {
                if (data.RowCount != 0)
                {
                    splitContainer2.SplitterDistance = 33;
                    data.Rows.Clear();
                    drawEmptyScehdule();
                    //計算學分
                    label1.Text = measureCredit().ToString();
                }
                readFile(ofd.FileName);
                File.Copy(ofd.FileName, dir + @"\Default\Default.bin", true);
            }

        }
        string oldFileName;
        private Course[] getData()
        {
            Course[] cd=new Course[data.RowCount];
            for (int i = 0; i < data.RowCount; i++)
            {
                cd[i] = getData(data.Rows[i]);
            }
            return cd;
        }
        private void saveData(string fileName)
        {
            
            Course[] cd = new Course[data.RowCount];
            cd = getData();
            BinaryFormatter formatter = new BinaryFormatter();
            //FileStream output = File.Create(fileName);
            FileStream output = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
            formatter.Serialize(output, cd);
            output.Close();

            DirectoryInfo dir = new DirectoryInfo(System.Windows.Forms.Application.StartupPath);
            FileStream defaultFile = File.Open(dir + @"\Default\Default.bin", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            formatter.Serialize(defaultFile, cd);
            defaultFile.Close();

            if (noSave())
            {
                //刪除未存檔符號
                saveSign(false);
            }
            oldFileName = fileName;            
        }
        private void myMenuItemSave_Click(object sender, System.EventArgs e)
        {
            if (oldFileName != null && oldFileName != string.Empty)
            {
                saveData(oldFileName);
            }
            else
            {
                myMenuItemSaveAs_Click(this, null);
            }
        }
        private void myMenuItemSaveAs_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            DirectoryInfo dir = new DirectoryInfo(System.Windows.Forms.Application.StartupPath);
            if (!Directory.Exists(dir + @"\Save")) Directory.CreateDirectory(dir + @"\Save");
            sfd.InitialDirectory = dir.FullName + @"\Save\"; // 檔案對話方框開啟的預設資料夾
            sfd.FileName = "Schedule";
            sfd.AddExtension = true;
            sfd.RestoreDirectory = true;
            sfd.Filter = "Binary Files (*.bin)|*.bin"; // 設定可以選擇的檔案類型
            sfd.DefaultExt = "bin";
            sfd.CheckFileExists = false;             // 若檔案/路徑 不存在是否顯示錯誤訊息
            sfd.CheckPathExists = false;
            DialogResult result = sfd.ShowDialog();     // 顯示檔案對話方框並回傳狀態（DialogResult.OK、DialogResult.Cancel）
            if (result == DialogResult.OK)
            {
                saveData(sfd.FileName);
            }
        }
        private void myMenuItemHelp_Click(object sender, System.EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }
        private void noClickHighLight()
        {
            schedule.DefaultCellStyle.SelectionBackColor = Color.OldLace;
            schedule.CurrentCell = null;
            schedule.ClearSelection();
            schedule.MultiSelect = false;
        }
        private void clickHighLight(DataGridViewRow dataRow)
        {
            int dataWeek = Array.IndexOf(weeks, dataRow.Cells[week.Name].Value.ToString()) + 1;
            int dataBeginSection = Array.IndexOf(section, dataRow.Cells[beginSection.Name].Value.ToString());
            int dataEndSection = Array.IndexOf(section, dataRow.Cells[endSection.Name].Value.ToString());
            schedule.DefaultCellStyle.SelectionBackColor = schedule.DefaultCellStyle.BackColor;
            for (int i = dataBeginSection; i <= dataEndSection; i++)
            {
                schedule.Rows[i].Cells[dataWeek].Style.BackColor = schedule.DefaultCellStyle.BackColor;
            }
        }
        private void clickHighLightRemove(DataGridViewRow dataRow)
        {
            int dataWeek = Array.IndexOf(weeks, dataRow.Cells[week.Name].Value.ToString()) + 1;
            int dataBeginSection = Array.IndexOf(section, dataRow.Cells[beginSection.Name].Value.ToString());
            int dataEndSection = Array.IndexOf(section, dataRow.Cells[endSection.Name].Value.ToString());
            Color dataColor=new Color();
            switch (dataRow.Cells[mustselectcommon.Name].Value.ToString())
            {
                case "必修":
                    dataColor = Color.SkyBlue;
                    break;
                case "選修":
                    dataColor = Color.LimeGreen;
                    break;
                case "通識":
                    dataColor = Color.PeachPuff;
                    break;
            }
            for (int i = dataBeginSection; i <= dataEndSection; i++)
            {
                schedule.Rows[i].Cells[dataWeek].Style.BackColor = dataColor;
            }
        }
        private DataGridViewRow findDataRow(string n)
        {
            DataGridViewRow find = null;
            for (int i = 0; i < data.RowCount; i++)
            {
                DataGridViewCell c = data.Rows[i].Cells[name.Name];
                if (c.Value.ToString().Equals(n))
                {
                    data.CurrentCell = c;
                    find = data.CurrentRow;
                    break;
                }
            }
            return find;
        }
        int? dataRowIndexOfScheduleMouseDown;
        private void schedule_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            data.ClearSelection();
            data.CurrentCell = null;
            dataRowIndexOfScheduleMouseDown = null;
            if (e != null)
            {
                if (e.ColumnIndex == 0 || e.RowIndex == -1)
                {
                    noClickHighLight();
                }
                else
                {
                    try
                    {
                        //找出選取Cell
                        schedule.CurrentCell = schedule.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        DataGridViewCell sc = schedule.CurrentCell;
                        if (sc.Value != null)
                        {
                            string name = sc.Value.ToString();
                            DataGridViewRow dataRow = findDataRow(name);
                            clickHighLight(dataRow);
                            //清除前先記錄以供MouseUp使用
                            dataRowIndexOfScheduleMouseDown = dataRow.Index;
                            //清除對應資料列
                            data.ClearSelection();
                            data.CurrentCell = null;
                        }
                    }
                    catch (Exception ex)
                    {
                        ex.ToString();
                    }
                }
            }            
        }

        private void schedule_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e != null)
            {
                try
                {
                    if (e.ColumnIndex == 0 || e.RowIndex == -1)
                    {
                        noClickHighLight();
                    }
                    if (e.ColumnIndex != 0 || e.RowIndex != -1 && dataRowIndexOfScheduleMouseDown == null)
                    {
                        noClickHighLight();
                        schedule.DefaultCellStyle.SelectionBackColor = schedule.DefaultCellStyle.BackColor;
                    }
                    if (dataRowIndexOfScheduleMouseDown != null)
                    {

                        schedule.CurrentCell = schedule.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        DataGridViewCell sc = schedule.CurrentCell;
                        DataGridViewRow dataRowOfScheduleMouseDown = data.Rows[dataRowIndexOfScheduleMouseDown.Value];
                        if (sc.Value != null)
                        {
                            int dataWeek = Array.IndexOf(weeks, dataRowOfScheduleMouseDown.Cells[week.Name].Value.ToString()) + 1;
                            int dataBeginSection = Array.IndexOf(section, dataRowOfScheduleMouseDown.Cells[beginSection.Name].Value.ToString());
                            int dataEndSection = Array.IndexOf(section, dataRowOfScheduleMouseDown.Cells[endSection.Name].Value.ToString());

                            if (sc.ColumnIndex == dataWeek && (sc.RowIndex >= dataBeginSection && sc.RowIndex <= dataEndSection))
                            {
                                clickHighLightRemove(dataRowOfScheduleMouseDown);
                                data.CurrentCell = dataRowOfScheduleMouseDown.Cells[0];
                                //清除schedule選取列
                                schedule.CurrentCell = null;
                                schedule.ClearSelection();
                                dataRowIndexOfScheduleMouseDown = null;
                            }
                            else
                            {
                                clickHighLightRemove(dataRowOfScheduleMouseDown);
                                schedule.CurrentCell = null;
                                schedule.ClearSelection();
                                dataRowIndexOfScheduleMouseDown = null;
                                //schedule.DefaultCellStyle.SelectionBackColor = schedule.DefaultCellStyle.BackColor;
                            }

                        }
                        else
                        {
                            clickHighLightRemove(dataRowOfScheduleMouseDown);
                            schedule.CurrentCell = null;
                            schedule.ClearSelection();
                            dataRowIndexOfScheduleMouseDown = null;
                        }
                    }                   
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }

        private void clickHighLightWithValue(DataGridViewRow dataRow)
        {
            int dataWeek = Array.IndexOf(weeks, dataRow.Cells[week.Name].Value.ToString()) + 1;
            int dataBeginSection = Array.IndexOf(section, dataRow.Cells[beginSection.Name].Value.ToString());
            int dataEndSection = Array.IndexOf(section, dataRow.Cells[endSection.Name].Value.ToString());
            schedule.DefaultCellStyle.SelectionBackColor = schedule.DefaultCellStyle.BackColor;
            for (int i = dataBeginSection; i <= dataEndSection; i++)
            {
                DataGridViewCell c = schedule.Rows[i].Cells[dataWeek];
                c.Style.BackColor = schedule.DefaultCellStyle.BackColor;
                c.Value = dataRow.Cells[name.Name].Value;
            }
        }
        int? dataRowIndexOfDataMouseDown;
        private void data_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e != null)
            {
                if (e.RowIndex != -1)
                {
                    try
                    {
                        schedule.ClearSelection();
                        schedule.CurrentCell = null;
                        data.CurrentCell = data[e.ColumnIndex, e.RowIndex];
                        dataRowIndexOfDataMouseDown = data.CurrentRow.Index;
                        clickHighLightWithValue(data.CurrentRow);
                    }
                    catch (Exception ex)
                    {
                        ex.ToString();
                    }
                }
            }
        }

        private void data_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e != null)
            {
                try
                {                    
                    //drawSchedule();
                    schedule.ClearSelection();
                    schedule.CurrentCell = null;
                    data.CurrentCell = data[e.ColumnIndex, e.RowIndex];
                    if (dataRowIndexOfDataMouseDown == data.CurrentRow.Index)
                    {
                        clickHighLightRemove(data.CurrentRow);
                    }
                    else
                    {
                        clickHighLightRemove(data.Rows[dataRowIndexOfDataMouseDown.Value]);
                    }
                    dataRowIndexOfDataMouseDown = null;
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
           }
        }

        private void data_MouseLeave(object sender, EventArgs e)
        {
            if (e != null)
            {
                if (dataRowIndexOfDataMouseDown != null)
                {
                    try
                    {
                        //drawSchedule();
                        clickHighLightRemove(data.Rows[dataRowIndexOfDataMouseDown.Value]);
                        schedule.DefaultCellStyle.SelectionBackColor = schedule.DefaultCellStyle.BackColor;
                    }
                    catch (Exception ex)
                    {
                        ex.ToString();
                    }
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                switch (e.KeyCode)
                {
                    case Keys.N:
                        myMenuItemNew_Click(this, null);
                        break;
                    case Keys.O:
                        myMenuItemOld_Click(this, null);
                        break;
                    case Keys.S:
                        myMenuItemSave_Click(this, null);
                        break;
                }
            }
        }
     }
}
