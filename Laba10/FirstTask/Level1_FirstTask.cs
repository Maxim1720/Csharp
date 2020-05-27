using Laba10.FirstTask.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba10.FirstTask
{
    public partial class Level1_FirstTask : Form
    {

        ArrayList Arr;
        private delegate void Fix(ref string str);
        Fix fix = new Fix(Replace.ToBackSlash);


        public Level1_FirstTask()
        {
            InitializeComponent();
        }
        private void Level1_FirstTask_Load(object sender, EventArgs e)
        {
            Arr = new ArrayList();
            fix += new Fix(Replace.ToDoubleSlash);
            fix += new Fix(Replace.ToUnderScore);
            fix += new Fix(Replace.ToUpper);
            ArraySize_Label.Text = Arr.Capacity.ToString();
        }

        private void AddInList()
        {
            ArraySize_Label.Text = Arr.Capacity.ToString();
            listBox1.Items.Clear();
            if (!Arr.Equals(null))
            {
                foreach (var i in Arr)
                {
                    listBox1.Items.Add(i);
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string str = (string)Arr[int.Parse(Delegated_TextBox.Text) - 1];
                fix(ref str);
                Arr[int.Parse(Delegated_TextBox.Text) - 1] = str;
                AddInList();
            }
            catch
            {
                Delegated_TextBox.Clear();
            }
        }

        private void input_Click(object sender, EventArgs e)
        {
            Arr.Add(StrInput_TextBox.Text);
            AddInList();
        }

        private void InsertOfArray_button_Click(object sender, EventArgs e)
        {
            try
            {
                Arr.Insert(int.Parse(InsertOfArray_TextBox.Text)-1, StrInput_TextBox.Text);
                AddInList();
            }
            catch
            {
                InsertOfArray_TextBox.Clear();
            }


        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Arr.Capacity = int.Parse(NewArrSize_TextBox.Text);
                    AddInList();
                }
                catch
                {
                    NewArrSize_TextBox.Clear();
                }
            }
        }
    }
}
