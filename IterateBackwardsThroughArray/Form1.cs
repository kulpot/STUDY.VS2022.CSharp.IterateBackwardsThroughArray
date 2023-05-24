using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IterateBackwardsThroughArray
{
    public partial class Form1 : Form
    {
        private string[] _sentence = new string[] { "This", "is", "some", "text" };

        public Form1()
        {
            InitializeComponent();
            ListStrings();
        }

        private void ListStrings()
        {
            for(int i = _sentence.Length - 1; i >= 0; i--)
            {
                listBox1.Items.Add(_sentence[i]);
            }
        }
    }
}
