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
    /// Логика взаимодействия для AddNewRoomWindow.xaml
    /// </summary>
    public partial class AddNewRoomWindow : Window
    {
        public DB.Entity db = MainWindow.db;

        public AddNewRoomWindow()
        {
            InitializeComponent();
        }

        private void click_Back(object sender, RoutedEventArgs e)
        {
            new RoomsWindow().Show();
            this.Close();
        }

        private void click_Add(object sender, RoutedEventArgs e)
        {
            try
            {
                var ID = int.Parse(tbxNumber.Text);
                if (db.Rooms.FirstOrDefault(w => w.NumberSign == ID && w.BuildingID == RoomsWindow.SelectBuilding.Letter) != null)
                {
                    MessageBox.Show("Комната с таким номером уже существует!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                if (int.Parse(tbxStorey.Text) > RoomsWindow.SelectBuilding.Storeys)
                {
                    MessageBox.Show("В этом здании только " + RoomsWindow.SelectBuilding.Storeys + " этаж(ей)!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                db.Rooms.Add(new DB.Rooms {
                    NumberSign = int.Parse(tbxNumber.Text),
                    Buildings = RoomsWindow.SelectBuilding,
                    Prescribe = tbxPrescribe.Text,
                    SquareRoom = double.Parse(tbxSquareRoom.Text),
                    HighRoom = double.Parse(tbxHighRoom.Text),
                    Storey = int.Parse(tbxStorey.Text)
                });
                db.SaveChanges();

                if (MessageBox.Show("Добавление новой комнаты прошло успешно! Хотите добавить ещё?","Perfect",MessageBoxButton.YesNo,MessageBoxImage.Information) == MessageBoxResult.Yes)
                {
                    new AddNewRoomWindow().Show();
                    this.Close();
                }
                else
                {
                    new RoomsWindow().Show();
                    this.Close();
                }
            }
            catch 
            {
                MessageBox.Show("Введите корректные данные!","Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }
    }
}
