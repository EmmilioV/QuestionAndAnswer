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
    public partial class Win : Form
    {
        public Win(Player player)
        {
            InitializeComponent();
            lblPlayerName.Text = player.Name.ToString()+"congratulations! with this score you have 25% descount in all our stores";
            lblPlayerScore.Text = player.TotalScore.ToString();
        }

        private void Win_Load(object sender, EventArgs e)
        {

        }
    }
}
