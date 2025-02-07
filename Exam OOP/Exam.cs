using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP
{
    public abstract class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; }

        public Exam(int time, int numQuestions)
        {
            Time = time;
            NumberOfQuestions = numQuestions;
            Questions = new Question[numQuestions];
        }

        public abstract void ShowExam();
    }
}
