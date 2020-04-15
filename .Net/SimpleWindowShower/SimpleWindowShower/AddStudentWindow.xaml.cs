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
    /// Interaction logic for AddStudentWindow.xaml
    /// </summary>
    public partial class AddStudentWindow : Window
    {
        private List<Student> _students;

        public AddStudentWindow(List<Student> students)
        {
            InitializeComponent();
            _students = students;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Student newStudent = new Student()
            {
                Age = int.Parse(ageTextBox.Text),
                Name = nameTextBox.Text,
                PhoneNumber = phoneNumberTextBox.Text
            };
            _students.Add(newStudent);
            Close();
        }
    }
}
