using Model.Data;
using Model.Objects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    
    public class OptionController
    {
        SqlConnection _connection;
        SqlCommand _command;
        SqlDataReader _reader;

        public List<Option> GenerateOptions(string questionId)
        {
            List<Option> options = new List<Option>();
            bool correctAnswer;
            DataAccess dataAccess = new DataAccess();
            _connection = dataAccess.getConnection();

            _command = new SqlCommand("Select * from [dbo].[Option] where questionId = @questionId", _connection);
            _command.Parameters.AddWithValue("@questionId", questionId);

            try
            {
                _connection.Open();
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    if (_reader["correctAnswer"].ToString().Equals("1"))
                       correctAnswer = true;
                    else
                        correctAnswer = false;

                    options.Add
                        (
                            new Option
                            (
                                _reader["id"].ToString(),
                                questionId,
                                _reader["description"].ToString(),
                                correctAnswer
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

            return options;
        }

    }
}
