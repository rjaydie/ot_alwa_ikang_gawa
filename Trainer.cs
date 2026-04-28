using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finals
{
    public partial class Trainer : Form
    {
        public Trainer()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide(); // Itatago ang kasalukuyang form
        }

        private void button3_Click(object sender, EventArgs e)
        {
            membership memberForm = new membership();
            memberForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TargetProgram programForm = new TargetProgram();
            programForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Trainer trainerForm = new Trainer();
            trainerForm.Show();
            this.Hide();
        }
    }
}
