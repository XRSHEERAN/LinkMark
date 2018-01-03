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
using System.IO;

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
        
        private void clear()
        {
            inp.Text = "http://example.com";
            inp1.Text = "Example";
            inp2.Text = "Write a comment here";
            inp.Foreground = Brushes.Gray;
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
            if (!inp.Text.Equals("http://example.com") && !inp1.Text.Equals("Example") && !inp2.Text.Equals("Write a comment here"))
                clear();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string text =  inp.Text +" " + inp1.Text + " " + inp2.Text + " ";
            clear();
            using (StreamWriter outputT = new StreamWriter(Directory.GetCurrentDirectory()+@"\shelf.txt"))
            {
                outputT.WriteLine(text);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            clear();
        }
    }
}
