using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetterCalculator
{
    public partial class FormCounter : Form
    {
        private LetterCounter _counter;
        public FormCounter()
        {
            InitializeComponent();
            _counter = new LetterCounter();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            var word = txtWord.Text;
            if (string.IsNullOrEmpty(word) || string.IsNullOrWhiteSpace(word))
            {
                MessageBox.Show(@"Please enter word to count", @"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblCount.Text = _counter.Count(word).ToString();
            txtWord.SelectAll();
            txtWord.Focus();

        }

        private void txtWord_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            var word = txtWord.Text;
            if (string.IsNullOrEmpty(word) || string.IsNullOrWhiteSpace(word))
            {
                MessageBox.Show(@"Please enter word to count", @"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblCount.Text = _counter.Count(word).ToString();
            txtWord.SelectAll();
            txtWord.Focus();
        }
    }
}
