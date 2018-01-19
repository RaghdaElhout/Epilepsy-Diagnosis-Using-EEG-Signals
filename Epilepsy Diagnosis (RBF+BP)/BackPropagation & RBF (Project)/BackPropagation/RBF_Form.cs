using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackPropagation
{
    public partial class RBF_Form : Form
    {
        int k;
        List<List<double>> F_N_S_training = new List<List<double>>(), OZ_training = new List<List<double>>();
        List<List<double>> F_N_S_testing = new List<List<double>>(), OZ_testing = new List<List<double>>();
        List<List<double>> kmeantraining = new List<List<double>>();
        List<Cluster> Clusters = new List<Cluster>();
        List<List<double>> AllSamplesFay = new List<List<double>>();
        List<List<double>> TestingFay = new List<List<double>>();
        List<double> weights = new List<double>();

        double learning_rate;
        int epoches;
        double MSE;
        double bias;
        bool ThereIsBias = false;
        double input_count = 20;
        private void setfiles()
        {
            // F_N_S_Training 
            int c = 0;
            for (int i = 0; i < 300; i++)
            {
                F_N_S_training.Add(new List<double>());
                kmeantraining.Add(new List<double>());
                for (int j = 0; j < 20; j++)
                {
                    F_N_S_training[c].Add(Program.Main_Form.F_N_S_Features[c][j]);
                    kmeantraining[c].Add(Program.Main_Form.F_N_S_Features[c][j]);


                }
                c++;
            }
            int seed = 400;
            for (int i = 0; i < 300; i++)
            {
                F_N_S_training.Add(new List<double>());
                kmeantraining.Add(new List<double>());

                for (int j = 0; j < 20; j++)
                {
                    F_N_S_training[c].Add(Program.Main_Form.F_N_S_Features[seed][j]);
                    kmeantraining[c].Add(Program.Main_Form.F_N_S_Features[seed][j]);


                }
                seed++;
                c++;
            }
            seed = 800;
            for (int i = 0; i < 300; i++)
            {
                F_N_S_training.Add(new List<double>());
                kmeantraining.Add(new List<double>());

                for (int j = 0; j < 20; j++)
                {
                    F_N_S_training[c].Add(Program.Main_Form.F_N_S_Features[seed][j]);
                    kmeantraining[c].Add(Program.Main_Form.F_N_S_Features[seed][j]);


                }
                seed++;
                c++;
            }
            int y = c;
            /* *********************************************************************** */
            //F_N_S_testing 
            c = 300;
            int start = 0;
            for (int i = 0; i < 100; i++)
            {
                F_N_S_testing.Add(new List<double>());
                for (int j = 0; j < 20; j++)
                {
                    F_N_S_testing[start].Add(Program.Main_Form.F_N_S_Features[c][j]);


                }
                c++;
                start++;
            }
            c = 700;
            for (int i = 0; i < 100; i++)
            {
                F_N_S_testing.Add(new List<double>());
                for (int j = 0; j < 20; j++)
                {
                    F_N_S_testing[start].Add(Program.Main_Form.F_N_S_Features[c][j]);


                }
                c++;
                start++;
            }
            c = 1100;
            for (int i = 0; i < 100; i++)
            {
                F_N_S_testing.Add(new List<double>());
                for (int j = 0; j < 20; j++)
                {
                    F_N_S_testing[start].Add(Program.Main_Form.F_N_S_Features[c][j]);


                }
                c++;
                start++;
            }

            /*************************************************************/
            // z_o_training 
            c = 0;
            for (int i = 0; i < 300; i++)
            {
                OZ_training.Add(new List<double>());
                kmeantraining.Add(new List<double>());

                for (int j = 0; j < 20; j++)
                {
                    OZ_training[c].Add(Program.Main_Form.O_Z_Features[c][j]);
                    kmeantraining[y].Add(Program.Main_Form.O_Z_Features[c][j]);


                }
                y++;
                c++;
            }
            seed = 400;
            for (int i = 0; i < 300; i++)
            {
                OZ_training.Add(new List<double>());
                kmeantraining.Add(new List<double>());

                for (int j = 0; j < 20; j++)
                {
                    OZ_training[c].Add(Program.Main_Form.O_Z_Features[seed][j]);
                    kmeantraining[y].Add(Program.Main_Form.O_Z_Features[c][j]);


                }
                y++;
                seed++;
                c++;
            }


            /**********************************/
            //oz testing 
            c = 300;
            start = 0;
            for (int i = 0; i < 100; i++)
            {
                OZ_testing.Add(new List<double>());
                for (int j = 0; j < 20; j++)
                {
                    OZ_testing[start].Add(Program.Main_Form.O_Z_Features[c][j]);


                }
                c++;
                start++;
            }
            c = 700;
            for (int i = 0; i < 100; i++)
            {
                OZ_testing.Add(new List<double>());
                for (int j = 0; j < 20; j++)
                {
                    OZ_testing[start].Add(Program.Main_Form.O_Z_Features[c][j]);


                }
                c++;
                start++;
            }
            //MessageBox.Show("hhh");

        }   // set training and testing files 
        public RBF_Form()
        {
            InitializeComponent();
            setfiles();
            //normalizetraining();
            //normalizetesting();
        }

        private void RBF_Form_Load(object sender, EventArgs e)
        {

        }

        private void Add_Hidden_Click(object sender, EventArgs e)
        {
            k = int.Parse(k_txtbox.Text);
            //  normalize();
            KmeanClustering();
            CalculateSigma();

        }
        void KmeanClustering()
        {
            //intialize k clusters.
            for (int i = 0; i < k; i++)
            {
                Cluster c = new Cluster();
                c.centroid = new List<double>();
                c.centroid = kmeantraining[i];
                c.features = new List<List<double>>();
                c.sigma = 0;
                Clusters.Add(c);
            }

            while (true)
            {

                int cluster = 0;
                for (int i = 0; i < kmeantraining.Count; i++)   //iterate on samples
                {
                    double dist = double.MaxValue;
                    for (int j = 0; j < k; j++)     //iterate on clusters
                    {
                        double d = 0;

                        for (int h = 0; h < 20; h++)  //Calculate distance between each sample and cluster centriod
                        {
                            d += (kmeantraining[i][h] - Clusters[j].centroid[h]) * (kmeantraining[i][h] - Clusters[j].centroid[h]);
                        }
                        d = Math.Sqrt(d);
                        if (d < dist)   //update min dist 
                        {
                            dist = d;
                            cluster = j;
                        }
                    }
                    Clusters[cluster].features.Add(kmeantraining[i]); //put sample in cluster with min dist.
                }
                bool SameCentroids = true;
                for (int i = 0; i < k; i++) //iterate on each cluster
                {
                    List<double> newCentriod = new List<double>();
                    for (int h = 0; h < 20; h++)  //Calculate new centriods
                    {
                        newCentriod.Add(0);
                        for (int j = 0; j < Clusters[i].features.Count; j++)
                        {
                            newCentriod[h] += Clusters[i].features[j][h];
                        }
                        newCentriod[h] /= Clusters[i].features.Count;
                    }
                    for (int f = 0; f < 20; f++)  //check if it's same centroid
                    {
                        if (newCentriod[f] != Clusters[i].centroid[f])
                            SameCentroids = false;
                        Clusters[i].centroid[f] = newCentriod[f];
                    }

                }
                if (SameCentroids == true)
                    break;
                for (int i = 0; i < k; i++)
                    Clusters[i].features.Clear();
            }

        }
        void CalculateSigma()
        {
            for (int i = 0; i < Clusters.Count; i++)
            {
                double distSum = 0;
                for (int j = 0; j < Clusters[i].features.Count; j++)
                {
                    double d = 0;

                    for (int m = 0; m < 20; m++)
                    {
                        d += (Clusters[i].features[j][m] - Clusters[i].centroid[m]) * (Clusters[i].features[j][m] - Clusters[i].centroid[m]);
                    }
                    d = Math.Sqrt(d);
                    distSum += d;
                }

                Clusters[i].sigma = (distSum / Clusters[i].features.Count);
            }
        }
        double CalculateLeastMeanError(List<double> errorList)
        {
            double leastMeanSQ = 0;
            foreach (double e in errorList)
            {
                leastMeanSQ += (e * e) / 2;
            }
            leastMeanSQ /= 1500;                 //m=60

            return leastMeanSQ;
        }

        private void RBF_btn_Click(object sender, EventArgs e)
        {
            Training();
            Testing();
        }

        void Training()
        {
            learning_rate = double.Parse(eta.Text.ToString());
            epoches = int.Parse(epocsCount.Text.ToString());
            MSE = double.Parse(MSE_txtbox.Text.ToString());
            Double LeastMeanError = double.MaxValue;
            if (Bias.Checked == true) ThereIsBias = true;
            for (int i = 0; i < kmeantraining.Count; i++)  //gaussian
            {
                List<double> SampleFay = new List<double>();
                for (int j = 0; j < k; j++)
                {
                    double r = 0;
                    for (int h = 0; h < 20; h++)
                    {
                        r += (Clusters[j].centroid[h] - kmeantraining[i][h]) * (Clusters[j].centroid[h] - kmeantraining[i][h]);
                    }
                    double g = Math.Exp(-r / (2 * Clusters[j].sigma * Clusters[j].sigma));
                    SampleFay.Add(g);
                }
                AllSamplesFay.Add(SampleFay);

            }

            int iter = 0;
            double d, y, summation, error;

            List<Random> w = new List<Random>();
            Random B = new Random();
            List<double> errorList = new List<double>();
            for (int i = 0; i < k; i++)
            {
                w.Add(new Random());
                weights.Add(w[i].Next());
            }
            bias = B.Next();
            while (LeastMeanError > MSE && iter <= epoches)
            {
                #region epoch
                d = 0;
                iter++;
                for (int i = 0; i < 900; i++)
                {
                    summation = 0;

                    for (int j = 0; j < k; j++)
                    {
                        summation += (AllSamplesFay[i][j] * weights[j]);

                    }
                    if (ThereIsBias == true) summation += bias;
                    y = summation;         //Linear Activation fn
                    error = d - y;
                    for (int j = 0; j < k; j++)
                    {
                        weights[j] = weights[j] + (learning_rate * error * AllSamplesFay[i][j]);
                    }
                    if (ThereIsBias == true) bias = bias + (error * learning_rate);
                }

                d = 1;
                for (int i = 900; i < 1500; i++)
                {
                    summation = 0;

                    for (int j = 0; j < k; j++)
                    {
                        summation += (AllSamplesFay[i][j] * weights[j]);

                    }
                    if (ThereIsBias == true) summation += bias;
                    y = summation;         //Linear Activation fn
                    error = d - y;
                    for (int j = 0; j < k; j++)
                    {
                        weights[j] = weights[j] + (learning_rate * error * AllSamplesFay[i][j]);
                    }

                }
                #endregion

                #region Calculate error
                d = 0;
                for (int i = 0; i < 900; i++)
                {
                    summation = 0;

                    for (int j = 0; j < k; j++)
                    {
                        summation += (AllSamplesFay[i][j] * weights[j]);

                    }
                    if (ThereIsBias == true) summation += bias;
                    y = summation;         //Linear Activation fn
                    error = d - y;
                    errorList.Add(error);
                }

                d = 1;
                for (int i = 900; i < 1500; i++)
                {
                    summation = 0;

                    for (int j = 0; j < k; j++)
                    {
                        summation += (AllSamplesFay[i][j] * weights[j]);

                    }
                    if (ThereIsBias == true) summation += bias;
                    y = summation;         //Linear Activation fn
                    error = d - y;
                    errorList.Add(error);

                }
                #endregion
                LeastMeanError = CalculateLeastMeanError(errorList);

            }



        }

        private void Classify_Click(object sender, EventArgs e)
        {
            List<double> input_grid = new List<double>();
            for (int i = 0; i < input_count; i++)
            {
                input_grid.Add(double.Parse(dataGridView1[0, i].Value.ToString()));
            }
            classify(input_grid);
        }

        private void classify(List<double> input_grid)
        {
            List<double> SampleFay = new List<double>();

            for (int j = 0; j < k; j++)
            {
                double r = 0;
                for (int h = 0; h < 20; h++)
                {
                    r += (Clusters[j].centroid[h] - input_grid[h]) * (Clusters[j].centroid[h] - input_grid[h]);
                }
                double g = Math.Exp(-r / (2 * Clusters[j].sigma * Clusters[j].sigma));
                SampleFay.Add(g);
            }

            double summation = 0, y = -1;

            for (int j = 0; j < k; j++)
            {
                summation += (SampleFay[j] * weights[j]);

            }
            if (ThereIsBias == true) summation += bias;
            if (summation >= 0.5) y = 1;
            else if (summation < 0.5) y = 0;
            class_txt.Clear();
            class_txt.Text = y.ToString();

        }

        void Testing()
        {
            #region gaussian
            for (int i = 0; i < F_N_S_testing.Count; i++)  //gaussian
            {
                List<double> SampleFay = new List<double>();
                for (int j = 0; j < k; j++)
                {
                    double r = 0;
                    for (int h = 0; h < 20; h++)
                    {
                        r += (Clusters[j].centroid[h] - F_N_S_testing[i][h]) * (Clusters[j].centroid[h] - F_N_S_testing[i][h]);
                    }
                    double g = Math.Exp(-r / (2 * Clusters[j].sigma * Clusters[j].sigma));
                    SampleFay.Add(g);
                }
                TestingFay.Add(SampleFay);

            }
            for (int i = 0; i < OZ_testing.Count; i++)  //gaussian
            {
                List<double> SampleFay = new List<double>();
                for (int j = 0; j < k; j++)
                {
                    double r = 0;
                    for (int h = 0; h < 20; h++)
                    {
                        r += (Clusters[j].centroid[h] - F_N_S_testing[i][h]) * (Clusters[j].centroid[h] - F_N_S_testing[i][h]);
                    }
                    double g = Math.Exp(-r / (2 * Clusters[j].sigma * Clusters[j].sigma));
                    SampleFay.Add(r);
                }
                TestingFay.Add(SampleFay);

            }
            #endregion
            double summation = 0;
            double y = 1, d;
            d = 0;
            double accuracy = 0;
            double[,] confusionMatrix = new double[2, 2];
            confusionMatrix[0, 0] = 0;
            confusionMatrix[0, 1] = 0;
            confusionMatrix[1, 0] = 0;
            confusionMatrix[1, 1] = 0;
            for (int i = 0; i < 300; i++)
            {
                summation = 0;

                for (int j = 0; j < k; j++)
                {
                    summation += (TestingFay[i][j] * weights[j]);

                }
                if (ThereIsBias == true) summation += bias;
                if (summation >= 0.5) y = 1;
                else if (summation < 0.5) y = 0;

                if (y == d) accuracy++;

                if (y == d && d == 0) confusionMatrix[0, 0]++;
                else if (y != d && d == 0) confusionMatrix[0, 1]++;

               
            }
            d = 1;
            for (int i = 300; i < 500; i++)
            {
                summation = 0;

                for (int j = 0; j < k; j++)
                {
                    summation += (TestingFay[i][j] * weights[j]);

                }
                if (ThereIsBias == true) summation += bias;
                if (summation >= 0.5) y = 1;
                else if (summation < 0.5) y = 0;

                if (y == d) accuracy++;

               

                if (y != d && d == 0) confusionMatrix[1, 0]++;
                else if (y == d && d == 0) confusionMatrix[1, 1]++;
            }
            accuracy /= 500;
            accuracy *= 100;

            AccuracyText.Clear();
            AccuracyText.Text = accuracy.ToString();

            Confusion_txt.Clear();
            Confusion_txt.AppendText(confusionMatrix[0, 0].ToString() + "  " + confusionMatrix[0, 1].ToString() + "\r\n" + confusionMatrix[1, 0].ToString() + "  " + confusionMatrix[1, 1].ToString());

        }
        //private void normalizetraining()
        //{


        //    int c = kmeantraining.Count();
        //    for (int i = 0; i < 20; i++)
        //    {
        //        List<double> temp = new List<double>();
        //        for (int j = 0; j < c; j++)
        //        {
        //            temp.Add(kmeantraining[j][i]);
        //        }
        //        temp.Sort();
        //        double min = temp[0];
        //        double max = temp[c - 1];
        //        for (int j = 0; j < c; j++)
        //        {
        //            kmeantraining[j][i] = (kmeantraining[j][i] - min) / (max - min);
        //        }
        //    }

        //}
        //private void normalizetesting()
        //{


        //    int c = F_N_S_testing.Count();
        //    for (int i = 0; i < 20; i++)
        //    {
        //        List<double> temp = new List<double>();
        //        for (int j = 0; j < c; j++)
        //        {
        //            temp.Add(F_N_S_testing[j][i]);
        //        }
        //        temp.Sort();
        //        double min = temp[0];
        //        double max = temp[c - 1];
        //        for (int j = 0; j < c; j++)
        //        {
        //            F_N_S_testing[j][i] = (F_N_S_testing[j][i] - min) / (max - min);
        //        }
        //    }
        //    int d = OZ_testing.Count();
        //    for (int i = 0; i < 20; i++)
        //    {
        //        List<double> temp = new List<double>();
        //        for (int j = 0; j < d; j++)
        //        {
        //            temp.Add(OZ_testing[j][i]);
        //        }
        //        temp.Sort();
        //        double min = temp[0];
        //        double max = temp[d - 1];
        //        for (int j = 0; j < d; j++)
        //        {
        //            OZ_testing[j][i] = (OZ_testing[j][i] - min) / (max - min);
        //        }
        //    }

        //}

    }
}
