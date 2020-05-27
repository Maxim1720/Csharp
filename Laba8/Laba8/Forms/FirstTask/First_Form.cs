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
    public partial class First_Form : Form
    {
        uint n;
        uint m;
        int[,] Arr;
        DataTable dt = new DataTable();
        DataColumn column;
        DataRow row;

        public First_Form()
        {
            InitializeComponent();
        }

        private void ArrCreate_Button_Click(object sender, EventArgs e)
        {
            dt = null;
            dt = new DataTable();
            try
            {
                
                n = Convert.ToUInt32(n_TextBox.Text);
                m = Convert.ToUInt32(m_TextBox.Text);
                Arr = new int[n, m];
                FillArr(Arr);

            }
            catch
            {
                n_TextBox.Clear();
                m_TextBox.Clear();
                
            }
            
            for(int i = 0; i < Arr.GetLength(1); i++)
            {
                column = new DataColumn();
                column.ColumnName = Arr[0, i].ToString();
                dt.Columns.Add(column);
            }
            for (int i = 1; i < Arr.GetLength(0); i++)
            { 
                row = dt.NewRow();
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                   
                    row[Arr[0, j].ToString()] = Arr[i, j].ToString();
                    
                }
                dt.Rows.Add(row);
            }

            TableArr.DataSource = dt;
            TableArr.Visible = true;
        }
        private void FillArr(int[,] Arr)
        {
            int h = 0;
            int k;
            bool flag;
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                flag = false;
                k = h;
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    if (k>0 && !flag)
                    {
                        Arr[i, j] = k--;
                    }
                    else
                    {
                        flag = true;
                        Arr[i, j] = k++;
                    }
                    
                }
                h++;
            }
        }

        private void n_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
