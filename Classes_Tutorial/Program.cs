using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * We need an electronic grade book to read the scores of an individual student and then compute some simple statistics from the scores.
 * The grades are entered as floating point numbers from 0 to 100, and the statistics should show us the highest grade, the lowest grade, and 
 * the average grade. 
 * 
 */
namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(60);
            book.AddGrade(60.3);
            book.AddGrade(83.4);
            book.AddGrade(43.2);
            book.AddGrade(93.6);
            book.AddGrade(84.5);
            book.AddGrade(92.3);


            GradeStatistics stats = book.ComputeStatistics();
            book.ComputeStatistics();
        }
    }
}
