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
    /// Логика взаимодействия для AddNewBuildingWindow.xaml
    /// </summary>
    public partial class AddNewBuildingWindow : Window
    {
        DB.Entity db = MainWindow.db;

        public AddNewBuildingWindow()
        {
            InitializeComponent();

            cbxType.ItemsSource = db.Type.ToList();
            cbxType.DisplayMemberPath = "Name";
            cbxType.SelectedIndex = 0;
        }

        private void click_Back(object sender, RoutedEventArgs e)
        {
            new BuildingsWindow().Show();
            this.Close();
        }

        private void click_Add(object sender, RoutedEventArgs e)
        {
            try
            {
                db.Buildings.Add(new DB.Buildings {
                    Domicile = BuildingsWindow.SelectDomicile,
                    Contents = tbxContents.Text,
                    Type = (DB.Type)cbxType.SelectedItem,
                    MySelf = chbx.IsChecked == true ? true : false,
                    Year = short.Parse(tbxYear.Text),
                    SquareAll = double.Parse(tbxSquareAll.Text),
                    Inhabited = double.Parse(tbxInhabited.Text),
                    Wear = byte.Parse(tbxWear.Text),
                    Wall = tbxWall.Text,
                    Cost = decimal.Parse(tbxCost.Text),
                    Storeys = int.Parse(tbxStoryes.Text)
                });
                db.SaveChanges();

                if (MessageBox.Show("Добавление нового здания прошло успешно! Вы хотите добавить ещё?","Perfect",MessageBoxButton.YesNo,MessageBoxImage.Information) == MessageBoxResult.Yes)
                {
                    new AddNewBuildingWindow().Show();
                    this.Close();
                }
                else
                {
                    new BuildingsWindow().Show();
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
