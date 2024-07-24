// Class that represents a Rectangle geomtric form and calculates its area

public class Rectangle : IGeometricForm
{
    protected double Lenght { get; set; }
    protected double Widht { get; set; }

    public Rectangle(double widht, double lenght)
    {
        this.Lenght = lenght;
        this.Widht = widht;
    }

    public double CalculateArea()
    {
        return Lenght * Widht;
    }
}
