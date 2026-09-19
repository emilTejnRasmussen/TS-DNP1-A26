namespace Ex3___Doctors_waiting_room;

public class WaitingRoom()
{
    public Action<int> NumberChange { get; set; }
    private int _currenNumber = 1;
    private int _ticketCount;

    public void RunWaitingRoom()
    {
        while (_currenNumber < _ticketCount)
        {
            Console.WriteLine($"Patient {_currenNumber} can now enter");
            Thread.Sleep(1000);
            
            NumberChange?.Invoke(_currenNumber);
            
            _currenNumber++;
        }
    }

    public int DrawNumber()
    {
        _ticketCount++;
        return _ticketCount;
    }
}