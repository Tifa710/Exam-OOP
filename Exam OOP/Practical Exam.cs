using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP
{
    public class PracticalExam : Exam
    {
        public PracticalExam(int time, int numQuestions) : base(time, numQuestions) { }

        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam:");
            foreach (var question in Questions)
            {
                if (question != null)
                {
                    Console.WriteLine(question.ToString());
                    question.AskQuestion();
                }
            }
        }
    }
}
