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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Human> list = new List<Human>();

        private void Form1_Load(object sender, EventArgs e)
        {
            Human h1 = new Human(15, "Mark");
            Human h2 = new Human(25, "Jim");
            Human h3 = new Human(43, "Bill");

            list.Add(h1);
            list.Add(h2);
            list.Add(h3);

            foreach (var item in list)
            {
                listBox1.Items.Add(item);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Human h = (Human)listBox1.Items[2];
            MessageBox.Show(h.Name + " " + h.Age.ToString());

            list.Clear();
            foreach (var item in listBox1.Items)
            {
                list.Add((Human)item);
            }

        }
    }

    class Human
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Human(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public override string ToString()
        {
            return $"Name = {Name}, Age = {Age}";
        }
    }
}
