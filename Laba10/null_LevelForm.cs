using Laba10.FirstTask;
using Laba10.SecondTask;
using Laba10.ThirdTask;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba10
{
    public partial class null_LevelForm : Form
    {
        public null_LevelForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Level1_FirstTask objForm = new Level1_FirstTask();
            objForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Level1_SecondForm objForm = new Level1_SecondForm();
            objForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Level1_ThirdTaskForm objForm = new Level1_ThirdTaskForm();
            objForm.Show();
        }
    }
}
