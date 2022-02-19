using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MyQueue<int> Numbers = new MyQueue<int>();
        private void fillListBox()
        {
            listBox1.Items.Clear();

            for (int i = 0; i < Numbers.MyArray().Length; i++)
            {
                listBox1.Items.Add(Numbers.MyArray()[i].ToString());
            }

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EnqueueBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Numbers.enQueue(Convert.ToInt32(elementTxt.Text));
                fillListBox();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка");
            }
        }

        private void DequeueBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Извлечен элемент: " + Numbers.deQueue());
                fillListBox();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка");
            }
        }

        private void PeekBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Ваш элемент: " + Numbers.Peek());
                fillListBox();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка");
            }
        }
    }
}
