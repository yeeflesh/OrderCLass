using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 排課
{
    [Serializable]
    public class Course
    {
        public string name, classid, roomid, grade, mustselectcommon, instructor, room,beginSection, endSection;
        public int credit, week;
        
    }
}
