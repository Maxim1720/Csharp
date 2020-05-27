namespace Laba8
{
    partial class Second_Form
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
            this.Warehouse_DataGrid = new System.Windows.Forms.DataGridView();
            this.Warehouse_Label = new System.Windows.Forms.Label();
            this.NumChoose_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChooseProduct_Button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductProperties_DataGrid = new System.Windows.Forms.DataGridView();
            this.ProductProperties_Panel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SearchToName_Button = new System.Windows.Forms.Button();
            this.SearchToName_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Sort_ListBox = new System.Windows.Forms.ListBox();
            this.Sort_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Warehouse_DataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductProperties_DataGrid)).BeginInit();
            this.ProductProperties_Panel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Warehouse_DataGrid
            // 
            this.Warehouse_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Warehouse_DataGrid.Location = new System.Drawing.Point(8, 28);
            this.Warehouse_DataGrid.Name = "Warehouse_DataGrid";
            this.Warehouse_DataGrid.Size = new System.Drawing.Size(562, 339);
            this.Warehouse_DataGrid.TabIndex = 4;
            // 
            // Warehouse_Label
            // 
            this.Warehouse_Label.AutoSize = true;
            this.Warehouse_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Warehouse_Label.Location = new System.Drawing.Point(165, 9);
            this.Warehouse_Label.Name = "Warehouse_Label";
            this.Warehouse_Label.Size = new System.Drawing.Size(117, 16);
            this.Warehouse_Label.TabIndex = 5;
            this.Warehouse_Label.Text = "Товар на складе";
            // 
            // NumChoose_TextBox
            // 
            this.NumChoose_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumChoose_TextBox.Location = new System.Drawing.Point(14, 42);
            this.NumChoose_TextBox.Name = "NumChoose_TextBox";
            this.NumChoose_TextBox.Size = new System.Drawing.Size(89, 24);
            this.NumChoose_TextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выберите товар по номеру";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.ChooseProduct_Button);
            this.panel1.Controls.Add(this.NumChoose_TextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 398);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 155);
            this.panel1.TabIndex = 8;
            // 
            // ChooseProduct_Button
            // 
            this.ChooseProduct_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseProduct_Button.Location = new System.Drawing.Point(136, 62);
            this.ChooseProduct_Button.Name = "ChooseProduct_Button";
            this.ChooseProduct_Button.Size = new System.Drawing.Size(86, 27);
            this.ChooseProduct_Button.TabIndex = 15;
            this.ChooseProduct_Button.Text = "Выбрать";
            this.ChooseProduct_Button.UseVisualStyleBackColor = true;
            this.ChooseProduct_Button.Click += new System.EventHandler(this.ChooseByNumber_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.Warehouse_DataGrid);
            this.panel2.Controls.Add(this.Warehouse_Label);
            this.panel2.Location = new System.Drawing.Point(236, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 370);
            this.panel2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(45, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Свойства товара";
            // 
            // ProductProperties_DataGrid
            // 
            this.ProductProperties_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductProperties_DataGrid.Location = new System.Drawing.Point(8, 30);
            this.ProductProperties_DataGrid.Name = "ProductProperties_DataGrid";
            this.ProductProperties_DataGrid.Size = new System.Drawing.Size(554, 77);
            this.ProductProperties_DataGrid.TabIndex = 11;
            // 
            // ProductProperties_Panel
            // 
            this.ProductProperties_Panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProductProperties_Panel.Controls.Add(this.ProductProperties_DataGrid);
            this.ProductProperties_Panel.Controls.Add(this.label2);
            this.ProductProperties_Panel.Location = new System.Drawing.Point(236, 398);
            this.ProductProperties_Panel.Name = "ProductProperties_Panel";
            this.ProductProperties_Panel.Size = new System.Drawing.Size(601, 155);
            this.ProductProperties_Panel.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.SearchToName_Button);
            this.panel3.Controls.Add(this.SearchToName_TextBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 155);
            this.panel3.TabIndex = 13;
            // 
            // SearchToName_Button
            // 
            this.SearchToName_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchToName_Button.Location = new System.Drawing.Point(136, 65);
            this.SearchToName_Button.Name = "SearchToName_Button";
            this.SearchToName_Button.Size = new System.Drawing.Size(86, 27);
            this.SearchToName_Button.TabIndex = 16;
            this.SearchToName_Button.Text = "Поиск";
            this.SearchToName_Button.UseVisualStyleBackColor = true;
            this.SearchToName_Button.Click += new System.EventHandler(this.SearchToName_Button_Click);
            // 
            // SearchToName_TextBox
            // 
            this.SearchToName_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchToName_TextBox.Location = new System.Drawing.Point(14, 42);
            this.SearchToName_TextBox.Name = "SearchToName_TextBox";
            this.SearchToName_TextBox.Size = new System.Drawing.Size(89, 24);
            this.SearchToName_TextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Поиск товара по названию";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.Sort_ListBox);
            this.panel4.Controls.Add(this.Sort_Label);
            this.panel4.Location = new System.Drawing.Point(6, 225);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(224, 146);
            this.panel4.TabIndex = 14;
            // 
            // Sort_ListBox
            // 
            this.Sort_ListBox.FormattingEnabled = true;
            this.Sort_ListBox.Items.AddRange(new object[] {
            "По наименованию",
            "По количеству",
            "По цене"});
            this.Sort_ListBox.Location = new System.Drawing.Point(14, 43);
            this.Sort_ListBox.Name = "Sort_ListBox";
            this.Sort_ListBox.Size = new System.Drawing.Size(125, 43);
            this.Sort_ListBox.TabIndex = 8;
            this.Sort_ListBox.SelectedIndexChanged += new System.EventHandler(this.Sort_ListBox_SelectedIndexChanged);
            // 
            // Sort_Label
            // 
            this.Sort_Label.AutoSize = true;
            this.Sort_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sort_Label.Location = new System.Drawing.Point(11, 21);
            this.Sort_Label.Name = "Sort_Label";
            this.Sort_Label.Size = new System.Drawing.Size(92, 18);
            this.Sort_Label.TabIndex = 7;
            this.Sort_Label.Text = "Сортировка";
            // 
            // Second_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(841, 565);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ProductProperties_Panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Second_Form";
            this.Text = "Second_Form";
            ((System.ComponentModel.ISupportInitialize)(this.Warehouse_DataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductProperties_DataGrid)).EndInit();
            this.ProductProperties_Panel.ResumeLayout(false);
            this.ProductProperties_Panel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Warehouse_DataGrid;
        private System.Windows.Forms.Label Warehouse_Label;
        private System.Windows.Forms.TextBox NumChoose_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ProductProperties_DataGrid;
        private System.Windows.Forms.Panel ProductProperties_Panel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox SearchToName_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox Sort_ListBox;
        private System.Windows.Forms.Label Sort_Label;
        private System.Windows.Forms.Button ChooseProduct_Button;
        private System.Windows.Forms.Button SearchToName_Button;
    }
}