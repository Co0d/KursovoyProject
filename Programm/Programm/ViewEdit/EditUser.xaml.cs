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

namespace Programm.ViewEdit
{
    /// <summary>
    /// Логика взаимодействия для EditUser.xaml
    /// </summary>
    public partial class EditUser : Window
    {
        private User _user = new User();
        public EditUser(User selectedUser)
        {
            InitializeComponent();
            if (selectedUser != null)
                _user = selectedUser;
            DataContext = _user;
        }

        private void Btn_Save(object sender, RoutedEventArgs e)
        {
            StringBuilder erros = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_user.Login))
                erros.AppendLine("Укажите фамилию");
            if (string.IsNullOrWhiteSpace(_user.Password))
                erros.AppendLine("Укажите Имя");
            if (string.IsNullOrWhiteSpace(_user.Post))
                erros.AppendLine("Укажите фамилию");
            if (erros.Length > 0)
            {
                MessageBox.Show(erros.ToString());
            }
            if (_user.id == 0)
            {
                UchetBaseEntities3.GetContext().User.Add(_user);
            }
            try
            {
                UchetBaseEntities3.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Btn_Can(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
