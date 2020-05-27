namespace Laba10.FirstTask
{
    partial class Level1_FirstTask
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
            this.StrInput_TextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.input = new System.Windows.Forms.Button();
            this.InsertOfArray_button = new System.Windows.Forms.Button();
            this.InsertOfArray_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Delegated_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ArraySize_Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NewArrSize_TextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StrInput_TextBox
            // 
            this.StrInput_TextBox.Location = new System.Drawing.Point(12, 12);
            this.StrInput_TextBox.Multiline = true;
            this.StrInput_TextBox.Name = "StrInput_TextBox";
            this.StrInput_TextBox.Size = new System.Drawing.Size(265, 69);
            this.StrInput_TextBox.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(378, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(410, 303);
            this.listBox1.TabIndex = 1;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(12, 87);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 38);
            this.input.TabIndex = 2;
            this.input.Text = "Вставить";
            this.input.UseVisualStyleBackColor = true;
            this.input.Click += new System.EventHandler(this.input_Click);
            // 
            // InsertOfArray_button
            // 
            this.InsertOfArray_button.Location = new System.Drawing.Point(177, 113);
            this.InsertOfArray_button.Name = "InsertOfArray_button";
            this.InsertOfArray_button.Size = new System.Drawing.Size(100, 38);
            this.InsertOfArray_button.TabIndex = 3;
            this.InsertOfArray_button.Text = "Вставить по индексу";
            this.InsertOfArray_button.UseVisualStyleBackColor = true;
            this.InsertOfArray_button.Click += new System.EventHandler(this.InsertOfArray_button_Click);
            // 
            // InsertOfArray_TextBox
            // 
            this.InsertOfArray_TextBox.Location = new System.Drawing.Point(196, 87);
            this.InsertOfArray_TextBox.Name = "InsertOfArray_TextBox";
            this.InsertOfArray_TextBox.Size = new System.Drawing.Size(81, 20);
            this.InsertOfArray_TextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(592, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ArrayList Коллекция";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Использование делегатов";
            // 
            // Delegated_TextBox
            // 
            this.Delegated_TextBox.Location = new System.Drawing.Point(112, 49);
            this.Delegated_TextBox.Name = "Delegated_TextBox";
            this.Delegated_TextBox.Size = new System.Drawing.Size(81, 20);
            this.Delegated_TextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "индекс строки";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(112, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Применить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.Delegated_TextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(588, 348);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Размер коллекции:";
            // 
            // ArraySize_Label
            // 
            this.ArraySize_Label.AutoSize = true;
            this.ArraySize_Label.Location = new System.Drawing.Point(12, 202);
            this.ArraySize_Label.Name = "ArraySize_Label";
            this.ArraySize_Label.Size = new System.Drawing.Size(0, 13);
            this.ArraySize_Label.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Изменение размера коллекции";
            // 
            // NewArrSize_TextBox
            // 
            this.NewArrSize_TextBox.Location = new System.Drawing.Point(12, 279);
            this.NewArrSize_TextBox.Name = "NewArrSize_TextBox";
            this.NewArrSize_TextBox.Size = new System.Drawing.Size(100, 20);
            this.NewArrSize_TextBox.TabIndex = 14;
            this.NewArrSize_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // Level1_FirstTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewArrSize_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ArraySize_Label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InsertOfArray_TextBox);
            this.Controls.Add(this.InsertOfArray_button);
            this.Controls.Add(this.input);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.StrInput_TextBox);
            this.Name = "Level1_FirstTask";
            this.Text = "Level1_FirstTask";
            this.Load += new System.EventHandler(this.Level1_FirstTask_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StrInput_TextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button input;
        private System.Windows.Forms.Button InsertOfArray_button;
        private System.Windows.Forms.TextBox InsertOfArray_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Delegated_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ArraySize_Label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NewArrSize_TextBox;
    }
}