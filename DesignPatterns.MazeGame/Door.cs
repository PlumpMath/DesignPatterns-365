using System;

namespace DesignPatterns.MazeGame
{
    public class Door : MapSite
    {
        private Room _room1;
        private Room _room2;
        private bool _isOpen;

        public Door(Room room1, Room room2)
        {
            _room1 = room1;
            _room2 = room2;
        }

        public override void Enter()
        {
            Console.WriteLine("Door");
        }

        public Room OtherSideFrom(Room room)
        {
            return room == _room1 ? _room2 : _room1;
        }
    }
}