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
    /// Логика взаимодействия для AddLD.xaml
    /// </summary>
    public partial class AddLD : Window
    {
        public AddLD()
        {
            InitializeComponent();
        }

        private void Btn_Save(object sender, RoutedEventArgs e)
        {
            LD ld = new LD();
            ld.FirstName = txb_FirstName.Text;
            ld.Name = txb_FirstName.Text;
            ld.MiddleName = txb_FirstName.Text;
            ld.WorkExperience = txb_WorkExperience.Text;
            ld.Education = txb_education.Text;
            ld.Profession = txb_Profession.Text;
            AppData.db.LD.Add(ld);
            AppData.db.SaveChanges();
            MessageBox.Show("Пользователь был добавлен в базу!");
        }

        private void Btn_Cel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
