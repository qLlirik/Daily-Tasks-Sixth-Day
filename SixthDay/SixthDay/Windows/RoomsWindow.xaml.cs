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
    /// Логика взаимодействия для RoomsWindow.xaml
    /// </summary>
    public partial class RoomsWindow : Window
    {
        static public DB.Buildings SelectBuilding;
        DB.Entity db = MainWindow.db;

        public RoomsWindow()
        {
            InitializeComponent();

            lv.ItemsSource = db.Rooms.Where(w => w.BuildingID == SelectBuilding.Letter).ToList();
        }

        private void click_Back(object sender, RoutedEventArgs e)
        {
            new BuildingsWindow().Show();
            this.Close();
        }

        private void click_AddNewRoom(object sender, RoutedEventArgs e)
        {
            new AddNewRoomWindow().Show();
            this.Close();
        }
    }
}
