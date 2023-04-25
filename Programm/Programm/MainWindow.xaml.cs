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
using Programm.Model;
using Programm.ViewTable;

namespace Programm
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public static class Globals
        {
            public static int UserRole;

            public static string Login;
            public static User userinfo { get; set; }
        }


        private void Btn_Next(object sender, RoutedEventArgs e)
        {
            var CurrentUser = AppData.db.User.FirstOrDefault(u => u.Login == txt_Login.Text);
            if (CurrentUser != null)
            {
                Globals.UserRole = CurrentUser.id;
                Globals.userinfo = CurrentUser;
                txt_Password.IsEnabled = true;
                Btn_next.Visibility = Visibility.Hidden;
                Btn_next1.Visibility = Visibility.Visible;

            }
            else
            {
                MessageBox.Show("Пользователь не найден!");
            }
        }

        private async void Btn_Next1(object sender, RoutedEventArgs e)
        {
            var CurrentUser1 = AppData.db.User.FirstOrDefault(u => u.Password == txt_Password.Password);
            if (CurrentUser1 != null)
            {
                Globals.UserRole = CurrentUser1.id;
                Globals.userinfo = CurrentUser1;
                Btn_next1.Visibility = Visibility.Hidden;
                Btn_next2.Visibility = Visibility.Visible;
                while (true)
                {
                    Random x = new Random();
                    int a = x.Next(1000, 9999);
                    txt_Code.Text = a.ToString();
                    await Task.Delay(10000);
                }
            }
            else
            {
                MessageBox.Show("Пароль не верен!");
            }
        }

        private void Btn_Next2(object sender, RoutedEventArgs e)
        {
            if (txt_Code.Text == txt_CodePod.Text)
            {
                MessageBox.Show("Вы вошли!");
                WindowGlav windowGlav = new WindowGlav();
                windowGlav.tb_User.Text = txt_Login.Text;
                windowGlav.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Вы не вошли!");
            }
        }

        private void Btn_Cancel(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
