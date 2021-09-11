using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Objects
{
    public class Player
    {
        private string _docNumber;
        private Round _roundId;
        private string _name;
        private int _totalScore;

        public Player(string docNumber, Round roundId, string name, int totalScore)
        {
            _docNumber = docNumber;
            _roundId = roundId;
            _name = name;
            _totalScore = totalScore;
        }

        public string DocNumber { get => _docNumber; set => _docNumber = value; }
        public Round RoundId { get => _roundId; set => _roundId = value; }
        public string Name { get => _name; set => _name = value; }
        public int TotalScore { get => _totalScore; set => _totalScore = value; }
    }

}
