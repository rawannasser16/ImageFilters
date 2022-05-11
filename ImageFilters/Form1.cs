using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZGraphTools;

namespace ImageFilters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        byte[,] ImageMatrix;
        string OpenedFilePath;
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Open the browsed image and display it
                OpenedFilePath = openFileDialog1.FileName;
                ImageMatrix = ImageOperations.OpenImage(OpenedFilePath);
                ImageOperations.DisplayImage(ImageMatrix, pictureBox1);

            }
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            ImageMatrix = ImageOperations.OpenImage(OpenedFilePath);
           // OpenFileDialog openFileDialog1 = new OpenFileDialog();
            int Sort = 0;
            int Filter = 0;
            string text = textBox1.Text;
            int Max_Size = int.Parse(text);
            string Text_Sort = combo2.Text;
            string Text_Filter = combo1.Text;
            if (Text_Sort == "Quick sort")
            {
                Sort = 1;
            }
            if (Text_Sort == "Count Sort")
            {
                Sort = 2;
            }
             if (Text_Sort == "Heap Sort")
            {
                Sort = 3;
            }
            if(Text_Filter == "Adaptive")
            {
                Filter = 1;
            }
            if (Text_Filter == "Alpha-Trim")
            {
                Filter = 2;
            }

            if (Sort != 0 && Filter != 0)
            {
                int Start = System.Environment.TickCount;
                ImageOperations.ImageFilter(ImageMatrix, Max_Size, Sort, Filter);
                int End = System.Environment.TickCount;
                ImageOperations.DisplayImage(ImageMatrix, pictureBox2);
                double Time = End - Start;
                Time /= 1000;
                label5.Text = (Time).ToString();
                label5.Text += " s";
            }
            
        }
        

            private void btnZGraph_Click(object sender, EventArgs e)
        {
            // Make up some data points from the N, N log(N) functions
            int N = 40;
            double[] x_values = new double[N];
            double[] y_values_N = new double[N];
            double[] y_values_NLogN = new double[N];

            for (int i = 0; i < N; i++)
            {
                x_values[i] = i;
                y_values_N[i] = i;
                y_values_NLogN[i] = i * Math.Log(i);
            }

            //Create a graph and add two curves to it
             ZGraphForm ZGF = new ZGraphForm("Sample Graph", "N", "f(N)");
            ZGF.add_curve("f(N) = N", x_values, y_values_N,Color.Red);
            ZGF.add_curve("f(N) = N Log(N)", x_values, y_values_NLogN, Color.Blue);
            ZGF.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        
        private void combo1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void combo2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}