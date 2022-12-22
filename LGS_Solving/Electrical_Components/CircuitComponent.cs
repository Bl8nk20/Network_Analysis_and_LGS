using System.Windows.Controls;

namespace CircuitSimulator
{
    public abstract class CircuitComponent
    {
        // Abstract method to draw the component on the canvas
        public abstract void Draw(Canvas canvas, double x, double y);

        // Abstract method to calculate the voltage and current for the component
        public abstract void Calculate(double voltage);
    }
}