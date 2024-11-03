using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator.Model
{
    public  class GPA
    {
        public string matricNo { get; set; }
        public decimal finalGPA {  get; set; }
        public int totalGradeReceived {  get; set; }
        public int totalGradePoint {  get; set; }
        public int totalCourse {  get; set; }
        public int totalGPA {  get; set; }
        public List<Grade> grades { get; set; }=new List<Grade>();
        public List<Course> courses { get; set; } = new List<Course>();

    }
}
