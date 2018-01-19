using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace BackPropagation
{
    public partial class BackpropagationForm : Form
    {
        public BackpropagationForm()
        {
            InitializeComponent();
        }
        const int classes = 5;
        public const int input_count = 20;
        const int output_count = 1;
        bool ep = false, cross_validation = false, MSE = false;
        List<Layer> Bp = new List<Layer>();
        //string[] str;

        int epoches;
        bool bias;
        bool HyperBolic = false;
        double A;

        string Data = "";

        private void BackP_Click(object sender, EventArgs e)
        {
            AccuracyText.Text = "";
            Confusion_txt.Text = "";
            BackPropagationTraining();
            BackPropagationTesting();
        }
        private void BackpropagationForm_Load(object sender, EventArgs e)
        {
        }



        private void Add_Hidden_Click(object sender, EventArgs e)
        {
            int Rows = Hidden.Rows.Count - 1;

            Bp = new List<Layer>();
            Layer t = new Layer(input_count);
            Bp.Add(t);
            for (int i = 0; i < Rows; i++)
            {
                Layer T = new Layer(int.Parse(Hidden[0, i].Value.ToString()));
                Bp.Add(T);
            }
            Layer tt = new Layer(output_count);
            Bp.Add(tt);
        }
        private void BackPropagationTraining()
        {
            if (Hyper.Checked)
            {
                HyperBolic = true;
            }
            else
            {
                HyperBolic = false;
            }
            epoches = int.Parse(epocsCount.Text);
            Ran();
            if (cross_validation == true)
            {
                double error = 0.0, cross_error = 0.0, previous_error;
                int run_cross = 0;
                for (int i = 0; i < epoches; i++)
                {
                    error = 0.0;
                    for (int j = 0; j < 240; j++) // F
                    {
                        for (int feature = 0; feature < input_count; feature++)
                        {
                            Bp[0].layer[feature].Yi = Program.Main_Form.F_N_S_Features[j][feature];
                        }
                        FeedForward(1);
                        error += (Bp[Bp.Count - 1].layer[0].Segmai * Bp[Bp.Count - 1].layer[0].Segmai);
                        BackForward();
                        Forward();
                    }
                    for (int j = 400; j < 640; j++)
                    {
                        for (int feature = 0; feature < input_count; feature++)
                        {
                            Bp[0].layer[feature].Yi = Program.Main_Form.F_N_S_Features[j][feature];
                        }
                        FeedForward(1);
                        error += (Bp[Bp.Count - 1].layer[0].Segmai * Bp[Bp.Count - 1].layer[0].Segmai);
                        BackForward();
                        Forward();
                    }
                    for (int j = 800; j < 1040; j++)
                    {
                        for (int feature = 0; feature < input_count; feature++)
                        {
                            Bp[0].layer[feature].Yi = Program.Main_Form.F_N_S_Features[j][feature];
                        }
                        FeedForward(1);
                        error += (Bp[Bp.Count - 1].layer[0].Segmai * Bp[Bp.Count - 1].layer[0].Segmai);
                        BackForward();
                        Forward();
                    }
                    for (int j = 0; j < 240; j++)
                    {
                        for (int feature = 0; feature < input_count; feature++)
                        {
                            Bp[0].layer[feature].Yi = Program.Main_Form.O_Z_Features[j][feature];
                        }
                        FeedForward(2);
                        error += (Bp[Bp.Count - 1].layer[0].Segmai * Bp[Bp.Count - 1].layer[0].Segmai);
                        BackForward();
                        Forward();
                    }
                    for (int j = 400; j < 640; j++)
                    {
                        for (int feature = 0; feature < input_count; feature++)
                        {
                            Bp[0].layer[feature].Yi = Program.Main_Form.O_Z_Features[j][feature];
                        }
                        FeedForward(2);
                        error += (Bp[Bp.Count - 1].layer[0].Segmai * Bp[Bp.Count - 1].layer[0].Segmai);
                        BackForward();
                        Forward();
                    }
                    error /= 1500.0;
                    error *= 0.5;
                    if (MSE == true && error <= double.Parse(MSE_txt.Text))
                    {
                        break;
                    }
                    run_cross++;
                    if (run_cross >= 50 && (run_cross % 50) == 0)
                    {
                        for (int j = 240; j < 300; j++) // F
                        {
                            for (int feature = 0; feature < input_count; feature++)
                            {
                                Bp[0].layer[feature].Yi = Program.Main_Form.F_N_S_Features[j][feature];
                            }
                            FeedForwardTesting();
                            cross_error += (Bp[Bp.Count - 1].layer[0].Segmai);
                        }
                        for (int j = 640; j < 700; j++) // S
                        {
                            for (int feature = 0; feature < input_count; feature++)
                            {
                                Bp[0].layer[feature].Yi = Program.Main_Form.F_N_S_Features[j][feature];
                            }
                            FeedForwardTesting();
                            cross_error += (Bp[Bp.Count - 1].layer[0].Segmai);
                        }
                        for (int j = 1040; j < 1100; j++)// N
                        {
                            for (int feature = 0; feature < input_count; feature++)
                            {
                                Bp[0].layer[feature].Yi = Program.Main_Form.F_N_S_Features[j][feature];
                            }
                            FeedForwardTesting();
                            cross_error += (Bp[Bp.Count - 1].layer[0].Segmai);
                        }
                        for (int j = 240; j < 300; j++)//O ******************************************************
                        {
                            for (int feature = 0; feature < input_count; feature++)
                            {
                                Bp[0].layer[feature].Yi = Program.Main_Form.O_Z_Features[j][feature];
                            }
                            FeedForwardTesting();
                            cross_error += (Bp[Bp.Count - 1].layer[0].Segmai);
                        }
                        for (int j = 640; j < 700; j++)//Z
                        {
                            for (int feature = 0; feature < input_count; feature++)
                            {
                                Bp[0].layer[feature].Yi = Program.Main_Form.O_Z_Features[j][feature];
                            }
                            FeedForwardTesting();
                            cross_error += (Bp[Bp.Count - 1].layer[0].Segmai);
                        }
                        cross_error /= 300.0;
                        previous_error = double.MaxValue;
                        if (cross_error > previous_error && run_cross > 50) break;
                        previous_error = cross_error;
                    }

                }
            }
            else
            {
                double error = 0.0;
                for (int i = 0; i < epoches; i++)
                {
                    error = 0.0;
                    for (int j = 0; j < 300; j++) // F
                    {
                        for (int feature = 0; feature < input_count; feature++)
                        {
                            Bp[0].layer[feature].Yi = Program.Main_Form.F_N_S_Features[j][feature];
                        }
                        FeedForward(1);
                        error += (Bp[Bp.Count - 1].layer[0].Segmai * Bp[Bp.Count - 1].layer[0].Segmai);
                        BackForward();
                        Forward();
                    }
                    for (int j = 400; j < 700; j++)
                    {
                        for (int feature = 0; feature < input_count; feature++)
                        {
                            Bp[0].layer[feature].Yi = Program.Main_Form.F_N_S_Features[j][feature];
                        }
                        FeedForward(1);
                        error += (Bp[Bp.Count - 1].layer[0].Segmai * Bp[Bp.Count - 1].layer[0].Segmai);
                        BackForward();
                        Forward();
                    }
                    for (int j = 800; j < 1100; j++)
                    {
                        for (int feature = 0; feature < input_count; feature++)
                        {
                            Bp[0].layer[feature].Yi = Program.Main_Form.F_N_S_Features[j][feature];
                        }
                        FeedForward(1);
                        error += (Bp[Bp.Count - 1].layer[0].Segmai * Bp[Bp.Count - 1].layer[0].Segmai);
                        BackForward();
                        Forward();
                    }
                    for (int j = 0; j < 300; j++)
                    {
                        for (int feature = 0; feature < input_count; feature++)
                        {
                            Bp[0].layer[feature].Yi = Program.Main_Form.O_Z_Features[j][feature];
                        }
                        FeedForward(2);
                        error += (Bp[Bp.Count - 1].layer[0].Segmai * Bp[Bp.Count - 1].layer[0].Segmai);
                        BackForward();
                        Forward();
                    }
                    for (int j = 400; j < 700; j++)
                    {
                        for (int feature = 0; feature < input_count; feature++)
                        {
                            Bp[0].layer[feature].Yi = Program.Main_Form.O_Z_Features[j][feature];
                        }
                        FeedForward(2);
                        error += (Bp[Bp.Count - 1].layer[0].Segmai * Bp[Bp.Count - 1].layer[0].Segmai);
                        BackForward();
                        Forward();
                    }

                    ////
                    error /= 1500.0;
                    error *= 0.5;
                    if (MSE == true && error <= double.Parse(MSE_txt.Text))
                    {
                        break;
                    }
                }
            }
        }
        private void BackPropagationTesting() //************************////
        {
            double[,] confusionMatrix = new double[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    confusionMatrix[i, j] = 0;
                }

            }
            double accuracy = 0;
            int class_num = 0;
            for (int i = 300; i < 400; i++) //  F
            {
                for (int feature = 0; feature < input_count; feature++)
                {
                    Bp[0].layer[feature].Yi = Program.Main_Form.F_N_S_Features[i][feature];
                }
                class_num = FeedForwardTesting();
                if (class_num == 1)
                {
                    confusionMatrix[0, 0]++;
                }
                else
                {
                    confusionMatrix[0, 1]++;
                }

            }
            for (int i = 1100; i < 1200; i++) // 0 1 0 0 0 (N)
            {
                for (int feature = 0; feature < input_count; feature++)
                {
                    Bp[0].layer[feature].Yi = Program.Main_Form.F_N_S_Features[i][feature];
                }
                class_num = FeedForwardTesting();
                if (class_num == 1)
                {
                    confusionMatrix[0, 0]++;
                }
                else
                {
                    confusionMatrix[0, 1]++;
                }

            }
            for (int i = 700; i < 800; i++) // 0 0 1 0 0 (S)
            {
                for (int feature = 0; feature < input_count; feature++)
                {
                    Bp[0].layer[feature].Yi = Program.Main_Form.F_N_S_Features[i][feature];
                }
                class_num = FeedForwardTesting();
                if (class_num == 1)
                {
                    confusionMatrix[0, 0]++;
                }
                else
                {
                    confusionMatrix[0, 1]++;
                }

            }
            for (int i = 300; i < 400; i++) // 0 0 1 0 0 (O)
            {
                for (int feature = 0; feature < input_count; feature++)
                {
                    Bp[0].layer[feature].Yi = Program.Main_Form.O_Z_Features[i][feature];
                }
                class_num = FeedForwardTesting();
                if (class_num == 1)
                {
                    confusionMatrix[1, 0]++;
                }
                else
                {
                    confusionMatrix[1, 1]++;
                }
            }
            for (int i = 700; i < 800; i++) // 0 0 1 0 0 (Z)
            {
                for (int feature = 0; feature < input_count; feature++)
                {
                    Bp[0].layer[feature].Yi = Program.Main_Form.O_Z_Features[i][feature];
                }
                class_num = FeedForwardTesting();
                if (class_num == 1)
                {
                    confusionMatrix[1, 0]++;
                }
                else
                {
                    confusionMatrix[1, 1]++;
                }
            }
            accuracy = confusionMatrix[0, 0] + confusionMatrix[1, 1];
            accuracy /= 500;
            accuracy *= 100;
            AccuracyText.Text = accuracy.ToString();
            Confusion_txt.AppendText(confusionMatrix[0, 0].ToString() + "  " + confusionMatrix[0, 1].ToString() + "\r\n" + confusionMatrix[1, 0].ToString() + "  " + confusionMatrix[1, 1].ToString() + "\r\n");
        }
        private double DHyperBolicFunction(double v, double a)
        {
            return (Math.Exp(-a * v) / (Math.Pow((1 + Math.Exp(-a * v)), 2)));
        }
        private double HyperBolicFunction(double v, double a)
        {
            return (1.0 - Math.Exp(-a * v)) / (1.0 + Math.Exp(-a * v));
        }
        private double DSigmoid(double y)
        {
            return (y * (1 - y));
        }
        private double Sigmoid(double v, double a)
        {
            return (1.0 / (1.0 + Math.Exp(-a * v)));
        }
        private double ActivationFunction(bool D, double v, double a, double y)
        {
            double res = 0.0;
            if (D)
            {
                if (Hyper.Checked)
                {
                    res = DHyperBolicFunction(v, a);
                }
                else
                {
                    res = DSigmoid(y);
                }
            }
            else
            {
                if (Hyper.Checked)
                {
                    res = HyperBolicFunction(v, a);
                }
                else
                {
                    res = Sigmoid(v, a);
                }
            }
            return res;
        }
        private int FeedForwardTesting()
        {
            int count = Bp.Count;
            int N = 0;
            double summation = 0;
            for (int i = 1; i < count; i++) // #layers
            {
                int layerCount = Bp[i - 1].layer.Count;
                N = 0;
                for (int j = 0; j < Bp[i].layer.Count; j++) // #neourns in layer i
                {
                    summation = 0;
                    List<double> RandomW = Bp[i].layer[j].W_inner;
                    for (int k = 0; k < layerCount; k++) // #neourns in layer i-1
                    {
                        summation += RandomW[k] * Bp[i - 1].layer[k].Yi;
                    }
                    if (bias)
                    {
                        summation += RandomW[RandomW.Count - 1];
                    }
                    Bp[i].layer[j].Vi = summation;
                    Bp[i].layer[j].Yi = ActivationFunction(false, summation, Bp[i].layer[j].A, 0);
                }
            }
            int d;
            if (Bp[Bp.Count - 1].layer[0].Yi >= 0.5) // first class
            {
                d = 1;
            }
            else //second class
            {
                d = 0;
            }
            Bp[Bp.Count - 1].layer[0].Segmai = (d - Bp[Bp.Count - 1].layer[0].Yi) * ActivationFunction(true, Bp[Bp.Count - 1].layer[0].Vi, A, Bp[Bp.Count - 1].layer[0].Yi);
            return d;
        }
        private void Ran()
        {
            Random temp = new Random();
            int count = Bp.Count;
            for (int i = 1; i < count; i++) // #layers
            {
                int layerCount = Bp[i - 1].layer.Count;

                for (int j = 0; j < Bp[i].layer.Count; j++) // #neourns in layer i
                {
                    List<double> RandomW = new List<double>();
                    for (int k = 0; k < layerCount; k++) // #neourns in layer i-1
                    {
                        RandomW.Add(temp.NextDouble() / 1000);
                        Bp[i].layer[j].W_inner.Add(RandomW[k]);
                    }
                    if (bias)
                    {
                        RandomW.Add(temp.NextDouble() / 1000);
                        Bp[i].layer[j].W_inner.Add(RandomW[RandomW.Count - 1]);
                    }
                }
            }
        }
        private void FeedForward(int index)
        {
            int count = Bp.Count;
            double summation = 0;
            int N = 0;
            for (int i = 1; i < count; i++) // #layers
            {
                int layerCount = Bp[i - 1].layer.Count;
                N = 0;
                for (int j = 0; j < Bp[i].layer.Count; j++) // #neourns in layer i
                {
                    summation = 0;
                    List<double> RandomW = Bp[i].layer[j].W_inner;
                    for (int k = 0; k < layerCount; k++) // #neourns in layer i-1 && #weight of every neourn in layer i
                    {
                        //RandomW.Add(temp.NextDouble());
                        //Bp[i].layer[j].W_inner.Add(RandomW[k]);
                        summation += RandomW[k] * Bp[i - 1].layer[k].Yi;
                    }
                    if (bias)
                    {
                        //RandomW.Add(temp.NextDouble());
                        //Bp[i].layer[j].W_inner.Add(RandomW[RandomW.Count - 1]);
                        summation += RandomW[RandomW.Count - 1];
                    }
                    A = 0.001;
                    Bp[i].layer[j].Vi = summation;
                    Bp[i].layer[j].Yi = ActivationFunction(false, summation, A, 0);
                    Bp[i].layer[j].A = A;
                }
            }
            int d;
            if (index == 1)
            {
                d = 1;
            }
            else
            {
                d = 0;
            }
            Bp[Bp.Count - 1].layer[0].Segmai = (d - Bp[Bp.Count - 1].layer[0].Yi) * ActivationFunction(true, Bp[Bp.Count - 1].layer[0].Vi, A, Bp[Bp.Count - 1].layer[0].Yi);
        }
        private void BackForward()
        {
            double summation = 0;
            for (int i = Bp.Count - 1; i >= 1; i--) // .layers
            {
                for (int j = 0; j < Bp[i - 1].layer.Count; j++)//#neourns of previous.layer
                {
                    summation = 0;
                    for (int k = 0; k < Bp[i].layer.Count; k++)
                    {
                        summation += (Bp[i].layer[k].Segmai * Bp[i].layer[k].W_inner[j]);
                    }
                    Bp[i - 1].layer[j].Segmai = summation * ActivationFunction(true, Bp[i - 1].layer[j].Vi, Bp[i - 1].layer[j].A, Bp[i - 1].layer[j].Vi);
                }
            }
        }
        private void Forward()
        {
            for (int i = 1; i < Bp.Count; i++)
            {
                for (int j = 0; j < Bp[i].layer.Count; j++)
                {
                    for (int k = 0; k < Bp[i].layer[j].W_inner.Count; k++)
                    {
                        Bp[i].layer[j].W_inner[k] += (double.Parse(eta.Text) * Bp[i].layer[j].Segmai * Bp[i].layer[j].Yi);
                    }
                }
            }
        }

        private void classify(List<double> INPUT_FEATURES)
        {
            for (int i = 0; i < input_count; i++)
            {
                Bp[0].layer[i].Yi = INPUT_FEATURES[i];
            }
            Ran();
            int d = FeedForwardTesting();
            if (d == 1)
            {
                class_txt.Text = "F N S interictal & ictal people";
            }
            else
            {
                class_txt.Text = "O Z relaxed and awake state eye movements";
            }
        }
        private void Classify_Click(object sender, EventArgs e)
        {
            List<double> input_grid = new List<double>();
            for (int i = 0; i < input_count; i++)
            {
                input_grid.Add(double.Parse(input_features_grid[0, i].Value.ToString()));
            }
            classify(input_grid);
        }

        private void Bias_CheckedChanged(object sender, EventArgs e)
        {
            if (Bias.Checked == true) bias = true;
            else if (Bias.Checked == false) bias = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cross_check.Checked == true) cross_validation = true;
            else if (cross_check.Checked == false) cross_validation = false;
        }

        private void MSE_check_CheckedChanged(object sender, EventArgs e)
        {
            if (MSE_check.Checked == true)
            {
                MSE = true;
            }
            else if (MSE_check.Checked == false)
            {
                MSE = false;
            }
        }

        //****************************************************************************************************///

        private void class_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Hidden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void eta_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void epocsCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AccuracyText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void Sigmoid_radio_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}
