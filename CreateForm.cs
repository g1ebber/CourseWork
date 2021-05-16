using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СourseWork
{
    public partial class CreateForm : Form
    {
        private MainForm mainForm;

        public CreateForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rectangle rec = new Rectangle(Decimal.ToDouble(numericUpDown1.Value), Decimal.ToDouble(numericUpDown2.Value), comboBox1.Text, textBox1.Text);
            mainForm.GetBH().add(rec);
            mainForm.GetListBox().Items.Add(+ rec.getID() + ". Name: " + rec.getName());
            this.Visible = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
