using Backprop;

namespace BPNN_model
{
    public partial class Form1 : Form
    {
        NeuralNet nn;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nn = new NeuralNet(4, 128, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int epochs = 30;

            trainStatus.Text = "Training...";

            for (int i = 0; i < epochs; i++)
            {
                // 0 0 0 0 = 0
                nn.setInputs(0, 0);
                nn.setInputs(1, 0);
                nn.setInputs(2, 0);
                nn.setInputs(3, 0);
                nn.setDesiredOutput(0, 0);
                nn.learn();

                // 0 0 0 1 = 0
                nn.setInputs(0, 0);
                nn.setInputs(1, 0);
                nn.setInputs(2, 0);
                nn.setInputs(3, 1);
                nn.setDesiredOutput(0, 0);
                nn.learn();

                // 0 0 1 0 = 0
                nn.setInputs(0, 0);
                nn.setInputs(1, 0);
                nn.setInputs(2, 1);
                nn.setInputs(3, 0);
                nn.setDesiredOutput(0, 0);
                nn.learn();

                //0 0 1 1 = 0
                nn.setInputs(0, 0);
                nn.setInputs(1, 0);
                nn.setInputs(2, 1);
                nn.setInputs(3, 1);
                nn.setDesiredOutput(0, 0);
                nn.learn();

                //0 1 0 0 = 0
                nn.setInputs(0, 0);
                nn.setInputs(1, 1);
                nn.setInputs(2, 0);
                nn.setInputs(3, 0);
                nn.setDesiredOutput(0, 0);
                nn.learn();

                //0 1 0 1 = 0
                nn.setInputs(0, 0);
                nn.setInputs(1, 1);
                nn.setInputs(2, 0);
                nn.setInputs(3, 1);
                nn.setDesiredOutput(0, 0);
                nn.learn();

                //0 1 1 0 = 0
                nn.setInputs(0, 0);
                nn.setInputs(1, 1);
                nn.setInputs(2, 1);
                nn.setInputs(3, 0);
                nn.setDesiredOutput(0, 0);
                nn.learn();

                //0 1 1 1 = 0
                nn.setInputs(0, 0);
                nn.setInputs(1, 1);
                nn.setInputs(2, 1);
                nn.setInputs(3, 1);
                nn.setDesiredOutput(0, 0);
                nn.learn();

                //1 0 0 0 = 0
                nn.setInputs(0, 1);
                nn.setInputs(1, 0);
                nn.setInputs(2, 0);
                nn.setInputs(3, 0);
                nn.setDesiredOutput(0, 0);
                nn.learn();

                //1 0 0 1 = 0
                nn.setInputs(0, 1);
                nn.setInputs(1, 0);
                nn.setInputs(2, 0);
                nn.setInputs(3, 1);
                nn.setDesiredOutput(0, 0);
                nn.learn();

                //1 0 1 0 = 0
                nn.setInputs(0, 1);
                nn.setInputs(1, 0);
                nn.setInputs(2, 1);
                nn.setInputs(3, 0);
                nn.setDesiredOutput(0, 0);
                nn.learn();

                //1 0 1 1 = 0
                nn.setInputs(0, 1);
                nn.setInputs(1, 0);
                nn.setInputs(2, 1);
                nn.setInputs(3, 1);
                nn.setDesiredOutput(0, 0);
                nn.learn();

                //1 1 0 0 = 0
                nn.setInputs(0, 1);
                nn.setInputs(1, 1);
                nn.setInputs(2, 0);
                nn.setInputs(3, 0);
                nn.setDesiredOutput(0, 0);
                nn.learn();

                //1 1 0 1 = 0
                nn.setInputs(0, 1);
                nn.setInputs(1, 1);
                nn.setInputs(2, 0);
                nn.setInputs(3, 1);
                nn.setDesiredOutput(0, 0);
                nn.learn();

                //1 1 1 0 = 0
                nn.setInputs(0, 1);
                nn.setInputs(1, 1);
                nn.setInputs(2, 1);
                nn.setInputs(3, 0);
                nn.setDesiredOutput(0, 0);
                nn.learn();

                //1 1 1 1 = 1
                nn.setInputs(0, 1);
                nn.setInputs(1, 1);
                nn.setInputs(2, 1);
                nn.setInputs(3, 1);
                nn.setDesiredOutput(0, 1);
                nn.learn();
            }

            trainStatus.Text += " Done";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nn.setInputs(0, Convert.ToDouble(textBox1.Text));
            nn.setInputs(1, Convert.ToDouble(textBox2.Text));
            nn.setInputs(2, Convert.ToDouble(textBox3.Text));
            nn.setInputs(3, Convert.ToDouble(textBox4.Text));
            nn.run();
            textBox7.Text = "" + nn.getOutputData(0);
        }
    }
}
