namespace SeatingCharts
{
    // Seat.cs
    public class Seat
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public bool IsOccupied { get; set; }
    }

    // SeatingLayout.cs
    public class SeatingLayout
    {
        public List<Seat> Seats { get; set; } = new List<Seat>();
    }

}
