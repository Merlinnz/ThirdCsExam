public class Calculator
{
    private double _num1 { get; set; }
    private double _num2 { get; set; }

    public Calculator(double num1, double num2)
    {
        _num1 = num1;
        _num2 = num2;
    }
    public double Add()
    {
        return _num1 + _num2;
    }
    public double Subtract()
    {
        return _num1 - _num2;
    }
    public double Multiply()
    {
        return _num1 * _num2;
    }
    public double Divide()
    {
        return _num1 / _num2;
    }
}