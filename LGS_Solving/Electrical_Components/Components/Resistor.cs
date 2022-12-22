using System;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;

namespace CircuitSimulator
{
    public class Resistor : CircuitComponent
    {
        // Resistance value of the resistor
        public double Resistance { get; set; }

        // Voltage drop across the resistor
        public double Voltage { get; set; }

        // Current through the resistor
        public double Current { get; set; }

        // Constructor
        public Resistor(double resistance)
        {
            Resistance = resistance;
            Voltage = 0.0;
            Current = 0.0;
        }

        // Draw the resistor on the canvas
        public override void Draw(Canvas canvas, double x, double y)
        {
            // Create the resistor shape
            Rectangle resistor = new Rectangle
            {
                Width = 50,
                Height = 20,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };

            // Create the voltage/current arrow
            Polygon arrow = new Polygon
            {
                Points = new PointCollection
                {
                    new System.Windows.Point(0, 0),
                    new System.Windows.Point(5, 5),
                    new System.Windows.Point(0, 10)
                },
                Stroke = Brushes.Black,
                StrokeThickness = 2,
                Fill = Brushes.Black
            };

            // Add the resistor and arrow to the canvas
            canvas.Children.Add(resistor);
            canvas.Children.Add(arrow);

            // Position the resistor and arrow on the canvas
            Canvas.SetLeft(resistor, x);
            Canvas.SetTop(resistor, y);
            Canvas.SetLeft(arrow, x + 50);
            Canvas.SetTop(arrow, y + 5);
        }

        // Calculate the voltage drop and current through the resistor
        public override void Calculate(double voltage)
        {
            Voltage = voltage;
            Current = Voltage / Resistance;
        }
    }
}
