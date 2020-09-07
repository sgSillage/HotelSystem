using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CommentForm : Form
    {
        public CommentForm()
        {
            InitializeComponent();
        }

        private int star = 5;




        private void CommentClicked(object sender, EventArgs e)
        {
            string s = textBox3.Text;
            DateTime t = DateTime.Now;
            User.Comment(t,User.id,s, star);
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            star = 1;
            label2.Text = "★";
            label3.Text = "☆";
            label4.Text = "☆";
            label5.Text = "☆";
            label6.Text = "☆";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            star = 2;
            label2.Text = "★";
            label3.Text = "★";
            label4.Text = "☆";
            label5.Text = "☆";
            label6.Text = "☆";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            star = 3;
            label2.Text = "★";
            label3.Text = "★";
            label4.Text = "★";
            label5.Text = "☆";
            label6.Text = "☆";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            star = 4;
            label2.Text = "★";
            label3.Text = "★";
            label4.Text = "★";
            label5.Text = "★";
            label6.Text = "☆";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            star = 5;
            label2.Text = "★";
            label3.Text = "★";
            label4.Text = "★";
            label5.Text = "★";
            label6.Text = "★";
        }
    }
}
