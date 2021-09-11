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
        private Category _categoryId;
        private string _description;

        public Question(string id, Category categoryId, string description)
        {
            _id = id;
            _categoryId = categoryId;
            _description = description;
        }

        public string Id { get => _id; set => _id = value; }
        public Category CategoryId { get => _categoryId; set => _categoryId = value; }
        public string Description { get => _description; set => _description = value; }
    }
}
