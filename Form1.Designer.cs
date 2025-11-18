namespace BPNN_model
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
            textBox4 = new TextBox();
            textBox7 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            trainStatus = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(171, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 34);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(171, 187);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 34);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(171, 242);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 34);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F);
            textBox4.Location = new Point(171, 299);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(155, 34);
            textBox4.TabIndex = 3;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 12F);
            textBox7.Location = new Point(409, 219);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(155, 34);
            textBox7.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(171, 392);
            button1.Name = "button1";
            button1.Size = new Size(115, 37);
            button1.TabIndex = 7;
            button1.Text = "Create BPNN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(321, 392);
            button2.Name = "button2";
            button2.Size = new Size(115, 37);
            button2.TabIndex = 8;
            button2.Text = "Train BPNN";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(111, 37);
            label1.Name = "label1";
            label1.Size = new Size(547, 31);
            label1.TabIndex = 9;
            label1.Text = "Backpropagation Neural Network - AND Operation";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.Location = new Point(465, 392);
            button3.Name = "button3";
            button3.Size = new Size(115, 37);
            button3.TabIndex = 10;
            button3.Text = "Test BPNN";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // trainStatus
            // 
            trainStatus.AutoSize = true;
            trainStatus.Location = new Point(26, 460);
            trainStatus.Name = "trainStatus";
            trainStatus.Size = new Size(0, 20);
            trainStatus.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 493);
            Controls.Add(trainStatus);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(textBox4);
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
        private TextBox textBox4;
        private TextBox textBox7;
        private Button button1;
        private Button button2;
        private Label label1;
        private Button button3;
        private Label trainStatus;
    }
}
