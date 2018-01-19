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
    public partial class WELCOME : Form
    {
        const int Features = 20;
        public StreamReader myReader;
        public List<List<double>>
            F_N_S_Features = new List<List<double>>(),
            O_Z_Features = new List<List<double>>();
        List<double> avg_f = new List<double>(), avg_o = new List<double>();

        /*
         F [0:399]    Train [0:299]    Test [300:399]
         S [400:799]  Train [400:699]  Test [700:799]
         N [800:1200] Train [800:1099] Test [1100:1199]
         *
         * 
         O [0:399]    Train [0:299]    Test [300:399]
         Z [400:799]  Train [400:699]  Test [700:799]
         */

        public WELCOME()
        {
            InitializeComponent();
        }
        private void normalize()
        {
            int fnscount = F_N_S_Features.Count();
            for (int i = 0; i < fnscount; i++)
            {
                F_N_S_Features[i].Sort();
                double min = F_N_S_Features[i][0];
                double max = F_N_S_Features[i][19];
                for (int j = 0; j < 20; j++)
                {
                    F_N_S_Features[i][j] = (F_N_S_Features[i][j] - min) / (max - min);
                }

            }
            int ozcount = O_Z_Features.Count();
            for (int i = 0; i < ozcount; i++)
            {
                O_Z_Features[i].Sort();
                double min = O_Z_Features[i][0];
                double max = O_Z_Features[i][19];
                for (int j = 0; j < 20; j++)
                {
                    O_Z_Features[i][j] = (O_Z_Features[i][j] - min) / (max - min);
                }

            }
        }
        private void normalize_z_score()
        {
            int fnscount = F_N_S_Features.Count();
            double std = 0.0;
            for (int i = 0; i < fnscount; i++)
            {
                std = 0.0;
                for (int j = 0; j < 20; j++)
                {
                    std += ((F_N_S_Features[i][j] - avg_f[j]) * (F_N_S_Features[i][j] - avg_f[j]));
                }
                std /= 19.0;
                std = Math.Sqrt(std);
                for (int j = 0; j < 20; j++)
                {
                    F_N_S_Features[i][j] = (F_N_S_Features[i][j] - avg_f[j]) / std;
                }
            }
            int ozcount = O_Z_Features.Count();
            for (int i = 0; i < ozcount; i++)
            {
                std = 0.0;
                for (int j = 0; j < 20; j++)
                {
                    std += ((O_Z_Features[i][j] - avg_o[j]) * (O_Z_Features[i][j] - avg_o[j]));
                }
                std /= 19.0;
                std = Math.Sqrt(std);
                for (int j = 0; j < 20; j++)
                {
                    O_Z_Features[i][j] = (O_Z_Features[i][j] - avg_o[j]) / std;
                }
            }
        }
        private void normalize_SULTAN()
        {
            int fnscount = F_N_S_Features.Count();
            List<double> F_N_S_Min = new List<double>(), F_N_S_Max = new List<double>();
            for (int i = 0; i < 20; i++)
            {
                F_N_S_Min.Add(F_N_S_Features[0][i]);
                F_N_S_Max.Add(0);
                for (int j = 0; j < fnscount; j++)
                {
                    if (F_N_S_Features[j][i] < F_N_S_Min[i])
                    {
                        F_N_S_Min[i] = F_N_S_Features[j][i];
                    }
                    if (F_N_S_Features[j][i] > F_N_S_Max[i])
                    {
                        F_N_S_Max[i] = F_N_S_Features[j][i];
                    }
                }
            }
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < fnscount; j++)
                {
                    F_N_S_Features[j][i] = (F_N_S_Features[j][i] - F_N_S_Min[i]) / (F_N_S_Max[i] - F_N_S_Min[i]);
                }
            }
            int ozcount = O_Z_Features.Count();
            List<double> O_Z_Min = new List<double>(), O_Z_Max = new List<double>();
            for (int i = 0; i < 20; i++)
            {
                O_Z_Min.Add(O_Z_Features[0][i]);
                O_Z_Max.Add(0);
                for (int j = 0; j < ozcount; j++)
                {
                    if (O_Z_Features[j][i] < O_Z_Min[i])
                    {
                        O_Z_Min[i] = O_Z_Features[j][i];
                    }
                    if (O_Z_Features[j][i] > O_Z_Max[i])
                    {
                        O_Z_Max[i] = O_Z_Features[j][i];
                    }
                }
            }
        }
        private void loaddata()
        {
            //************************** F ******************//
            myReader = new StreamReader("F.txt");
            int Count = 0;
            string line = "";
            string[] L;
            double sum_row = 0.0;
            for (int c = 0; c < 400; c++)
            {
                sum_row = 0.0;
                line = myReader.ReadLine();
                F_N_S_Features.Add(new List<double>());
                L = line.Split('\t');
                for (int i = 0; i < Features; i++)
                {
                    F_N_S_Features[Count].Add(double.Parse(L[i].ToString()));
                    sum_row += F_N_S_Features[Count][i];
                }
                sum_row /= 20.0;
                avg_f.Add(sum_row);
                Count++;
            }
            myReader.Close();

            //************************** N ******************//
            myReader = new StreamReader("N.txt");
            line = "";
            for (int c = 0; c < 400; c++)
            {
                sum_row = 0.0;
                line = myReader.ReadLine();
                F_N_S_Features.Add(new List<double>());
                L = line.Split('\t');
                for (int i = 0; i < Features; i++)
                {
                    F_N_S_Features[Count].Add(double.Parse(L[i].ToString()));
                    sum_row += F_N_S_Features[Count][i];
                }
                sum_row /= 20.0;
                avg_f.Add(sum_row);
                Count++;
            }
            myReader.Close();
            //************************** S ******************//
            myReader = new StreamReader("S.txt");
            line = "";
            for (int c = 0; c < 400; c++)
            {
                sum_row = 0.0;
                line = myReader.ReadLine();
                F_N_S_Features.Add(new List<double>());
                L = line.Split('\t');
                for (int i = 0; i < Features; i++)
                {
                    F_N_S_Features[Count].Add(double.Parse(L[i].ToString()));
                    sum_row += F_N_S_Features[Count][i];
                }
                sum_row /= 20.0;
                avg_f.Add(sum_row);
                Count++;
            }
            myReader.Close();
            //************************** O ******************//
            myReader = new StreamReader("O.txt");
            Count = 0;
            line = "";
            for (int c = 0; c < 400; c++)
            {
                sum_row = 0.0;
                line = myReader.ReadLine();
                O_Z_Features.Add(new List<double>());
                L = line.Split('\t');
                for (int i = 0; i < Features; i++)
                {
                    O_Z_Features[Count].Add(double.Parse(L[i].ToString()));
                    sum_row += O_Z_Features[Count][i];
                }
                sum_row /= 20.0;
                avg_o.Add(sum_row);
                Count++;
            }
            myReader.Close();

            //************************** Z ******************//
            myReader = new StreamReader("z.txt");
            line = "";
            for (int c = 0; c < 400; c++)
            {
                sum_row = 0.0;
                line = myReader.ReadLine();
                O_Z_Features.Add(new List<double>());
                L = line.Split('\t');
                for (int i = 0; i < Features; i++)
                {
                    O_Z_Features[Count].Add(double.Parse(L[i].ToString()));
                    sum_row += O_Z_Features[Count][i];
                }
                sum_row /= 20.0;
                avg_o.Add(sum_row);
                Count++;
            }
            myReader.Close();
            // normalize();
            // normalize_SULTAN();
            normalize_z_score();
            /*double Min1 = F1.Min();
            double Min2 = F2.Min();
            double Min3 = F3.Min();
            double Min4 = F4.Min();

            double Max1 = F1.Max();
            double Max2 = F2.Max();
            double Max3 = F3.Max();
            double Max4 = F4.Max();

            for (int i = 0; i < F1.Count; i++)
            {
                F1[i] = ((F1[i] - Min1) / (Max1 - Min1));
                F2[i] = ((F2[i] - Min2) / (Max2 - Min2));
                F3[i] = ((F3[i] - Min3) / (Max3 - Min3));
                F4[i] = ((F4[i] - Min4) / (Max4 - Min4));
            }*/

        }

        private void Bp_form_btn_Click(object sender, EventArgs e)
        {
            BackpropagationForm f = new BackpropagationForm();
            f.ShowDialog();
        }

        private void RBF_form_btn_Click(object sender, EventArgs e)
        {
            RBF_Form f = new RBF_Form();
            f.ShowDialog();
        }

        private void WELCOME_Load(object sender, EventArgs e)
        {
            loaddata();
        }




    }
}
