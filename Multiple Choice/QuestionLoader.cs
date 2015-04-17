using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Multiple_Choice
{
    class QuestionLoader
    {
        public static List<BaseQuestion> LoadQuestions(String url)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(url))
                {
                    String line = "";
                    List<BaseQuestion> questions = new List<BaseQuestion>();
                    BaseQuestion question = new BaseQuestion();

                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (line.StartsWith("QUESTION:"))
                        {
                            line = line.Substring(line.IndexOf(':') + 1);

                            question = new BaseQuestion();
                            question.Question = line;
                        }
                        else if (line.StartsWith("ANSWER:"))
                        {
                            line = line.Substring(line.IndexOf(':') + 1);

                            question.Answer = line;
                            questions.Add(question);
                        }
                        else if (line.Contains(')'))
                        {
                            line = line.Substring(line.IndexOf(')') + 1);

                            question.AddChoice(line);
                        }
                    }

                    return questions;
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }
    }
}
