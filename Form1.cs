using System.Collections.Generic;
using Backprop;

namespace BPNN_model
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        bool hasTrained = false;

        //[
        //    [no. neurons, epochs, true result (1), false result (0)]
        //]

        List<double[]> results = new List<double[]>();

        public Form1()
        {
            InitializeComponent();
            trainButton.Enabled = false;
            textButton.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nn = new NeuralNet(4, 200, 1);
            trainStatus.Text = "Neural Network Initializes";
            trainButton.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int epochs = 150;

            trainStatus.Text = "Training...";

            for (int i = 0; i < epochs; i++)
            {
                // 0 0 0 0 = 0
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // 0 0 0 1 = 0
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // 0 0 1 0 = 0
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //0 0 1 1 = 0
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //0 1 0 0 = 0
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //0 1 0 1 = 0
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //0 1 1 0 = 0
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //0 1 1 1 = 0
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //1 0 0 0 = 0
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //1 0 0 1 = 0
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //1 0 1 0 = 0
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //1 0 1 1 = 0
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //1 1 0 0 = 0
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //1 1 0 1 = 0
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //1 1 1 0 = 0
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //1 1 1 1 = 1
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();
            }

            trainStatus.Text += " Done";
            textButton.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string input0 = neuronInput0.Text;
            string input1 = neuronInput1.Text;
            string input2 = neuronInput2.Text;
            string input3 = neuronInput3.Text;

            if(input0 == null || input1 == null || input2 == null || input3 == null)
            {
                trainStatus.Text = "Please enter all four inputs.";
                return;
            }

            if(!double.TryParse(input0, out _) || !double.TryParse(input1, out _) ||
                !double.TryParse(input2, out _) || !double.TryParse(input3, out _))
            {
                trainStatus.Text = "Please enter valid numeric inputs.";
                return;
            }

            nn.setInputs(0, Convert.ToDouble(neuronInput0.Text));
            nn.setInputs(1, Convert.ToDouble(neuronInput1.Text));
            nn.setInputs(2, Convert.ToDouble(neuronInput2.Text));
            nn.setInputs(3, Convert.ToDouble(neuronInput3.Text));
            nn.run();
            neuronOutput.Text = "" + nn.getOutputData(0);
        }
    }
}
