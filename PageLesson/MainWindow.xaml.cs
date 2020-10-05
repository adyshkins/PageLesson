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
using static PageLesson.AppData.DataFrame;

namespace PageLesson
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {      


        public MainWindow()
        {
            InitializeComponent();           
            FrmMain.Navigate(new MainPage());            
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new MainPage());
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new Page2());
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new PageListUser());
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            if (FrmMain.CanGoBack)
            {
                FrmMain.GoBack();
            }         
                          

        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new Page3());
        }
    }
}
