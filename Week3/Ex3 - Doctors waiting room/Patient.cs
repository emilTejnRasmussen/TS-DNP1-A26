namespace Ex3___Doctors_waiting_room;

public class Patient
{
    private int _queueNumber;
    private int _id;
    public Patient(WaitingRoom wr, int id)
    {
        wr.NumberChange += ReactToNumber;
        _id = id;
        
        _queueNumber = wr.DrawNumber();
    }

    private void ReactToNumber(int number)
    {
        Console.WriteLine($"Patient {_id} looks up");

        Console.WriteLine(number == _queueNumber
            ? $"Patient {_id} goes to the doctor's room"
            : $"Patient {_id} goes back to looking at phone");
    }
}