using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Objects
{
    public class Round
    {
        private string _id;
        private Category _categoryId;
        private bool _result;
        private int _score;

        public Round(string id, Category categoryId, bool result, int score)
        {
            _id = id;
            _categoryId = categoryId;
            _result = result;
            _score = score;
        }

        public string Id { get => _id; set => _id = value; }
        public Category CategoryId { get => _categoryId; set => _categoryId = value; }
        public bool Name { get => _result; set => _result = value; }
        public int TotalScore { get => _score; set => _score = value; }
    }
}
