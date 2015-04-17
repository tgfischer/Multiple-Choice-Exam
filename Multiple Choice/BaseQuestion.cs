using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Choice
{
    class BaseQuestion
    {
        public String Question;
        public String Answer;
        private List<String> choices;

        public BaseQuestion()
        {
            this.choices = new List<String>();
        }

        public bool CheckAnswer(int choice)
        {
            return this.Answer.Equals(choices.ElementAt(choice - 1));
        }

        public void AddChoice(String choice)
        {
            this.choices.Add(choice);
        }

        public void WriteQuestion()
        {
            Console.WriteLine(this.Question);

            List<String> choices = this.Choices;

            for (int i = 0; i < choices.Count; i++)
            {
                Console.WriteLine(i + 1 + ") " + choices.ElementAt(i));
            }
        }

        public List<String> Choices
        {
            get
            {
                if (!this.choices.Contains("True") && !this.choices.Contains("All of the above") && !this.choices.Contains("None of the above"))
                {
                    Random random = new Random();
                    this.choices = this.choices.OrderBy(x => random.Next()).ToList();
                    return this.choices;
                }
                else
                {
                    return this.choices;
                }
            }
        }

        public int NumChoices
        {
            get { return this.choices.Count; }
        }
    }
}
