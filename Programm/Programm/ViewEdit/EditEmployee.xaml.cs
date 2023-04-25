using Programm.ViewTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using Programm.Model;
using System.Data.Entity.Migrations;
using System.ComponentModel;

namespace Programm.ViewEdit
{
    /// <summary>
    /// Логика взаимодействия для EditEmployee.xaml
    /// </summary>
    public partial class EditEmployee : Window
    {
        private Employee _employee = new Employee(); 
        public EditEmployee(Employee selectedEmployee)
        {
            InitializeComponent(); 
            
            if(selectedEmployee != null )
                _employee = selectedEmployee;
            DataContext = _employee;
        }

        private void Btn_Edit(object sender, RoutedEventArgs e)
        {
            StringBuilder erros = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_employee.FirstName))
                erros.AppendLine("Укажите фамилию");
            if (string.IsNullOrWhiteSpace(_employee.Name))
                erros.AppendLine("Укажите Имя");
            if (string.IsNullOrWhiteSpace(_employee.MiddleName))
                erros.AppendLine("Укажите фамилию");
            if (_employee.DateOfBirth == null)
                erros.AppendLine("Укажите дату рождения");
            if (string.IsNullOrWhiteSpace(_employee.Post))
                erros.AppendLine("Укажите Должность");
            if(erros.Length > 0)
            {
                MessageBox.Show(erros.ToString());
            }
            if(_employee.id == 0)
            {
                UchetBaseEntities3.GetContext().Employee.Add(_employee);
            }
            try
            {
                UchetBaseEntities3.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void Btn_Can(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
