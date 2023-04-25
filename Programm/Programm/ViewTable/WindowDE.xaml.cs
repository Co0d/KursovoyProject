using Programm.Model;
using Programm.ViewAdd;
using Programm.ViewEdit;
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

namespace Programm.ViewTable
{
    /// <summary>
    /// Логика взаимодействия для WindowDE.xaml
    /// </summary>
    public partial class WindowDE : Window
    {
        public WindowDE()
        {
            InitializeComponent();
            if (MainWindow.Globals.UserRole == 1)
            {
                Btn_User1.Visibility = Visibility.Visible;
            }
            else
            {
                Btn_User1.Visibility = Visibility.Collapsed;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DEGrid.ItemsSource = AppData.db.DocumentEducation.ToList();
        }

        private void Btn_Glav(object sender, RoutedEventArgs e)
        {
            WindowGlav windowGlav = new WindowGlav();
            windowGlav.Show();
            this.Close();
        }

        private void Btn_LD(object sender, RoutedEventArgs e)
        {
            WindowLD windowLD = new WindowLD();
            windowLD.Show();
            this.Close();
        }

        private void Btn_DE(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Pass(object sender, RoutedEventArgs e)
        {
            WindowPassport windowPassport = new WindowPassport();
            windowPassport.Show();
            this.Close();
        }

        private void Btn_State(object sender, RoutedEventArgs e)
        {
            WindowStatement windowStatement = new WindowStatement();
            windowStatement.Show();
            this.Close();
        }

        private void Btn_User(object sender, RoutedEventArgs e)
        {
            WindowUser windowUser = new WindowUser();
            windowUser.Show();
            this.Close();
        }

        private void Btn_Exit(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Btn_Empl(object sender, RoutedEventArgs e)
        {
            WindowEmployee windowEmployee = new WindowEmployee();
            windowEmployee.Show();
            this.Close();
        }

        private void Btn_Add(object sender, RoutedEventArgs e)
        {
            AddDE addDE = new AddDE();
            addDE.Show();
        }

        private void Btn_Edit(object sender, RoutedEventArgs e)
        {
            EditDE editDE = new EditDE(DEGrid.SelectedItem as DocumentEducation);
            editDE.Show();
        }

        private void Btn_Del(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить пользователя?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var CurrentUser = DEGrid.SelectedItem as DocumentEducation;
                AppData.db.DocumentEducation.Remove(CurrentUser);
                AppData.db.SaveChanges();
                DEGrid.ItemsSource = AppData.db.DocumentEducation.ToList();
                MessageBox.Show("Удалено");
            }
        }

        private void Btn_Otchet(object sender, RoutedEventArgs e)
        {

        }
    }
}
