using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для AddNewDomcileWindow.xaml
    /// </summary>
    public partial class AddNewDomcileWindow : Window
    {
        DB.Entity db = MainWindow.db;

        public AddNewDomcileWindow()
        {
            InitializeComponent();
        }

        private void click_Back(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }

        private void clickSelectImage(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Images|*.png;*.bmp;*.jpg;*.jpeg";
            if (ofd.ShowDialog() == true)
                tbxImage.Text = ofd.FileName;
        }

        private void click_Add(object sender, RoutedEventArgs e)
        {
            try
            {
                var ID = int.Parse(tbxID.Text);
                if (db.Domicile.FirstOrDefault(w=>w.ID == ID) != null)
                {
                    MessageBox.Show("Домовладение с таким номером уже существует!","Error",MessageBoxButton.OK,MessageBoxImage.Error);
                    return;
                }

              db.Domicile.Add(new DB.Domicile {
                  ID = int.Parse(tbxID.Text),
                  Block = tbxBlock.Text,
                  Address = tbxAddress.Text,
                  District = tbxDistrict.Text,
                  Inventory = dpInventory.SelectedDate.Value,
                  Land = double.Parse(tbxLand.Text),
                  Actual = double.Parse(tbxActual.Text),
                  BuildUp = double.Parse(tbxBuildUp.Text),
                  Yard = double.Parse(tbxYard.Text),
                  Green = double.Parse(tbxGreen.Text),
                  Garden = double.Parse(tbxGarden.Text),
                  Bad = double.Parse(tbxBand.Text),
                  Picture = ImageToByte(tbxImage.Text),
                  Light = rbLightTrue.IsChecked == true ? true : false,
                  WaterPipe = rbWaterTrue.IsChecked == true ? true : false,
                  Heating = rbHeatingTrue.IsChecked == true ? true : false,
                  Comment = tbxComment.Text
              });
              db.SaveChanges();

              if (MessageBox.Show("Домовладение добавлено! Добавить ещё?", "Perfect", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
              {
                  new AddNewDomcileWindow().ShowDialog();
                  this.Close();
              }
              else
                  new MainWindow().Show();
                  this.Close();

            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введите корректные данные!","Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Введите корректный путь изображения!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private byte[] ImageToByte(string uri)
        {
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(new BitmapImage(new Uri(uri,UriKind.Relative))));
            MemoryStream ms = new MemoryStream();
            encoder.Save(ms);
            return ms.ToArray();
        }
    }
}
