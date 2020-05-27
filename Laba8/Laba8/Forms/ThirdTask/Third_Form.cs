using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba8.Forms.ThirdTask
{
    public partial class Third_Form : Form
    {
        string stat = "static";
        string[] modifications = { "public", "private", "internal", "protected" };
        string VoidMethod = "void";
        string IntMethod = "int";
        string UIntMethod = "uint";
        string DoubleMethod = "double";


        string Method = "";
        public Third_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] NM = ClassDescription_TextBox.Text.Split('\n');
            
            string path = "C:\\Users\\musie\\Desktop\\University\\C#\\Laba8\\Laba8\\Files\\Methods.txt";
            StreamWriter sw = new StreamWriter(path);
            int k = 0;

            foreach (string s in NM)
            {
                Method = "";
                if (s.Contains(stat)||s.Contains(modifications[0]) || s.Contains(modifications[1]) || s.Contains(modifications[2]) || s.Contains(modifications[3]))
                {
                    if (s.Contains(VoidMethod) || s.Contains(IntMethod) || s.Contains(UIntMethod) || s.Contains(DoubleMethod) || s.Contains("DataTable"))
                    {
                        if (s.Contains('(') && s.Contains(')'))
                        {
                            Method += s;

                            if (NM[k + 1].Contains("{"))
                            {
                                int y = k + 1;
                                int skobCount = 1;
                                while (skobCount!=0)
                                {
                                    if (NM[y].Contains("{"))
                                    {
                                        skobCount++;
                                    }
                                    else if (NM[y].Contains("}"))
                                    {
                                        skobCount--;
                                    }
                                    Method += NM[y];
                                    y++;
                                    
                                }

                            }
                        }
                    }
                }
                k++;
                sw.Write(Method);
                
            }

            sw.Close();


        }
    }
}
