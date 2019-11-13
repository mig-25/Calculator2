using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private double total1 = 0;
        private double total2 = 0;
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool multiplyButtonClicked = false;
        bool divideButtonClicked = false;
        bool squareButtonClicked = false;


        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            textBox_Result.Text = "0";
            labelCurrentOperation.Content = "";
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            textBox_Result.Text = "0";
            labelCurrentOperation.Content = "";

        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            if (plusButtonClicked == true)
            {
                total2 = total1 + double.Parse(textBox_Result.Text);
                labelCurrentOperation.Content = total1 + "+" + double.Parse(textBox_Result.Text);
                textBox_Result.Text = total2.ToString();
                total1 = 0;
            }
            else if (minusButtonClicked == true)
            {
                total2 = total1 - double.Parse(textBox_Result.Text);
                labelCurrentOperation.Content = total1 + "-" + double.Parse(textBox_Result.Text);
                textBox_Result.Text = total2.ToString();
                total1 = 0;
            }
            else if (multiplyButtonClicked == true)
            {
                total2 = total1 * double.Parse(textBox_Result.Text);
                labelCurrentOperation.Content = total1 + "*" + double.Parse(textBox_Result.Text);
                textBox_Result.Text = total2.ToString();
                total1 = 0;
            }
            else if (divideButtonClicked == true)
            {
                total2 = total1 / double.Parse(textBox_Result.Text);
                labelCurrentOperation.Content = total1 + "/" + double.Parse(textBox_Result.Text);
                textBox_Result.Text = total2.ToString();
                total1 = 0;
            }
            else if (squareButtonClicked == true)
            {
                total1 = Math.Round(Math.Sqrt(total1));
               
            }
        
        }

        private void btnBackSpace_Click(object sender, RoutedEventArgs e)
        {
            int i = textBox_Result.Text.Length;
            textBox_Result.Text = textBox_Result.Text.Substring(0, textBox_Result.Text.Length - 1);

        }

        private void btnPositiveNegative_Click(object sender, RoutedEventArgs e)
        {
            if (textBox_Result.Text.StartsWith("-"))
            {
                //It's negative now, so strip the `-` sign to make it positive
                textBox_Result.Text = textBox_Result.Text.Substring(1);
            }
            else if (!string.IsNullOrEmpty(textBox_Result.Text) && decimal.Parse(textBox_Result.Text) != 0)
            {
                //It's positive now, so prefix the value with the `-` sign to make it negative
                textBox_Result.Text = "-" + textBox_Result.Text;
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            textBox_Result.Text += "7";
            labelCurrentOperation.Content = textBox_Result.Text;
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            textBox_Result.Text += "8";
            labelCurrentOperation.Content = textBox_Result.Text;
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            textBox_Result.Text += "9";
            labelCurrentOperation.Content = textBox_Result.Text;
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            textBox_Result.Text += "4";
            labelCurrentOperation.Content = textBox_Result.Text;
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            textBox_Result.Text += "5";
            labelCurrentOperation.Content = textBox_Result.Text;
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            textBox_Result.Text += "6";
            labelCurrentOperation.Content = textBox_Result.Text;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            textBox_Result.Text += "1";
            labelCurrentOperation.Content = textBox_Result.Text;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            textBox_Result.Text += "2";
            labelCurrentOperation.Content = textBox_Result.Text;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            textBox_Result.Text += "3";
            labelCurrentOperation.Content = textBox_Result.Text;
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            textBox_Result.Text += "0";
            labelCurrentOperation.Content = textBox_Result.Text;
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            total1 += double.Parse(textBox_Result.Text);
            labelCurrentOperation.Content = textBox_Result.Text + "+";
            textBox_Result.Text = "";

            plusButtonClicked = true;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            total1 += double.Parse(textBox_Result.Text);
            labelCurrentOperation.Content = textBox_Result.Text + "-";
            textBox_Result.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = true;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
        }

        private void btnTimes_Click(object sender, RoutedEventArgs e)
        {
            total1 += double.Parse(textBox_Result.Text);
            labelCurrentOperation.Content = textBox_Result.Text + "*";
            textBox_Result.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = true;
            divideButtonClicked = false;
            squareButtonClicked = false;
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            total1 += double.Parse(textBox_Result.Text);
            labelCurrentOperation.Content = textBox_Result.Text + "/";
            textBox_Result.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = true;
            squareButtonClicked = false;
        }

        private void btnSquare_Click(object sender, RoutedEventArgs e)
        {
            total1 += double.Parse(textBox_Result.Text);
            labelCurrentOperation.Content = textBox_Result.Text + "&#8730;";
            textBox_Result.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = true;
        }

        private void btnDecimal_Click(object sender, RoutedEventArgs e)
        {
            textBox_Result.Text += ",";
        }
    }
}
