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
    /// Логика взаимодействия для EditLD.xaml
    /// </summary>
    public partial class EditLD : Window
    {
        private LD _ld = new LD();
        public EditLD(LD selectedLD)
        {
            InitializeComponent();
            if (selectedLD != null)
                _ld = selectedLD;
            DataContext = _ld;
        }

        private void Btn_Save(object sender, RoutedEventArgs e)
        {
            StringBuilder erros = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_ld.FirstName))
                erros.AppendLine("Укажите фамилию");
            if (string.IsNullOrWhiteSpace(_ld.Name))
                erros.AppendLine("Укажите Имя");
            if (string.IsNullOrWhiteSpace(_ld.MiddleName))
                erros.AppendLine("Укажите фамилию");
            if (string.IsNullOrWhiteSpace(_ld.WorkExperience))
                erros.AppendLine("Укажите Опыт Работы");
            if (string.IsNullOrWhiteSpace(_ld.Education))
                erros.AppendLine("Укажите Образование");
            if (string.IsNullOrWhiteSpace(_ld.Profession))
                erros.AppendLine("Укажите Профессию");
            if (erros.Length > 0)
            {
                MessageBox.Show(erros.ToString());
            }
            if (_ld.id == 0)
            {
                UchetBaseEntities3.GetContext().LD.Add(_ld);
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
