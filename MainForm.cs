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
    public partial class MainForm : Form
    {
        
        //Rectangle rect = new Rectangle();
        private BinaryHeap<Rectangle> BH;
        public MainForm()
        {
            InitializeComponent();
            BH = new BinaryHeap<Rectangle>();

            Rectangle rec1 = new Rectangle(1, 1, "red","One");
            GetBH().add(rec1);
            GetListBox().Items.Add(rec1.getID() + ". Name: " + rec1.getName());

            Rectangle rec2 = new Rectangle(2, 3, "orange", "Two");
            GetBH().add(rec2);
            GetListBox().Items.Add(rec2.getID() + ". Name: " + rec2.getName());

            Rectangle rec3 = new Rectangle(5, 8, "yellow", "Three");
            GetBH().add(rec3);
            GetListBox().Items.Add(rec3.getID() + ". Name: " + rec3.getName());
        }

        public BinaryHeap<Rectangle> GetBH()
        {
            return BH;
        }

        public ListBox GetListBox()
        {
            return listBox;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CreateForm temp = new CreateForm(this);
            temp.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void ChooseMaxBut_Click(object sender, EventArgs e)
        {
            if (BH.heapSize > 0)
            {
                Rectangle rect = BH.getMax();
                label3.Text = rect.getName();
                label5.Text = rect.getColor();
                label6.Text = rect.getLength().ToString();
                label7.Text = rect.getWidth().ToString();
                label12.Text = rect.area().ToString();
                label11.Text = rect.perimeter().ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            if (BH.heapSize > 0)
            {
                string ID = listBox.Items[0].ToString().Substring(0);
                Convert.ToInt32(ID);
                //BH.delete(ID)
            }
        }

        private void ChooseMinBut_Click(object sender, EventArgs e)
        {
            if (BH.heapSize > 0)
            {
                Rectangle rect = BH.getMin();
                label3.Text = rect.getName();
                label5.Text = rect.getColor();
                label6.Text = rect.getLength().ToString();
                label7.Text = rect.getWidth().ToString();
                label12.Text = rect.area().ToString();
                label11.Text = rect.perimeter().ToString();
            }
        }

        private void ChooseBut_Click(object sender, EventArgs e)
        {
            if (BH.heapSize > 0)
            {
                string ID = listBox.Items[0].ToString().Split('.')[0];
                int id = Convert.ToInt32(ID);
                /*Rectangle rect = BH.Search(ID);
                label3.Text = rect.getName();
                label5.Text = rect.getColor();
                label6.Text = rect.getLength().ToString();
                label7.Text = rect.getWidth().ToString();
                label12.Text = rect.area().ToString();
                label11.Text = rect.perimeter().ToString();*/
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
