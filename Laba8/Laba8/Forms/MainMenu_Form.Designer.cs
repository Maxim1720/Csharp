namespace Laba8
{
    partial class MainMenu_Form
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
            this.FirstTask_Button = new System.Windows.Forms.Button();
            this.SecondTask_Button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstTask_Button
            // 
            this.FirstTask_Button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.FirstTask_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstTask_Button.Location = new System.Drawing.Point(12, 12);
            this.FirstTask_Button.Name = "FirstTask_Button";
            this.FirstTask_Button.Size = new System.Drawing.Size(87, 71);
            this.FirstTask_Button.TabIndex = 0;
            this.FirstTask_Button.Text = "First Task";
            this.FirstTask_Button.UseVisualStyleBackColor = false;
            this.FirstTask_Button.Click += new System.EventHandler(this.FirstTask_Button_Click);
            // 
            // SecondTask_Button
            // 
            this.SecondTask_Button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SecondTask_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondTask_Button.Location = new System.Drawing.Point(105, 89);
            this.SecondTask_Button.Name = "SecondTask_Button";
            this.SecondTask_Button.Size = new System.Drawing.Size(87, 71);
            this.SecondTask_Button.TabIndex = 1;
            this.SecondTask_Button.Text = "Second Task";
            this.SecondTask_Button.UseVisualStyleBackColor = false;
            this.SecondTask_Button.Click += new System.EventHandler(this.SecondTask_Button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(198, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 71);
            this.button3.TabIndex = 2;
            this.button3.Text = "Third Task";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainMenu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(292, 244);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SecondTask_Button);
            this.Controls.Add(this.FirstTask_Button);
            this.Name = "MainMenu_Form";
            this.Text = "MainMenu_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FirstTask_Button;
        private System.Windows.Forms.Button SecondTask_Button;
        private System.Windows.Forms.Button button3;
    }
}