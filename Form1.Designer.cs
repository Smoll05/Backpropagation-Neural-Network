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
            neuronInput0 = new TextBox();
            neuronInput1 = new TextBox();
            neuronInput2 = new TextBox();
            neuronInput3 = new TextBox();
            neuronOutput = new TextBox();
            createButton = new Button();
            trainButton = new Button();
            label1 = new Label();
            textButton = new Button();
            trainStatus = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // neuronInput0
            // 
            neuronInput0.BorderStyle = BorderStyle.FixedSingle;
            neuronInput0.Cursor = Cursors.IBeam;
            neuronInput0.Font = new Font("Segoe UI", 12F);
            neuronInput0.Location = new Point(111, 152);
            neuronInput0.Name = "neuronInput0";
            neuronInput0.Size = new Size(115, 34);
            neuronInput0.TabIndex = 0;
            neuronInput0.TextAlign = HorizontalAlignment.Center;
            // 
            // neuronInput1
            // 
            neuronInput1.BorderStyle = BorderStyle.FixedSingle;
            neuronInput1.Cursor = Cursors.IBeam;
            neuronInput1.Font = new Font("Segoe UI", 12F);
            neuronInput1.Location = new Point(111, 208);
            neuronInput1.Name = "neuronInput1";
            neuronInput1.Size = new Size(115, 34);
            neuronInput1.TabIndex = 1;
            neuronInput1.TextAlign = HorizontalAlignment.Center;
            // 
            // neuronInput2
            // 
            neuronInput2.BorderStyle = BorderStyle.FixedSingle;
            neuronInput2.Cursor = Cursors.IBeam;
            neuronInput2.Font = new Font("Segoe UI", 12F);
            neuronInput2.Location = new Point(111, 263);
            neuronInput2.Name = "neuronInput2";
            neuronInput2.Size = new Size(115, 34);
            neuronInput2.TabIndex = 2;
            neuronInput2.TextAlign = HorizontalAlignment.Center;
            // 
            // neuronInput3
            // 
            neuronInput3.BorderStyle = BorderStyle.FixedSingle;
            neuronInput3.Cursor = Cursors.IBeam;
            neuronInput3.Font = new Font("Segoe UI", 12F);
            neuronInput3.Location = new Point(111, 320);
            neuronInput3.Name = "neuronInput3";
            neuronInput3.Size = new Size(115, 34);
            neuronInput3.TabIndex = 3;
            neuronInput3.TextAlign = HorizontalAlignment.Center;
            // 
            // neuronOutput
            // 
            neuronOutput.BorderStyle = BorderStyle.FixedSingle;
            neuronOutput.Font = new Font("Segoe UI", 12F);
            neuronOutput.Location = new Point(552, 237);
            neuronOutput.Name = "neuronOutput";
            neuronOutput.ReadOnly = true;
            neuronOutput.Size = new Size(115, 34);
            neuronOutput.TabIndex = 6;
            neuronOutput.TextAlign = HorizontalAlignment.Center;
            // 
            // createButton
            // 
            createButton.Location = new Point(120, 392);
            createButton.Name = "createButton";
            createButton.Size = new Size(115, 37);
            createButton.TabIndex = 7;
            createButton.Text = "Create BPNN";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // trainButton
            // 
            trainButton.Location = new Point(333, 392);
            trainButton.Name = "trainButton";
            trainButton.Size = new Size(115, 37);
            trainButton.TabIndex = 8;
            trainButton.Text = "Train BPNN";
            trainButton.UseVisualStyleBackColor = true;
            trainButton.Click += trainButton_Click;
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
            // textButton
            // 
            textButton.Location = new Point(543, 392);
            textButton.Name = "textButton";
            textButton.Size = new Size(115, 37);
            textButton.TabIndex = 10;
            textButton.Text = "Test BPNN";
            textButton.UseVisualStyleBackColor = true;
            textButton.Click += testButton_Click;
            // 
            // trainStatus
            // 
            trainStatus.AutoSize = true;
            trainStatus.Location = new Point(26, 460);
            trainStatus.Name = "trainStatus";
            trainStatus.Size = new Size(0, 20);
            trainStatus.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(120, 104);
            label2.Name = "label2";
            label2.Size = new Size(97, 23);
            label2.TabIndex = 12;
            label2.Text = "Input Layer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(552, 104);
            label3.Name = "label3";
            label3.Size = new Size(111, 23);
            label3.TabIndex = 13;
            label3.Text = "Output Layer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(333, 237);
            label4.Name = "label4";
            label4.Size = new Size(112, 23);
            label4.TabIndex = 14;
            label4.Text = "Hidden Layer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(264, 225);
            label5.Name = "label5";
            label5.Size = new Size(41, 46);
            label5.TabIndex = 15;
            label5.Text = "X";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(477, 225);
            label6.Name = "label6";
            label6.Size = new Size(41, 46);
            label6.TabIndex = 16;
            label6.Text = "X";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(26, 159);
            label7.Name = "label7";
            label7.Size = new Size(65, 23);
            label7.TabIndex = 17;
            label7.Text = "Input 0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(26, 215);
            label8.Name = "label8";
            label8.Size = new Size(63, 23);
            label8.TabIndex = 18;
            label8.Text = "Input 1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(26, 270);
            label9.Name = "label9";
            label9.Size = new Size(65, 23);
            label9.TabIndex = 19;
            label9.Text = "Input 2";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(26, 327);
            label10.Name = "label10";
            label10.Size = new Size(65, 23);
            label10.TabIndex = 20;
            label10.Text = "Input 3";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(688, 244);
            label11.Name = "label11";
            label11.Size = new Size(79, 23);
            label11.TabIndex = 21;
            label11.Text = "Output 0";
            // 
            // button1
            // 
            button1.Location = new Point(647, 336);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 22;
            button1.Text = "Automate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 493);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(trainStatus);
            Controls.Add(textButton);
            Controls.Add(label1);
            Controls.Add(trainButton);
            Controls.Add(createButton);
            Controls.Add(neuronOutput);
            Controls.Add(neuronInput3);
            Controls.Add(neuronInput2);
            Controls.Add(neuronInput1);
            Controls.Add(neuronInput0);
            Name = "Form1";
            Text = "Backpropagation Neural Network";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox neuronInput0;
        private TextBox neuronInput1;
        private TextBox neuronInput2;
        private TextBox neuronInput3;
        private TextBox neuronOutput;
        private Button createButton;
        private Button trainButton;
        private Label label1;
        private Button textButton;
        private Label trainStatus;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button button1;
    }
}
