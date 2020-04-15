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

namespace SimpleWindowShower
{
    /// <summary>
    /// Interaction logic for CustomWindow.xaml
    /// </summary>
    public partial class CustomWindow : Window
    {
        private MainWindow _mainWindow;

        public CustomWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            studentComboBox.ItemsSource = mainWindow.studentListBox.Items;
            studentComboBox.SelectedIndex = -1;
            studentComboBox.SelectionChanged += ComboBox_SelectionChanged;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (studentComboBox.SelectedIndex != -1)
            {
                nameLabel.Content = ((Student)studentComboBox.SelectedItem).Name;
                ageLabel.Content = ((Student)studentComboBox.SelectedItem).Age;
                phoneNumberLabel.Content = ((Student)studentComboBox.SelectedItem).PhoneNumber;
            }
        }
    }
}
