using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStackTask
{
    public partial class Form1 : Form
    {
        MyStack<int> Numbers = new MyStack<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void pushBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Numbers.Push(Convert.ToInt32(textBox1.Text));
                fillListBox();
            }
            catch (Exception)
            {
              MessageBox.Show("Переполнение стека");
            }
        }

        private void fillListBox()
        {
            listBox1.Items.Clear();

            for (int i = 0; i < Numbers.MyArray.Length; i++)
            {
                listBox1.Items.Add(Numbers.MyArray[i].ToString());
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void popBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(Convert.ToString(Numbers.Pop()));
                fillListBox();
            }
            catch (Exception)
            {
                MessageBox.Show("Стек пуст");
            }
        }

        private void peekBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(Convert.ToString(Numbers.Peek()));

            }
            catch (Exception)
            {
                MessageBox.Show("Стек пуст");
            }
        }
    }
}
