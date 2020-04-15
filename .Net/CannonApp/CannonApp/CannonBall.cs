using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace CannonApp
{
    public class CannonBall
    {
        private MainWindow _mainWindow;
        private World _world;
        private double _angle;
        private double _velocity;
        private DispatcherTimer _timer = new DispatcherTimer();
        private Ellipse _cannonball = new Ellipse();
        private int _frame;


        public CannonBall(MainWindow mainWindow, World world)
        {
            _mainWindow = mainWindow;
            _world = world;
        }

        public void Shoot()
        {
            TurnOffItems();

            _angle = _mainWindow.angleSlider.Value;
            _velocity = _mainWindow.speedSlider.Value;

            SetUp();

            StartTimer();
        }

        private void TurnOffItems()
        {
            _mainWindow.angleSlider.IsEnabled = false;
            _mainWindow.speedSlider.IsEnabled = false;
            _mainWindow.shootButton.IsEnabled = false;
        }

        private void SetUp()
        {
            Point startPoint = new Point(0, 8);
            _cannonball.Width = 10;
            _cannonball.Height = 10;
            _cannonball.Margin = new Thickness(_world.ConvertPoint(startPoint).X, _world.ConvertPoint(startPoint).Y, 0, 0);
            _cannonball.Stroke = new SolidColorBrush(Colors.Red);
            _cannonball.Fill = new SolidColorBrush(Colors.Red);
            _world.WorldCanvas.Children.Add(_cannonball);
        }

        private void StartTimer()
        {
            //We gaan hier met één 50ste van een seconde verhogen zo renderen we iedere seconde 50 frames
            _timer.Interval = TimeSpan.FromSeconds(1.0 / 50.0);
            _timer.Tick += UpdateCannonball;
            _frame = 0;
            _timer.Start();
        }

        private void UpdateCannonball(object sender, EventArgs e)
        {
            _frame++;
            Point newLocation = CalculateNewPoint();
            if (newLocation.X > _world.WorldCanvas.Width || newLocation.Y < 0)
            {
                _timer.Stop();
                _world.WorldCanvas.Children.Remove(_cannonball);
                TurnOnItems();
                return;
            }
            UpdateCanvas(newLocation);
        }

        private Point CalculateNewPoint()
        {
            Point newLocation = new Point();
            newLocation.X = _velocity * Math.Cos(Math.PI * _angle / 180.0) * (_frame / 50.0);
            newLocation.Y = _velocity * Math.Sin(Math.PI * _angle / 180.0) * (_frame / 50.0) - 0.5 * 9.81 * Math.Pow(_frame / 50.0, 2) + 8;
            return newLocation;
        }

        private void UpdateCanvas(Point newLocation)
        {
            _mainWindow.distanceLabel.Content = newLocation.X;
            _mainWindow.heightLabel.Content = newLocation.Y;
            Point convertedPoint = _world.ConvertPoint(newLocation);
            _cannonball.Margin = new Thickness(convertedPoint.X, convertedPoint.Y, 0, 0);
        }

        private void TurnOnItems()
        {
            _mainWindow.angleSlider.IsEnabled = true;
            _mainWindow.speedSlider.IsEnabled = true;
            _mainWindow.shootButton.IsEnabled = true;
        }
    }
}
