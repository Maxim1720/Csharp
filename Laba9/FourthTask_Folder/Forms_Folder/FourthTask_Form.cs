using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Library.FourthTask_Folder;

namespace Laba9.FourthTask_Folder.Forms_Folder
{
    public partial class FourthTask_Form : Form
    {

        Ipad[] ipads;
        DataColumn column;
        DataRow row;
        DataTable dt;
        string[] column_names = { "Model", "Processor", "Memory", "Camera - Mp", "Width - mm", "Height - mm", "Display" };
        public FourthTask_Form()
        {
            InitializeComponent();
        }

        private void DrawTable()
        {
            dt = new DataTable();
            for (int i = 0; i < column_names.Length; i++)
            {
                column = new DataColumn(column_names[i]);
                dt.Columns.Add(column);
            }

            for (int i = 0; i < ipads.Length; i++)
            {
                row = dt.NewRow();
                int j = 1;
                row[column_names[0]] = ipads[i].ToString().Replace('_', ' ');
                foreach (var prop in ipads[i])
                {
                    row[column_names[j]] = prop.ToString();
                    j++;
                }
                dt.Rows.Add(row);
            }

            Ipad_View.DataSource = dt;
        }

        private void FourthTask_Form_Load(object sender, EventArgs e)
        {
            //ipads = new List<Ipad>();
            ipads = new Ipad[5];
            for (int i = 0; i < 5; i++)
            {
                
                Ipad.Model m = (Ipad.Model)i;
                ipads[i] = new Ipad(m);
                //ipads.Add(new Ipad(m));
            }

            DrawTable();

            foreach (var item in ipads[0])
            {
                listBox1.Items.Add(item.ToString().Replace('_', ' '));
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Array.Sort<Ipad>(ipads);
            DrawTable();
        }
    }
}
