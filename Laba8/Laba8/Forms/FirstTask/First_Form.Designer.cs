namespace Laba8
{
    partial class First_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TableArr = new System.Windows.Forms.DataGridView();
            this.n_TextBox = new System.Windows.Forms.TextBox();
            this.m_TextBox = new System.Windows.Forms.TextBox();
            this.n_label = new System.Windows.Forms.Label();
            this.m_Label = new System.Windows.Forms.Label();
            this.ArrCreate_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableArr)).BeginInit();
            this.SuspendLayout();
            // 
            // TableArr
            // 
            this.TableArr.AllowUserToAddRows = false;
            this.TableArr.AllowUserToDeleteRows = false;
            this.TableArr.AllowUserToResizeColumns = false;
            this.TableArr.AllowUserToResizeRows = false;
            this.TableArr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.TableArr.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.TableArr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TableArr.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.TableArr.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.TableArr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableArr.EnableHeadersVisualStyles = false;
            this.TableArr.Location = new System.Drawing.Point(185, 5);
            this.TableArr.Name = "TableArr";
            this.TableArr.ReadOnly = true;
            this.TableArr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TableArr.Size = new System.Drawing.Size(397, 366);
            this.TableArr.TabIndex = 0;
            this.TableArr.TabStop = false;
            this.TableArr.Visible = false;
            // 
            // n_TextBox
            // 
            this.n_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.n_TextBox.Location = new System.Drawing.Point(22, 29);
            this.n_TextBox.Name = "n_TextBox";
            this.n_TextBox.Size = new System.Drawing.Size(36, 22);
            this.n_TextBox.TabIndex = 1;
            this.n_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.n_TextBox_KeyPress);
            // 
            // m_TextBox
            // 
            this.m_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.m_TextBox.Location = new System.Drawing.Point(75, 29);
            this.m_TextBox.Name = "m_TextBox";
            this.m_TextBox.Size = new System.Drawing.Size(41, 22);
            this.m_TextBox.TabIndex = 2;
            // 
            // n_label
            // 
            this.n_label.AutoSize = true;
            this.n_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.n_label.Location = new System.Drawing.Point(31, 13);
            this.n_label.Name = "n_label";
            this.n_label.Size = new System.Drawing.Size(15, 16);
            this.n_label.TabIndex = 3;
            this.n_label.Text = "n";
            // 
            // m_Label
            // 
            this.m_Label.AutoSize = true;
            this.m_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.m_Label.Location = new System.Drawing.Point(90, 13);
            this.m_Label.Name = "m_Label";
            this.m_Label.Size = new System.Drawing.Size(19, 16);
            this.m_Label.TabIndex = 4;
            this.m_Label.Text = "m";
            // 
            // ArrCreate_Button
            // 
            this.ArrCreate_Button.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ArrCreate_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArrCreate_Button.Location = new System.Drawing.Point(22, 57);
            this.ArrCreate_Button.Name = "ArrCreate_Button";
            this.ArrCreate_Button.Size = new System.Drawing.Size(94, 23);
            this.ArrCreate_Button.TabIndex = 5;
            this.ArrCreate_Button.Text = "Create Array";
            this.ArrCreate_Button.UseVisualStyleBackColor = false;
            this.ArrCreate_Button.Click += new System.EventHandler(this.ArrCreate_Button_Click);
            // 
            // First_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(587, 375);
            this.Controls.Add(this.ArrCreate_Button);
            this.Controls.Add(this.m_Label);
            this.Controls.Add(this.n_label);
            this.Controls.Add(this.m_TextBox);
            this.Controls.Add(this.n_TextBox);
            this.Controls.Add(this.TableArr);
            this.Name = "First_Form";
            this.Text = "ArrCreate_Form";
            ((System.ComponentModel.ISupportInitialize)(this.TableArr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TableArr;
        private System.Windows.Forms.TextBox n_TextBox;
        private System.Windows.Forms.TextBox m_TextBox;
        private System.Windows.Forms.Label n_label;
        private System.Windows.Forms.Label m_Label;
        private System.Windows.Forms.Button ArrCreate_Button;
    }
}

