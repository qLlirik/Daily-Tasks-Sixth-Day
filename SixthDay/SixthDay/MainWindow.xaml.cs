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

namespace SixthDay
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static public DB.Entity db = new DB.Entity();

        public MainWindow()
        {
            InitializeComponent();

            lv.ItemsSource = db.Domicile.ToList();
        }

        private void click_AddNewDominicile(object sender, RoutedEventArgs e)
        {
            new Windows.AddNewDomcileWindow().Show();
            this.Close();
        }

        private void click_SelectDomocile(object sender, RoutedEventArgs e)
        {
            Windows.BuildingsWindow.SelectDomicile = (DB.Domicile)((Button)sender).DataContext;
            new Windows.BuildingsWindow().Show();
            this.Close();
        }
    }
}
