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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Programm.ViewAdd
{
    /// <summary>
    /// Логика взаимодействия для AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : Window
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void Btn_Save(object sender, RoutedEventArgs e)
        {
            Employee employee = new Employee();
            employee.FirstName = txb_FirstName.Text;
            employee.Name = txb_Name.Text;
            employee.MiddleName = txb_MiddleName.Text;
            employee.DateOfBirth = txb_DateOfBirth.DisplayDate;
            employee.Post = txb_Post.Text;
            AppData.db.Employee.Add(employee);
            AppData.db.SaveChanges();
            MessageBox.Show("Пользователь был добавлен в базу!");
        }

        private void Btn_Cel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
