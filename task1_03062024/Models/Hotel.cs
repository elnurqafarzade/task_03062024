using task1_03062024.Exceptions;

namespace task1_03062024.Models
{
    internal class Hotel
    {
        public string Name { get; set; }
        private List<Room> _rooms { get; set; } = new();

        public Hotel(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new NullReferenceException("Name deyerini bos saxlamaq olmaz!!");
            }

        }
        public void MakeReservation(int? roomId)
        {
            if (roomId == null)
            {
                throw new NullReferenceException("Deyer null ola bilmez");
            }
            Room? room = _rooms.FirstOrDefault(room => room.Id == roomId);

            if (!room.IsAvailable)
            {
                throw new NotAvailableException("Otaq doludur");
            }

            room.IsAvailable =false;
            Console.WriteLine("Rezervasiya olundu");
        }

        public void AddRoom(Room room)
        {
            _rooms.Add(room);
        }

    }
}
