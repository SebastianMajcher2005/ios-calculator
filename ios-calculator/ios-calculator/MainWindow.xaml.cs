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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            firstNum = "";
            secondNum = "";
            userInput = "";
            result = 0.0;
            TextBoxResult.Text = "0";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            actionType = '*';
            firstNum = userInput;
            userInput = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            actionType = '-';
            firstNum = userInput;
            userInput = "";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            actionType = '+';
            firstNum = userInput;
            userInput = "";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            TextBoxResult.Text = "";
            userInput += "0";
            TextBoxResult.Text = userInput;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            actionType= '/';
            firstNum = userInput;
            userInput = "";
        }

        

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            actionType = ',';
            firstNum = userInput;
            userInput = "";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
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

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            TextBoxResult.Text = "";
            userInput += "1";
            TextBoxResult.Text = userInput;
        }


        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            TextBoxResult.Text = "";
            userInput += "3";
            TextBoxResult.Text = userInput;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            TextBoxResult.Text = "";
            userInput += "2";
            TextBoxResult.Text = userInput;
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            TextBoxResult.Text = "";
            userInput += "6";
            TextBoxResult.Text = userInput;
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            TextBoxResult.Text = "";
            userInput += "5";
            TextBoxResult.Text = userInput;
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            TextBoxResult.Text = "";
            userInput += "4";
            TextBoxResult.Text = userInput;
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            TextBoxResult.Text = "";
            userInput += "9";
            TextBoxResult.Text = userInput;
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            TextBoxResult.Text = "";
            userInput += "8";
            TextBoxResult.Text = userInput;
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            TextBoxResult.Text = "";
            userInput += "7";
            TextBoxResult.Text = userInput;
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            TextBoxResult.Text = "";
            userInput += "";
            TextBoxResult.Text = userInput;
        }

        private void TextBoxResult_TextChanged(object sender, TextChangedEventArgs e)
        {
            
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

        private void Window_IsMouseDirectlyOverChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

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

        private void Ellipse_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Ellipse_PreviewMouseUp_1(object sender, MouseButtonEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void close_tabs_icons_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBoxResult_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
