using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxControl
{

    public partial class Form1 : Form
    {            
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                listBox2.Items.Add(rnd.Next(100));
            }
            Test obj = new Test();
            obj.Text = "Cheater";
            obj.Value = 255.78;
            listBox1.Items.Add(obj);
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            object obj = listBox1.SelectedItem;
            if (obj != null)
                this.Text = obj.ToString();
        }

        private void btnAddList1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtInput.Text);
        }

        private void btnDeleteList1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                listBox1.Items.RemoveAt(index);
            }
        }

        private void btnClearList1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnAddList2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                listBox2.Items.Add(rnd.Next(100));
            }
        }

        private void btnDeleteList2_Click(object sender, EventArgs e)
        {
            Text = listBox2.SelectedIndices.Count.ToString();
            for (int i = listBox2.SelectedIndices.Count - 1; i >= 0; i--)
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndices[0]);
            }
            //int selInd = listBox2.SelectedIndices.Count;
            //for (int i = 0; i < selInd; i++)
            //{
            //    listBox2.Items.RemoveAt(listBox2.SelectedIndices[0]);
            //}

        }

        private void btnClearList2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }
    }
    class Test
    {
        public string Text { get; set; }
        public double Value { get; set; }
        public override string ToString()
        {
            return Text;
        }
    }
}
