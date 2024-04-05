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

using CalcLibrary;

namespace WpfCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calc calc = new Calc();

        public MainWindow()
        {
            InitializeComponent();

            calc.CurrNumberChange +=
                (number) => tbOut.Text = number.ToString();
        }

        private void btNum1_Click(object sender, RoutedEventArgs e)
        {
            calc.AddNumber(1);
        }

        private void btNum2_Click(object sender, RoutedEventArgs e)
        {
            calc.AddNumber(2);
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            calc.SetAction(MathActions.Addition);
        }

        private void btResult_Click(object sender, RoutedEventArgs e)
        {
            calc.Result();
        }

        private void btReset_Click(object sender, RoutedEventArgs e)
        {
            calc.Reset();
        }
    }
}
