using System.Collections.Generic;
using Backprop;

namespace BPNN_model
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        bool hasTrained = false;

        public Form1()
        {
            InitializeComponent();
            trainButton.Enabled = false;
            textButton.Enabled = false;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            nn = new NeuralNet(4, 180, 1);
            trainStatus.Text = "Neural Network Initializes";
            trainButton.Enabled = true;
        }

        private void trainButton_Click(object sender, EventArgs e)
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

        private void testButton_Click(object sender, EventArgs e)
        {
            string input0 = neuronInput0.Text;
            string input1 = neuronInput1.Text;
            string input2 = neuronInput2.Text;
            string input3 = neuronInput3.Text;

            if (input0 == null || input1 == null || input2 == null || input3 == null)
            {
                trainStatus.Text = "Please enter all four inputs.";
                return;
            }

            if (!double.TryParse(input0, out _) || !double.TryParse(input1, out _) ||
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

        private void button1_Click(object sender, EventArgs e)
        {
            int[] results = new int[16];
            
            for (int j = 0; j < 1000; j++)
            {
                nn = new NeuralNet(4, 220, 1);
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

                for (double a = 0.0; a <= 1; a+=1)
                {

                    for (double b = 0.0; b <= 1; b+=1)
                    {

                        for (double c = 0.0; c <= 1; c+=1)
                        {

                            for (double d = 0.0; d <= 1; d+=1)
                            {
                                nn.setInputs(0, a);
                                nn.setInputs(1, b);
                                nn.setInputs(2, c);
                                nn.setInputs(3, d);
                                nn.run();
                                double output = nn.getOutputData(0);
                                int roundedOutput = (output >= 0.5) ? 1 : 0;
                                int index = (int)(a * 8 + b * 4 + c * 2 + d * 1);

                                if (a == 1.0 && b == 1.0 && c == 1.0 && d == 1.0)
                                {
                                    if (roundedOutput == 1)
                                    {
                                        results[index]++;
                                    }
                                }
                                else
                                {
                                    if (roundedOutput == 0)
                                    {
                                        results[index]++;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            trainStatus.Text = "";

            foreach(var result in results)
            {
                trainStatus.Text += result + " ";
            }
        }
    }
}
