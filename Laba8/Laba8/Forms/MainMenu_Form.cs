using Laba8.Forms.ThirdTask;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba8
{
    public partial class MainMenu_Form : Form
    {
        public MainMenu_Form()
        {
            InitializeComponent();
        }

        private void FirstTask_Button_Click(object sender, EventArgs e)
        {
            First_Form objfirst = new First_Form();
            objfirst.Show();
        }

        private void SecondTask_Button_Click(object sender, EventArgs e)
        {
            Second_Form objsecond = new Second_Form();
            objsecond.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Third_Form objThird = new Third_Form();
            objThird.Show();
        }
    }
}
