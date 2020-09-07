using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegisterFrame
{
    public partial class FindPassword : Form
    {
        public FindPassword()
        {
            InitializeComponent();
        }

        private void FindPassword_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void buttonFindPCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
    }
}
