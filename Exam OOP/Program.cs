namespace Exam_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Subject ID: ");
            int subjectId = int.Parse(Console.ReadLine());

            Console.Write("Enter Subject Name: ");
            string subjectName = Console.ReadLine();

            Subject subject = new Subject(subjectId, subjectName);

            Console.Write("Enter Exam Type (1 for Final, 2 for Practical): ");
            int examType = int.Parse(Console.ReadLine());

            Console.Write("Enter Exam Duration (minutes): ");
            int duration = int.Parse(Console.ReadLine());

            Console.Write("Enter Number of Questions: ");
            int numQuestions = int.Parse(Console.ReadLine());

            Exam exam = examType == 1 ? new FinalExam(duration, numQuestions) : new PracticalExam(duration, numQuestions);

            for (int i = 0; i < numQuestions; i++)
            {
                Console.Write("Enter Question Type (1 for T/F, 2 for MCQ): ");
                int qType = int.Parse(Console.ReadLine());

                Console.Write("Enter Question Header: ");
                string header = Console.ReadLine();

                Console.Write("Enter Question Body: ");
                string body = Console.ReadLine();

                Console.Write("Enter Question Mark: ");
                int mark = int.Parse(Console.ReadLine());

                if (qType == 1)
                {
                    var question = new TrueFalseQuestion(header, body, mark);
                    Console.Write("Enter Correct Answer (1 for True, 2 for False): ");
                    question.RightAnswerId = int.Parse(Console.ReadLine());
                    exam.Questions[i] = question;
                }
                else
                {
                    Answer[] answers = new Answer[3];
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"Enter Answer {j + 1}: ");
                        answers[j] = new Answer(j + 1, Console.ReadLine());
                    }

                    var question = new MCQQuestion(header, body, mark, answers);
                    Console.Write("Enter Correct Answer (1-3): ");
                    question.RightAnswerId = int.Parse(Console.ReadLine());
                    exam.Questions[i] = question;
                }
            }

            subject.CreateExam(exam);
            exam.ShowExam();
        }
    }
}
