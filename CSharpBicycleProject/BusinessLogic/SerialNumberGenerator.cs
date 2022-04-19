namespace CSharpBicycleProject;

internal sealed class SerialNumberGenerator
{
    private static SerialNumberGenerator instance;
    private static object synchronizationRoot = new object();
    private string _modelNumber;
    private int _startNumber;

    public int RecentNumber { get { return _startNumber; } }

    public static SerialNumberGenerator Instance
    {
        get
        {
            lock(synchronizationRoot)
            {
                if(instance == null)
                    instance = new SerialNumberGenerator();
            }
            return instance;
        }
    }

    private SerialNumberGenerator() { }

    public void SetModelAndStart(string modelNum, int startNum)
    {
        _modelNumber = modelNum;
        _startNumber = startNum;
    }

    public string GetNextSerial()
    {
        return _modelNumber + (++_startNumber);
    }


} // end class
