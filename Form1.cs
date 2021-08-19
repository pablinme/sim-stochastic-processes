using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Simulation_Lab15
{
    enum MyWeather
    {
        Clear, Cloudy, Overcast 
    }

    public partial class Form1 : Form
    {
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

            DataTable dt = new DataTable();
            this.dataGridView1.DataSource = dt;

            dt.Columns.Add("Clear");
            dt.Columns.Add("Cloudy");
            dt.Columns.Add("Overcast");

            dt.Rows.Add(new Object[] { "-0.4", "0.3", "0.1" });
            dt.Rows.Add(new Object[] { "0.4", "-0.8", "0.4" });
            dt.Rows.Add(new Object[] { "0.1", "0.4", "-0.5" });

            this.dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            int countClear = 0;
            int countCloudy = 0;
            int countOvercast = 0;

            int w = 4;
            double sum = 0;

            int t = int.Parse(textBoxTime.Text);
            int n = int.Parse(textBoxIterations.Text);
            
            // A -- Clear = 0
            // B -- Cloudy = 1
            // C -- Overcast = 2
            double w1 = -0.4; //  Clear->Clear
            double w2 = -0.8; //  Cloudy->Cloudy
            double w3 = -0.5;  // Overcast->Overcast

            double w4 = 0.4;  // Cloudy->Clear   -- Overcast->Cloudy -- Cloudy->Overcast
            double w5 = 0.1;  // Overcast->Clear -- Clear->Overcast
            double w6 = 0.3;  // Clear->Cloudy


            double p1 = 0.33; //in any stage it can start Clear, Cloudy or Overcast
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;

            int[] weather = new int[w];

            for (int it = 1; it <= n; it++)
            {
                labelCurrentIteration.Invoke((MethodInvoker)delegate
                {
                    labelCurrentIteration.Text = "Current Iteration: " + it.ToString();
                    labelCurrentIteration.Update();
                });

                weather[0] = rand.Next(0, 3);
                weather[1] = rand.Next(0, 3);
                weather[2] = rand.Next(0, 3);
                weather[3] = rand.Next(0, 3);

                labelCurrentTime.Invoke((MethodInvoker)delegate
                {
                    labelWeather.Text = "Weather for the next hour: " +
                        (MyWeather)weather[0] + " -> " +
                        (MyWeather)weather[1] + " -> " +
                        (MyWeather)weather[2] + " -> " +
                        (MyWeather)weather[3];
                    labelWeather.Update();
                });

                for (int wi = 0; wi < weather.Length - 1; wi++)
                {
                    if (weather[wi] == 0) // Clear
                    {
                        countClear++;
                        if (weather[wi + 1] == 0) // Clear
                        {
                            if (wi+1 == 1) p2 = w1;
                            else if (wi+1 == 2) p3 = w1;
                            else if (wi + 1 == 3) p4 = w1;
                        }
                        else if (weather[wi + 1] == 1) // Cloudy
                        {
                            if (wi + 1 == 1) p2 = w6;
                            else if (wi + 1 == 2) p3 = w6;
                            else if (wi + 1 == 3) p4 = w6;
                        }
                        else if (weather[wi + 1] == 2) // Overcast
                        {
                            if (wi + 1 == 1) p2 = w5;
                            else if (wi + 1 == 2) p3 = w5;
                            else if (wi + 1 == 3) p4 = w5;
                        }
                    }
                    if (weather[wi] == 1) // Cloudy
                    {
                        countCloudy++;
                        if (weather[wi + 1] == 0 || weather[wi + 1] == 2) // Clear OR Overcast
                        {
                            if (wi + 1 == 1) p2 = w4;
                            else if (wi + 1 == 2) p3 = w4;
                            else if (wi + 1 == 3) p4 = w4;
                        }
                        else if (weather[wi + 1] == 1) // Cloudy
                        {
                            if (wi + 1 == 1) p2 = w2;
                            else if (wi + 1 == 2) p3 = w2;
                            else if (wi + 1 == 3) p4 = w2;
                        }
                    }
                    if (weather[wi] == 2) // Overcast
                    {
                        countOvercast++;
                        if (weather[wi + 1] == 0) // Clear
                        {
                            if (wi + 1 == 1) p2 = w5;
                            else if (wi + 1 == 2) p3 = w5;
                            else if (wi + 1 == 3) p4 = w5;
                        }
                        else if (weather[wi + 1] == 1) // Cloudy
                        {
                            if (wi + 1 == 1) p2 = w4;
                            else if (wi + 1 == 2) p3 = w4;
                            else if (wi + 1 == 3) p4 = w4;
                        }
                        else if (weather[wi + 1] == 2) // Overcast
                        {
                            if (wi + 1 == 1) p2 = w3;
                            else if (wi + 1 == 2) p3 = w3;
                            else if (wi + 1 == 3) p4 = w3;
                        }
                    }
                }
                sum = p1 + p2 + p3 + p4;

                double[] e_probabilities = new double[9];
                double[] probabilities = new double[9];
                double[] experiments = new double[9];
                double[] frequency = new double[9];

                //Expected Value - µ
                double xp1 = 1 * p1;
                double xp2 = 2 * p2;
                double xp3 = 3 * p3;
                double xp4 = 4 * p4;

                double miu = xp1 + xp2 + xp3 + xp4;

                //Variance - µ
                double x2p1 = (1 * 1) * p1;
                double x2p2 = (2 * 2) * p2;
                double x2p3 = (3 * 3) * p3;
                double x2p4 = (4 * 4) * p4;

                double variance = x2p1 + x2p2 + x2p3 + x2p4;
                variance -= (miu * miu);

                experiments[0] = 0;
                experiments[1] = 0;
                experiments[2] = 0;
                experiments[3] = 0;

                e_probabilities[0] = xp1;
                e_probabilities[1] = xp2;
                e_probabilities[2] = xp3;
                e_probabilities[3] = xp4;

                probabilities[0] = p1;
                probabilities[1] = p2;
                probabilities[2] = p3;
                probabilities[3] = p4;

                while (i < n)
                {
                    int r = rand.Next(0, 3); // Clear - Cloudy - Overcast
                    if (r == 1) experiments[0]++;
                    else if (r == 2) experiments[1]++;
                    else if (r == 3) experiments[2]++;
                    else if (r >= 4) experiments[3]++;
                    i++;
                }

                i = 0;
                foreach (var item in experiments)
                {
                    frequency[i++] = item / n;
                }

                double e_miu = 1 * frequency[0] +
                               2 * frequency[1] +
                               3 * frequency[2] +
                               4 * frequency[3];

                double e_variance = (1 * 1) * frequency[0] +
                                    (2 * 2) * frequency[1] +
                                    (3 * 3) * frequency[2] +
                                    (4 * 4) * frequency[3];

                e_variance -= (e_miu * e_miu);

                //Errors
                double miuError = Math.Abs(e_miu - miu) / Math.Abs(miu);
                double varianceError = Math.Abs(e_variance - variance) / Math.Abs(variance);

                //Chi
                double chi = 0;
                double alfa = 0.05;
                for (i = 0; i < 4; i++)
                {
                    chi += Math.Pow((frequency[i] - probabilities[i]), 2) / probabilities[i];
                }

                textBoxAverage.Invoke((MethodInvoker)delegate
                {
                    textBoxAverage.Text = miu.ToString("0.000") + " (error = " + Math.Round((miuError * 100)).ToString() + "%)";
                    textBoxAverage.Update();
                });


                textBoxVariance.Invoke((MethodInvoker)delegate
                {
                    textBoxVariance.Text = variance.ToString("0.000") + " (error = " + Math.Round((varianceError * 100)).ToString() + "%)";
                    textBoxVariance.Update();
                });


                labelChi.Invoke((MethodInvoker)delegate
                {
                    labelChi.Text = "Chi-squared: \r\n" + chi.ToString("0.000") + " > " + alfa.ToString("0.000") + " ( " + ((chi > alfa) ? "YES" : "FALSE") + " )";
                    labelChi.Update();
                });

                for (int ti = 1; ti <= t; ti++)
                {
                    labelCurrentTime.Invoke((MethodInvoker)delegate
                    {
                        labelCurrentTime.Text = "Current Time: " + ti.ToString();
                        labelCurrentTime.Update();
                    });
                    Thread.Sleep(200);
                }   
            }
        }
    }
}
