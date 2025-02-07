using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP
{
    public abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] Answers { get; set; }
        public int RightAnswerId { get; set; }

        public Question(string header, string body, int mark, int answerCount)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Answers = new Answer[answerCount];
        }

        public abstract bool AskQuestion();
        public override string ToString()
        {
            string questionText = $"{Header}: {Body} (Mark: {Mark})\n";
            foreach (var ans in Answers)
            {
                if (ans != null)
                    questionText += $"{ans.AnswerId}. {ans.AnswerText}\n";
            }
            return questionText;
        }
    }
}
