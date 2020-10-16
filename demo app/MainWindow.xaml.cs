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

namespace demo_app
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello Girl");
        }
        
        private void Button_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello Girls");


        }

        private void A_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            A.Background = Brushes.LavenderBlush;

            A.Text = "Tell me your name";
        }

        private void TextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            B.Background = Brushes.MistyRose;

            B.Text = "Top secret";
        }
    }
}
