using Laba9.FirstTask_Folder.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba9.FirstTask_Folder
{
    public partial class FirstTask : Form
    {

        //Поля

        DataTable dt; //Таблица, которую мы будем выводить
        DataRow row1; //Строка нашей таблицы

        DataTable testingTable;

        List<AxeThrower> at = new List<AxeThrower>();
        List<Berserker> berserkers = new List<Berserker>();  //Списки юнитов разных типов
        List<Dragon> dragons = new List<Dragon>();

        BinaryFormatter bif;  //Бинарный форматтер
        Stream DragonFile, TrollFile, BerserkerFile;  //Потоки, которые в дальнейшем служат ФАЙЛОВЫМИ

        DataSet dataSet = new DataSet();

        private void SomeMethod()
        {
        }

        //Поля


        public FirstTask()//КОНСТРУКТОР
        {
            InitializeComponent();
        }

        private void DrawTable()//ПРОЦЕДУРА - РИСУЕТ ТАБЛИЦУ
        {
            // dt = Table.DataSource;
            dt = new DataTable();
            dt.Columns.Add("№");
            dt.Columns.Add("Name");
            dt.Columns.Add("HP");
            dt.Columns.Add("Attack");      //Задаем столбцы таблице
            dt.Columns.Add("Armor");
            dt.Columns.Add("Distance");
            dt.Columns.Add("Price");

            testingTable = dt;

            for (int i = 0; i < at.Count; i++)
            {
                row1 = dt.NewRow();
                row1[0] = i + 1;
                row1[1] = at[i];
                row1[2] = at[i].HP.ToString();
                row1["Attack"] = at[i].Attack;
                row1["Armor"] = at[i].Armor.ToString();
                row1["Distance"] = at[i].Distance.ToString();
                row1["Price"] = at[i].Price.ToString();
                dt.Rows.Add(row1);
            }
            for (int i = 0; i < dragons.Count; i++)
            {
                row1 = dt.NewRow();
                row1["№"] = i + 1;
                row1["Name"] = dragons[i];
                row1["HP"] = dragons[i].HP.ToString();
                row1["Attack"] = dragons[i].Attack;
                row1["Armor"] = dragons[i].Armor.ToString();
                row1["Distance"] = dragons[i].Distance.ToString();
                row1["Price"] = dragons[i].Price.ToString();
                dt.Rows.Add(row1);
            }                 //В качестве строк под каждый столбец задаем соответствующие данные
            for (int i = 0; i < berserkers.Count; i++)
            {
                row1 = dt.NewRow();
                row1["№"] = i + 1;
                row1["Name"] = berserkers[i];
                row1["HP"] = berserkers[i].HP.ToString();
                row1["Attack"] = berserkers[i].Attack;
                row1["Armor"] = berserkers[i].Armor.ToString();
                row1["Distance"] = berserkers[i].Distance.ToString();
                row1["Price"] = berserkers[i].Price.ToString();
                dt.Rows.Add(row1);
            }

            Table.DataSource = dt;
            Table.AutoResizeColumns();
            Table.AutoResizeRows();

        }
        private Berserker NewBerserk(AxeThrower ax)// ФУНКЦИЯ - замена тролля берсерком(удаление тролля, создание берсерка - всё!)
        {
            at.Remove(ax);
            return new Berserker();
        }
        private void FirstTask_Load(object sender, EventArgs e) //СОБЫТИЕ - ЗАГРУЗКА ФОРМЫ и ДЕСЕРИАЛИЗАЦИЯ ОБЪЕКТОВ
        {
            if (File.Exists("Troll.bin") && File.Exists("Berserker.bin") && File.Exists("Dragon.bin") && File.Exists("DT.bin"))
            {
                TrollFile = File.Open("Troll.bin", FileMode.Open, FileAccess.ReadWrite);
                DragonFile = File.Open("Dragon.bin", FileMode.Open, FileAccess.ReadWrite);   //Открытие файлов, где лежат объекты юнитов
                BerserkerFile = File.Open("Berserker.bin", FileMode.Open, FileAccess.ReadWrite);


                bif = new BinaryFormatter();  //Бинарный форматтер, используется для сериализации и десериализации объектов в файлы
                at.AddRange((List<AxeThrower>)bif.Deserialize(TrollFile));
                dragons.AddRange((List<Dragon>)bif.Deserialize(DragonFile));   //выгрузка объектов обратно в оперативку
                berserkers.AddRange((List<Berserker>)bif.Deserialize(BerserkerFile));

                DragonFile.Close();
                BerserkerFile.Close();  //закрываем потоки для их сохранения
                TrollFile.Close();
            }
            else
            {
                DragonFile = File.Create("Dragon.bin");
                BerserkerFile = File.Create("Berserker.bin");
                TrollFile = File.Create("Troll.bin");
            }

            DrawTable();


        }

        private void FirstTask_FormClosing(object sender, FormClosingEventArgs e)//СОБЫТИЕ - СЕРИАЛИЗАЦИЯ ПРИ ЗАКРЫТИИ ФОРМЫ
        {

            TrollFile = File.Open("Troll.bin", FileMode.Open, FileAccess.ReadWrite);
            DragonFile = File.Open("Dragon.bin", FileMode.Open, FileAccess.ReadWrite);   //Открываем файлы, куда будем класть объекты в постоянную память
            BerserkerFile = File.Open("Berserker.bin", FileMode.Open, FileAccess.ReadWrite);

            bif.Serialize(TrollFile, at);
            bif.Serialize(BerserkerFile, berserkers);  //Кладем объекты в постоянную память
            bif.Serialize(DragonFile, dragons);

            DragonFile.Close();
            BerserkerFile.Close();  //Закрываем поток
            TrollFile.Close();
        }

        private void ClearTable_Button_Click(object sender, EventArgs e)//КНОПКА - ОЧИСТКА ТАБЛИЦЫ И УДАЛЕНИЕ ВСЕХ ЮНИТОВ
        {

            at.Clear();
            dragons.Clear();
            berserkers.Clear();
            Table.Columns.Clear();
            DrawTable();
        }

        private void button1_Click(object sender, EventArgs e)//КНОПКА - ПРОКАЧКА ТРОЛЛЯ В БЕРСЕРКА
        {
            foreach (DataGridViewRow r in Table.SelectedRows)
            {

                if (r.Cells["Name"].Value.ToString() == "AxeThrower")
                {

                    berserkers.Add(NewBerserk(at[int.Parse(r.Cells[0].Value.ToString()) - 1]));
                    Table.Rows.Remove(r);

                }

            }
            DrawTable();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e) //  Новая величина ФИКСИРОВАННАЯ                                 !!!!!
        {
            label1.Visible = false;
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    foreach (DataGridViewRow r in Table.SelectedRows)
                    {
                        if (listBox2.SelectedItem.ToString() == "HP")
                        {
                            if (r.Cells[1].Value.ToString() == "AxeThrower")
                            {
                                at[int.Parse(r.Cells[0].Value.ToString()) - 1].UpdateFields(int.Parse(textBox1.Text), Unit.UpdatingSettings.HP);
                            }
                            else if (r.Cells[1].Value.ToString() == "Berserker")
                            {
                                berserkers[int.Parse(r.Cells[0].Value.ToString()) - 1].UpdateFields(int.Parse(textBox1.Text), Unit.UpdatingSettings.HP);
                            }
                            else if (r.Cells[1].Value.ToString() == "Dragon")
                            {
                                dragons[int.Parse(r.Cells[0].Value.ToString()) - 1].UpdateFields(int.Parse(textBox1.Text), Unit.UpdatingSettings.HP);
                            }
                        }
                        else if (listBox2.SelectedItem.ToString() == "Attack")
                        {
                            if (r.Cells[1].Value.ToString() == "AxeThrower")
                            {
                                at[int.Parse(r.Cells[0].Value.ToString()) - 1].UpdateAttack(textBox1.Text);

                            }
                            else if (r.Cells[1].Value.ToString() == "Berserker")
                            {
                                berserkers[int.Parse(r.Cells[0].Value.ToString()) - 1].UpdateAttack(textBox1.Text);
                            }
                            else if (r.Cells[1].Value.ToString() == "Dragon")
                            {
                                dragons[int.Parse(r.Cells[0].Value.ToString()) - 1].UpdateAttack(textBox1.Text);
                            }
                        }
                        else if (listBox2.SelectedItem.ToString() == "Armor")
                        {
                            if (r.Cells[1].Value.ToString() == "AxeThrower")
                            {
                                at[int.Parse(r.Cells[0].Value.ToString()) - 1].UpdateFields(int.Parse(textBox1.Text), Unit.UpdatingSettings.Armor);

                            }
                            else if (r.Cells[1].Value.ToString() == "Berserker")
                            {
                                berserkers[int.Parse(r.Cells[0].Value.ToString()) - 1].UpdateFields(int.Parse(textBox1.Text), Unit.UpdatingSettings.Armor);
                            }
                            else if (r.Cells[1].Value.ToString() == "Dragon")
                            {
                                dragons[int.Parse(r.Cells[0].Value.ToString()) - 1].UpdateFields(int.Parse(textBox1.Text), Unit.UpdatingSettings.Armor);
                            }
                        }
                        else if (listBox2.SelectedItem.ToString() == "Distance")
                        {
                            if (r.Cells[1].Value.ToString() == "AxeThrower")
                            {
                                at[int.Parse(r.Cells[0].Value.ToString()) - 1].UpdateFields(int.Parse(textBox1.Text), Unit.UpdatingSettings.Distance);

                            }
                            else if (r.Cells[1].Value.ToString() == "Berserker")
                            {
                                berserkers[int.Parse(r.Cells[0].Value.ToString()) - 1].UpdateFields(int.Parse(textBox1.Text), Unit.UpdatingSettings.Distance);
                            }
                            else if (r.Cells[1].Value.ToString() == "Dragon")
                            {
                                dragons[int.Parse(r.Cells[0].Value.ToString()) - 1].UpdateFields(int.Parse(textBox1.Text), Unit.UpdatingSettings.Distance);
                            }

                        }
                        else if (listBox2.SelectedItem.ToString() == "Price")
                        {
                            if (r.Cells[1].Value.ToString() == "AxeThrower")
                            {
                                at[int.Parse(r.Cells[0].Value.ToString()) - 1].UpdateFields(int.Parse(textBox1.Text), Unit.UpdatingSettings.Price);

                            }
                            else if (r.Cells[1].Value.ToString() == "Berserker")
                            {
                                berserkers[int.Parse(r.Cells[0].Value.ToString()) - 1].UpdateFields(int.Parse(textBox1.Text), Unit.UpdatingSettings.Price);
                            }
                            else if (r.Cells[1].Value.ToString() == "Dragon")
                            {
                                dragons[int.Parse(r.Cells[0].Value.ToString()) - 1].UpdateFields(int.Parse(textBox1.Text), Unit.UpdatingSettings.Price);
                            }
                        }

                    }
                    DrawTable();
                    label1.Text = "Изменения внесены";
                }

                catch
                {
                    label1.Visible = true;
                    label1.Text = "Неверный ввод";
                }


            }

        }

        

        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.Enabled = true;
        }

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)//ЛИСТ БОКС - ВЫБОР ЮНИТА ДЛЯ СОЗДАНИЯ
        {
            CreateUnit_Button.Enabled = true;
        }

        private void CreateUnit_Button_Click(object sender, EventArgs e)//КНОПКА - СОЗДАНИЕ ИГРОВОГО ЮНИТА
        {
            try
            {
                if (listBox1.SelectedItem.ToString() == "TrollAxeThrower")
                {

                    at.Add(new AxeThrower());
                }
                else if (listBox1.SelectedItem.ToString() == "Dragon")
                {
                    dragons.Add(new Dragon());
                }
                DrawTable();

            }

            catch { }
        }






    }
}

