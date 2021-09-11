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
        private readonly Player _player;

        public Win(Player player)
        {
            InitializeComponent();
            _player = player;
        }

        private void Win_Load(object sender, EventArgs e)
        {

        }
    }
}
