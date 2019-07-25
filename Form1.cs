using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetChecked
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnGetItem_Click(object sender, EventArgs e)
        {
            listBoxitem.Items.Clear();
            foreach (string s in checkedListBox.CheckedItems)
                listBoxitem.Items.Add(s);
        }

        private void BtnGetIndex_Click(object sender, EventArgs e)
        {
            listBoxIndex.Items.Clear();
            for (int i = 0; i < checkedListBox.CheckedIndices.Count; i++)
                listBoxIndex.Items.Add(checkedListBox.CheckedIndices[i]);
        }
    }
}
