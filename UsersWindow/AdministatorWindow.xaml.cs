using CourtExpert.FormsToFillOut;
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

namespace CourtExpert
{
    /// <summary>
    /// Логика взаимодействия для AdministatorWindow.xaml
    /// </summary>
    public partial class AdministatorWindow : Window
    {
        public AdministatorWindow()
        {
            InitializeComponent();
        }

        private void ButtonLegalEntityClick(object sender, RoutedEventArgs e)
        {
            LegalEntityWindow form2 = new LegalEntityWindow();
            form2.Show();
        }

        private void ButtonIndividualPersonClick(object sender, RoutedEventArgs e)
        {
            PersoneClientWindow personeClientWindow = new PersoneClientWindow();
            personeClientWindow.Show();
        }
    }
}
