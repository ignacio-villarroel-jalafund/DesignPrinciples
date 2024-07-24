// Class that represents a Circle geometric form and calculates its area

public class Circle : IGeometricForm
{
    protected double Radio { get; set; }

    public Circle(double radio)
    {
        this.Radio = radio;
    }

    public double CalculateArea()
    {
        return Math.PI * Radio * Radio;
    }
}