﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Objects
{
    public class Round
    {
        private string _id;
        private int _difficulty;
        private bool _result;
        private int _score;

        public Round() { }

        public Round(string id, int dificulty, bool result, int score)
        {
            _id = id;
            _difficulty = dificulty;
            _result = result;
            _score = score;
        }

        public string Id { get => _id; set => _id = value; }
        public int Dificulty { get => _difficulty; set => _difficulty = value; }
        public bool Name { get => _result; set => _result = value; }
        public int Score { get => _score; set => _score = value; }
    }
}
