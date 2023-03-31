using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerCore.Model
{
    public class Teacher
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string GraduateDepartment { get; set; }
        public double ExamScore { get; set; }
        public int OsymRank { get; set; }
        public string PreferredSection { get; set; }
        public string PreferredCity { get; set; }
    }
}
