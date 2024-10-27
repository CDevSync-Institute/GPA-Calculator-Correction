using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator.Methods
{
    public static class GPASaga
    {
        public static decimal CalculateFinalGPA(int gradeReceived, int totalGradePoint)
        {
            decimal response= gradeReceived/totalGradePoint;
            return response;
        }

    }
}
