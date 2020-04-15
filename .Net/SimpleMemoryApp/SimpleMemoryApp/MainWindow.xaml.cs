using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;

namespace SimpleMemoryApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CanvasClicked(object sender, MouseButtonEventArgs e)
        {
            Point currentLocation = Mouse.GetPosition(mainCanvas);
            CreateCircle(currentLocation.X, currentLocation.Y);
            saveMenuItem.IsEnabled = true;
        }

        private void CreateCircle(double X, double Y)
        {
            Ellipse circle = new Ellipse();
            circle.Width = 10;
            circle.Height = 10;
            circle.Margin = new Thickness(X, Y, 0, 0);
            circle.Stroke = new SolidColorBrush(Colors.Red);
            circle.Fill = new SolidColorBrush(Colors.Red);
            mainCanvas.Children.Add(circle);
        }

        private void CursorMove(object sender, MouseEventArgs e)
        {
            Point currentLocation = Mouse.GetPosition(mainCanvas);
            xLocationLabel.Content = (int) currentLocation.X;
            yLocationLabel.Content = (int) currentLocation.Y;
        }

        private void OpenMenuItem_Click(object sender, RoutedEventArgs e)
        {
            mainCanvas.Children.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string startDir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.InitialDirectory = startDir;
            openFileDialog.Filter = "Text Files| *.txt";

            if (openFileDialog.ShowDialog() == true)
            {
                string file = openFileDialog.FileName;
                StreamReader inputStream = File.OpenText(file);

                string line = inputStream.ReadLine();
                while (line != null)
                {
                    string[] items = line.Split(';');
                    CreateCircle(double.Parse(items[0]), double.Parse(items[1]));
                    line = inputStream.ReadLine();
                }
                inputStream.Close();
            }

            saveMenuItem.IsEnabled = true;
        }

        private void SaveMenuItem_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            string startDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog.InitialDirectory = startDirectory;
            saveFileDialog.Filter = "Text Files| *.txt";

            if (saveFileDialog.ShowDialog() == true)
            {
                string path = saveFileDialog.FileName;
                StreamWriter outputStream = File.CreateText(path);
                foreach (Ellipse child in mainCanvas.Children)
                {
                    string writeAway = child.Margin.Left + ";" + child.Margin.Top;
                    outputStream.WriteLine(writeAway);
                }
                outputStream.Close();
            }
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
