using Laba8.Classes;
using Laba8.Forms;
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
    public partial class Second_Form : Form
    {
        private Warehouse wh;
        DataTable dt = new DataTable();
        DataColumn column;
        DataRow row;
        DataGridColumnNames dg;

        enum DataGridColumnNames
        {
            No, Название, Код, Количество, Стоимость
        };
        uint ColumnCount = 5;

        private DataTable DataGridFill(Warehouse wh, DataTable DT)
        {
            for (int i = 0; i < ColumnCount; i++)
            {
                dg = (DataGridColumnNames)i;
                column = new DataColumn(dg.ToString());

                DT.Columns.Add(column);
            }
            for (int i = 0; i < wh.Count; i++)
            {
                row = DT.NewRow();
                for (int j = 0; j < ColumnCount; j++)
                {
                    dg = (DataGridColumnNames)j;
                    if (dg.ToString() == "No")
                    {
                        row[dg.ToString()] = i + 1;
                    }
                    else
                    {
                        row[dg.ToString()] = wh[i].arr[j];
                    }
                }
                DT.Rows.Add(row);
            }
            return DT;
        }
        public Second_Form()
        {
            InitializeComponent();
            wh = new Warehouse();
            Warehouse_DataGrid.DataSource = DataGridFill(wh, dt);

        }



        private void ChooseByNumber_Click(object sender, EventArgs e)
        {
            DataTable mini_DG = new DataTable();


            for (int i = 1; i < ColumnCount; i++)
            {
                dg = (DataGridColumnNames)i;

                column = new DataColumn(dg.ToString());
                mini_DG.Columns.Add(column);


            }
            row = mini_DG.NewRow();
            for (int i = 1; i < ColumnCount; i++)
            {
                dg = (DataGridColumnNames)i;

                try
                {
                    row[dg.ToString()] = wh[int.Parse(NumChoose_TextBox.Text) - 1].arr[i].ToString();
                }
                catch
                {
                    NumChoose_TextBox.Clear();

                }

            }
            mini_DG.Rows.Add(row);
            ProductProperties_DataGrid.DataSource = mini_DG;
        }

        private void Sort_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            const string NameSort = "По наименованию";
            const string CountSort = "По количеству";
            const string PriceSort = "По цене";

            if (Sort_ListBox.SelectedItem.ToString() == NameSort)
            {
                var kek = from pr in wh.kit
                          orderby pr.Name.ToString(), pr.Name.ToString().Length
                          select pr;
                int y = 0;
                foreach (var p in kek)
                {

                    wh.kit[y] = p;
                    wh.kit[y].Num = (uint)y + 1;
                    y++;
                }
                Warehouse_DataGrid.DataSource = DataGridFill(wh, dt = new DataTable());

            }
            else if (Sort_ListBox.SelectedItem.ToString() == CountSort)
            {
                var kek = from pr in wh.kit
                          orderby pr.Count
                          select pr;
                int y = 0;
                foreach (var p in kek)
                {

                    wh.kit[y] = p;
                    wh.kit[y].Num = (uint)y + 1;
                    y++;
                }
                Warehouse_DataGrid.DataSource = DataGridFill(wh, dt = new DataTable());
            }
            else if (Sort_ListBox.SelectedItem.ToString() == PriceSort)
            {
                var kek = from pr in wh.kit
                          orderby pr.Price
                          select pr;
                int y = 0;
                foreach (var p in kek)
                {

                    wh.kit[y] = p;
                    wh.kit[y].Num = (uint)y + 1;
                    y++;
                }
                Warehouse_DataGrid.DataSource = DataGridFill(wh, dt = new DataTable());
            }

        }

        private void SearchToName_Button_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            int count = 0;
            for (int i = 0; i < wh.kit.Count; i++)
            {
                if (wh.kit[i].Name.ToString().Replace('_', ' ').ToLower().Contains(SearchToName_TextBox.Text.ToLower()))
                {
                    count++;
                    row = dt.NewRow();
                    for (int j = 0; j < ColumnCount; j++)
                    {
                        dg = (DataGridColumnNames)j;
                        if (dg.ToString() == "No")
                        {
                            row[dg.ToString()] = i + 1;
                        }
                        else
                        {
                            row[dg.ToString()] = wh[i].arr[j];
                        }
                    }
                    dt.Rows.Add(row);
                }
            }

            Warehouse_DataGrid.DataSource = dt;
            if (count == 0 || string.IsNullOrEmpty(SearchToName_TextBox.Text))
            {
                NotSearch_FormDialog n = new NotSearch_FormDialog();
                if (count == 0) n.ShowDialog();
                SearchToName_TextBox.Clear();
            }
        }
    }
}
