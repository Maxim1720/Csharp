namespace Laba9.FirstTask_Folder
{
    partial class FirstTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateUnit_Button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Table = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.ClearTable_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateUnit_Button
            // 
            this.CreateUnit_Button.Enabled = false;
            this.CreateUnit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateUnit_Button.Location = new System.Drawing.Point(12, 62);
            this.CreateUnit_Button.Name = "CreateUnit_Button";
            this.CreateUnit_Button.Size = new System.Drawing.Size(125, 60);
            this.CreateUnit_Button.TabIndex = 0;
            this.CreateUnit_Button.Text = "Создать Юнит";
            this.CreateUnit_Button.UseVisualStyleBackColor = true;
            this.CreateUnit_Button.Click += new System.EventHandler(this.CreateUnit_Button_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "TrollAxeThrower",
            "Dragon"});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(125, 44);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(143, 12);
            this.Table.Name = "Table";
            this.Table.ReadOnly = true;
            this.Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Table.Size = new System.Drawing.Size(450, 255);
            this.Table.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Прокачать выбранных троллей";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClearTable_Button
            // 
            this.ClearTable_Button.Location = new System.Drawing.Point(12, 234);
            this.ClearTable_Button.Name = "ClearTable_Button";
            this.ClearTable_Button.Size = new System.Drawing.Size(125, 33);
            this.ClearTable_Button.TabIndex = 4;
            this.ClearTable_Button.Text = "Очистить таблицу";
            this.ClearTable_Button.UseVisualStyleBackColor = true;
            this.ClearTable_Button.Click += new System.EventHandler(this.ClearTable_Button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.listBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 128);
            this.panel1.TabIndex = 5;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "HP",
            "Attack",
            "Armor",
            "Distance",
            "Price"});
            this.listBox2.Location = new System.Drawing.Point(6, 33);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(119, 43);
            this.listBox2.TabIndex = 3;
            this.listBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseDown);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(6, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите изменяемую характеристику";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(217, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Изменение характеристик";
            // 
            // FirstTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 443);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ClearTable_Button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CreateUnit_Button);
            this.Name = "FirstTask";
            this.Text = "FirstTask";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FirstTask_FormClosing);
            this.Load += new System.EventHandler(this.FirstTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateUnit_Button;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ClearTable_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
    }
}