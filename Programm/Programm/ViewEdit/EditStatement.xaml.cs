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
    /// Логика взаимодействия для EditStatement.xaml
    /// </summary>
    public partial class EditStatement : Window
    {
        private Statement _state = new Statement();
        public EditStatement(Statement selectedState)
        {
            InitializeComponent();
            if (selectedState != null)
                _state = selectedState;
            DataContext = _state;
        }

        private void Brn_Save(object sender, RoutedEventArgs e)
        {
            StringBuilder erros = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_state.FirstName))
                erros.AppendLine("Укажите фамилию");
            if (string.IsNullOrWhiteSpace(_state.Name))
                erros.AppendLine("Укажите Имя");
            if (string.IsNullOrWhiteSpace(_state.MiddleName))
                erros.AppendLine("Укажите фамилию");
            if (string.IsNullOrWhiteSpace(_state.Cash))
                erros.AppendLine("Укажите Заработную плату");
            if (string.IsNullOrWhiteSpace(_state.DayWork))
                erros.AppendLine("Укажите Рабочие дни");
            if (erros.Length > 0)
            {
                MessageBox.Show(erros.ToString());
            }
            if (_state.id == 0)
            {
                UchetBaseEntities3.GetContext().Statement.Add(_state);
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

        private void Brn_Can(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
