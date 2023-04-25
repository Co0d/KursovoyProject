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
    /// Логика взаимодействия для EditPassport.xaml
    /// </summary>
    public partial class EditPassport : Window
    {
        private Passport _pass = new Passport();
        public EditPassport(Passport selectedPassport)
        {
            InitializeComponent();
            if (selectedPassport != null)
                _pass = selectedPassport;
            DataContext = _pass;
        }

        private void Btn_Save(object sender, RoutedEventArgs e)
        {
            StringBuilder erros = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_pass.FirstName))
                erros.AppendLine("Укажите фамилию");
            if (string.IsNullOrWhiteSpace(_pass.Name))
                erros.AppendLine("Укажите Имя");
            if (string.IsNullOrWhiteSpace(_pass.MiddleName))
                erros.AppendLine("Укажите фамилию");
            if (string.IsNullOrWhiteSpace(_pass.Number))
                erros.AppendLine("Укажите номер");
            if (string.IsNullOrWhiteSpace(_pass.Series))
                erros.AppendLine("Укажите серию");
            if (erros.Length > 0)
            {
                MessageBox.Show(erros.ToString());
            }
            if (_pass.id == 0)
            {
                UchetBaseEntities3.GetContext().Passport.Add(_pass);
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
