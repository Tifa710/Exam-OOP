using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP
{
    public class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, int mark, Answer[] answers) : base(header, body, mark, answers.Length)
        {
            Answers = answers;
        }

        public override bool AskQuestion()
        {
            while (true)
            {
                Console.Write(ToString());
                Console.Write("Your Answer: ");
                int userAnswer = int.Parse(Console.ReadLine());
                if (userAnswer == RightAnswerId)
                {
                    Console.WriteLine("Your answer is correct");
                    return true;
                }
                else
                {
                    Console.WriteLine("Your answer is wrong, try again.");
                }
            }
        }
    }
}
