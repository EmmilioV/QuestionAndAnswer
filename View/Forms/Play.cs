using Controller;
using Model.Objects;
using System;
using System.Windows.Forms;

namespace View.Forms
{
    public partial class Play : Form
    {
        public Play()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayerController playerController = new PlayerController();
            Player player= playerController.CreatePlayer(txtDocNumber.Text, txtName.Text);
            
            Questions questions = new Questions(player);
            questions.Show();
            this.Visible = false;
        }

        private void Play_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
