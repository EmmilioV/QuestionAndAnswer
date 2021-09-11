using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Objects
{
    public class Category
    {
        private string _id;
        private int _level;

        public Category(string id, int level)
        {
            _id = id;
            _level = level;
        }

        public string Id { get => _id; set => _id = value; }
        public int Level { get => _level; set => _level = value; }
    }
}
