using Programm.Model;
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

namespace Programm.ViewAdd
{
    /// <summary>
    /// Логика взаимодействия для AddUser.xaml
    /// </summary>
    public partial class AddUser : Window
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void Btn_Save(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user.Login = txb_Login.Text;
            user.Password = txb_Password.Text;
            user.Post = txb_Post.Text;           
            AppData.db.User.Add(user);
            AppData.db.SaveChanges();
            MessageBox.Show("Пользователь был добавлен в базу!");
        }

        private void Btn_Can(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
