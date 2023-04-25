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
    /// Логика взаимодействия для EditDE.xaml
    /// </summary>
    public partial class EditDE : Window
    {
        private DocumentEducation _de = new DocumentEducation();
        public EditDE(DocumentEducation selectedDocumentEducation)
        {
            InitializeComponent();

            if (selectedDocumentEducation != null)
                _de = selectedDocumentEducation;
            DataContext = _de;
        }

        private void Brn_Save(object sender, RoutedEventArgs e)
        {
            StringBuilder erros = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_de.FirstName))
                erros.AppendLine("Укажите фамилию");
            if (string.IsNullOrWhiteSpace(_de.Name))
                erros.AppendLine("Укажите Имя");
            if (string.IsNullOrWhiteSpace(_de.MiddleName))
                erros.AppendLine("Укажите фамилию");
            if (string.IsNullOrWhiteSpace(_de.Institute))
                erros.AppendLine("Укажите институт");
            if (string.IsNullOrWhiteSpace(_de.Education))
                erros.AppendLine("Укажите образование");
            if (erros.Length > 0)
            {
                MessageBox.Show(erros.ToString());
            }
            if (_de.id == 0)
            {
                UchetBaseEntities3.GetContext().DocumentEducation.Add(_de);
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
