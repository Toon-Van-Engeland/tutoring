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

namespace CannonApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private World _world;

        public MainWindow()
        {
            InitializeComponent();
            _world = new World(cannonballCanvas);
        }

        private void shootButton_Click(object sender, RoutedEventArgs e)
        {
            CannonBall cannonBall = new CannonBall(this, _world);
            cannonBall.Shoot();
        }

        private void speedSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            speedAmmountLabel.Content = speedSlider.Value;
        }

        private void angleSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            angleAmmountLabel.Content = angleSlider.Value;
        }
    }
}
