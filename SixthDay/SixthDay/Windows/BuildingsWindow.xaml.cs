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
using System.Windows.Shapes;

namespace SixthDay.Windows
{
    /// <summary>
    /// Логика взаимодействия для BuildingsWindow.xaml
    /// </summary>
    public partial class BuildingsWindow : Window
    {
        static public DB.Domicile SelectDomicile;
        DB.Entity db = MainWindow.db;

        public BuildingsWindow()
        {
            InitializeComponent();

            click_Search(null,null);
        }

        private void click_Back(object sender, RoutedEventArgs e)
        {
            SelectDomicile = null;
            new MainWindow().Show();
            this.Close();
        }

        private void click_AddNewBuilding(object sender, RoutedEventArgs e)
        {
            new AddNewBuildingWindow().Show();
            this.Close();
        }

        private void click_SelectRoom(object sender, RoutedEventArgs e)
        {
            RoomsWindow.SelectBuilding = (DB.Buildings)((Button)sender).DataContext;
            new RoomsWindow().Show();
            this.Close();
        }

        private void click_Search(object sender, RoutedEventArgs e)
        {
            var qwery = db.Buildings.Where(w=>w.Letter != null);
            if (cbxConteins.Text.Length != 0)
            {
                System.IO.File.AppendAllText("Search.txt", cbxConteins.Text + '`');
                qwery = qwery.Where(w => w.Contents.Contains(cbxConteins.Text));
            }
            lv.ItemsSource = qwery.Where(w => w.DomicileID == SelectDomicile.ID).ToList();
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                cbxConteins.IsDropDownOpen = false;
                click_Search(null,null);
                return;
            }
            cbxConteins.ItemsSource = null;
            cbxConteins.IsDropDownOpen = true;
            cbxConteins.ItemsSource = System.IO.File.ReadAllText("Search.txt").Split('`').ToList();
        }
    }
}
