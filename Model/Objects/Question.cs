using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Objects
{
    public class Question
    {
        private string _id;
        private string _roundId;
        private string _description;

        public Question(string id, string roundId, string description)
        {
            _id = id;
            _roundId = roundId;
            _description = description;
        }

        public string Id { get => _id; set => _id = value; }
        public string RoundId { get => _roundId; set => _roundId = value; }
        public string Description { get => _description; set => _description = value; }
    }
}
