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
    public partial class ChangeForm : Form
    {
        public ChangeForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //this.Text = rect.name;
        }

        private void ChangeBut_Click(object sender, EventArgs e)
        {
            //rect.setProperty();
            this.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.Text = rect.color;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //this.Text = rect.heigth;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            //this.Text = rect.width;
        }
    }
}
