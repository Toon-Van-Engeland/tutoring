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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimpleWindowShower
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Student> students = new List<Student>();

        public MainWindow()
        {
            InitializeComponent();
            students.Add(new Student()
            {
                Age = 22,
                Name = "Gio",
                PhoneNumber = "0488 00 59 59"
            });
            students.Add(new Student()
            {
                Age = 21,
                Name = "Toon",
                PhoneNumber = "0489 33 44 28"
            });
            students.Add(new Student()
            {
                Age = 22,
                Name = "Syb",
                PhoneNumber = "0471 52 13 71"
            });

            studentListBox.ItemsSource = students;
        }

        private void CurrentButton_Click(object sender, RoutedEventArgs e)
        {
            if (studentListBox.SelectedIndex != -1)
            {
                Student currentStudent = (Student)studentListBox.SelectedItem;
                MessageBox.Show(currentStudent.ToString());
            }
        }

        private void DetailButton_Click(object sender, RoutedEventArgs e)
        {
            CustomWindow customWindow = new CustomWindow(this);
            IsEnabled = false;
            Hide();
            customWindow.Show();
            customWindow.Closed += CustomWindowOnClosed;
        }

        private void CustomWindowOnClosed(object sender, EventArgs e)
        {
            Show();
            IsEnabled = true;
        }

        private void NewMenuItem_Click(object sender, RoutedEventArgs e)
        {
            AddStudentWindow addStudentWindow = new AddStudentWindow(students);
            addStudentWindow.Show();
            addStudentWindow.Closed += AddStudentWindowOnClosed;
        }

        private void AddStudentWindowOnClosed(object sender, EventArgs e)
        {
            studentListBox.Items.Refresh();
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
