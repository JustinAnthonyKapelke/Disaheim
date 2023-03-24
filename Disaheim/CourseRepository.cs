//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Disaheim
//{
//    public class CourseRepository
//    {
//        //Private field courses
//        private List<Course> courses = new List<Course>();

//        //Add Course method
//        public void AddCourse(Course course)
//        { 
//            courses.Add(course);
//        }

//        //Get Course method
//        public Course GetCourse(string name)
//        {
//            foreach (Course course in courses) 
//            { 
//             if(name == name)
//                    return course;
//            }
//            return null;
//        }


//        //Get total value of of Courses
//        public double GetTotalValue()
//        {
//            double totalValue = 0.0;
//            Utility utility = new Utility();

//            foreach (Course course in courses)
//            {
//                totalValue += utility.GetValueOfCourse(course);
//            }
//            return totalValue;
//        }

//    }
//}
