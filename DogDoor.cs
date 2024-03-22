public class DogDoor
{
    private bool _isOpen;

    public DogDoor()
    {
        this._isOpen = false;
    }

    public void Open()
    {        
        _isOpen = true;
    }
    public void Close()
    {        
        _isOpen = false;
    }
    public bool IsOpen
    { get { return _isOpen; } }

}