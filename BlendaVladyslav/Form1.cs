using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlendaVladyslav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] c()
        {
            int[,] a = { { 1, 4, 2 }, { 2, 5, 1 } };
            int[,] b = { { 3, 4, 2 }, { 3, 5, 7 }, { 1, 2, 1 } };

            int m = 3;

            int[,] result = new int[2, 3];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int sum = 0;
                    for (int t = 0; t < m; t++)
                    {
                        sum += a[i, t] * b[t, j];
                    }
                    result[i, j] = sum;
                }
            }
            return result;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] a = c();
            for (int i = 0; i < 2; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.Write(Convert.ToString(a[i, j]) + " ");

                }
                Console.WriteLine("");

            }
            
        }
    }
}
