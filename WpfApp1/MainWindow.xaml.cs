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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<String> WebList=new List<String>();
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void inp_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox curr = (TextBox)sender;
            curr.Text = "";
            curr.Foreground = Brushes.Black;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            grid0.Focus();
            inp.Text = "http://example.com";
            inp.Foreground = Brushes.Gray;
        }
    }
}
