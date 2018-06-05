using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {
        //Variables
        private int totalMarks = 0;
        private int possibleMarks = 0;
        private string submitterName;
        private string letterGrade;

        //Constructors
        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
            this.possibleMarks = possibleMarks;
            this.submitterName = submitterName;
        }

        //Properties
        public int TotalMarks
        {
            get
            {
                return totalMarks;
            }
            set
            {
                if (value < 0)
                {
                    totalMarks = 0; // a place to build an exception
                }
                else
                {
                    totalMarks = value;//C# keyword
                }
            }
        }
        public int PossibleMarks
        {
            get
            {
                return possibleMarks;// does the same as get{ return possibleMarks;} readonly means you cannot set value
            }
        }
        public string SubmitterName
        {
            get
            {
                return submitterName;
            }
        }
        public string LetterGrade
        {
            get
            {
                double gradeMarks = (double)totalMarks / possibleMarks;
                if (gradeMarks>= .9)
                {
                    letterGrade = "A";
                }
                else if (gradeMarks >= .8)
                {
                    letterGrade = "B";
                }
                else if (gradeMarks >=.7)
                {
                    letterGrade = "C";
                }
                else if (gradeMarks >=.6)
                {
                    letterGrade = "D";
                }
                else
                {
                    letterGrade = "F";
                }
                return letterGrade;
            }
        }
        //Methods
    }
}
