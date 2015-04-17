using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multiple_Choice
{
    class Program
    {
        static void Main(string[] args)
        {
            Exam exam = new Exam();
            String url = "se3314.txt";  // Change URL to location of text file that contains questions
            Console.WindowWidth = 100;  // 0 < Console.WindowWidth <= Console.LargestWindowWidth
            Console.Title = "Multiple Choice Exam";

            // Opening message
            if (exam.LoadQuestions(url))
            {
                Console.WriteLine("\nPress any key to quit...");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.WriteLine("Loaded multiple choice problems from:\n" + url + "\n");
            }

            // Iterate through questions
            while (exam.MoveNext())
            {
                WriteHorizontalRule();

                BaseQuestion question = exam.CurrentQuestion;
                question.WriteQuestion();

                int choice = 0;

                // Validate input
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > exam.CurrentQuestion.NumChoices)
                {
                    Console.WriteLine("Not a valid choice. Try again");
                }

                // Check answer
                if (exam.CheckAnswer(choice))
                {
                    Console.WriteLine("\nCorrect! (" + exam.Average + "% " + exam.QuestionsCorrect + "/" + exam.QuestionsCompleted + ")\n");
                }
                else
                {
                    Console.WriteLine("\nWrong! (" + exam.Average + "% " + exam.QuestionsCorrect + "/" + exam.QuestionsCompleted
                        + ")\nCorrect answer is: " + question.Answer + "\n");
                }
            }

            WriteHorizontalRule();

            // Finish exam
            Console.WriteLine("You finished with " + exam.Average + "%\nPress any key to quit...");
            Console.ReadKey();
        }

        /// <summary>
        /// Write a sequence of -'s to create a horizontal line across the console
        /// </summary>
        private static void WriteHorizontalRule()
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("-");
            }

            Console.Write("\n");
        }
    }
}
