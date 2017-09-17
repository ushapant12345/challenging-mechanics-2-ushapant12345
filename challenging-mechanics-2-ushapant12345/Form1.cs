using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace challenging_mechanics_2_ushapant12345
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int number1 = 10, number2 = 15, number3 = 5, number4 = 75, number5 = 3;
            double number6 = 10.0, number7 = 45.0, number8 = 3, number9 = 23, number10 = 15;
            int answer1, answer2, answer3, answer4, answer5;
            int answer6, answer7, answer8, answer9, answer10;
            double answer11, answer12, answer13, answer14, answer15;
            double answer16, answer17, answer18, answer19, answer20;

            answer1 = number1 + 10;
            answer2 = number2 - 12;
            answer3 = 12 - number3;
            answer4 = number4 / 5;
            answer5 = number3 * 8;
            answer6 = number3 + number4;
            answer7 = number2 / number3;
            answer8 = number4 / number3;
            answer9 = number4 / number1;
            answer10 = number5 / number2;

            MessageBox.Show(answer1.ToString());
            MessageBox.Show(answer2.ToString());
            MessageBox.Show(answer3.ToString());
            MessageBox.Show(answer4.ToString());
            MessageBox.Show(answer5.ToString());
            MessageBox.Show(answer6.ToString());
            MessageBox.Show(answer7.ToString());
            MessageBox.Show(answer8.ToString());
            MessageBox.Show(answer9.ToString());
            MessageBox.Show(answer10.ToString());

            answer11 = number6 + 10;
            answer12 = number7 - 12;
            answer13 = 12 - number8;
            answer14 = number9 / 5;
            answer15 = number8 *  8;
            answer16 = number8 + number9;
            answer17 = number7 / number8;
            answer18 = number9 / number8;
            answer19 = number9 / number6;
            answer20 = number10 / number7;
            MessageBox.Show(answer11.ToString());
            MessageBox.Show(answer12.ToString());
            MessageBox.Show(answer13.ToString());
            MessageBox.Show(answer14.ToString());
            MessageBox.Show(answer15.ToString());
            MessageBox.Show(answer16.ToString());
            MessageBox.Show(answer17.ToString());
            MessageBox.Show(answer18.ToString());
            MessageBox.Show(answer19.ToString());
            MessageBox.Show(answer20.ToString());



            answer1 = number3 % 1;
            answer2 = number3 % 2;
            answer3 = number3 % 3;
            answer4 = number3 % 4;
            answer5 = number3 % 5;
            answer6 = number3 % 6;
            answer7 = number3 % 7;
            answer8 = number3 % 8;
            answer9 = number3 % 9;
            answer10 = number3 % 10;



            MessageBox.Show(answer1.ToString());
            MessageBox.Show(answer2.ToString());
            MessageBox.Show(answer3.ToString());
            MessageBox.Show(answer4.ToString());
            MessageBox.Show(answer5.ToString());
            MessageBox.Show(answer6.ToString());
            MessageBox.Show(answer7.ToString());
            MessageBox.Show(answer8.ToString());
            MessageBox.Show(answer9.ToString());
            MessageBox.Show(answer10.ToString());

           
             MessageBox.Show(answer11.ToString("n2"));
            MessageBox.Show(answer14.ToString("n6"));
            MessageBox.Show(answer18.ToString("n3"));
            MessageBox.Show(answer17.ToString("C"));
            MessageBox.Show(answer18.ToString("C"));
            MessageBox.Show(answer19.ToString("C"));
            MessageBox.Show(answer20.ToString("C"));




            string input1 = "apple", input2 = "banana", input3 = "pear",input4 = "pine", input5 = "boat", input6 = "fruit";
            string output1, output2, output3, output4, output5, output6;

            output1 = input1;
          
            output2 = input4 + input1;
            output3 = input4 + " " + input5;
            output4 = input2 + " " + input5;
            output5 = input1 + " " + "is a"+ " " +  input6;
            output6 = input1 + "," + input2 + "," + input3 + "," + "in a" + " " + input6 + input5;
            MessageBox.Show(output1);
            MessageBox.Show(output2);
            MessageBox.Show(output3);
            MessageBox.Show(output4);
            MessageBox.Show(output5);
            MessageBox.Show(output6);























        }
    }
}
