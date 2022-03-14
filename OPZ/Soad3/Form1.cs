using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soad3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void input_Click(object sender, EventArgs e)
        {

            string s = input_text.Text;
            
            OPZ_text.Text = OPZ.GetExpression(s);
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            string s = OPZ_text.Text;
            
            calculated_value.Text =Convert.ToString(OPZ.Counting(s));
        }
    }
}
