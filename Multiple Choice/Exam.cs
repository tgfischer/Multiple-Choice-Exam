using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Choice
{
    class Exam
    {
        private int questionsCorrect = 0;
        private int questionsCompleted = 0;
        private BaseQuestion currentQuestion;
        private List<BaseQuestion> questions;

        public Exam()
        {
            this.questions = new List<BaseQuestion>();
        }

        public bool LoadQuestions(String url)
        {
            this.questions = QuestionLoader.LoadQuestions(url);
            return this.questions == null;
        }

        public bool CheckAnswer(int choice)
        {
            if (this.CurrentQuestion.CheckAnswer(choice))
            {
                questionsCorrect++;
                return true;
            }

            return false;
        }

        public bool MoveNext()
        {
            
            if (this.questions.Count > 0)
            {
                this.questionsCompleted++;
                this.currentQuestion = this.questions.PickRandom();
                this.questions.Remove(this.currentQuestion);

                return true;
            }

            return false;
        }

        public BaseQuestion CurrentQuestion
        {
            get { return this.currentQuestion; }
        }

        public int QuestionsCompleted
        {
            get { return questionsCompleted; }
        }

        public int QuestionsCorrect
        {
            get { return questionsCorrect; }
        }

        public double Average
        {
            get { return Math.Round(this.questionsCorrect * 100F / this.questionsCompleted, 1); }
        }
    }
}
