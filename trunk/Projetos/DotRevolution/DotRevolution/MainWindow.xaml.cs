using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Menu mainMenu = new Menu();
      
                    }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Menu mainMenu = new Menu();

            ChildWindow childWindow = new ChildWindow();

            childWindow.Show();
        }

        private void image1_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {
            
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Menu mainMenu = new Menu();
        MainWindow: Page1;
           
        }

       

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Menu mainMenu = new Menu();
            Window mainWindow = new Window();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Menu mainMenu = new Menu();
            Window mainWindow = new Window();
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void image1_ImageFailed_1(object sender, ExceptionRoutedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
