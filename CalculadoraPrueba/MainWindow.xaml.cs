using System;
using System.Collections.Generic;
using System.Data;
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

namespace CalculadoraPrueba
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String numeroString="";

        public MainWindow()
        {
            InitializeComponent();
            
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            numeroString= String.Concat(numeroString, "1");
            resultado.Text = numeroString;
        }

        private void bttn_2_Click(object sender, RoutedEventArgs e)
        {
            numeroString = String.Concat(numeroString, "2");
            resultado.Text = numeroString;
        }

        private void bttn_3_Click(object sender, RoutedEventArgs e)
        {
            numeroString = String.Concat(numeroString, "3");
            resultado.Text = numeroString;
        }

        private void bttn_clear_Click(object sender, RoutedEventArgs e)
        {
            numeroString = "";
            resultado.Text = numeroString;
        }

        private void bttn_0_Click(object sender, RoutedEventArgs e)
        {
            numeroString = String.Concat(numeroString, "0");
            resultado.Text = numeroString;
        }

        private void bttn_7_Click(object sender, RoutedEventArgs e)
        {
            numeroString = String.Concat(numeroString, "7");
            resultado.Text = numeroString;
        }

        private void bttn_8_Click(object sender, RoutedEventArgs e)
        {
            numeroString = String.Concat(numeroString, "8");
            resultado.Text = numeroString;
        }

        private void bttn_9_Click(object sender, RoutedEventArgs e)
        {
            numeroString = String.Concat(numeroString, "9");
            resultado.Text = numeroString;
        }

        private void bttn_6_Click(object sender, RoutedEventArgs e)
        {
            numeroString = String.Concat(numeroString, "6");
            resultado.Text = numeroString;
        }

        private void bttn_4_Click(object sender, RoutedEventArgs e)
        {
            numeroString = String.Concat(numeroString, "4");
            resultado.Text = numeroString;
        }

        private void bttn_5_Click(object sender, RoutedEventArgs e)
        {
            numeroString = String.Concat(numeroString, "5");
            resultado.Text = numeroString;
        }



        private void bttn_Open_Click(object sender, RoutedEventArgs e)
        {
            numeroString = String.Concat(numeroString, "(");
            resultado.Text = numeroString;
        }

        private void bttn_Close_Click(object sender, RoutedEventArgs e)
        {
            numeroString = String.Concat(numeroString, ")");
            resultado.Text = numeroString;
        }

        private void bttn_comma_Click(object sender, RoutedEventArgs e)
        {
            numeroString = String.Concat(numeroString, ".");
            resultado.Text = numeroString;
        }

        private void bttn_perc_Click(object sender, RoutedEventArgs e)
        {
            numeroString = String.Concat(numeroString, "/100");
            resultado.Text = numeroString;
        }

        private void bttn_rest1_Click(object sender, RoutedEventArgs e)
        {
            numeroString = String.Concat(numeroString, "-");
            resultado.Text = numeroString;
        }

        private void bttn_mult_Click(object sender, RoutedEventArgs e)
        {
            numeroString = String.Concat(numeroString, "*");
            resultado.Text = numeroString;
        }

        private void bttn_div_Click(object sender, RoutedEventArgs e)
        {
            numeroString = String.Concat(numeroString, "/");
            resultado.Text = numeroString;
        }

        private void bttn_sum_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                decimal answer = (decimal)dt.Compute("(" + numeroString + ")*1.0", "");
                MessageBox.Show(answer.ToString());
            }
            catch (InvalidCastException)
            {
                try
                {
                    double answer = (double)dt.Compute("(" + numeroString + ")*1.0", "");
                    MessageBox.Show(answer.ToString());
                }
                catch (InvalidCastException err)
                {
                    MessageBox.Show(err.ToString());
                }
            }            
        }

        private void bttn_rest_Click(object sender, RoutedEventArgs e)
        {
            numeroString = String.Concat(numeroString, "+");
            resultado.Text = numeroString;
        }

        private void resultado_TextChanged(object sender, TextChangedEventArgs e)
        {
            numeroString = resultado.Text;
        }
    }
}
