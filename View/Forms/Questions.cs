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
        private QuestionController _questionController = new QuestionController();
        private OptionController _optionController = new OptionController();
        private List<Option> _options;
        private string _questionId;
        private int _roundNumber = 0;

        public Questions(Player player)
        {
            InitializeComponent();
            _player = player;
            GenerateQuestion();
        }

        private void GenerateQuestion()
        {
            if(_roundNumber < 5)
            {
                _roundNumber += 1;
                Question question = _questionController.GenerateQuestion(_roundNumber.ToString());
                lblQuestion.Text = question.Description;

                _questionId = question.Id;
                _options = _optionController.GenerateOptions(_questionId);

                rbOption1.Text = _options[0].Description;
                rbOption2.Text = _options[1].Description;
                rbOption3.Text = _options[2].Description;
                rbOption4.Text = _options[3].Description;
            }
            else
            {
                PlayerController.Update(_player, _roundNumber);
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
                PlayerController.Update(_player, _roundNumber);
                GenerateQuestion();
            }
            else
            {
                PlayerController.EndGame(_player, _roundNumber);
                MessageBox.Show("Incorrect Answer. Good luck to the next one","INCORRECT", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                new Play().Show();
                this.Visible = false;
            }

            return;
        }

        private void END(object sender, FormClosingEventArgs e)
        {
            PlayerController.EndGame(_player, _roundNumber);
            Application.Exit();
        }
    }
}
