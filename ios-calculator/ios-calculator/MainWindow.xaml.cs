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


namespace ios_calculator
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


        string firstNum , secondNum;
        char actionType = ' ';
        double result = 0.0;
        string userInput = "";
        private void Reset_Button(object sender, RoutedEventArgs e)
        {
            firstNum = "";
            secondNum = "";
            userInput = "";
            result = 0.0;
            TextBoxResult.Text = "0";
        }

        private void Multiplication_Button(object sender, RoutedEventArgs e)
        {
            actionType = '*';
            firstNum = userInput;
            userInput = "";
        }

        private void Minus_Button(object sender, RoutedEventArgs e)
        {
            actionType = '-';
            firstNum = userInput;
            userInput = "";
        }

        private void Plus_Button(object sender, RoutedEventArgs e)
        {
            actionType = '+';
            firstNum = userInput;
            userInput = "";
        }

        private void Zero_Button(object sender, RoutedEventArgs e)
        {
            TextBoxResult.Text = "";
            userInput += "0";
            TextBoxResult.Text = userInput;
        }

        private void Divide_Button(object sender, RoutedEventArgs e)
        {
            actionType= '/';
            firstNum = userInput;
            userInput = "";
        }

        

        private void Comma_Button(object sender, RoutedEventArgs e)
        {
            actionType = ',';
            firstNum = userInput;
            userInput = "";
        }

        private void Equals_Button(object sender, RoutedEventArgs e)
        {
            secondNum = userInput;
            double frstNum, secNum;
            frstNum = Convert.ToInt32(firstNum);
            secNum = Convert.ToInt32(secondNum);

            switch(actionType)
            {
                case ('+'):
                    result = frstNum + secNum;
                    TextBoxResult.Text = result.ToString();
                    break;
                case ('-'):
                    result = frstNum - secNum;
                    TextBoxResult.Text = result.ToString();
                    break;
                case ('*'):
                    result = frstNum * secNum;
                    TextBoxResult.Text = result.ToString();
                    break;
                case ('/'):
                    result = frstNum / secNum;
                    TextBoxResult.Text = result.ToString();
                    if (frstNum == 0 || secNum == 0)
                    {
                        result = 0;
                        TextBoxResult.Text = result.ToString();
                    }
                    else
                    {
                        result = frstNum / secNum;
                        TextBoxResult.Text = result.ToString();
                    }
                    break;
                

            }
        }

        private void One_Button(object sender, RoutedEventArgs e)
        {
            TextBoxResult.Text = "";
            userInput += "1";
            TextBoxResult.Text = userInput;
        }


        private void Three_Button(object sender, RoutedEventArgs e)
        {
            TextBoxResult.Text = "";
            userInput += "3";
            TextBoxResult.Text = userInput;
        }

        private void Two_Button(object sender, RoutedEventArgs e)
        {
            TextBoxResult.Text = "";
            userInput += "2";
            TextBoxResult.Text = userInput;
        }

        private void Six_Button(object sender, RoutedEventArgs e)
        {
            TextBoxResult.Text = "";
            userInput += "6";
            TextBoxResult.Text = userInput;
        }

        private void Five_Button(object sender, RoutedEventArgs e)
        {
            TextBoxResult.Text = "";
            userInput += "5";
            TextBoxResult.Text = userInput;
        }

        private void Four_Button(object sender, RoutedEventArgs e)
        {
            TextBoxResult.Text = "";
            userInput += "4";
            TextBoxResult.Text = userInput;
        }

        private void Nine_Button(object sender, RoutedEventArgs e)
        {
            TextBoxResult.Text = "";
            userInput += "9";
            TextBoxResult.Text = userInput;
        }

        private void Eight_Button(object sender, RoutedEventArgs e)
        {
            TextBoxResult.Text = "";
            userInput += "8";
            TextBoxResult.Text = userInput;
        }

        private void Seven_Button(object sender, RoutedEventArgs e)
        {
            TextBoxResult.Text = "";
            userInput += "7";
            TextBoxResult.Text = userInput;
        }
        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            TextBoxResult.Text = "";
            userInput += "";
            TextBoxResult.Text = userInput;
        }
        private void closeApp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void minimalizeApp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.WindowState = WindowState.Minimized;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void Ellipse_MouseEnter(object sender, MouseEventArgs e)
        {
            try
            {
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            int stringLength = TextBoxResult.Text.Length;
            if (stringLength > 1)
            {
                TextBoxResult.Text = TextBoxResult.Text.Substring(stringLength -1);

            }
            else
            {
                TextBoxResult.Text = "0";
            }

        }
    }
}
