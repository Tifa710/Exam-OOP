using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP
{
    public class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, int mark) : base(header, body, mark, 2)
        {
            Answers[0] = new Answer(1, "True");
            Answers[1] = new Answer(2, "False");
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
                    Console.WriteLine("Your answer is wrong, please try again.");
                }
            }
        }
    }
}
