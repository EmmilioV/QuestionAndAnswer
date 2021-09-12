using Model.Data;
using Model.Objects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    public class QuestionController
    {
        SqlConnection _connection;
        SqlCommand _command;
        SqlDataReader _reader; 
        
        public Question GenerateQuestion(string roundId)
        {
            int randomNum = new Random().Next(1, 6);
            List<Question> questions = GenerateListQuestion(roundId);
            Question question;

            question = questions[randomNum];

            return question;
        }

        /// <summary>
        /// return a list of questions
        /// </summary>
        /// <param name="rounId"></param>
        /// <returns></returns>
        public List<Question> GenerateListQuestion(string roundId)
        {
            List<Question> questions = new List<Question>();
            DataAccess dataAccess = new DataAccess();
            _connection = dataAccess.getConnection();

            _command = new SqlCommand("Select * from question where roundId = @roundId", _connection);
            _command.Parameters.AddWithValue("@roundId", roundId);
            try
            {
                _connection.Open();
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    questions.Add
                        (
                            new Question
                            (
                                _reader["id"].ToString(),
                                roundId,
                                _reader["description"].ToString()
                            )
                        );
                }

                _connection.Close();

            }
            catch (Exception ex)
            {
                _connection.Close();
                Console.WriteLine("El error fue " + ex.Message);
            }

            return questions;
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
