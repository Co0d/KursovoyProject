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
    /// Логика взаимодействия для AddDE.xaml
    /// </summary>
    public partial class AddDE : Window
    {
        public AddDE()
        {
            InitializeComponent();
        }

        private void Btn_Save(object sender, RoutedEventArgs e)
        {
            DocumentEducation de = new DocumentEducation();
            de.FirstName = txb_FirstName.Text;
            de.Name = txb_FirstName.Text;
            de.MiddleName = txb_FirstName.Text;
            de.Institute = txb_Institute.Text;
            de.Education = txb_Education.Text;            
            AppData.db.DocumentEducation.Add(de);
            AppData.db.SaveChanges();
            MessageBox.Show("Пользователь был добавлен в базу!");
        }

        private void Btn_Can(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
