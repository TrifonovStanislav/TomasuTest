﻿using System;
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
using System.Text.RegularExpressions;
using WpfApplication1.ViewModels;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new FunctionViewModel();
            
        }

        private double calcFunc()
        {
            double result = 0;
            try
            {                
                double a = Convert.ToDouble(textBoxA.Text);
                double b = Convert.ToDouble(textBoxB.Text);
                double c = Convert.ToDouble(comboBox2.SelectedItem);
                double x = Convert.ToDouble(tbX.Text);
                double y = Convert.ToDouble(tbY.Text);
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        result = a * x + b + c;
                        break;
                    case 1:
                        result = a * Math.Pow(x, 2) + b * y + c;
                        break;
                    case 2:
                        result = a * Math.Pow(x, 3) + b * Math.Pow(y, 2) + c;
                        break;
                    case 3:
                        result = a * Math.Pow(x, 4) + b * Math.Pow(y, 3) + c;
                        break;
                    case 4:
                        result = a * Math.Pow(x, 5) + b * Math.Pow(y, 4) + c;
                        break;
                }
            }
            catch(System.FormatException)
            {
                return result;
            }
            return result;
        }

        private void textBoxA_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text); 
        }
        
        private void textBoxB_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void tbX_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void tbY_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            resultTb.Text = calcFunc().ToString();

        }

        private void comboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            resultTb.Text = calcFunc().ToString();
        }               

        private void textBoxA_TextChanged(object sender, TextChangedEventArgs e)
        {
            resultTb.Text = calcFunc().ToString();
        }

        private void textBoxB_TextChanged(object sender, TextChangedEventArgs e)
        {
            resultTb.Text = calcFunc().ToString();
        }

        private void tbX_TextChanged(object sender, TextChangedEventArgs e)
        {
            resultTb.Text = calcFunc().ToString();
        }

        private void tbY_TextChanged(object sender, TextChangedEventArgs e)
        {
            resultTb.Text = calcFunc().ToString();
        }

        
    }
}
