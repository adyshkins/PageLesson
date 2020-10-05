using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для PageListUser.xaml
    /// </summary>
    public partial class PageListUser : Page
    {
        public PageListUser()
        {           
            InitializeComponent();
            listUser.ItemsSource = context.User.ToList();                 
        }

        private void SearchTXT_TextChanged(object sender, TextChangedEventArgs e)
        {
            listUser.ItemsSource = context.User.Where(i => i.NameUser.Contains(searchTXT.Text)).ToList();
        }
    }
}
