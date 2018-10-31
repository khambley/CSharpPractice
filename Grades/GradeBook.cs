using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {

        public GradeBook()
        {
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            stats.HighestGrade = 0;

            //Average Grade
            float sum = 0;
            foreach(float grade in grades)
            {   
                //Find HighestGrade in List
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                //Find LowestGrade in List
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }

            //can't divide by zero, runtime error - TODO add error handling
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        //NullReferenceException, using an uninitialized variable, a variable that points to nothing
        private List<float> grades;

    }
}
