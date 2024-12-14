public class ExampleClass
{
    private int _value;

    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public void MyMethod()
    {
        int x = Value; // Read
        Value = x + 1; // Write
    }
}