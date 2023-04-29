using System;

public class Wagon
{
    public int Number { get; set; }
    public string Type { get; set; }
    public int NumberOfSeats { get; set; }
    public int NumberOfPassengers { get; set; }

    public Wagon(int number, string type, int numberOfSeats, int numberOfPassengers)
    {
        Number = number;
        Type = type;
        NumberOfSeats = numberOfSeats;
        NumberOfPassengers = numberOfPassengers;
    }

    public int NumberOfAvailableSeats()
    {
        return NumberOfSeats - NumberOfPassengers;
    }

    public override string ToString()
    {
        return "Wagon number: " + Number + "\n" +
            "Wagon type: " + Type + "\n" +
            "Number of seats: " + NumberOfSeats + "\n" +
            "Number of passengers: " + NumberOfPassengers;
    }
}