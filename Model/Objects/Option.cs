using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Objects
{
    public class Option
    {
        private string _Id;
        private string _questionId;
        private string _description;
        private bool _correctAnswer;

        public Option(string id, string questionId, string description, bool correctAnswer)
        {
            _Id = id;
            _questionId = questionId;
            _description = description;
            _correctAnswer = correctAnswer;
        }

        public string Id { get => _Id; set => _Id = value; }
        public string QuestionId { get => _questionId; set => _questionId = value; }
        public string Description { get => _description; set => _description = value; }
        public bool CorrectAnswer { get => _correctAnswer; set => _correctAnswer = value; }
    }
}
