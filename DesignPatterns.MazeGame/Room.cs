using System;
using System.Collections.Generic;

namespace DesignPatterns.MazeGame
{
    public class Room : MapSite
    {
        private int _roomNumber = 0;

        private Dictionary<Direction, MapSite> _sides;

        public Room(int roomNumber)
        {
            _roomNumber = roomNumber;
            _sides = new Dictionary<Direction, MapSite>(0);
        }

        public override void Enter()
        {
            Console.WriteLine("Room");
        }

        public MapSite GetSide(Direction direction)
        {
            return _sides[direction];
        }

        public void SetSide(Direction direction, MapSite mapSite)
        {
            _sides[direction] = mapSite;
        }

        public int RoomNumber
        {
            get { return _roomNumber; }
            set { _roomNumber = value; }
        }
    }
}