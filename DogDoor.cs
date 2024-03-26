using SmartDogDoors;

public class DogDoor
{
    private bool _isOpen;

    public bool IsOpen { get { return _isOpen; } }
    public List<Bark> AllowedBarks { get; set; } = null!;

    public DogDoor()
    {
        this._isOpen = false;
    }

    public void Open()
    {        
        Console.WriteLine("The dog door opens.");
        _isOpen = true;

        Timer timer = new Timer(state =>
        {
            // This lambda function will be executed when the timer elapses.
            // You can replace this with your desired logic.
            Console.WriteLine("Timer elapsed! Closing...");
            Close();
            Console.WriteLine("IsOpen: " + IsOpen);
        }, null, 5000, Timeout.Infinite);
    }
    public void Close()
    {
        Console.WriteLine("The dog door closes.");
        _isOpen = false;
    }
}