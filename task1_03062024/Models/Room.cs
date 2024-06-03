using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace task1_03062024.Models
{
    internal class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get; set; } = true;

        public void ShowInfo() 
        {
            Console.WriteLine($"Room Id: {Id}, Name: {Name}, Price: {Price}, Capacity: {PersonCapacity}, Status: {IsAvailable} ");

        }
    }
}
