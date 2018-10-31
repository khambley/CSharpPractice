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
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        //NullReferenceException, using an uninitialized variable, a variable that points to nothing
        List<float> grades;

    }
}
