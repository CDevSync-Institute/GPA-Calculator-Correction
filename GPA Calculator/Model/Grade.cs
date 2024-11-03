using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator.Model
{
    public  class Grade
    {
        public int id { get; set; }
        //public string matricNo {  get; set; }
        public string courseCode { get; set; }
        public char gradeCharacter { get; set; } = 'E';
        public int scoreReceived { get; set; } = 0;
        public int gradePoint { get; set; }
        public int GPAPerCourse { get; set; }
    }
}
