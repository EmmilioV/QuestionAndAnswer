using Model.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    public class QuestionController
    {
        public Question GenerateQuestion(string categoryId)
        {

            Question question = new Question("1", categoryId, "¿Cual es la capital de colombia?");

            return question;
        }

        public bool ValidateAnswer(List<Option> options, string playerAnswerId)
        {
            bool correctAnswer = options.Where(x => x.Id.Equals(playerAnswerId)).Select(x => x.CorrectAnswer).FirstOrDefault();

            if (correctAnswer == true)
                return true;
            else
                return false;
        }
    }
}
