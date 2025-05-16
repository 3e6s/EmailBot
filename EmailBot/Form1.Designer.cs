namespace EmailBot
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Red;
            textBox1.ForeColor = Color.Chartreuse;
            textBox1.Location = new Point(626, 270);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(864, 242);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.ForeColor = Color.Red;
            textBox2.Location = new Point(626, 596);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(863, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Red;
            textBox3.Location = new Point(626, 711);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(863, 441);
            textBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Algerian", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(627, 1158);
            button1.Name = "button1";
            button1.Size = new Size(862, 64);
            button1.TabIndex = 3;
            button1.Text = "SEND";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DimGray;
            label1.Font = new Font("Simplified Arabic Fixed", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Chartreuse;
            label1.Location = new Point(855, 128);
            label1.Name = "label1";
            label1.Size = new Size(431, 84);
            label1.TabIndex = 4;
            label1.Text = "Email Bot";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Simplified Arabic Fixed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Chartreuse;
            label2.Location = new Point(627, 223);
            label2.Name = "label2";
            label2.Size = new Size(157, 44);
            label2.TabIndex = 5;
            label2.Text = "Emails";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Simplified Arabic Fixed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Chartreuse;
            label3.Location = new Point(626, 528);
            label3.Name = "label3";
            label3.Size = new Size(203, 44);
            label3.TabIndex = 6;
            label3.Text = "Subjects";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Simplified Arabic Fixed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Chartreuse;
            label4.Location = new Point(627, 654);
            label4.Name = "label4";
            label4.Size = new Size(111, 44);
            label4.TabIndex = 7;
            label4.Text = "Body";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1303, 1115);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
