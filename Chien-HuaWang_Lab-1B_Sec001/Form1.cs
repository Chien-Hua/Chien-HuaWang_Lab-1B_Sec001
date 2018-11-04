using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chien_HuaWang_Lab_1B_Sec001
{
    public partial class Form1 : Form
    {
        private static int[] intArray;
        private static double[] doubleArray;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                textBox1.Text = string.Empty;
                Random random = new Random();
                intArray = new int[12];
                for (int i = 0; i < intArray.Length; i++)
                {

                    intArray[i] = random.Next(1, 100); // random number from 1 to 100
                    textBox1.Text += intArray[i] + "\r\n"; // add 
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            Random random = new Random();
            doubleArray = new double[12];
            for (int i = 0; i < doubleArray.Length; i++)
            {
                double doubleNumber = 0;
                doubleNumber = random.Next(1, 100) + (0.1 * random.Next(1, 9));
                doubleArray[i] = doubleNumber;
                textBox2.Text += doubleArray[i] + "\r\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string input;
            input = textBox3.Text;
            Regex regex = new Regex("([0-9]*)\\.([1-9]*)");
            Match match = regex.Match(input);
            if (match.Success)
            {
                Search(doubleArray, input);
            }
            else
            {
                Search(intArray, input);
            }


        }
        private void Search<T>(T[] array, string input)
        {
            int result = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (input == array[i].ToString())
                {
                    result = i;
                    break;
                }
                else
                {
                    result = -1;
                }
            }

            label1.Text = String.Format("The number of {0} is in the {1} of the array", input, result);

        }
    }
}
