using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator.Model
{
    public class Course
    {
        public string courseCode { get; set; }
        public string courseName { get; set; }
        public int courseUnit {  get; set; }
        public string? courseDescription {  get; set; }

    }
}
