using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CannonApp
{
    public class World
    {
        private double hoogte;
        private double breedte;

        public Canvas WorldCanvas { get; }

        public World(Canvas paperCanvas)
        {
            hoogte = paperCanvas.Height;
            breedte = paperCanvas.Width;
            WorldCanvas = paperCanvas;

            DrawSmallMarkLines(paperCanvas);

            SetNumbersOnMarks(paperCanvas);
        }

        private void DrawSmallMarkLines(Canvas paperCanvas)
        {
            SolidColorBrush brush = new SolidColorBrush(Colors.Black);

            int index = 10;
            while (index < breedte)
            {
                DrawLine(paperCanvas, brush, index, hoogte, index, hoogte - 10);
                index += 10;
            }
        }

        private void SetNumbersOnMarks(Canvas paperCanvas)
        {
            int index = 100;
            while (index < breedte)
            {
                SetText(paperCanvas, index);
                index += 100;
            }
        }

        private static void SetText(Canvas canvas, int number)
        {
            TextBlock txt1 = new TextBlock();
            txt1.FontSize = 8;
            txt1.Text = Convert.ToString(number);
            Canvas.SetTop(txt1, canvas.Height - 20);
            Canvas.SetLeft(txt1, number - 6);
            canvas.Children.Add(txt1);
        }

        private static void DrawLine(Canvas drawingArea, SolidColorBrush brushToUse, double startX, double startY, double endX, double endY)
        {
            Line l = new Line();
            l.X1 = startX;
            l.X2 = endX;
            l.Y1 = startY;
            l.Y2 = endY;
            l.Stroke = brushToUse;
            drawingArea.Children.Add(l);
        }

        public Point ConvertPoint(Point worldPoint)
        {
            Point canvasPoint = new Point(worldPoint.X, hoogte - worldPoint.Y);
            return canvasPoint;
        }
    }
}
