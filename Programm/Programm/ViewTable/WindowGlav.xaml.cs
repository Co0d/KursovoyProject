using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для WindowGlav.xaml
    /// </summary>
    public partial class WindowGlav : Window
    {
        public WindowGlav()
        {            
            InitializeComponent();
            MainWindow mainWindow = new MainWindow();
            if (MainWindow.Globals.UserRole == 1)
            {
                Btn_User1.Visibility = Visibility.Visible;
            }
            else
            {
                Btn_User1.Visibility = Visibility.Collapsed;
            }
            tb_User.Text = mainWindow.txt_Login.Text;
        }

        private void Btn_Glav(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Empl(object sender, RoutedEventArgs e)
        {
            WindowEmployee windowEmployee = new WindowEmployee();
            windowEmployee.Show();
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
            WindowDE windowDE = new WindowDE();
            windowDE.Show();
            this.Close();
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

        private void Btn_novosti(object sender, RoutedEventArgs e)
        {
            Process.Start(@"https://ria.ru");
        }

        private void Btn_pogoda(object sender, RoutedEventArgs e)
        {
            Process.Start(@"https://www.gismeteo.ru/weather-vorkuta-3960/");
        }

        private void Btn_avito(object sender, RoutedEventArgs e)
        {
            Process.Start(@"https://www.avito.ru");
        }

        private void Btn_hh(object sender, RoutedEventArgs e)
        {
            Process.Start(@"https://vorkuta.hh.ru");
        }
    }
}
