using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void teacher_Click(object sender, EventArgs e)
        {
            Form2 teacherForm = new Form2();
            teacherForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 staffForm = new Form4();
            staffForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 expanseForm = new Form5();
            expanseForm.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form3 studentForm = new Form3();
            studentForm.Show();
            this.Hide();
        }
    }
}
