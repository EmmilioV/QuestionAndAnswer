using Controller;
using Model.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Forms
{
    public partial class Questions : Form
    {
        private Player _player;
        private Round _round;
        private Question _question;
        private QuestionController _questionController = new QuestionController();
        private OptionController _optionController = new OptionController();
        private PlayerController _playerController = new PlayerController();
        private RoundController _roundController;
        private int _roundNumber = 0;
        private List<Option> _options;
        private string _questionId;

        public Questions(Player player)
        {
            InitializeComponent();
            _player = player;
            GenerateQuestion();
        }

        private void GenerateQuestion()
        {
            _roundNumber += 1;

            if(_roundNumber <= 5)
            {
                _roundController = new RoundController();
                _round = _roundController.GetRound(_roundNumber);

                _question = _questionController.GenerateQuestion(_roundNumber.ToString());
                lblQuestion.Text = _question.Description;

                _questionId = _question.Id;
                _options = _optionController.GenerateOptions(_questionId);

                rbOption1.Text = _options[0].Description;
                rbOption2.Text = _options[1].Description;
                rbOption3.Text = _options[2].Description;
                rbOption4.Text = _options[3].Description;
            }
            else
            {
                //_player= _playerController.Update(_player, _round, true);
                new Win(_player);
                this.Visible = false;
            }

            return;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string playerAnswerId;

            if (rbOption1.Checked)
                playerAnswerId = _options[0].Id;
            else if (rbOption2.Checked)
                playerAnswerId = _options[1].Id;
            else if (rbOption3.Checked)
                playerAnswerId = _options[2].Id;
            else
                playerAnswerId = _options[3].Id;

            if(_questionController.ValidateAnswer(_options, playerAnswerId))
            {
                MessageBox.Show("Correct! Keep going", "CORRECT", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                _player = _playerController.Update(_player, _round, true);
                GenerateQuestion();
            }
            else
            {
                MessageBox.Show("Incorrect Answer. Good luck to the next one","INCORRECT", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                _player = _playerController.Update(_player, _round, false);
                new Play().Show();
                this.Visible = false;
            }

            return;
        }

        private void END(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
