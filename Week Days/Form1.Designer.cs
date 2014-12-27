namespace Week_Days
{
    partial class Form1
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
            this.monthBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.getDaysBtn = new System.Windows.Forms.Button();
            this.daysBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthBox
            // 
            this.monthBox.Location = new System.Drawing.Point(12, 27);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(100, 20);
            this.monthBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Month";
            // 
            // getDaysBtn
            // 
            this.getDaysBtn.Location = new System.Drawing.Point(12, 53);
            this.getDaysBtn.Name = "getDaysBtn";
            this.getDaysBtn.Size = new System.Drawing.Size(59, 23);
            this.getDaysBtn.TabIndex = 3;
            this.getDaysBtn.Text = "Get Weekdays";
            this.getDaysBtn.UseVisualStyleBackColor = true;
            this.getDaysBtn.Click += new System.EventHandler(this.getDaysBtn_Click);
            // 
            // daysBox
            // 
            this.daysBox.Location = new System.Drawing.Point(12, 84);
            this.daysBox.Name = "daysBox";
            this.daysBox.Size = new System.Drawing.Size(146, 343);
            this.daysBox.TabIndex = 4;
            this.daysBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(167, 435);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.daysBox);
            this.Controls.Add(this.getDaysBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox monthBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getDaysBtn;
        private System.Windows.Forms.RichTextBox daysBox;
        private System.Windows.Forms.Button button1;
    }
}

