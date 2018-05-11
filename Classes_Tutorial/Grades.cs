using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{ 
    class GradeBook
    {

        private List<double> grades; //Stop the grades uninitialized exception
        public static double Max = 100;
        public static double Min = 0;
        private double average;
        private double highest;
        private double lowest;
        private double median;
        
        public GradeBook()
        {
            grades = new List<double>();
        }
        public void AddGrade(double grade )
        {
            grades.Add(grade);
        }
        public GradeStatistics ComputeStatistics()
        {
            //Will be populated to generate the statistics for grade
            GradeStatistics stats =  new GradeStatistics();
            float sum = 0;
            
            foreach (float grade in grades)
            {
                sum += grade;
            }

            return stats;
        }
        
       
    }
}






















