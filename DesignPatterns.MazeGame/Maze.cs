using System.Collections.Generic;

namespace DesignPatterns.MazeGame
{
    public class Maze
    {
        private readonly Dictionary<int, Room> _rooms;

        public Maze()
        {
            _rooms = new Dictionary<int, Room>();
        }

        public void AddRoom(Room room)
        {
            _rooms.Add(room.RoomNumber, room);
        }

        public Room RoomNo(int number)
        {
            return _rooms[number];
        }
    }
}