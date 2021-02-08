using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Course
    {
        string courseName;
        string courseCode;
        int courseCredit;

        public string CourseName
        {
            set
            {
                courseName = value;
            }
            get
            {
                return courseName;
            }
        }
        public string CourseCode
        {
            set
            {
                courseCode = value;
            }
            get
            {
                return courseCode;
            }
        }
        public int CourseCredit
        {
            set
            {
                courseCredit = value;
            }
            get
            {
                return courseCredit;
            }
        }
        public Course(string courseName, string courseCode, int courseCredit)
        {
            this.courseName = courseName;
            this.courseCode = courseCode;
            this.courseCredit = courseCredit;
        }
        public void ShowCourseInfo()
        {
            Console.WriteLine("Course Name : " + courseName);
            Console.WriteLine("Course Code : " + courseCode);
            Console.WriteLine("Course Credit : " + courseCredit);
        }
    }
}
