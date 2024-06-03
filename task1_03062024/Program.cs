using task1_03062024.Exceptions;
using task1_03062024.Models;

namespace task1_03062024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new Room()
            {
                Id = 1,
                Name = "Gym",
                Price = 200,
                PersonCapacity = 20,
                IsAvailable = true
            };

            Room room2 = new Room()
            {
                Id = 2,
                Name = "Room",
                Price = 200,
                PersonCapacity = 2,
                IsAvailable = true,
            };

            Hotel hotel = new Hotel("PB-201");
            hotel.AddRoom(room1);
            hotel.AddRoom(room2);

            try
            {
                //hotel.MakeReservation(2);
                //hotel.MakeReservation(1);

            }
            catch (NullReferenceException e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
            catch (NotAvailableException e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }


        chooseen:

            Console.WriteLine("1.Room show info");
            Console.WriteLine("2.Make Reservation");
            string? choose = Console.ReadLine();
            switch (choose)
            {
                case "1":
                    room1.ShowInfo();
                    Console.WriteLine();
                    room2.ShowInfo();
                    goto chooseen;
                case "2":
                    Console.WriteLine("Id daxil et");
                    int.TryParse(Console.ReadLine(), out int reservId);
                    hotel.MakeReservation(reservId);
                    goto chooseen;
                default:
                    goto chooseen;
            }

        }
    }
}
