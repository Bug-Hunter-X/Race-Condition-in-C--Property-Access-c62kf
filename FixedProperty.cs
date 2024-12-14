using System.Threading;

public class ExampleClass
{
    private int _value;
    private readonly object _lock = new object(); // Added lock object

    public int Value
    {
        get
        {
            lock (_lock) // Lock for read
            {
                return _value;
            }
        }
        set
        {
            lock (_lock) // Lock for write
            {
                _value = value;
            }
        }
    }

    public void MyMethod()
    {
        int x;
        lock (_lock) 
        {
            x = Value; // Read
            Value = x + 1; // Write
        }
    }
}