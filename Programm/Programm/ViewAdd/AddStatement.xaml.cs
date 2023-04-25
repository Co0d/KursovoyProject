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
    /// Логика взаимодействия для AddStatement.xaml
    /// </summary>
    public partial class AddStatement : Window
    {
        public AddStatement()
        {
            InitializeComponent();
        }

        private void Btn_Save(object sender, RoutedEventArgs e)
        {
            Statement state = new Statement();
            state.FirstName = txb_FirstName.Text;
            state.Name = txb_Name.Text;
            state.MiddleName = txb_MiddleName.Text;
            state.Cash = txb_Cash.Text;
            state.DayWork = txb_DayWork.Text;
            AppData.db.Statement.Add(state);
            AppData.db.SaveChanges();
            MessageBox.Show("Пользователь был добавлен в базу!");
        }

        private void Btn_Can(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
