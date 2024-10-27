using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator.Methods
{
    public class GradeSaga
    {
        public int GetGradePoint(char gradeCharacter)
        {
            gradeCharacter=char.ToUpper(gradeCharacter);
            int response = 0;
            switch(gradeCharacter)
            {
                case 'A':
                     response=5;
                    break;
                case 'B':
                    response=4; break;
                    case 'C':
                    response=3; break;
                case 'D':
                    response = 2;
                    break;
                default:
                    response = 0;
                    break;
            }
            return response;
        }
        public char  GetGradeCharacter(int score)
        {
            if (score < 40)
            {
                return 'E';
            }
            else if (score <= 50)
            {
                return 'D';
            }
            else if (score <= 60)
            {
                return 'c';
            }
            else if (score <= 70)
            {
                return 'B';
            }
            else
            {
                return 'A'; 
            }
        }
        public int ComputeTotalGrade(int lastCumulativeGrade, int newGrade)
        {

            return lastCumulativeGrade+newGrade;
        }
        public static int CalculateTotalGradeReceived(int lastCumulativeGradeReceived, int newGradeReceived)
        {

            return lastCumulativeGradeReceived + newGradeReceived;
        }
    }

}
