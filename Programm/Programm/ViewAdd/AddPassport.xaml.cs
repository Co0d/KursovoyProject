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
    /// Логика взаимодействия для AddPassport.xaml
    /// </summary>
    public partial class AddPassport : Window
    {
        public AddPassport()
        {
            InitializeComponent();
        }

        private void Btn_Save(object sender, RoutedEventArgs e)
        {
            Passport pass = new Passport();
            pass.Number = txb_Number.Text;
            pass.Series = txb_Series.Text;
            pass.FirstName = txb_FirstName.Text;
            pass.Name = txb_Name.Text;
            pass.MiddleName = txb_MiddleName.Text;
            AppData.db.Passport.Add(pass);
            AppData.db.SaveChanges();
            MessageBox.Show("Пользователь был добавлен в базу!");
        }

        private void Btn_Can(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
